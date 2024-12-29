namespace _230408056
{
    public partial class anaSayfa : Form
    {
        public anaSayfa()
        {
            InitializeComponent();
        }
        private void richTextBox_cevap1_TextChanged(object sender, EventArgs e)
        {
            //Karakter say�s�n� g�nceller eder.
            label_karakter.Text = "Karakter say�s�: " + richTextBox_cevap1.Text.Length.ToString();

            //1000 den az olunca uyar� yazmas�.
            int ksayi = richTextBox_cevap1.TextLength;
            if (ksayi < 1000)
            {
                label_uyari.Text = "Karakter say�s� en az 1000 olmal�.";
            }
            else
            {
                label_uyari.Text = "";
            }
            //En fazla 5000 yazmas�n� sa�l�yor.
            richTextBox_cevap1.MaxLength = 5000;
        }

        //panelleri kapat�p a�ma bide timer ba�latma
        private void btn_Test1_Click(object sender, EventArgs e)
        {
            panel_c1.Visible = true;
            panel_c2.Visible = false;
            panel_c3.Visible = false;
            panel_c4.Visible = false;
            panel_c5.Visible = false;

            panel_s1.Visible = true;
            panel_s2.Visible = false;
            panel_s3.Visible = false;
            panel_s4.Visible = false;
            panel_s5.Visible = false;

            timer_s1.Enabled = true;
        }

        private void btn_Test2_Click(object sender, EventArgs e)
        {
            panel_c1.Visible = false;
            panel_c2.Visible = true;
            panel_c3.Visible = false;
            panel_c4.Visible = false;
            panel_c5.Visible = false;

            panel_s1.Visible = false;
            panel_s2.Visible = true;
            panel_s3.Visible = false;
            panel_s4.Visible = false;
            panel_s5.Visible = false;

            timer_s2.Enabled = true;
        }

        private void btn_Test3_Click(object sender, EventArgs e)
        {
            panel_c1.Visible = false;
            panel_c2.Visible = false;
            panel_c3.Visible = true;
            panel_c4.Visible = false;
            panel_c5.Visible = false;

            panel_s1.Visible = false;
            panel_s2.Visible = false;
            panel_s3.Visible = true;
            panel_s4.Visible = false;
            panel_s5.Visible = false;

            timer_s3.Enabled = true;
        }

        private void btn_Test4_Click(object sender, EventArgs e)
        {
            panel_c1.Visible = false;
            panel_c2.Visible = false;
            panel_c3.Visible = false;
            panel_c4.Visible = true;
            panel_c5.Visible = false;

            panel_s1.Visible = false;
            panel_s2.Visible = false;
            panel_s3.Visible = false;
            panel_s4.Visible = true;
            panel_s5.Visible = false;

            timer_s4.Enabled = true;
        }

        private void btn_Test5_Click(object sender, EventArgs e)
        {
            panel_c1.Visible = false;
            panel_c2.Visible = false;
            panel_c3.Visible = false;
            panel_c4.Visible = false;
            panel_c5.Visible = true;

            panel_s1.Visible = false;
            panel_s2.Visible = false;
            panel_s3.Visible = false;
            panel_s4.Visible = false;
            panel_s5.Visible = true;

            timer_s5.Enabled = true;
        }

        
        //Timer k�rm�z� ye�il olay �eysi
        private void timer_s1_Tick(object sender, EventArgs e) //Birinci soru do�ru cevap B
        {
            if (rb_1_B.Checked == true)
            {
                btn_Test1.ForeColor = Color.Green;
            }
            else
            {
                btn_Test1.ForeColor = Color.Red;
            }
        }

        private void timer_s2_Tick(object sender, EventArgs e) //�kinci soru do�ru cevap C
        {
            if (rb_2_C.Checked == true)
            {
                btn_Test2.ForeColor = Color.Green;
            }
            else
            {
                btn_Test2.ForeColor = Color.Red;
            }
        }

        private void timer_s3_Tick(object sender, EventArgs e) //����nc� soru do�ru cevap B
        {
            if(rb_3_B.Checked == true)
            {
                btn_Test3.ForeColor = Color.Green;
            }
            else
            {
                btn_Test3.ForeColor = Color.Red;
            }
        }

        private void timer_s4_Tick(object sender, EventArgs e) //D�rd�nc� soru do�ru cevap B
        {
            if (rb_4_B.Checked == true)
            {
                btn_Test4.ForeColor = Color.Green;
            }
            else
            {
                btn_Test4.ForeColor = Color.Red;
            }
        }

        private void timer_s5_Tick(object sender, EventArgs e) //Be�inci soru do�ru cevap A
        {
            if (rb_5_A.Checked == true)
            {
                btn_Test5.ForeColor = Color.Green;
            }
            else
            {
                btn_Test5.ForeColor = Color.Red;
            }
        }
    }
}
