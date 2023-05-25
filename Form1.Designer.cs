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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            this.TopPanel = new System.Windows.Forms.Panel();
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
            this.pic_art = new System.Windows.Forms.PictureBox();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.TextVolume = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelTrackStart = new System.Windows.Forms.Label();
            this.labelTrackEnd = new System.Windows.Forms.Label();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnFolderSelect = new System.Windows.Forms.Button();
            this.textBoxFileSearch = new System.Windows.Forms.TextBox();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.LightCyan;
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.lblLogo);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(801, 34);
            this.TopPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(764, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(8, 9);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(88, 20);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "BeatBlast";
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 18;
            this.listBoxSongs.Location = new System.Drawing.Point(341, 167);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(367, 184);
            this.listBoxSongs.TabIndex = 1;
            // 
            // btnSelectSong
            // 
            this.btnSelectSong.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSelectSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectSong.ForeColor = System.Drawing.Color.White;
            this.btnSelectSong.Location = new System.Drawing.Point(537, 410);
            this.btnSelectSong.Name = "btnSelectSong";
            this.btnSelectSong.Size = new System.Drawing.Size(251, 28);
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
            this.btnPlayPause.Location = new System.Drawing.Point(114, 411);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(130, 28);
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
            this.btnNext.Location = new System.Drawing.Point(250, 411);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 28);
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
            this.btnPrevious.Location = new System.Drawing.Point(21, 411);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(84, 28);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // btnRepeat
            // 
            this.btnRepeat.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepeat.ForeColor = System.Drawing.Color.White;
            this.btnRepeat.Location = new System.Drawing.Point(341, 411);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(85, 28);
            this.btnRepeat.TabIndex = 6;
            this.btnRepeat.Text = "Repeat";
            this.btnRepeat.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.OrangeRed;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(432, 410);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(88, 28);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // p_bar
            // 
            this.p_bar.Location = new System.Drawing.Point(21, 381);
            this.p_bar.Name = "p_bar";
            this.p_bar.Size = new System.Drawing.Size(767, 23);
            this.p_bar.TabIndex = 8;
            // 
            // pic_art
            // 
            this.pic_art.Image = global::musicplayer.Properties.Resources.rap_mixtape_cover_art_design_template___Gemaakt_met_PosterMyWall;
            this.pic_art.Location = new System.Drawing.Point(39, 134);
            this.pic_art.Name = "pic_art";
            this.pic_art.Size = new System.Drawing.Size(223, 233);
            this.pic_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_art.TabIndex = 9;
            this.pic_art.TabStop = false;
            // 
            // trackVolume
            // 
            this.trackVolume.Location = new System.Drawing.Point(740, 149);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackVolume.Size = new System.Drawing.Size(45, 202);
            this.trackVolume.TabIndex = 11;
            this.trackVolume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // TextVolume
            // 
            this.TextVolume.AutoSize = true;
            this.TextVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextVolume.Location = new System.Drawing.Point(740, 354);
            this.TextVolume.Name = "TextVolume";
            this.TextVolume.Size = new System.Drawing.Size(48, 13);
            this.TextVolume.TabIndex = 12;
            this.TextVolume.Text = "Volume";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolume.Location = new System.Drawing.Point(743, 136);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(37, 13);
            this.labelVolume.TabIndex = 13;
            this.labelVolume.Text = "100%";
            // 
            // labelTrackStart
            // 
            this.labelTrackStart.AutoSize = true;
            this.labelTrackStart.BackColor = System.Drawing.Color.Black;
            this.labelTrackStart.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackStart.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelTrackStart.Location = new System.Drawing.Point(20, 46);
            this.labelTrackStart.Name = "labelTrackStart";
            this.labelTrackStart.Size = new System.Drawing.Size(76, 34);
            this.labelTrackStart.TabIndex = 14;
            this.labelTrackStart.Text = "00:00";
            // 
            // labelTrackEnd
            // 
            this.labelTrackEnd.AutoSize = true;
            this.labelTrackEnd.BackColor = System.Drawing.Color.Black;
            this.labelTrackEnd.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrackEnd.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelTrackEnd.Location = new System.Drawing.Point(704, 46);
            this.labelTrackEnd.Name = "labelTrackEnd";
            this.labelTrackEnd.Size = new System.Drawing.Size(76, 34);
            this.labelTrackEnd.TabIndex = 15;
            this.labelTrackEnd.Text = "00:00";
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 34);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(801, 56);
            this.player.TabIndex = 10;
            // 
            // btnFolderSelect
            // 
            this.btnFolderSelect.BackColor = System.Drawing.Color.OrangeRed;
            this.btnFolderSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolderSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolderSelect.ForeColor = System.Drawing.Color.White;
            this.btnFolderSelect.Location = new System.Drawing.Point(666, 126);
            this.btnFolderSelect.Name = "btnFolderSelect";
            this.btnFolderSelect.Size = new System.Drawing.Size(42, 23);
            this.btnFolderSelect.TabIndex = 16;
            this.btnFolderSelect.Text = "•••";
            this.btnFolderSelect.UseVisualStyleBackColor = false;
            // 
            // textBoxFileSearch
            // 
            this.textBoxFileSearch.Location = new System.Drawing.Point(467, 126);
            this.textBoxFileSearch.Name = "textBoxFileSearch";
            this.textBoxFileSearch.Size = new System.Drawing.Size(193, 20);
            this.textBoxFileSearch.TabIndex = 17;
            // 
            // MusicPlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.textBoxFileSearch);
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
            this.Name = "MusicPlayerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player App";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
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
        private System.Windows.Forms.Button btnFolderSelect;
        private System.Windows.Forms.TextBox textBoxFileSearch;
    }
}

