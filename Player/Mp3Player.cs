using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Player
{
    public class Mp3Player : IDisposable
    {

        public Mp3Player(string name = "MediaFile")
        {
            _namePlayer = name;
            _IsMuted = false;
            _IsPaused = false;
            _volume = 500;
            _treble = 500;
            _bass = 500;
        }

        private bool _IsPaused;
        private bool _IsMuted;
        private string _currentSong = string.Empty;
        private const int _bufforLength = 1000;
        private readonly string _namePlayer;

        //They contains value set by user.
        private int? _volume;
        private int? _bass;
        private int? _treble;

        /// <summary>
        /// Gets the actual song.
        /// </summary>
        public string CurrentSong
        {
            get => _currentSong;
           
        }

        /// <summary>
        /// Volume value is between 0 - 1000
        /// </summary>
        public int? Volume
        {
            get
            {
                if (IsMuted)
                    return null;

                string val = ReadStatus();

                if (int.TryParse(val, out int returnVal))
                    return returnVal;

                return null;
            }
            set
            {
                if (value is int obj)
                { if (obj >= 0 && obj <= 1000)
                    {
                        SetAudio(obj);
                        _volume = obj;
                    }
                }
            }
        }

        /// <summary>
        /// Sets or gets the bass value. Between 0 - 1000.
        /// </summary>
        public int? Bass
        {
            get
            {
                string val = ReadStatus();

                if (int.TryParse(val, out int returnVal))
                    return returnVal;
                return 0;
            }
            set
            {
                if (value is int obj)
                    if (obj >= 0 && obj <= 1000)
                    {
                         SetAudio(obj);
                        _bass = obj;
                    }
            }
        }

        /// <summary>
        /// Gets or Sets treble Value. It can be between 0 - 1000.
        /// </summary>
        public int? Treble
        {
            get
            {
                string val = ReadStatus();

                if (int.TryParse(val, out int returnVal))
                    return returnVal;
                return 0;
            }
            set
            {
                if (value is int obj)
                    if (obj >= 0 && obj <= 1000)
                    {
                        SetAudio(obj);
                        _treble = obj;
                    }
            }
        }

        /// <summary>
        /// Gets the true if mp3 player is muted.
        /// </summary>
        public bool IsMuted
        {
            get => _IsMuted;
        }

        #region Public Methods
        /// <summary>
        /// Opens file to play it.
        /// </summary>
        /// <param name="filename"></param>
        public void Open(string filename)
        {
            this.Stop();
            string format = $"open \"{filename}\" type MPEGVideo alias {_namePlayer}";
            _currentSong = Path.GetFileName(filename); 
            mciSendString(format, null, 0, 0);

        }

        /// <summary>
        /// Plays a song.
        /// </summary>
        /// <param name="loop">If True, song will repeat.</param>
        public void Play(bool loop)
        {
            string command = string.Format("play {0}", _namePlayer);

            if (loop)
                command += " REPEAT";
            mciSendString(command, null, 0, 0);

            //We have to setAudio the same like user set, because The deault value of SetAudio is 1000
            this.Volume = _volume;
            this.Bass = _bass;
            this.Treble = _treble;
            
            _IsPaused = false;
        }

        /// <summary>
        /// Pauses playing song or plays the paused song.
        /// </summary>
        public void Pause()
        {
            if (!_IsPaused)
            {
                string command = "pause MediaFile";
                mciSendString(command, null, 0, 0);
                _IsPaused = true;
            }
            else
            { 
                this.Play(false);
            }
        }

        /// <summary>
        /// Stop the song.
        /// </summary>
        public void Stop()
        {
            string command = "close MediaFile";
            mciSendString(command, null, 0, 0);
        }

        /// <summary>
        /// Gets the status (playing, paused, stopped)
        /// </summary>
        /// <returns>Status Name</returns>
        public string Status()
        {
            return ReadStatus("mode");
        }

        /// <summary>
        /// Mutes the Mp3 Player.
        /// </summary>
        public void Mute()
        {
            if (!_IsMuted)
            {
                StringBuilder returnString = new StringBuilder(_bufforLength);
                string _command = "setaudio MediaFile off";
                mciSendString(_command, null, 0, 0);

                _IsMuted = true;
            }

               
            
        }
        public void UnMute()
        {
            StringBuilder returnString = new StringBuilder(_bufforLength);
            string _command = "setaudio MediaFile on";
            mciSendString(_command, null, 0, 0);

            _IsMuted = false;
        }

        /// <summary>
        /// Gets the full length song.
        /// </summary>
        /// <returns></returns>
        public TimeSpan GetSongLength()
        {
            string sb = ReadStatus("length");

            // Length song in miliseconds.
            long secondsgLength = Convert.ToInt64(sb.ToString());

            return SongLength(secondsgLength);
        }
        #endregion

        /// <summary>
        /// Gets the song length from miliseconds.
        /// </summary>
        /// <param name="miliseconds">Song length in miliseconds.</param>
        /// <returns></returns>
        private TimeSpan SongLength(long miliseconds)
        {
            const int _constHours = 3600000;
            const int _constMinutes = 60000;
            const int _constSeconds = 1000;

            long _hours = miliseconds / _constHours;
            long _restHours = miliseconds % _constHours;

            long _minutes = _restHours / _constMinutes;
            long _restMinutes = _restHours % _constMinutes;

            long _seconds = _restMinutes / _constSeconds;

            return new TimeSpan((int)_hours, (int)_minutes, (int)_seconds);
        }

        /// <summary>
        /// Reads the status audio.
        /// </summary>
        /// <param name="input">Type mode, volume etc.</param>
        /// <returns></returns>
        private string ReadStatus([CallerMemberName]string input = null)
        {

            StringBuilder returnString = new StringBuilder(_bufforLength);
            string _command = string.Format("status {0} {1}", _namePlayer, input);
            mciSendString(_command, returnString, _bufforLength, 0);

            return returnString.ToString();

        }

        /// <summary>
        /// Sets audio volume, bass etc.
        /// </summary>
        /// <param name="value">It's value (vol. bass.) 0-1000</param>
        /// <param name="method">It's called method. Method must have the same name like volume etc.</param>
        private void SetAudio(int value, [CallerMemberName] string method = null)
        {
            StringBuilder returnString = new StringBuilder(_bufforLength);
            string _command = string.Format("setaudio {0} {1} to {2}",_namePlayer, method, value);
            mciSendString(_command, returnString, _bufforLength, 0);
        }
        #region Winmm.DLL Methods

        [DllImport("winmm.DLL")]
        private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwdCallBack);

        #endregion

        public void Dispose()
        {
            _currentSong = string.Empty;
            _IsPaused = false;

            this.Stop();
        }
    }
}
