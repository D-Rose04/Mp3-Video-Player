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

namespace Reproductor
{
    public partial class Form1 : Form
    {
        private List<string> archivo, ruta;
        private OpenFileDialog OpenFileDialog;
        private FolderBrowserDialog folderBrowser;
        private bool pause;
        private bool playing;
        private int songidx;

        public Form1()
        {
            InitializeComponent();
            OpenFileDialog = new OpenFileDialog();
            folderBrowser = new FolderBrowserDialog();
            axWindowsMediaPlayer1.uiMode = "none";
            pause = false;
            playing = false;
        }

        private void carpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Playlist.Text = folderBrowser.SelectedPath;
            }
        }

        private void limipiarColaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lista_Reproduccion.Items.Clear();
        }

        private void Lista_Reproduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            songidx = Lista_Reproduccion.SelectedIndex;
            axWindowsMediaPlayer1.URL = ruta[songidx];
        }
        
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            songidx += 1;
            if (songidx <= ruta.Count - 1)
            {
                axWindowsMediaPlayer1.URL = ruta[songidx];
            }
            else
            {
                songidx = 0;
                axWindowsMediaPlayer1.URL = ruta[songidx];
            }
            axWindowsMediaPlayer1.Ctlcontrols.next();
            Lista_Reproduccion.SetSelected(songidx, true);
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            songidx -= 1;
            if (songidx >= 0)
            {
                axWindowsMediaPlayer1.URL = ruta[songidx];
            }
            else
            {
                songidx = ruta.Count - 1;
                axWindowsMediaPlayer1.URL = ruta[songidx];
            }
            axWindowsMediaPlayer1.Ctlcontrols.previous();
            Lista_Reproduccion.SetSelected(songidx, true);
        }

        private void PpButton_Click(object sender, EventArgs e)
        {
            if (pause)
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();
                pause = false;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                pause = true;
            }
        }

        private void seleccionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog.Multiselect = true;
            OpenFileDialog.InitialDirectory = Playlist.Text;
            OpenFileDialog.Filter = 
                "archivo MP3| *.mp3| archivo MP4| *.mp4| archivo AVI| *.avi| archivo FLAC| *.flac";
            
            if (OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                archivo = OpenFileDialog.SafeFileNames.ToList();
                ruta = OpenFileDialog.FileNames.ToList();
                foreach (var item in archivo)
                {
                    Lista_Reproduccion.Items.Add(item);
                }

                songidx = songidx == 0 ? songidx : 0 ;

                if (!playing)
                {
                    axWindowsMediaPlayer1.URL = ruta[songidx];
                    playing = true;
                    Lista_Reproduccion.SetSelected(songidx, true);
                }
                
            }
        }
    }
}
