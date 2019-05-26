namespace Player
{
    partial class PlayerMp3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerMp3));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.draggable1 = new Player.Draggable();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.MaximizeButton = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.WindowLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Audio = new System.Windows.Forms.PictureBox();
            this.FolderSongs = new System.Windows.Forms.PictureBox();
            this.Stop = new System.Windows.Forms.PictureBox();
            this.singleSong = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Next = new System.Windows.Forms.PictureBox();
            this.Pause = new System.Windows.Forms.PictureBox();
            this.Play = new System.Windows.Forms.PictureBox();
            this.Previous = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PlayList = new System.Windows.Forms.ListBox();
            this.FolderSong = new System.Windows.Forms.FolderBrowserDialog();
            this.CurrentSong = new System.Windows.Forms.Label();
            this.CurrenTime = new System.Windows.Forms.Label();
            this.PanelIcons = new System.Windows.Forms.Panel();
            this.Adjust = new System.Windows.Forms.PictureBox();
            this.List = new System.Windows.Forms.PictureBox();
            this.PanelSlide = new System.Windows.Forms.Panel();
            this.Shuffle = new System.Windows.Forms.PictureBox();
            this.PlayListSplitter = new System.Windows.Forms.Splitter();
            this.Slider = new System.Windows.Forms.Timer(this.components);
            this.MainStage = new System.Windows.Forms.Panel();
            this.MainPicture = new System.Windows.Forms.PictureBox();
            this.Repeat = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Audio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FolderSongs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleSong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Previous)).BeginInit();
            this.PanelIcons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Adjust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.List)).BeginInit();
            this.PanelSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Shuffle)).BeginInit();
            this.MainStage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repeat)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.MainPanel.Controls.Add(this.draggable1);
            this.MainPanel.Controls.Add(this.MinimizeButton);
            this.MainPanel.Controls.Add(this.MaximizeButton);
            this.MainPanel.Controls.Add(this.Close_Button);
            this.MainPanel.Controls.Add(this.WindowLabel);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(551, 44);
            this.MainPanel.TabIndex = 0;
            // 
            // draggable1
            // 
            this.draggable1.Dock = System.Windows.Forms.DockStyle.Right;
            this.draggable1.Location = new System.Drawing.Point(394, 0);
            this.draggable1.Name = "draggable1";
            this.draggable1.SelectControl = this.MainPanel;
            this.draggable1.Size = new System.Drawing.Size(10, 44);
            this.draggable1.TabIndex = 8;
            this.draggable1.Text = "draggable1";
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
            this.MinimizeButton.Location = new System.Drawing.Point(404, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(49, 44);
            this.MinimizeButton.TabIndex = 7;
            this.MinimizeButton.Tag = "";
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.MaximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaximizeButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.MaximizeButton.Image = global::Player.Properties.Resources.icons8_maximize_window_48;
            this.MaximizeButton.Location = new System.Drawing.Point(453, 0);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(49, 44);
            this.MaximizeButton.TabIndex = 6;
            this.MaximizeButton.Tag = "";
            this.MaximizeButton.UseVisualStyleBackColor = false;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
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
            this.Close_Button.Location = new System.Drawing.Point(502, 0);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(49, 44);
            this.Close_Button.TabIndex = 4;
            this.Close_Button.Tag = "";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.CloseButton_Click);
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
            this.WindowLabel.Size = new System.Drawing.Size(100, 22);
            this.WindowLabel.TabIndex = 3;
            this.WindowLabel.Text = "Mp3 Player";
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
            this.panel1.Controls.Add(this.Repeat);
            this.panel1.Controls.Add(this.Audio);
            this.panel1.Controls.Add(this.FolderSongs);
            this.panel1.Controls.Add(this.Stop);
            this.panel1.Controls.Add(this.singleSong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 429);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(551, 64);
            this.panel1.TabIndex = 2;
            // 
            // Audio
            // 
            this.Audio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Audio.Dock = System.Windows.Forms.DockStyle.Right;
            this.Audio.Image = global::Player.Properties.Resources.icons8_audio;
            this.Audio.Location = new System.Drawing.Point(467, 5);
            this.Audio.Name = "Audio";
            this.Audio.Size = new System.Drawing.Size(79, 54);
            this.Audio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Audio.TabIndex = 3;
            this.Audio.TabStop = false;
            this.Audio.Click += new System.EventHandler(this.MuteButton_Click);
            // 
            // FolderSongs
            // 
            this.FolderSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FolderSongs.Dock = System.Windows.Forms.DockStyle.Left;
            this.FolderSongs.Image = global::Player.Properties.Resources.icons8_foldersongs;
            this.FolderSongs.Location = new System.Drawing.Point(107, 5);
            this.FolderSongs.Name = "FolderSongs";
            this.FolderSongs.Size = new System.Drawing.Size(102, 54);
            this.FolderSongs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FolderSongs.TabIndex = 2;
            this.FolderSongs.TabStop = false;
            this.FolderSongs.Click += new System.EventHandler(this.FolderSongs_Click);
            this.FolderSongs.MouseEnter += new System.EventHandler(this.PictureBoxes_MouseEnter);
            this.FolderSongs.MouseLeave += new System.EventHandler(this.PictureBoxes_MouseLeave);
            // 
            // Stop
            // 
            this.Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop.Image = global::Player.Properties.Resources.icons8_stop;
            this.Stop.Location = new System.Drawing.Point(205, 5);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(100, 54);
            this.Stop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Stop.TabIndex = 1;
            this.Stop.TabStop = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // singleSong
            // 
            this.singleSong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.singleSong.Dock = System.Windows.Forms.DockStyle.Left;
            this.singleSong.Image = global::Player.Properties.Resources.icons8_singlesong;
            this.singleSong.Location = new System.Drawing.Point(5, 5);
            this.singleSong.Name = "singleSong";
            this.singleSong.Size = new System.Drawing.Size(102, 54);
            this.singleSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.singleSong.TabIndex = 0;
            this.singleSong.TabStop = false;
            this.singleSong.Click += new System.EventHandler(this.Open_Click);
            this.singleSong.MouseEnter += new System.EventHandler(this.PictureBoxes_MouseEnter);
            this.singleSong.MouseLeave += new System.EventHandler(this.PictureBoxes_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Next);
            this.panel2.Controls.Add(this.Pause);
            this.panel2.Controls.Add(this.Play);
            this.panel2.Controls.Add(this.Previous);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 368);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(551, 61);
            this.panel2.TabIndex = 3;
            // 
            // Next
            // 
            this.Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next.Image = global::Player.Properties.Resources.icons8_next;
            this.Next.Location = new System.Drawing.Point(380, 5);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(87, 51);
            this.Next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Next.TabIndex = 5;
            this.Next.TabStop = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            this.Next.MouseEnter += new System.EventHandler(this.PictureBoxes_MouseEnter);
            this.Next.MouseLeave += new System.EventHandler(this.PictureBoxes_MouseLeave);
            // 
            // Pause
            // 
            this.Pause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pause.Image = ((System.Drawing.Image)(resources.GetObject("Pause.Image")));
            this.Pause.Location = new System.Drawing.Point(280, 5);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(100, 51);
            this.Pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pause.TabIndex = 4;
            this.Pause.TabStop = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            this.Pause.MouseEnter += new System.EventHandler(this.PictureBoxes_MouseEnter);
            this.Pause.MouseLeave += new System.EventHandler(this.PictureBoxes_MouseLeave);
            // 
            // Play
            // 
            this.Play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.Image = global::Player.Properties.Resources.icons8_play;
            this.Play.Location = new System.Drawing.Point(180, 5);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(100, 51);
            this.Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Play.TabIndex = 3;
            this.Play.TabStop = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            this.Play.MouseEnter += new System.EventHandler(this.PictureBoxes_MouseEnter);
            this.Play.MouseLeave += new System.EventHandler(this.PictureBoxes_MouseLeave);
            // 
            // Previous
            // 
            this.Previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Previous.Image = global::Player.Properties.Resources.icons8_previous;
            this.Previous.Location = new System.Drawing.Point(80, 5);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(100, 51);
            this.Previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Previous.TabIndex = 2;
            this.Previous.TabStop = false;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            this.Previous.MouseEnter += new System.EventHandler(this.PictureBoxes_MouseEnter);
            this.Previous.MouseLeave += new System.EventHandler(this.PictureBoxes_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel4.Location = new System.Drawing.Point(467, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(79, 51);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 51);
            this.panel3.TabIndex = 0;
            // 
            // PlayList
            // 
            this.PlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(192)))), ((int)(((byte)(235)))));
            this.PlayList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlayList.ForeColor = System.Drawing.Color.Snow;
            this.PlayList.FormattingEnabled = true;
            this.PlayList.HorizontalScrollbar = true;
            this.PlayList.Location = new System.Drawing.Point(0, 97);
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(0, 199);
            this.PlayList.TabIndex = 4;
            this.PlayList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PlayList_MouseDoubleClick);
            // 
            // FolderSong
            // 
            this.FolderSong.Description = "Select your folder where you have MP3 songs.";
            this.FolderSong.ShowNewFolderButton = false;
            // 
            // CurrentSong
            // 
            this.CurrentSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.CurrentSong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CurrentSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrentSong.Location = new System.Drawing.Point(0, 340);
            this.CurrentSong.Margin = new System.Windows.Forms.Padding(5);
            this.CurrentSong.Name = "CurrentSong";
            this.CurrentSong.Padding = new System.Windows.Forms.Padding(5);
            this.CurrentSong.Size = new System.Drawing.Size(551, 28);
            this.CurrentSong.TabIndex = 5;
            this.CurrentSong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CurrentSong.Visible = false;
            // 
            // CurrenTime
            // 
            this.CurrenTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrenTime.AutoSize = true;
            this.CurrenTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(234)))), ((int)(((byte)(255)))));
            this.CurrenTime.Location = new System.Drawing.Point(499, 349);
            this.CurrenTime.Name = "CurrenTime";
            this.CurrenTime.Size = new System.Drawing.Size(0, 13);
            this.CurrenTime.TabIndex = 6;
            this.CurrenTime.Visible = false;
            // 
            // PanelIcons
            // 
            this.PanelIcons.Controls.Add(this.Adjust);
            this.PanelIcons.Controls.Add(this.List);
            this.PanelIcons.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIcons.Location = new System.Drawing.Point(0, 44);
            this.PanelIcons.Name = "PanelIcons";
            this.PanelIcons.Size = new System.Drawing.Size(42, 296);
            this.PanelIcons.TabIndex = 7;
            // 
            // Adjust
            // 
            this.Adjust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Adjust.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Adjust.Image = global::Player.Properties.Resources.icons8_adjust;
            this.Adjust.Location = new System.Drawing.Point(0, 246);
            this.Adjust.Name = "Adjust";
            this.Adjust.Size = new System.Drawing.Size(42, 50);
            this.Adjust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Adjust.TabIndex = 1;
            this.Adjust.TabStop = false;
            this.Adjust.Click += new System.EventHandler(this.SettingsButton_Click);
            this.Adjust.MouseEnter += new System.EventHandler(this.PictureBoxes_MouseEnter);
            this.Adjust.MouseLeave += new System.EventHandler(this.PictureBoxes_MouseLeave);
            // 
            // List
            // 
            this.List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.List.Dock = System.Windows.Forms.DockStyle.Top;
            this.List.Image = global::Player.Properties.Resources.icons8_playlist;
            this.List.Location = new System.Drawing.Point(0, 0);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(42, 50);
            this.List.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.List.TabIndex = 0;
            this.List.TabStop = false;
            this.List.Click += new System.EventHandler(this.MenuButton_Click);
            this.List.MouseEnter += new System.EventHandler(this.PictureBoxes_MouseEnter);
            this.List.MouseLeave += new System.EventHandler(this.PictureBoxes_MouseLeave);
            // 
            // PanelSlide
            // 
            this.PanelSlide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelSlide.BackColor = System.Drawing.Color.AliceBlue;
            this.PanelSlide.Controls.Add(this.Shuffle);
            this.PanelSlide.Controls.Add(this.PlayListSplitter);
            this.PanelSlide.Controls.Add(this.PlayList);
            this.PanelSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelSlide.Location = new System.Drawing.Point(42, 44);
            this.PanelSlide.Name = "PanelSlide";
            this.PanelSlide.Size = new System.Drawing.Size(0, 296);
            this.PanelSlide.TabIndex = 8;
            // 
            // Shuffle
            // 
            this.Shuffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Shuffle.Image = global::Player.Properties.Resources.icons8_shuffle;
            this.Shuffle.Location = new System.Drawing.Point(6, 41);
            this.Shuffle.Name = "Shuffle";
            this.Shuffle.Size = new System.Drawing.Size(42, 50);
            this.Shuffle.TabIndex = 6;
            this.Shuffle.TabStop = false;
            this.Shuffle.Click += new System.EventHandler(this.Shuffle_Click);
            // 
            // PlayListSplitter
            // 
            this.PlayListSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlayListSplitter.Location = new System.Drawing.Point(0, 92);
            this.PlayListSplitter.Name = "PlayListSplitter";
            this.PlayListSplitter.Size = new System.Drawing.Size(0, 5);
            this.PlayListSplitter.TabIndex = 5;
            this.PlayListSplitter.TabStop = false;
            // 
            // Slider
            // 
            this.Slider.Interval = 50;
            this.Slider.Tick += new System.EventHandler(this.Slider_Tick);
            // 
            // MainStage
            // 
            this.MainStage.Controls.Add(this.MainPicture);
            this.MainStage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainStage.Location = new System.Drawing.Point(42, 44);
            this.MainStage.Name = "MainStage";
            this.MainStage.Padding = new System.Windows.Forms.Padding(5);
            this.MainStage.Size = new System.Drawing.Size(509, 296);
            this.MainStage.TabIndex = 9;
            // 
            // MainPicture
            // 
            this.MainPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPicture.Image = ((System.Drawing.Image)(resources.GetObject("MainPicture.Image")));
            this.MainPicture.Location = new System.Drawing.Point(5, 5);
            this.MainPicture.Name = "MainPicture";
            this.MainPicture.Size = new System.Drawing.Size(499, 286);
            this.MainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MainPicture.TabIndex = 0;
            this.MainPicture.TabStop = false;
            // 
            // Repeat
            // 
            this.Repeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Repeat.Image = global::Player.Properties.Resources.icons8_repeat;
            this.Repeat.Location = new System.Drawing.Point(304, 5);
            this.Repeat.Name = "Repeat";
            this.Repeat.Size = new System.Drawing.Size(100, 54);
            this.Repeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Repeat.TabIndex = 4;
            this.Repeat.TabStop = false;
            this.Repeat.Click += new System.EventHandler(this.Repeat_Click);
            // 
            // PlayerMp3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(551, 493);
            this.Controls.Add(this.MainStage);
            this.Controls.Add(this.PanelSlide);
            this.Controls.Add(this.PanelIcons);
            this.Controls.Add(this.CurrenTime);
            this.Controls.Add(this.CurrentSong);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayerMp3";
            this.Text = "Mp3 Player";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Audio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FolderSongs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleSong)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Previous)).EndInit();
            this.PanelIcons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Adjust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.List)).EndInit();
            this.PanelSlide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Shuffle)).EndInit();
            this.MainStage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label WindowLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox singleSong;
        private System.Windows.Forms.PictureBox Stop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Next;
        private System.Windows.Forms.PictureBox Pause;
        private System.Windows.Forms.PictureBox Play;
        private System.Windows.Forms.PictureBox Previous;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox PlayList;
        private System.Windows.Forms.PictureBox FolderSongs;
        public System.Windows.Forms.FolderBrowserDialog FolderSong;
        private System.Windows.Forms.Label CurrentSong;
        private System.Windows.Forms.Label CurrenTime;
        private System.Windows.Forms.Panel PanelIcons;
        private System.Windows.Forms.PictureBox List;
        private System.Windows.Forms.Panel PanelSlide;
        private System.Windows.Forms.Timer Slider;
        private System.Windows.Forms.Splitter PlayListSplitter;
        private System.Windows.Forms.Panel MainStage;
        private System.Windows.Forms.PictureBox MainPicture;
        private System.Windows.Forms.PictureBox Adjust;
        private System.Windows.Forms.PictureBox Audio;
        private System.Windows.Forms.Button MaximizeButton;
        private System.Windows.Forms.Button MinimizeButton;
        private Draggable draggable1;
        private System.Windows.Forms.PictureBox Shuffle;
        private System.Windows.Forms.PictureBox Repeat;
    }
}

