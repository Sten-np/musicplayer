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

namespace musicplayer
{
    public partial class MusicPlayerApp : Form
    {
        private static string[] songs;
        private int count;
        private String path = @"";
        private String selectedSong = @"";

        //De constructor voor de class MusicPlayerApp. Met daarin de componenten die worden meteen ingeladen.
        // en de player.Hide() die ervoor zorgt dat de standaard media player niet zichtbaar is.
        public MusicPlayerApp()
        {
            InitializeComponent();
            player.Hide();
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

                string[] fileNames = Directory.GetFiles(this.path);
                this.count = fileNames.Count();
                label1.Text = this.count + " files loaded in.";
                foreach (string filePath in fileNames)
                {
                    string fileName = Path.GetFileName(filePath);
                    listBoxSongs.Items.Add(filePath);
                }
            }
            else
            {
                listBoxSongs.Items.Add("Directory does not exist!");
            }
        }

        private void btnSelectSong_Click(object sender, EventArgs e)
        {
            if(listBoxSongs.SelectedItem != null)
            {
                string selectedItem = listBoxSongs.SelectedItem.ToString();
                this.selectedSong = selectedItem;
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
                            player.Ctlcontrols.play();
                        }
                        else
                        {
                            MessageBox.Show("Bestand niet in ondersteund formaat!");
                        }
                        
                    }
                }
            }
            catch (System.Windows.Forms.AxHost.InvalidActiveXStateException ex)
            {
                MessageBox.Show("InvalidActiveXStateException occurred: " + ex.Message);
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

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            player.settings.setMode("loop", true);
        }

    }
}
