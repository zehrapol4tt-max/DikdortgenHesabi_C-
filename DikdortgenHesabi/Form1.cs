namespace DikdortgenHesabi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kisa_kenar = txtKisa.Text;
            string uzun_kenar = txtUzun.Text;
            float uzun;
            float kisa;


            if (!float.TryParse(kisa_kenar, out kisa))
            {
                lblHata.Text = ("Lutfen gecerli bir sayi giriniz!");
            }
            else if (!float.TryParse(uzun_kenar, out uzun))
            {
                lblHata.Text = ("lutfen gecerli bir sayi giriniz!");
                return;
            }

            uzun = Convert.ToSingle(uzun_kenar);
            kisa = Convert.ToSingle(kisa_kenar);




            if (uzun < kisa)
            {
                lblHata.Text = ("kisa kenar, uzun kenardan buyuk olamaz!");
                return;
            }
            else
            {
                float alan = uzun * kisa;
                string sonuc = Convert.ToString(alan);
                lblSonuc.Text = sonuc;
            }
            panel1.Width = Convert.ToInt32(uzun);
            panel1.Height = Convert.ToInt32(kisa);
        }

        private void panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void lblHata_Click(object sender, EventArgs e)
        {

        }
    }
}
