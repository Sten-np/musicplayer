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
using System.Runtime.CompilerServices;

namespace musicplayer
{
    public partial class MusicPlayerApp : Form
    {
        private string[] songs;
        private int count;
        private String path = @"";
        private String selectedSong = @"";
        private readonly Random random;


        //De constructor voor de class MusicPlayerApp. Met daarin de componenten die worden meteen ingeladen.
        // en de player.Hide() die ervoor zorgt dat de standaard media player niet zichtbaar is.
        public MusicPlayerApp()
        {
            InitializeComponent();
            trackVolume.Value = 50;
            labelVolume.Text = "50%";
            player.Hide();
            random = new Random();
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
            if (Directory.Exists(this.path)) // Als het gegeven pad bestaat, zet dan de inhoud van het pad in de property this.songs
            {
                listBoxSongs.Items.Clear();
                this.songs = Directory.GetFiles(this.path); // De inhoud wordt in een array gezet.
                this.songs.Append(this.path); // Concat het volledige pad aan het bestandnaam, voor de playback.

                foreach (string filePath in this.songs) // Loop alle array inhoudt door en zet het in de listbox.
                {
                    if (filePath.Contains(".mp3") || filePath.Contains(".ogg")
                        || filePath.Contains(".wav") || filePath.Contains(".flac"))
                    {
                        listBoxSongs.Items.Add(filePath);
                    }
                }
                this.count = listBoxSongs.Items.Count;
                label1.Text = this.count + " files loaded in.";
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
                getSongName(selectedItem);
            }
        }

        private void btnPlayPause_Click(object sender, EventArgs e)
        {
            try
            {
                if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    player.Ctlcontrols.pause();
                }
                else if (player.playState == WMPLib.WMPPlayState.wmppsPaused)
                {
                    player.Ctlcontrols.play();
                }
                else
                {
                    player.URL = this.selectedSong;
                    player.Ctlcontrols.play();
                }
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
                            getSongName(nextItem.ToString());
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
                int currentItem = listBoxSongs.SelectedIndex;

                if (currentItem < listBoxSongs.Items.Count - 1)
                {
                    object nextItem = listBoxSongs.Items[currentItem + 1];

                    if (nextItem != null)
                    {
                        if (nextItem.ToString().Contains(".mp3") || nextItem.ToString().Contains(".flac") ||
                            nextItem.ToString().Contains(".ogg") || nextItem.ToString().Contains(".wav"))
                        {
                            player.URL = nextItem.ToString();
                            listBoxSongs.SelectedIndex = currentItem + 1;
                            player.Ctlcontrols.play();
                            getSongName(nextItem.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Bestand niet in ondersteund formaat!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No more songs in the playlist.");
                    // You can add your logic here, such as stopping playback or handling end of playlist
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
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / p_bar.Width;
            }
            else
            {
                MessageBox.Show("Please select a song first.");
            }
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            player.settings.setMode("loop", true);
        }

        private void playlistAdd_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.ShowDialog();
                String file = fileDialog.FileName.ToString();
                this.songs.Append(file);
                if (file != null)
                {
                    songs = songs.Append(file).ToArray();
                    listBoxSongs.Items.Add(file);
                    this.count = listBoxSongs.Items.Count;
                    label1.Text = this.count + " files loaded in.";
                }
                else
                {
                    MessageBox.Show("No file got selected");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error in playlistAdd" + ex.Message);
            }
        }

        //playlist remove is de functie die zegt dat een nummer uit de lijst moet gaan
        private void playlistRemove_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedItem != null)
            {
                int selectedIndex = listBoxSongs.SelectedIndex;
                listBoxSongs.Items.RemoveAt(selectedIndex);
                songs = songs.Where((_, index) => index != selectedIndex).ToArray();
                count = listBoxSongs.Items.Count;
                label1.Text = count + " files loaded in.";
            }
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
                                    getSongName(nextItem.ToString());
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

        private void getSongName(String selectedItem)
        {
            string fileName = Path.GetFileNameWithoutExtension(selectedItem);
            label_name.Text = fileName;
        }

        private bool isDarkMode = false;

        private void Btn_darkmode_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;

            switch (isDarkMode)
            {
                case true:
                    BackColor = Color.SlateGray;
                    TopPanel.BackColor = Color.DarkGray;
                    listBoxSongs.BackColor = Color.DarkGray;
                    btnNext.BackColor = Color.DarkGray;
                    btnPlayPause.BackColor = Color.DarkGray;
                    btnPrevious.BackColor = Color.DarkGray;
                    btnStop.BackColor = Color.DarkGray;
                    btnRepeat.BackColor = Color.DarkGray;
                    btnShuffle.BackColor = Color.DarkGray;
                    btnSelectSong.BackColor = Color.DarkGray;
                    playlistAdd.BackColor = Color.DarkGray;
                    playlistRemove.BackColor = Color.DarkGray;
                break;

                case false:
                    BackColor = SystemColors.Control;
                    listBoxSongs.BackColor = SystemColors.Control;
                    TopPanel.BackColor = Color.LightCyan;
                    btnNext.BackColor = Color.OrangeRed;
                    btnPlayPause.BackColor = Color.OrangeRed;
                    btnPrevious.BackColor = Color.OrangeRed;
                    btnStop.BackColor = Color.OrangeRed;
                    btnRepeat.BackColor = Color.OrangeRed;
                    btnShuffle.BackColor= Color.OrangeRed;
                    btnSelectSong.BackColor = Color.OrangeRed;
                    playlistAdd.BackColor = Color.OrangeRed;
                    playlistRemove.BackColor = Color.OrangeRed;
                    break;
            }
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            ShuffleSongs();
        }
        private void ShuffleSongs()
        {
            // Randomly shuffle the songs array
            int n = songs.Length;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                string value = songs[k];
                songs[k] = songs[n];
                songs[n] = value;
            }
            listBoxSongs.Items.Clear();
            foreach (string filePath in songs)
            {
                if (filePath.Contains(".mp3") || filePath.Contains(".ogg")
                    || filePath.Contains(".wav") || filePath.Contains(".flac"))
                {
                    listBoxSongs.Items.Add(filePath);
                }
            }
            }
        }
}
