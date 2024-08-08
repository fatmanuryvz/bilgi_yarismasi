using System.Security.Policy;
using System.Windows.Forms;

namespace bilgi_yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnA.Click += new EventHandler(timerStoppedEvent);
            btnB.Click += new EventHandler(timerStoppedEvent);
            btnC.Click += new EventHandler(timerStoppedEvent);
            btnD.Click += new EventHandler(timerStoppedEvent);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int soruno = 0, dogruno = 0, yanlisno = 0, puan = 0 ;
        private void btnsonraki_Click(object sender, EventArgs e)
        {
            

            timer1.Start();

                        
        
            //her sonraki soruya týkladýðýmýzda þýklar yeniden aktif olsun
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            soruno++;
            label4.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Türkiye'nin baþkenti?";
                btnA.Text = "izmir";
                btnB.Text = "ankara";
                btnC.Text = "istanbul";
                btnD.Text = "bursa";
                label1.Text = "ankara";

            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi þehir egede bulunmaz";
                btnA.Text = "izmir";
                btnB.Text = "aydýn";
                btnC.Text = "trabzon";
                btnD.Text = "manisa";
                label1.Text = "trabzon";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "türkiye'de kaç il var?";
                btnA.Text = "80";
                btnB.Text = "81";
                btnC.Text = "70";
                btnD.Text = "75";
                label1.Text = "81";

            }

            if (pictureBox2.Enabled == true)
            {
                label3.Text = puan.ToString();
                puan = dogruno * 5;
                label3.Text = puan.ToString();

            }
            if (soruno == 4)
            {
                richTextBox1.Text = "OYUN BÝTTÝ!" + " SKOR!: " + puan ;
                btnA.Visible = false;
                btnB.Visible = false;
                btnC.Visible = false;
                btnD .Visible = false;
                timer1.Stop();
                btnsonraki.Visible = false;

            }


            //label1 doðru cevap -  label2 bizim cevabýmýz!
        }

        private void btnA_Click(object sender, EventArgs e)

        {

            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label2.Text = btnA.Text;

            if (label1.Text == label2.Text)
            {
                dogruno++;
                label5.Text = dogruno.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlisno++;
                label6.Text = yanlisno.ToString();
                pictureBox1.Visible = true;
            }
            
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label2.Text = btnB.Text;

            if (label1.Text == label2.Text)
            {
                dogruno++;
                label5.Text = dogruno.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlisno++;
                label6.Text = yanlisno.ToString();
                pictureBox1.Visible = true;
            }
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label2.Text = btnC.Text;
            if (label1.Text == label2.Text)
            {
                dogruno++;
                label5.Text = dogruno.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlisno++;
                label6.Text = yanlisno.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)

        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;

            label2.Text = btnD.Text;
            if (label1.Text == label2.Text)
            {
                dogruno++;
                label5.Text = dogruno.ToString();
                pictureBox2.Visible = true;

            }
            else
            {
                yanlisno++;
                label6.Text = yanlisno.ToString();
                pictureBox1.Visible = true;
            }
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label7.Text =sayac.ToString();

            
            if(sayac == 50 )
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                timer1.Stop();
            }

        }

        private void timerStoppedEvent(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timerStartedEvent(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}

  

