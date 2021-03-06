﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class PlayerMp3 : Form
    {
        #region Private Fields
        private Mp3Player _mp3Player;
        private ControlWindow settings;
        private PlayList _mp3PlayList;
        private int _lastSong = 0;
        private int _currentSongPLaylistIndex = 0;
        private List<ImageDTO> _resList;
        private bool _shuffle = false;
        private bool _repeatFolder = false;
        private bool _setrepeatWhilePlaying = false;
        private bool _repeatSong = false;

        #region Song Timer
        private TimeSpan songLength;
        private Timer songTimer;
        #endregion

        #region Sliding Menu
        private const int _slidingPanMenu = 238;
        private bool _IsHidden = true;
        #endregion

        // This sets true if you have opened buffer.
        // Before you listening to one song.
        private bool _isSongOpened = false;
        #endregion

        public PlayerMp3()
        { 
            InitializeComponent();
            _mp3Player = new Mp3Player();
            _mp3PlayList = new PlayList();
            songTimer = new Timer();
            songTimer.Tick += ChangeSongLength;
            FolderSong.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            _resList = Properties.Resources.ResourceManager.GetResourceSet(CultureInfo.CurrentCulture, false, true)
                    .Cast<DictionaryEntry>()
                    .Where(x => x.Value.GetType() == typeof(Bitmap))
                    .Select(x => new ImageDTO { Name = x.Key.ToString(), Image = (Image)x.Value })
                    .ToList();

        }

        /// <summary>
        /// Opens the show dialog and guest selects the song.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlgOpen = new OpenFileDialog())
            {
                dlgOpen.Filter = "MP3 File|*.mp3";
                dlgOpen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                
                if(dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    _mp3Player.Open(dlgOpen.FileName); 
                    songTimer.Stop();
                    SetSongTimer(_mp3Player.GetSongLength());
                    PlayingSongLabel();
                    _isSongOpened = true;
                }
            }
        }

        /// <summary>
        /// Play the song.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Play_Click(object sender, EventArgs e)
        {
            if (!IsSongPaused())
            {
                _repeatSong = _setrepeatWhilePlaying;
                _setrepeatWhilePlaying = false;

                // If some songs is selected in playlist.
                if (PlayList.Items.Count != 0 && !_isSongOpened)
                {
                    string filename = _mp3PlayList.PathFolder + "\\" + PlayList.Items[_currentSongPLaylistIndex].ToString();
                    _mp3Player.Open(filename);
                    if (IsSongStopped())
                    {
                        SetSongTimer(_mp3Player.GetSongLength());
                        _mp3Player.Play(_repeatSong);
                        songTimer.Start();
                        PlayingSongLabel();
                    }
                }
                else
                {
                    _mp3Player.Play(_repeatSong);
                    _isSongOpened = false;

                    if (songLength.TotalSeconds != 0)
                    {
                        songTimer.Start();
                        PlayingSongLabel();
                    }

                }
            }
            else this.Pause_Click(sender, e);
        }


        /// <summary>
        /// Pauses the song.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pause_Click(object sender, EventArgs e)
        {

            if (_mp3Player.Status().Contains("playing"))
            {
                songTimer.Stop();
            }
            if (IsSongPaused())
                songTimer.Start();
            _mp3Player.Pause();

        }

        /// <summary>
        /// Stops the mp3 player.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Stop_Click(object sender, EventArgs e)
        {
             if (!IsSongStopped())
             {
                 _mp3Player.Stop();
                 songTimer.Stop();
                 SetSongTimer(new TimeSpan(0, 0, 0));
             }
        }

        /// <summary>
        /// Retrieves the folder.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FolderSongs_Click(object sender, EventArgs e)
        {
            PlayList.Items.Clear();
            string path = string.Empty;

            if(FolderSong.ShowDialog() == DialogResult.OK)
            {
                path = FolderSong.SelectedPath;
            }

            if (string.IsNullOrEmpty(path))
                return;
            _mp3PlayList.PathFolder = path;
            IList<string> list = _mp3PlayList.Read;

            for(int i = 0; i < list.Count; i++)
            {
                PlayList.Items.Add(list[i]);
            }

            try
            {
                PlayList.SetSelected(_currentSongPLaylistIndex, true);
                this.Play_Click(sender, e);
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("You don't have any songs in this folder.","Files hasn't been found.",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Plays Next song in the playlist.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Next_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_shuffle)
                {
                    int _tmpIndex = _currentSongPLaylistIndex;
                    if (_currentSongPLaylistIndex >= PlayList.Items.Count - 1 && _repeatFolder)
                    { _currentSongPLaylistIndex = -1; }
                    PlayList.SetSelected(_tmpIndex, false);
                    PlayList.SetSelected(++_currentSongPLaylistIndex, true);
                }
                else
                    Shuffling();
                this.Play_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Plays previous song in the playlist.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Previous_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_shuffle)
                {
                    int _tmpIndex = _currentSongPLaylistIndex;
                    if (_currentSongPLaylistIndex <= 0 && _repeatFolder)
                    { _currentSongPLaylistIndex = PlayList.Items.Count; }
                    PlayList.SetSelected(_tmpIndex, false);
                    PlayList.SetSelected(--_currentSongPLaylistIndex, true);
                }
                else
                    Shuffling();
                this.Play_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// If you double clicked on item. It should be play.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                _currentSongPLaylistIndex = PlayList.SelectedIndex;
                this.Play_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region UI Click Buttons
        /// <summary>
        /// Close the app.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            _mp3Player.Dispose();
            Application.Exit();
        }

        /// <summary>
        /// When cursor is over the element.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Button_MouseEnter(object sender, EventArgs e)
        {
            if(sender is Button button)
            {
                button.Image = Properties.Resources.icons8_close_window_filled_48;
                this.Cursor = Cursors.Hand; 
            }
        }

        /// <summary>
        /// Set default cursor's style and button's foreground.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Button_MouseLeave(object sender, EventArgs e)
        {
            if(sender is Button button)
            {
                button.Image = Properties.Resources.icons8_close_window_filled_48__1_;
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Current Song gets the text and now it's visible.
        /// </summary>
        private void PlayingSongLabel()
        {
            CurrentSong.Text = _mp3Player.CurrentSong;
            CurrentSong.Visible = true;
        }


        private void PictureBoxes_MouseEnter(object sender, EventArgs e)
        {
            if(sender is PictureBox box)
            {

                box.Image = _resList.Where(x => x.Name.ToString()
                    .ToLowerInvariant()
                    .Contains(box.Name.ToString().ToLowerInvariant() + "1"))
                .Select(x => x.Image)
                .SingleOrDefault();
            }
        }

        private void PictureBoxes_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox box)
            {
                box.Image = _resList.Where(x => x.Name.ToString()
                        .ToLowerInvariant()
                        .Contains(box.Name.ToString().ToLowerInvariant()))
                    .OrderBy(x => x.Name.ToString().Length)
                    .Select(x => x.Image)
                    .FirstOrDefault();
            }
        }

        #endregion


        #region Sliding Menu
        /// <summary>
        /// This method is repating.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Slider_Tick(object sender, EventArgs e)
        {
            if (_IsHidden)
            {
                PanelSlide.Width = PanelSlide.Width + 12;

                if (PanelSlide.Width >= _slidingPanMenu)
                {
                    Slider.Stop();
                    _IsHidden = false;
                    this.Refresh();
                }
            }
            else
            {
                PanelSlide.Width = PanelSlide.Width - 12;

                if (PanelSlide.Width <= 0)
                {
                    Slider.Stop();
                    _IsHidden = true;
                    this.Refresh();
                }
            }
            
        }

        /// <summary>
        /// Starts the interval.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuButton_Click(object sender, EventArgs e)
        {
            
            Slider.Start();
        }

        #endregion

        #region SongTimer
        /// <summary>
        /// Sets the songTimer. Sets interval and shows song length in UI.
        /// </summary>
        /// <param name="songTime"></param>
        private void SetSongTimer(TimeSpan songTime)
        {
            songLength = songTime;
            CurrenTime.Visible = true;
            CurrenTime.Text = songTime.ToString(@"hh\:mm\:ss");
            songTimer.Interval = 1000;
        }

        /// <summary>
        /// Every tick song length is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeSongLength(object sender, EventArgs e)
        {
            if (songLength.TotalMinutes == 0)
            {
                SetSongTimer(new TimeSpan(0, 0, 0));
                songTimer.Stop();

                //It set if song was playing
                if(_setrepeatWhilePlaying)
                {
                    this.Play_Click(sender, e);
                    return;
                }

                if(_repeatSong)
                {
                    SetSongTimer(_mp3Player.GetSongLength());
                    songTimer.Start();
                    return;
                }
                //If song has been ended. This method continues playing.
                this.Next_Click(sender, e);
            }
            songLength -= new TimeSpan(hours:0,minutes:0,seconds:1);
            CurrenTime.Text = songLength.ToString(@"hh\:mm\:ss");
        }
        #endregion

        #region Helpers
        private bool IsSongStopped()
        {
            if (_mp3Player.Status().Contains("stopped") || string.IsNullOrEmpty(_mp3Player.Status()))
                return true;
            return false;
        }

        private bool IsSongPaused()
        {
            return _mp3Player.Status() == "paused" ? true : false;
        }
        private bool IsSongPlaying()
        {
            if (_mp3Player.Status().Contains("playing"))
                return true;
            return false;
        }
        #endregion

        /// <summary>
        /// Open the settings window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            settings = new ControlWindow(_mp3Player);
            settings.Show(); 
        }

        /// <summary>
        /// Mutes the song.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MuteButton_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox box)
            {
                if(_mp3Player.IsMuted)
                {
                    box.Image = Properties.Resources.icons8_audio;
                    _mp3Player.UnMute();
                }
                else
                {
                    box.Image = Properties.Resources.icons8_audio1;
                    _mp3Player.Mute();
                }
                
            }
        }

        /// <summary>
        /// Maximies the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        /// <summary>
        /// Minimizes the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized ||
                this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// After click this button we can shuffle songs in an playlist.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Shuffle_Click(object sender, EventArgs e)
        {
            if (!_shuffle)
            {
                PictureBoxes_MouseEnter(sender, e);
                _shuffle = true;
            }
            else
            {
                PictureBoxes_MouseLeave(sender, e);
                _shuffle = false;
            }
        }

        /// <summary>
        /// This method shuffles songs then sets to playlist.
        /// </summary>
        private void Shuffling()
        {

           PlayList.SetSelected(_currentSongPLaylistIndex, false);

           int _playListLength = PlayList.Items.Count;

           Random _rand = new Random();
           _currentSongPLaylistIndex = _rand.Next(_playListLength);

           //It rerolls if an song is the same as the last song.
           while (_lastSong == _currentSongPLaylistIndex)
               _currentSongPLaylistIndex = _rand.Next(_playListLength);

           PlayList.SetSelected(_currentSongPLaylistIndex, true);
        }

        private void Repeat_Click(object sender, EventArgs e)
        {
            if (!_repeatFolder && (!_repeatSong && !_setrepeatWhilePlaying))
            {
                _repeatFolder = true;

                if(sender is PictureBox box)
                {
                    box.Image = Properties.Resources.icons8_repeatFolder;
                }
                return;
            }
            if(!_repeatFolder && _setrepeatWhilePlaying)
            {
                _setrepeatWhilePlaying = false;

                if(sender is PictureBox box)
                {
                    box.Image = Properties.Resources.icons8_repeat;
                }
                return;
            }
            else
            {
                if (IsSongPlaying())
                {
                    _setrepeatWhilePlaying = true;
                    _repeatFolder = false;

                    if(sender is PictureBox box)
                    {
                        box.Image = Properties.Resources.icons8_repeatSong;
                    }
                }
            }
        }
    }
}
