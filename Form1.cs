using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SpeedGameLauncher
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private async void Play_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"SpeedGame.exe");
            await Task.Run(() =>
            Application.Exit());
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void PlayDX11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"SpeedGame.exe", "-dx11");
            await Task.Run(() =>
            Application.Exit());
        }

        private async void PlayRegen_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"SpeedGame.exe", "-regenerateinis");
            await Task.Run(() =>
            Application.Exit());
        }
    }
}
