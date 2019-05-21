using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        private int _currentSongPLaylistIndex = 0;

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
                // If some songs is selected in playlist.
                if (PlayList.Items.Count != 0 && !_isSongOpened)
                {
                    string filename = _mp3PlayList.PathFolder + "\\" + PlayList.Items[_currentSongPLaylistIndex].ToString();
                    _mp3Player.Open(filename);
                    if (IsSongStopped())
                    {
                        SetSongTimer(_mp3Player.GetSongLength());
                        _mp3Player.Play(false);
                        songTimer.Start();
                        PlayingSongLabel();
                    }
                }
                else
                {
                    _mp3Player.Play(false);
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
                int _tmpIndex = _currentSongPLaylistIndex;
                if (_currentSongPLaylistIndex >= PlayList.Items.Count - 1)
                    return;
                PlayList.SetSelected(_tmpIndex, false);
                PlayList.SetSelected(++_currentSongPLaylistIndex, true);
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
                int _tmpIndex = _currentSongPLaylistIndex;
                if (_currentSongPLaylistIndex <= 0)
                    return;
                PlayList.SetSelected(_tmpIndex, false);
                PlayList.SetSelected(--_currentSongPLaylistIndex, true);
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
                button.ForeColor = Color.Crimson;
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
                button.ForeColor = Color.AliceBlue;
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


        private void Buttons_MouseEnter(object sender, EventArgs e)
        {
            if(sender is PictureBox box)
            {
                box.BackColor = Color.Black;
            }
        }

        private void Buttons_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox box)
            {
                box.BackColor = Color.AliceBlue;
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

                //If song has been ended. This method continue the playlist.
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
                    box.Image = Properties.Resources._005_volume; _mp3Player.UnMute();
                }
                else
                {
                    box.Image = Properties.Resources._004_mute;
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
    }
}
