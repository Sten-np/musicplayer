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
                string fileType = "*.mp3";
                string[] fileNames = Directory.GetFiles(path, fileType);

                foreach (string filePath in fileNames)
                {
                    string fileName = Path.GetFileName(filePath);
                    listBoxSongs.Items.Add(fileName);
                }
            }
            else
            {
                listBoxSongs.Items.Add("Directory does not exist!");
            }
        }
    }
}
