using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicplayer
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
            track_volume.Value = 50;
            labelVolume.Text = "50%";
            
        }

        private void track_volume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = track_volume.Value;
            labelVolume.Text = track_volume.Value.ToString() + "%";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
