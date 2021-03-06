﻿namespace Player
{
    partial class ControlWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlWindow));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.WindowLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProgressVolume = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.MinusVolume = new System.Windows.Forms.PictureBox();
            this.AddVolume = new System.Windows.Forms.PictureBox();
            this.panelBass = new System.Windows.Forms.Panel();
            this.ProgressBass = new System.Windows.Forms.ProgressBar();
            this.AddBass = new System.Windows.Forms.PictureBox();
            this.MinusBass = new System.Windows.Forms.PictureBox();
            this.BassLabel = new System.Windows.Forms.Label();
            this.panelTreble = new System.Windows.Forms.Panel();
            this.ProgressTreble = new System.Windows.Forms.ProgressBar();
            this.MinusTreble = new System.Windows.Forms.PictureBox();
            this.AddTreble = new System.Windows.Forms.PictureBox();
            this.TrebleLabel = new System.Windows.Forms.Label();
            this.draggable1 = new Player.Draggable();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinusVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddVolume)).BeginInit();
            this.panelBass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinusBass)).BeginInit();
            this.panelTreble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinusTreble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddTreble)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.MainPanel.Controls.Add(this.draggable1);
            this.MainPanel.Controls.Add(this.MinimizeButton);
            this.MainPanel.Controls.Add(this.Close_Button);
            this.MainPanel.Controls.Add(this.WindowLabel);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 44);
            this.MainPanel.TabIndex = 1;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.MinimizeButton.Image = global::Player.Properties.Resources.icons8_minimize_window_48;
            this.MinimizeButton.Location = new System.Drawing.Point(702, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(49, 44);
            this.MinimizeButton.TabIndex = 7;
            this.MinimizeButton.Tag = "";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.Close_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_Button.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_Button.FlatAppearance.BorderSize = 0;
            this.Close_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Close_Button.ForeColor = System.Drawing.Color.AliceBlue;
            this.Close_Button.Image = global::Player.Properties.Resources.icons8_close_window_filled_48__1_;
            this.Close_Button.Location = new System.Drawing.Point(751, 0);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(49, 44);
            this.Close_Button.TabIndex = 4;
            this.Close_Button.Tag = "";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            this.Close_Button.MouseEnter += new System.EventHandler(this.Close_Button_MouseEnter);
            this.Close_Button.MouseLeave += new System.EventHandler(this.Close_Button_MouseLeave);
            // 
            // WindowLabel
            // 
            this.WindowLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.WindowLabel.AutoSize = true;
            this.WindowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WindowLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.WindowLabel.Location = new System.Drawing.Point(48, 9);
            this.WindowLabel.Name = "WindowLabel";
            this.WindowLabel.Size = new System.Drawing.Size(75, 22);
            this.WindowLabel.TabIndex = 3;
            this.WindowLabel.Text = "Settings";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTreble);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 224);
            this.panel1.TabIndex = 2;
            // 
            // ProgressVolume
            // 
            this.ProgressVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressVolume.Location = new System.Drawing.Point(23, 53);
            this.ProgressVolume.Name = "ProgressVolume";
            this.ProgressVolume.Size = new System.Drawing.Size(327, 27);
            this.ProgressVolume.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressVolume.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.VolumeLabel);
            this.panel2.Controls.Add(this.MinusVolume);
            this.panel2.Controls.Add(this.AddVolume);
            this.panel2.Controls.Add(this.ProgressVolume);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 182);
            this.panel2.TabIndex = 3;
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VolumeLabel.Location = new System.Drawing.Point(151, 19);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(63, 20);
            this.VolumeLabel.TabIndex = 3;
            this.VolumeLabel.Text = "Volume";
            // 
            // MinusVolume
            // 
            this.MinusVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MinusVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinusVolume.Image = global::Player.Properties.Resources._002_return;
            this.MinusVolume.Location = new System.Drawing.Point(23, 111);
            this.MinusVolume.Name = "MinusVolume";
            this.MinusVolume.Size = new System.Drawing.Size(100, 50);
            this.MinusVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinusVolume.TabIndex = 2;
            this.MinusVolume.TabStop = false;
            this.MinusVolume.Click += new System.EventHandler(this.MinusVolume_Click);
            // 
            // AddVolume
            // 
            this.AddVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddVolume.Image = global::Player.Properties.Resources._003_right_arrow;
            this.AddVolume.Location = new System.Drawing.Point(250, 111);
            this.AddVolume.Name = "AddVolume";
            this.AddVolume.Size = new System.Drawing.Size(100, 50);
            this.AddVolume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddVolume.TabIndex = 1;
            this.AddVolume.TabStop = false;
            this.AddVolume.Click += new System.EventHandler(this.AddVolume_Click);
            // 
            // panelBass
            // 
            this.panelBass.Controls.Add(this.BassLabel);
            this.panelBass.Controls.Add(this.MinusBass);
            this.panelBass.Controls.Add(this.AddBass);
            this.panelBass.Controls.Add(this.ProgressBass);
            this.panelBass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBass.Location = new System.Drawing.Point(374, 44);
            this.panelBass.Name = "panelBass";
            this.panelBass.Size = new System.Drawing.Size(426, 182);
            this.panelBass.TabIndex = 4;
            // 
            // ProgressBass
            // 
            this.ProgressBass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBass.Location = new System.Drawing.Point(50, 53);
            this.ProgressBass.Name = "ProgressBass";
            this.ProgressBass.Size = new System.Drawing.Size(327, 27);
            this.ProgressBass.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBass.TabIndex = 1;
            // 
            // AddBass
            // 
            this.AddBass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBass.Image = global::Player.Properties.Resources._003_right_arrow;
            this.AddBass.Location = new System.Drawing.Point(277, 111);
            this.AddBass.Name = "AddBass";
            this.AddBass.Size = new System.Drawing.Size(100, 50);
            this.AddBass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddBass.TabIndex = 2;
            this.AddBass.TabStop = false;
            this.AddBass.Click += new System.EventHandler(this.AddVolume_Click);
            // 
            // MinusBass
            // 
            this.MinusBass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MinusBass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinusBass.Image = global::Player.Properties.Resources._002_return;
            this.MinusBass.Location = new System.Drawing.Point(50, 111);
            this.MinusBass.Name = "MinusBass";
            this.MinusBass.Size = new System.Drawing.Size(100, 50);
            this.MinusBass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinusBass.TabIndex = 3;
            this.MinusBass.TabStop = false;
            this.MinusBass.Click += new System.EventHandler(this.MinusVolume_Click);
            // 
            // BassLabel
            // 
            this.BassLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BassLabel.AutoSize = true;
            this.BassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BassLabel.Location = new System.Drawing.Point(183, 19);
            this.BassLabel.Name = "BassLabel";
            this.BassLabel.Size = new System.Drawing.Size(45, 20);
            this.BassLabel.TabIndex = 4;
            this.BassLabel.Text = "Bass";
            // 
            // panelTreble
            // 
            this.panelTreble.Controls.Add(this.TrebleLabel);
            this.panelTreble.Controls.Add(this.AddTreble);
            this.panelTreble.Controls.Add(this.MinusTreble);
            this.panelTreble.Controls.Add(this.ProgressTreble);
            this.panelTreble.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTreble.Location = new System.Drawing.Point(0, 0);
            this.panelTreble.Name = "panelTreble";
            this.panelTreble.Size = new System.Drawing.Size(374, 224);
            this.panelTreble.TabIndex = 0;
            // 
            // ProgressTreble
            // 
            this.ProgressTreble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressTreble.Location = new System.Drawing.Point(23, 52);
            this.ProgressTreble.Name = "ProgressTreble";
            this.ProgressTreble.Size = new System.Drawing.Size(327, 27);
            this.ProgressTreble.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressTreble.TabIndex = 1;
            // 
            // MinusTreble
            // 
            this.MinusTreble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MinusTreble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinusTreble.Image = global::Player.Properties.Resources._002_return;
            this.MinusTreble.Location = new System.Drawing.Point(23, 128);
            this.MinusTreble.Name = "MinusTreble";
            this.MinusTreble.Size = new System.Drawing.Size(100, 50);
            this.MinusTreble.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinusTreble.TabIndex = 3;
            this.MinusTreble.TabStop = false;
            this.MinusTreble.Click += new System.EventHandler(this.MinusVolume_Click);
            // 
            // AddTreble
            // 
            this.AddTreble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTreble.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTreble.Image = global::Player.Properties.Resources._003_right_arrow;
            this.AddTreble.Location = new System.Drawing.Point(250, 128);
            this.AddTreble.Name = "AddTreble";
            this.AddTreble.Size = new System.Drawing.Size(100, 50);
            this.AddTreble.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddTreble.TabIndex = 4;
            this.AddTreble.TabStop = false;
            this.AddTreble.Click += new System.EventHandler(this.AddVolume_Click);
            // 
            // TrebleLabel
            // 
            this.TrebleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TrebleLabel.AutoSize = true;
            this.TrebleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TrebleLabel.Location = new System.Drawing.Point(151, 20);
            this.TrebleLabel.Name = "TrebleLabel";
            this.TrebleLabel.Size = new System.Drawing.Size(53, 20);
            this.TrebleLabel.TabIndex = 5;
            this.TrebleLabel.Text = "Treble";
            // 
            // draggable1
            // 
            this.draggable1.Dock = System.Windows.Forms.DockStyle.Right;
            this.draggable1.Location = new System.Drawing.Point(692, 0);
            this.draggable1.Name = "draggable1";
            this.draggable1.SelectControl = this.MainPanel;
            this.draggable1.Size = new System.Drawing.Size(10, 44);
            this.draggable1.TabIndex = 8;
            this.draggable1.Text = "draggable1";
            // 
            // ControlWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelBass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ControlWindow";
            this.Text = "ControlWindow";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinusVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddVolume)).EndInit();
            this.panelBass.ResumeLayout(false);
            this.panelBass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddBass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinusBass)).EndInit();
            this.panelTreble.ResumeLayout(false);
            this.panelTreble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinusTreble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddTreble)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private Draggable draggable1;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Label WindowLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar ProgressVolume;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.PictureBox MinusVolume;
        private System.Windows.Forms.PictureBox AddVolume;
        private System.Windows.Forms.Panel panelTreble;
        private System.Windows.Forms.Label TrebleLabel;
        private System.Windows.Forms.PictureBox AddTreble;
        private System.Windows.Forms.PictureBox MinusTreble;
        private System.Windows.Forms.ProgressBar ProgressTreble;
        private System.Windows.Forms.Panel panelBass;
        private System.Windows.Forms.Label BassLabel;
        private System.Windows.Forms.PictureBox MinusBass;
        private System.Windows.Forms.PictureBox AddBass;
        private System.Windows.Forms.ProgressBar ProgressBass;
    }
}