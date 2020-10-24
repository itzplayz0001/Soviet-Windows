using System.Media;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using System;
using System.Threading.Tasks;

namespace Soviet_Windows
{
    public partial class boot : Form
    {
        public boot()
        {
            InitializeComponent();
        }

        private async void boot_Load(object sender, EventArgs e)
        {
            // LOAD
            black.Visible = true;
            errorMsg.Visible = false;
            SoundPlayer computerKreek = new SoundPlayer(@"Audio\fans.wav");
            computerKreek.Play();
            americanMegatrends.Visible = false;
            stalinsoftBoot.Visible = false;
            await Task.Delay(2500);
            americanMegatrends.Visible = true;
            await Task.Delay(4500);
            americanMegatrends.Visible = false;
            await Task.Delay(1001);
            stalinsoftBoot.Visible = true;
            await Task.Delay(2005);
            stalinsoftBoot.Visible = false;
            await Task.Delay(400);
            black.Visible = false;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            errorMsg.Visible = true;
            await Task.Delay(1050);

            // REDIRECTING TO WINDOWS XP LOGIN
            application main = new application();
            main.Show();
            this.Hide();
        }
    }
}
