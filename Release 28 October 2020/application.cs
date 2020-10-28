using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using System.CodeDom;

namespace Soviet_Windows
{
    public partial class application : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        public application()
        {
            InitializeComponent();
            player.SoundLocation = @"Assets/Audio/fans.wav";
        }

        private void application_Load(object sender, EventArgs e)
        {
            SoundPlayer wrror = new SoundPlayer(@"Assets\Audio\error.wav");
            wrror.Play();
            //player.Play();
            // Custom Cursor
            string cursorPath = @"Assets/cursor.png";
            Bitmap bmp = new Bitmap(new Bitmap(cursorPath), 16, 26);
            this.Cursor = new Cursor(bmp.GetHicon());

            // HIDING FUNCTIONS
            startMenu.Hide();
            hideStart.Hide();
            codeT.Hide();

            // LOADING WELCOME ERROR
            
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            startMenu.Show();
            hideStart.Show();
        }

        private void winxp_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void winxp_Paint(object sender, PaintEventArgs e)
        {
            //Console.WriteLine("Hey there!");
        }

        private void hideStart_Click(object sender, EventArgs e)
        {
            startMenu.Hide();
            hideStart.Hide();
        }

        private void icoTrash_Click(object sender, EventArgs e)
        {
            // Clicking Trash Icon
            SoundPlayer wrror = new SoundPlayer(@"Assets\Audio\error.wav");
            wrror.Play();
        }

        private void icoChrome_Click(object sender, EventArgs e)
        {
            // Click for Chrome
        }

        private void okSixnine_Click(object sender, EventArgs e)
        {
            SoundPlayer cliqq = new SoundPlayer(@"Assets\Audio\error.wav");
            cliqq.Play();
            wlcmErr.Hide();
        }

        private void mediaControl_Click(object sender, EventArgs e)
        {
            SoundPlayer dd = new SoundPlayer(@"Assets\Audio\error.wav");
            dd.Play();
            codeT.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            codeT.Hide();
        }
    }
}
