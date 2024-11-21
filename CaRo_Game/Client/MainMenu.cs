using Client.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace Client
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addUserControl(UserControl UC)
        {
            UC.Dock = DockStyle.Fill;
            ContainerPn.Controls.Clear();
            ContainerPn.Controls.Add(UC);
            UC.BringToFront();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            PlayScreen playScreen = new PlayScreen();
            addUserControl(playScreen);
            MenuPn.FillColor = Color.FromArgb(107, 203, 119);
        }

        private void OnlineBtn_Click(object sender, EventArgs e)
        {
            OnlineScreen onlineScreen = new OnlineScreen();
            addUserControl(onlineScreen);
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            AccountInfoScreen accountInfoScreen = new AccountInfoScreen();
            addUserControl(accountInfoScreen);
            MenuPn.FillColor = Color.Gray;
        }
    }
}
