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

        public ControlWindow()
        {
            InitializeComponent();
        }
        public ControlWindow(Mp3Player player)
        {
            InitializeComponent();
            _player = player;
            ProgressVolumes();

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
            if (sender is Button button)
            {
                button.ForeColor = Color.AliceBlue;
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
        /// Gets the volume value from model.
        /// </summary>
        public  void ProgressVolumes()
        {
            if(_player.Volume.HasValue)
               ProgressVolume.Value = _player.Volume.Value / 10;
           
            this.Refresh();
        }

        /// <summary>
        /// Adds volume value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddVolume_Click(object sender, EventArgs e)
        {
             if(ProgressVolume.Value >= 0 && ProgressVolume.Value < 100)
             {
                 ProgressVolume.Value += 10;
                 _player.Volume = 10 * ProgressVolume.Value;
             }

            MessageBox.Show(_player.Volume.ToString());
        }

        /// <summary>
        /// Minus volume value.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinusVolume_Click(object sender, EventArgs e)
        {
            if (ProgressVolume.Value > 0 && ProgressVolume.Value <= 100)
            {
                ProgressVolume.Value -= 10;
                _player.Volume = 10 * ProgressVolume.Value;
            }
        }

    }
}
