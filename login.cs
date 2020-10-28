using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Soviet_Windows
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private async void login_Load(object sender, EventArgs e)
        {
            SoundPlayer wlcm = new SoundPlayer(@"Assets\Audio\wlcm.wav");
            wlcm.Play();
            await Task.Delay(9001);

            application main = new application();
            main.Show();
            this.Hide();
        }
    }
}
