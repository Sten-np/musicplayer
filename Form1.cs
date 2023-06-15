using AxWMPLib;
using WMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace musicplayer
{
    public partial class MusicPlayerApp : Form
    {
        private string[] songs;
        private int count;
        private String path = @"";
        private String selectedSong = @"";
        private String songName;


        //De constructor voor de class MusicPlayerApp. Met daarin de componenten die worden meteen ingeladen.
        // en de player.Hide() die ervoor zorgt dat de standaard media player niet zichtbaar is.
        public MusicPlayerApp()
        {
            InitializeComponent();
            trackVolume.Value = 50;
            labelVolume.Text = "50%";
            player.Hide();
            player.PlayStateChange += Player_PlayStateChange;
        }

        // Een setter zodat de gebruiker het folderpad kan aanpassen.
        public void SetPath(string path)
        {
            this.path = path;
        }

        // methode die kijkt of de folder waarin de muziek hoort te staan bestaat. Bestaat hij wel? Dan worden de 'songs' in een array gezet die vervolgens 
        // in de listBoxSongs wordt gezet om getoont te worden aan de gebruiker.

        public void InsertIntoListBox()
        {
            if (Directory.Exists(this.path))
            {
                this.songs = Directory.GetFiles(this.path);
                this.count = this.songs.Count();
                this.songs.Append(this.path);
                label1.Text = this.count + " files loaded in.";

                foreach (string filePath in this.songs)
                {
                    if (filePath.Contains(".mp3") || filePath.Contains(".ogg")
                        || filePath.Contains(".wav") || filePath.Contains(".flac"))
                    {
                        this.songName = Path.GetFileName(filePath);
                        listBoxSongs.Items.Add(filePath);
                    }
                }
            }
            else
            {
                listBoxSongs.Items.Add("Directory does not exist!");
            }
        }

        private void btnSelectSong_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedItem != null)
            {
                string selectedItem = listBoxSongs.SelectedItem.ToString();
                this.selectedSong = selectedItem;
                label_name.Text = selectedItem.ToString().Trim();
            }
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            try
            {
                player.URL = this.selectedSong;
                player.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kon het bestand niet afspelen. " + ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                int currentItem = listBoxSongs.SelectedIndex;

                if (currentItem < listBoxSongs.Items.Count - 1)
                {
                    object nextItem = listBoxSongs.Items[currentItem + 1];

                    if (nextItem != null)
                    {
                        player.URL = nextItem.ToString();
                        if (nextItem.ToString().Contains(".mp3") || nextItem.ToString().Contains(".flac") ||
                            nextItem.ToString().Contains(".ogg") || nextItem.ToString().Contains(".wav"))
                        {
                            listBoxSongs.SelectedIndex = currentItem + 1;
                            player.Ctlcontrols.play();
                            label_name.Text = nextItem.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bestand niet in ondersteund formaat!");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Het 'volgende' bestand bestaat niet.");
                }
            }
            catch (System.Windows.Forms.AxHost.InvalidActiveXStateException ex)
            {
                MessageBox.Show("InvalidActiveXStateException occurred: " + ex.Message);
            }
        }

        // Of de status veranderd van de mediaplayer, IS de media ge-eindigt. Speel dan het volgende nummer af.
        void Player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                try
                {
                    int currentItem = listBoxSongs.SelectedIndex;
                    if (currentItem < listBoxSongs.Items.Count - 1)
                    {
                        object nextItem = listBoxSongs.Items[currentItem + 1];
                        if (nextItem != null && (nextItem.ToString().Contains(".mp3") || nextItem.ToString().Contains(".flac")
                            || nextItem.ToString().Contains(".ogg") || nextItem.ToString().Contains(".wav")))
                        {
                            player.URL = nextItem.ToString();
                            player.Ctlcontrols.play();
                            listBoxSongs.SelectedIndex = currentItem + 1;
                            label_name.Text = nextItem.ToString();
                        }
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show("Error in PlaySateChange " + ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFolderSelect_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            string searchQuery = dialog.SelectedPath;
            SetPath(searchQuery);
            InsertIntoListBox();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void Minimalized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                p_bar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                p_bar.Value = (int)player.Ctlcontrols.currentPosition;
            }
            try
            {
                labelTrackStart.Text = player.Ctlcontrols.currentPositionString;
                labelTrackEnd.Text = player.Ctlcontrols.currentItem.durationString.ToString();
            }
            catch
            {

            }
        }

        private void p_bar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / p_bar.Width;
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            player.settings.setMode("loop", true);
        }

        private void playlistAdd_Click(object sender, EventArgs e)
        {

        }

        private void playlistRemove_Click(object sender, EventArgs e)
        {

        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackVolume.Value;
            labelVolume.Text = trackVolume.Value.ToString() + "%";
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                int currentItem = listBoxSongs.SelectedIndex;

                if (currentItem > 0)
                {
                    if (currentItem < listBoxSongs.Items.Count + 1)
                    {
                        object nextItem = listBoxSongs.Items[currentItem - 1];
                            if (nextItem != null)
                            {
                                player.URL = nextItem.ToString();
                                if (nextItem.ToString().Contains(".mp3") || nextItem.ToString().Contains(".flac") ||
                                    nextItem.ToString().Contains(".ogg") || nextItem.ToString().Contains(".wav"))
                                {
                                    listBoxSongs.SelectedIndex = currentItem - 1;
                                    player.Ctlcontrols.play();
                                    label_name.Text = nextItem.ToString();
                                }
                                else
                                {
                                    MessageBox.Show("Bestand niet in ondersteund formaat!");
                                }

                            }
                            else
                            {
                                MessageBox.Show("Geen vorig bestand beschikbaar.");
                            }  
                    }

                }
                else
                {
                    MessageBox.Show("Het 'vorige' bestand bestaat niet.");
                }
            }
            catch (System.Windows.Forms.AxHost.InvalidActiveXStateException ex)
            {
                MessageBox.Show("InvalidActiveXStateException occurred: " + ex.Message);
            }
        }
    }
}
