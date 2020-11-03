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
            // TANK ANIMATION
            tTwo.Hide();
            tThree.Hide();
            tFour.Hide();
            tFive.Hide();
            tZero.Hide();

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
            computerKreek.Stop();
            // tanks <-----
            SoundPlayer prelog = new SoundPlayer(@"Assets\Audio\prelogin.wav");
            prelog.Play();
            //await Task.Delay(1200);
            tOne.Hide();
            tTwo.Show();
            await Task.Delay(1200);
            tTwo.Hide();
            tThree.Show();
            await Task.Delay(1200);
            tThree.Hide();
            tFour.Show();
            await Task.Delay(1200);
            tFour.Hide();
            tFive.Show();
            await Task.Delay(1200);
            tFive.Hide();

            tZero.Show();
            await Task.Delay(1200);
            tZero.Hide();
            tOne.Hide();
            tTwo.Show();
            await Task.Delay(1200);
            tTwo.Hide();
            tThree.Show();
            await Task.Delay(1200);
            tThree.Hide();
            tFour.Show();
            await Task.Delay(1200);
            tFour.Hide();
            tFive.Show();
            // Tamk Animation, you can just copy paste to make the animatin longer
            await Task.Delay(1200);

            stalinsoftBoot.Visible = false;
            await Task.Delay(400);
            black.Visible = false;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            errorMsg.Visible = true;
            await Task.Delay(1050);

            // REDIRECTING TO WINDOWS XP LOGIN 
            login loginPage = new login();
            loginPage.Show();
            this.Hide();
        }

        private void stalinsoftBoot_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
