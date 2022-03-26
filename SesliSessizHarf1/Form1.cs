namespace SesliSessizHarf1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbHarf.SelectedIndex = 0;
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            tbKelime.Text = "";
            cbHarf.SelectedIndex = 0;
            lSonuc.Text = "";
        }

        private void bGetir_Click(object sender, EventArgs e)
        {
            if (!ValideEt())
            {
                return;
            }

            SesliSessizHarfBul2();
        }

        void SesliSessizHarfBul1()
        {
            char[] sesliHarfler = new char[] { 'a', 'e', 'ý', 'i', 'o', 'ö', 'u', 'ü' };
            string sonuc = "";

            bool sesliKarakterMi;
            bool sessizKarakterMi;

            foreach (var kelimeKarakter in tbKelime.Text)
            {
                sesliKarakterMi = false;
                sessizKarakterMi = true;

                foreach (var sesliKarakter in sesliHarfler)
                {
                    if (cbHarf.SelectedIndex == 1)
                    {
                        if (kelimeKarakter.ToString().ToLower() == sesliKarakter.ToString())
                        {
                            sesliKarakterMi = true;
                            break;
                        }
                    }

                    else // 2: sessiz harf
                    {
                        if (kelimeKarakter.ToString().ToLower() == sesliKarakterMi.ToString())
                        {
                            sessizKarakterMi = false;
                            break;
                        }
                    }
                }

                if ((cbHarf.SelectedIndex == 1 && sesliKarakterMi) || (cbHarf.SelectedIndex == 2 && sessizKarakterMi))
                {
                    if (!sonuc.Contains(kelimeKarakter.ToString()))
                    {
                        sonuc += kelimeKarakter;
                    }
                }
            }

            if (sonuc.Equals(""))
            {
                lSonuc.Text = cbHarf.Text + " Bulunamadý.";
            }
            else
            {
                lSonuc.Text = sonuc;
            }
        }

        void SesliSessizHarfBul2() //2. algoritma
        {
            char[] sesliHarfler = { 'a', 'e', 'ý', 'i', 'o', 'ö', 'u', 'ü' };
            string sonuc = "";
            if (cbHarf.SelectedIndex == 1) //1: sesli harf
            {
                foreach (char kelimeKarakter in tbKelime.Text.ToLower())
                {
                    foreach (char sesliHarf in sesliHarfler)
                    {
                        if (kelimeKarakter == sesliHarf)
                        {
                            if (!sonuc.Contains(kelimeKarakter.ToString()))
                            {
                                sonuc += kelimeKarakter;
                            }
                            break;
                        }
                    }
                }
            }
            else // 2: sessiz harf
            {
                foreach (char kelimeKarakter in tbKelime.Text.ToLower())
                {
                    bool sessizKarakterMi = true;
                    foreach (char sesliHarf in sesliHarfler)
                    {
                        if (kelimeKarakter == sesliHarf)
                        {
                            sessizKarakterMi = false;
                            break;
                        }
                    }
                    if (sessizKarakterMi && !sonuc.Contains(kelimeKarakter.ToString()))
                    {
                        sonuc += kelimeKarakter;
                    }
                }
            }
            if (sonuc.Equals(""))
            {
                lSonuc.Text = cbHarf.Text + " Bulunamadý.";
            }
            else
            {
                lSonuc.Text = sonuc;
            }
        }

        bool ValideEt()
        {
            if (String.IsNullOrWhiteSpace(tbKelime.Text))
            {
                MessageBox.Show("Kelime boþ býrakýlamaz...", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (tbKelime.Text.Contains(" "))
            {
                MessageBox.Show("Boþluk kullanmayýnýz...", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (cbHarf.SelectedIndex == 0)
            {
                MessageBox.Show("Sesli veya sessiz harf seçiniz...", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}