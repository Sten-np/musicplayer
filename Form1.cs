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
        private String path = @"";
        private String selectedSong = @"";
        public MusicPlayerApp()
        {
            InitializeComponent();
            SetPath(@"C:\Users\\Sten\\Music\\");
            InsertIntoListBox();

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
            if (Directory.Exists(path))
            {

                string[] fileNames = Directory.GetFiles(path);

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
            catch (System.Windows.Forms.AxHost.InvalidActiveXStateException ex)
            {
                MessageBox.Show("InvalidActiveXStateException occurred: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
