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
    public partial class ControlWindow : Form
    {
        private Mp3Player _player;
        enum CategoryBar { Volume,Bass,Treble};
        enum Operation { Minus, Add};
        public ControlWindow()
        {
            InitializeComponent();
        }
        public ControlWindow(Mp3Player player)
        {
            InitializeComponent();
            _player = player;
            ProgressBars();

        }

        #region UI Control
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// When cursor is over the element.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Button_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button button)
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
            if (sender is Button button)
            {
                button.Image = Properties.Resources.icons8_close_window_filled_48__1_;
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Minimize the window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        /// <summary>
        /// Gets the volume, bass and trble value from model.
        /// </summary>
        public  void ProgressBars()
        {
            if(_player.Volume.HasValue)
               ProgressVolume.Value = _player.Volume.Value / 10;

            if (_player.Bass.HasValue)
                ProgressBass.Value = _player.Bass.Value / 10;

            if (_player.Treble.HasValue)
                ProgressTreble.Value = _player.Treble.Value / 10;
           
            this.Refresh();
        }

        /// <summary>
        /// Adds volume value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddVolume_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox box)
            {
                ChangeValueProgress(box.Name);
            }
        }

        /// <summary>
        /// Minus volume value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinusVolume_Click(object sender, EventArgs e)
        {
            if(sender is PictureBox box)
            {
                ChangeValueProgress(box.Name);
            }
        }

        private void ChangeValueProgress(string nameProgress)
        {
            if(nameProgress.ToLowerInvariant().Contains("add"))
            {
                var _temp = nameProgress.ToLowerInvariant().Replace("add", "");
                AddOrMinusValue(AnyValueEnumAsString<CategoryBar>(_temp), 10, Operation.Add);
            }
            else
            { 
                var _temp = nameProgress.ToLowerInvariant().Replace("minus", "");
                AddOrMinusValue(AnyValueEnumAsString<CategoryBar>(_temp), 10,Operation.Minus);

            }
        }

        /// <summary>
        /// Add or minus your value in progressbar and the mp3Player model.
        /// You can add/minus Volume, Treble, Bass
        /// </summary>
        /// <param name="category">Choose what you want change. (Volume, Treble, Bass)</param>
        /// <param name="value">It's value which you want add / minus. It must be between 5 and 20.</param>
        /// <param name="operation">Selects your Operation Add or Minus.</param>
        private void AddOrMinusValue(CategoryBar category, int value, Operation operation)
        {
            if(value > 20 || value < 5)
            {
                return;
            }

            if(operation.HasFlag(Operation.Add))
            {
                switch(category)
                {
                    case CategoryBar.Volume:
                        if (ProgressVolume.Value >= 0 && ProgressVolume.Value < 100)
                        {
                            ProgressVolume.Value += value;
                            _player.Volume = value * ProgressVolume.Value;
                        }
                        break;

                    case CategoryBar.Bass:
                        if (ProgressBass.Value >= 0 && ProgressBass.Value < 100)
                        {
                            ProgressBass.Value += value;
                            _player.Bass = value * ProgressBass.Value;
                        }
                        break;

                    case CategoryBar.Treble:
                        if (ProgressTreble.Value >= 0 && ProgressTreble.Value < 100)
                        {
                            ProgressTreble.Value += value;
                            _player.Treble = value * ProgressTreble.Value;
                        }
                        break;

                    default:
                        break;
                }
            }
            else
            {
                switch (category)
                {
                    case CategoryBar.Volume:
                        if (ProgressVolume.Value >= 0 && ProgressVolume.Value < 100)
                        {
                            ProgressVolume.Value -= value;
                            _player.Volume = value * ProgressVolume.Value;
                        }
                        break;

                    case CategoryBar.Bass:
                        if (ProgressBass.Value >= 0 && ProgressBass.Value < 100)
                        {
                            ProgressBass.Value -= value;
                            _player.Bass = value * ProgressBass.Value;
                        }
                        break;

                    case CategoryBar.Treble:
                        if (ProgressTreble.Value >= 0 && ProgressTreble.Value < 100)
                        {
                            ProgressTreble.Value -= value;
                            _player.Treble = value * ProgressTreble.Value;
                        }
                        break;

                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Checks that our enum have any value the same like string input.
        /// </summary>
        /// <typeparam name="T">ONLY FOR ENUMS</typeparam>
        /// <param name="parameter">Input your string which you want to check.</param>
        /// <returns>Returns value of Enums.</returns>
        private T AnyValueEnumAsString<T>(string parameter)
        {
            var _myEnums = Enum.GetValues(typeof(T));

            for(int i = 0; i < _myEnums.Length; i++)
            {
                var _toEqual = _myEnums.GetValue(i).ToString().ToLowerInvariant();

                if(string.Equals(parameter.ToLowerInvariant(), _toEqual))
                {
                    return (T)_myEnums.GetValue(i);
                }
            }

            throw new ArgumentNullException("Enum doesn't have any value which it'll be equals with your param.");
        }

    }
}
