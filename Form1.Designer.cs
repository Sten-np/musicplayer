namespace musicplayer
{
    partial class MusicPlayerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Minimalized = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.btnSelectSong = new System.Windows.Forms.Button();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnRepeat = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.p_bar = new System.Windows.Forms.ProgressBar();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.TextVolume = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelTrackStart = new System.Windows.Forms.Label();
            this.labelTrackEnd = new System.Windows.Forms.Label();
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.btnFolderSelect = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playlistRemove = new System.Windows.Forms.Button();
            this.playlistAdd = new System.Windows.Forms.Button();
            this.song_name = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimalized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFolderSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.LightCyan;
            this.TopPanel.Controls.Add(this.pictureBox2);
            this.TopPanel.Controls.Add(this.Minimalized);
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.lblLogo);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1068, 42);
            this.TopPanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::musicplayer.Properties.Resources.maximize;
            this.pictureBox2.Location = new System.Drawing.Point(1213, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Minimalized
            // 
            this.Minimalized.Image = global::musicplayer.Properties.Resources.minimalise1;
            this.Minimalized.Location = new System.Drawing.Point(964, 0);
            this.Minimalized.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Minimalized.Name = "Minimalized";
            this.Minimalized.Size = new System.Drawing.Size(48, 42);
            this.Minimalized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimalized.TabIndex = 2;
            this.Minimalized.TabStop = false;
            this.Minimalized.Click += new System.EventHandler(this.Minimalized_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1019, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(11, 11);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(104, 25);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "BeatBlast";
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 24;
            this.listBoxSongs.Location = new System.Drawing.Point(455, 206);
            this.listBoxSongs.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(488, 196);
            this.listBoxSongs.TabIndex = 1;
            // 
            // btnSelectSong
            // 
            this.btnSelectSong.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSelectSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSong.ForeColor = System.Drawing.Color.White;
            this.btnSelectSong.Location = new System.Drawing.Point(716, 505);
            this.btnSelectSong.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectSong.Name = "btnSelectSong";
            this.btnSelectSong.Size = new System.Drawing.Size(335, 34);
            this.btnSelectSong.TabIndex = 2;
            this.btnSelectSong.Text = "Select Song";
            this.btnSelectSong.UseVisualStyleBackColor = false;
            this.btnSelectSong.Click += new System.EventHandler(this.btnSelectSong_Click);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.BackColor = System.Drawing.Color.OrangeRed;
            this.btnPlayPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayPause.ForeColor = System.Drawing.Color.White;
            this.btnPlayPause.Location = new System.Drawing.Point(152, 506);
            this.btnPlayPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(173, 34);
            this.btnPlayPause.TabIndex = 3;
            this.btnPlayPause.Text = "▶ / II";
            this.btnPlayPause.UseVisualStyleBackColor = false;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.OrangeRed;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(333, 506);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(113, 34);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.OrangeRed;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(28, 506);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(112, 34);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnRepeat
            // 
            this.btnRepeat.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepeat.ForeColor = System.Drawing.Color.White;
            this.btnRepeat.Location = new System.Drawing.Point(455, 506);
            this.btnRepeat.Margin = new System.Windows.Forms.Padding(4);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(113, 34);
            this.btnRepeat.TabIndex = 6;
            this.btnRepeat.Text = "Repeat";
            this.btnRepeat.UseVisualStyleBackColor = false;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.OrangeRed;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(576, 505);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(117, 34);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(28, 469);
            this.p_bar.Margin = new System.Windows.Forms.Padding(4);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(1023, 28);
            this.p_bar.TabIndex = 8;
            this.p_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_bar_MouseDown);
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(983, 195);
            this.trackVolume.Margin = new System.Windows.Forms.Padding(4);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackVolume.Size = new System.Drawing.Size(56, 249);
            this.trackVolume.TabIndex = 11;
            this.trackVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll);
            // 
            // TextVolume
            // 
            this.TextVolume.AutoSize = true;
            this.TextVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextVolume.Location = new System.Drawing.Point(987, 436);
            this.TextVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TextVolume.Name = "TextVolume";
            this.TextVolume.Size = new System.Drawing.Size(61, 17);
            this.TextVolume.TabIndex = 12;
            this.TextVolume.Text = "Volume";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolume.Location = new System.Drawing.Point(991, 167);
            this.labelVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(48, 17);
            this.labelVolume.TabIndex = 13;
            this.labelVolume.Text = "100%";
            // 
            // labelTrackStart
            // 
            this.labelTrackStart.AutoSize = true;
            this.labelTrackStart.BackColor = System.Drawing.Color.Black;
            this.labelTrackStart.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackStart.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelTrackStart.Location = new System.Drawing.Point(27, 57);
            this.labelTrackStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTrackStart.Name = "labelTrackStart";
            this.labelTrackStart.Size = new System.Drawing.Size(97, 42);
            this.labelTrackStart.TabIndex = 14;
            this.labelTrackStart.Text = "00:00";
            // 
            // labelTrackEnd
            // 
            this.labelTrackEnd.AutoSize = true;
            this.labelTrackEnd.BackColor = System.Drawing.Color.Black;
            this.labelTrackEnd.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackEnd.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelTrackEnd.Location = new System.Drawing.Point(939, 57);
            this.labelTrackEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTrackEnd.Name = "labelTrackEnd";
            this.labelTrackEnd.Size = new System.Drawing.Size(97, 42);
            this.labelTrackEnd.TabIndex = 15;
            this.labelTrackEnd.Text = "00:00";
            // 
            // pic_art
            // 
            this.pic_art.Image = global::musicplayer.Properties.Resources.rap_mixtape_cover_art_design_template___Gemaakt_met_PosterMyWall;
            this.pic_art.Location = new System.Drawing.Point(52, 195);
            this.pic_art.Margin = new System.Windows.Forms.Padding(4);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(273, 257);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 9;
            this.pic_art.TabStop = false;
            // 
            // btnFolderSelect
            // 
            this.btnFolderSelect.Image = global::musicplayer.Properties.Resources.folder1;
            this.btnFolderSelect.Location = new System.Drawing.Point(455, 167);
            this.btnFolderSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFolderSelect.Name = "btnFolderSelect";
            this.btnFolderSelect.Size = new System.Drawing.Size(41, 32);
            this.btnFolderSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFolderSelect.TabIndex = 16;
            this.btnFolderSelect.TabStop = false;
            this.btnFolderSelect.Click += new System.EventHandler(this.btnFolderSelect_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(808, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 17;
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 42);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(1068, 56);
            this.player.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playlistRemove
            // 
            this.playlistRemove.BackColor = System.Drawing.Color.OrangeRed;
            this.playlistRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlistRemove.ForeColor = System.Drawing.Color.White;
            this.playlistRemove.Location = new System.Drawing.Point(511, 176);
            this.playlistRemove.Name = "playlistRemove";
            this.playlistRemove.Size = new System.Drawing.Size(40, 23);
            this.playlistRemove.TabIndex = 18;
            this.playlistRemove.Text = "-";
            this.playlistRemove.UseVisualStyleBackColor = false;
            this.playlistRemove.Click += new System.EventHandler(this.playlistRemove_Click);
            // 
            // playlistAdd
            // 
            this.playlistAdd.BackColor = System.Drawing.Color.OrangeRed;
            this.playlistAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlistAdd.ForeColor = System.Drawing.Color.White;
            this.playlistAdd.Location = new System.Drawing.Point(557, 176);
            this.playlistAdd.Name = "playlistAdd";
            this.playlistAdd.Size = new System.Drawing.Size(45, 23);
            this.playlistAdd.TabIndex = 19;
            this.playlistAdd.Text = "+";
            this.playlistAdd.UseVisualStyleBackColor = false;
            this.playlistAdd.Click += new System.EventHandler(this.playlistAdd_Click);
            // 
            // song_name
            // 
            this.song_name.AutoSize = true;
            this.song_name.Location = new System.Drawing.Point(49, 143);
            this.song_name.Name = "song_name";
            this.song_name.Size = new System.Drawing.Size(36, 16);
            this.song_name.TabIndex = 18;
            this.song_name.Text = "Title:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(107, 143);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 16);
            this.label_name.TabIndex = 21;
            // 
            // MusicPlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 554);
            this.Controls.Add(this.playlistAdd);
            this.Controls.Add(this.playlistRemove);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.song_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFolderSelect);
            this.Controls.Add(this.labelTrackEnd);
            this.Controls.Add(this.labelTrackStart);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.TextVolume);
            this.Controls.Add(this.trackVolume);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pic_art);
            this.Controls.Add(this.p_bar);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnRepeat);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPlayPause);
            this.Controls.Add(this.btnSelectSong);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MusicPlayerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player App";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimalized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFolderSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Button btnSelectSong;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnRepeat;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ProgressBar p_bar;
        private System.Windows.Forms.PictureBox pic_art;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Label TextVolume;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelTrackStart;
        private System.Windows.Forms.Label labelTrackEnd;
        private System.Windows.Forms.PictureBox Minimalized;
        private System.Windows.Forms.PictureBox btnFolderSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.Button playlistRemove;
        private System.Windows.Forms.Button playlistAdd;

        private System.Windows.Forms.Label song_name;
        private System.Windows.Forms.Label label_name;

    }
}

