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

        private async void PlayDX12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project Speed 2 is not performance friendly when using DirectX12! It is recommended to play the game using the default DirectX11 renderer!");
            await Task.Run(() =>
            System.Diagnostics.Process.Start(@"SpeedGame.exe", "-dx12"));
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
