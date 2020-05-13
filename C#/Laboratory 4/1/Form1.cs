using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA4
{
    public partial class Form1 : Form
    {
        private Mp3Player _mp3;
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlgOpen = new OpenFileDialog())
            {
                dlgOpen.Filter = "Mp3 File|*.mp3";
                dlgOpen.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                if (dlgOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    _mp3 = new Mp3Player(dlgOpen.FileName);
                    _mp3.Repeat = true;
                }
            }
        }
   

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (_mp3 != null)
                _mp3.Play();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (_mp3 != null)
                _mp3.Stop();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _mp3.SetVolume(trackBar1.Value);
        }
    }
}
