//24.11.23 
using System;

namespace C____Sinema_Büfe_Satış_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public int siparisno, toplambilet, toplammisir, toplamicecek, toplamcikolata, toplamcips, biletadet, misiradet, icecekadet, cikolataadet, cipsadet = 0;
        public double biletfiyat, misirfiyat, icecekfiyat, cikolatafiyat, cipsfiyat, toplam, kasa, genelkasa= 0;

        public void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            if (textBox1.Text.Length == 0) { MessageBox.Show("Lütfen bilet sayısı giriniz.", "Uyarı"); }
            else if (Convert.ToInt16(textBox1.Text) < 1) { MessageBox.Show("Bilet sayısı en az 1 olmalıdır.", "Uyarı"); }
            else if (textBox2.Text.Length == 0) { MessageBox.Show("Lütfen mısır sayısı giriniz.", "Uyarı"); }
            else if (textBox3.Text.Length == 0) { MessageBox.Show("Lütfen içecek sayısı giriniz.", "Uyarı"); }
            else if (textBox4.Text.Length == 0) { MessageBox.Show("Lütfen çikolata sayısı giriniz.", "Uyarı"); }
            else if (textBox2.Text.Length == 0) { MessageBox.Show("Lütfen cips sayısı giriniz.", "Uyarı"); }
            else
            {
                biletadet = Convert.ToInt32(textBox1.Text);
                misiradet = Convert.ToInt32(textBox2.Text);
                icecekadet = Convert.ToInt32(textBox3.Text);
                cikolataadet = Convert.ToInt32(textBox4.Text);
                cipsadet = Convert.ToInt32(textBox5.Text);

                biletfiyat = biletadet * 25;
                misirfiyat = misiradet * 12.5;
                icecekfiyat = icecekadet * 10;
                cikolatafiyat = cikolataadet * 3.5;
                cipsfiyat = cipsadet * 5;


                label23.Text = Convert.ToString(biletfiyat) + ",00 TL";

                if (misiradet >= 1)
                {
                    if (misiradet % 2 == 0) label24.Text = Convert.ToString(misirfiyat) + ",00 TL";
                    else label24.Text = Convert.ToString(misirfiyat) + "0 TL";
                }
                else
                {
                    if (misiradet % 2 == 0) label24.Text = "0" + Convert.ToString(misirfiyat) + ",00 TL";
                    else label24.Text = "0" + Convert.ToString(misirfiyat) + "0 TL";
                }

                if (icecekadet >= 1)
                {
                    label25.Text = Convert.ToString(icecekfiyat) + ",00 TL";
                }
                else
                {
                    label25.Text = "0" + Convert.ToString(icecekfiyat) + ",00 TL";
                }

                if (cikolataadet > 2)
                {
                    if (cikolataadet % 2 == 0) label26.Text = Convert.ToString(cikolatafiyat) + ",00 TL";
                    else label26.Text = Convert.ToString(cikolatafiyat) + "0 TL";
                }
                else
                {
                    if (cikolataadet % 2 == 0) label26.Text = "0" + Convert.ToString(cikolatafiyat) + ",00 TL";
                    else label26.Text = "0" + Convert.ToString(cikolatafiyat) + "0 TL";
                }

                if (cipsadet > 1)
                {
                    if (cipsadet % 2 == 0) label27.Text = Convert.ToString(cipsfiyat) + ",00 TL";
                    else label27.Text = Convert.ToString(cipsfiyat) + ",00 TL";
                }
                else
                {
                    if (cipsadet % 2 == 0) label27.Text = "0" + Convert.ToString(cipsfiyat) + ",00 TL";
                    else label27.Text = "0" + Convert.ToString(cipsfiyat) + ",00 TL";
                }


                toplam = biletfiyat + misirfiyat + icecekfiyat + cikolatafiyat + cipsfiyat;
                if (toplam % 1 == 0) label30.Text = Convert.ToString(toplam) + ",00 TL";
                else label30.Text = Convert.ToString(toplam) + "0 TL";


                label18.Text = Convert.ToString(biletadet);
                label19.Text = Convert.ToString(misiradet);
                label20.Text = Convert.ToString(icecekadet);
                label21.Text = Convert.ToString(cikolataadet);
                label22.Text = Convert.ToString(cipsadet);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            siparisno++;
            kasa += toplam;
            button4.Enabled = true;
            MessageBox.Show("Sipariş alındı.Sipariş numarası: " + siparisno + ".\n\nSipariş içeriği:\n\n" + biletadet + " Bilet: " + biletfiyat + " TL\n" + misiradet + " Mısır: " + misirfiyat + " TL\n" + icecekadet + " İçecek: " + icecekfiyat + " TL\n" + cikolataadet + " Çikolata: " + cikolatafiyat + " TL\n" + cipsadet + " Cips: " + cipsfiyat + " TL\n\nTOPLAM: " + toplam + " TL");
            button2.Enabled = false;
            toplambilet += biletadet;
            toplammisir += misiradet;
            toplamicecek += icecekadet;
            toplamcikolata += cikolataadet;
            toplamcips += cipsadet;
            toplam = 0;
            biletfiyat = 0;
            biletadet = 0;
            misirfiyat = 0;
            misiradet = 0;
            icecekfiyat = 0;
            icecekadet = 0;
            cikolatafiyat = 0;
            cikolataadet = 0;
            cipsfiyat = 0;
            cipsadet = 0;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            label18.Text = Convert.ToString(biletadet);
            label19.Text = Convert.ToString(misiradet);
            label20.Text = Convert.ToString(icecekadet);
            label21.Text = Convert.ToString(cikolataadet);
            label22.Text = Convert.ToString(cipsadet);
            label23.Text = "00.00 TL";
            label24.Text = "00.00 TL";
            label25.Text = "00.00 TL";
            label26.Text = "00.00 TL";
            label27.Text = "00.00 TL";
            label30.Text = "00.00 TL";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            biletfiyat = 0;
            biletadet = 0;
            misirfiyat = 0;
            misiradet = 0;
            icecekfiyat = 0;
            icecekadet = 0;
            cikolatafiyat = 0;
            cikolataadet = 0;
            cipsfiyat = 0;
            cipsadet = 0;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            label18.Text = Convert.ToString(biletadet);
            label19.Text = Convert.ToString(misiradet);
            label20.Text = Convert.ToString(icecekadet);
            label21.Text = Convert.ToString(cikolataadet);
            label22.Text = Convert.ToString(cipsadet);
            label23.Text = "00.00 TL";
            label24.Text = "00.00 TL";
            label25.Text = "00.00 TL";
            label26.Text = "00.00 TL";
            label27.Text = "00.00 TL";
            label30.Text = "00.00 TL";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            genelkasa += kasa;
            MessageBox.Show("GÜNSONU\n\nGünsonu kazanç: " + kasa + "\n\nSatılan bilet: " + toplambilet + "\nSatılan mısır: " + toplammisir + "\nSatılan içecek: " + toplamicecek + "\nSatılan çikolata: " + toplamcikolata + "\nSatılan cips: " + toplamcips+"\n\nTOPLAM PARA: "+genelkasa);
            biletfiyat = 0;
            biletadet = 0;
            misirfiyat = 0;
            misiradet = 0;
            icecekfiyat = 0;
            icecekadet = 0;
            cikolatafiyat = 0;
            cikolataadet = 0;
            cipsfiyat = 0;
            cipsadet = 0;
            toplam = 0;
            siparisno = 0;
            toplambilet = 0;
            toplammisir = 0;
            toplamicecek = 0;
            toplamcikolata = 0;
            toplamcips = 0;
            kasa = 0;
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            label18.Text = Convert.ToString(biletadet);
            label19.Text = Convert.ToString(misiradet);
            label20.Text = Convert.ToString(icecekadet);
            label21.Text = Convert.ToString(cikolataadet);
            label22.Text = Convert.ToString(cipsadet);
            label23.Text = "00.00 TL";
            label24.Text = "00.00 TL";
            label25.Text = "00.00 TL";
            label26.Text = "00.00 TL";
            label27.Text = "00.00 TL";
            label30.Text = "00.00 TL";
            button4.Enabled = false;
        }
    }
}