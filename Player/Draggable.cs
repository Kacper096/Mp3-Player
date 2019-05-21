using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    partial class Draggable : Control
    {
        public Draggable()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private Control handleControl;

        public Control SelectControl
        {
            get => this.handleControl;
            set
            {
                this.handleControl = value;
                this.handleControl.MouseDown += new MouseEventHandler(this.DragFrom_MouseDown);
            }
        }
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr a, int msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragFrom_MouseDown(object sender, MouseEventArgs e)
        {
            bool isDragged = e.Button == MouseButtons.Left;
            if (isDragged)
            {
                Draggable.ReleaseCapture();
                Draggable.SendMessage(this.SelectControl.FindForm().Handle, 161, 2, 0);
            }
        }
    }
}
