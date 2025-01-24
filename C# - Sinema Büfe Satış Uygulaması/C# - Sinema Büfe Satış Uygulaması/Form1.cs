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
            btnOnay.Enabled = true;
            if (txtBilet.Text.Length == 0) { MessageBox.Show("Lütfen bilet sayısı giriniz.", "Uyarı"); }
            else if (Convert.ToInt16(txtBilet.Text) < 1) { MessageBox.Show("Bilet sayısı en az 1 olmalıdır.", "Uyarı"); }
            else if (txtMisir.Text.Length == 0) { MessageBox.Show("Lütfen mısır sayısı giriniz.", "Uyarı"); }
            else if (txtIcecek.Text.Length == 0) { MessageBox.Show("Lütfen içecek sayısı giriniz.", "Uyarı"); }
            else if (txtCikolata.Text.Length == 0) { MessageBox.Show("Lütfen çikolata sayısı giriniz.", "Uyarı"); }
            else if (txtMisir.Text.Length == 0) { MessageBox.Show("Lütfen cips sayısı giriniz.", "Uyarı"); }
            else
            {
                biletadet = Convert.ToInt32(txtBilet.Text);
                misiradet = Convert.ToInt32(txtMisir.Text);
                icecekadet = Convert.ToInt32(txtIcecek.Text);
                cikolataadet = Convert.ToInt32(txtCikolata.Text);
                cipsadet = Convert.ToInt32(txtCips.Text);

                biletfiyat = biletadet * 25;
                misirfiyat = misiradet * 12.5;
                icecekfiyat = icecekadet * 10;
                cikolatafiyat = cikolataadet * 3.5;
                cipsfiyat = cipsadet * 5;


                lblBiletUcret.Text = Convert.ToString(biletfiyat) + ",00 TL";

                if (misiradet >= 1)
                {
                    if (misiradet % 2 == 0) lblMisirUcret.Text = Convert.ToString(misirfiyat) + ",00 TL";
                    else lblMisirUcret.Text = Convert.ToString(misirfiyat) + "0 TL";
                }
                else
                {
                    if (misiradet % 2 == 0) lblMisirUcret.Text = "0" + Convert.ToString(misirfiyat) + ",00 TL";
                    else lblMisirUcret.Text = "0" + Convert.ToString(misirfiyat) + "0 TL";
                }

                if (icecekadet >= 1)
                {
                    lblIcecekUcret.Text = Convert.ToString(icecekfiyat) + ",00 TL";
                }
                else
                {
                    lblIcecekUcret.Text = "0" + Convert.ToString(icecekfiyat) + ",00 TL";
                }

                if (cikolataadet > 2)
                {
                    if (cikolataadet % 2 == 0) lblCikolataUcret.Text = Convert.ToString(cikolatafiyat) + ",00 TL";
                    else lblCikolataUcret.Text = Convert.ToString(cikolatafiyat) + "0 TL";
                }
                else
                {
                    if (cikolataadet % 2 == 0) lblCikolataUcret.Text = "0" + Convert.ToString(cikolatafiyat) + ",00 TL";
                    else lblCikolataUcret.Text = "0" + Convert.ToString(cikolatafiyat) + "0 TL";
                }

                if (cipsadet > 1)
                {
                    if (cipsadet % 2 == 0) lblCipsUcret.Text = Convert.ToString(cipsfiyat) + ",00 TL";
                    else lblCipsUcret.Text = Convert.ToString(cipsfiyat) + ",00 TL";
                }
                else
                {
                    if (cipsadet % 2 == 0) lblCipsUcret.Text = "0" + Convert.ToString(cipsfiyat) + ",00 TL";
                    else lblCipsUcret.Text = "0" + Convert.ToString(cipsfiyat) + ",00 TL";
                }


                toplam = biletfiyat + misirfiyat + icecekfiyat + cikolatafiyat + cipsfiyat;
                if (toplam % 1 == 0) lblToplamFiyat.Text = Convert.ToString(toplam) + ",00 TL";
                else lblToplamFiyat.Text = Convert.ToString(toplam) + "0 TL";


                lblBiletAdet.Text = Convert.ToString(biletadet);
                lblMisirAdet.Text = Convert.ToString(misiradet);
                lblIcecekAdet.Text = Convert.ToString(icecekadet);
                lblCikolataAdet.Text = Convert.ToString(cikolataadet);
                lblCipsAdet.Text = Convert.ToString(cipsadet);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            siparisno++;
            kasa += toplam;
            btnGunsonu.Enabled = true;
            MessageBox.Show("Sipariş alındı.Sipariş numarası: " + siparisno + ".\n\nSipariş içeriği:\n\n" + biletadet + " Bilet: " + biletfiyat + " TL\n" + misiradet + " Mısır: " + misirfiyat + " TL\n" + icecekadet + " İçecek: " + icecekfiyat + " TL\n" + cikolataadet + " Çikolata: " + cikolatafiyat + " TL\n" + cipsadet + " Cips: " + cipsfiyat + " TL\n\nTOPLAM: " + toplam + " TL");
            btnOnay.Enabled = false;
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
            txtBilet.Text = string.Empty;
            txtMisir.Text = string.Empty;
            txtIcecek.Text = string.Empty;
            txtCikolata.Text = string.Empty;
            txtCips.Text = string.Empty;
            lblBiletAdet.Text = Convert.ToString(biletadet);
            lblMisirAdet.Text = Convert.ToString(misiradet);
            lblIcecekAdet.Text = Convert.ToString(icecekadet);
            lblCikolataAdet.Text = Convert.ToString(cikolataadet);
            lblCipsAdet.Text = Convert.ToString(cipsadet);
            lblBiletUcret.Text = "00.00 TL";
            lblMisirUcret.Text = "00.00 TL";
            lblIcecekUcret.Text = "00.00 TL";
            lblCikolataUcret.Text = "00.00 TL";
            lblCipsUcret.Text = "00.00 TL";
            lblToplamFiyat.Text = "00.00 TL";
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
            btnOnay.Enabled = false;
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
            txtBilet.Text = string.Empty;
            txtMisir.Text = string.Empty;
            txtIcecek.Text = string.Empty;
            txtCikolata.Text = string.Empty;
            txtCips.Text = string.Empty;
            lblBiletAdet.Text = Convert.ToString(biletadet);
            lblMisirAdet.Text = Convert.ToString(misiradet);
            lblIcecekAdet.Text = Convert.ToString(icecekadet);
            lblCikolataAdet.Text = Convert.ToString(cikolataadet);
            lblCipsAdet.Text = Convert.ToString(cipsadet);
            lblBiletUcret.Text = "00.00 TL";
            lblMisirUcret.Text = "00.00 TL";
            lblIcecekUcret.Text = "00.00 TL";
            lblCikolataUcret.Text = "00.00 TL";
            lblCipsUcret.Text = "00.00 TL";
            lblToplamFiyat.Text = "00.00 TL";
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
            txtBilet.Text = string.Empty;
            txtMisir.Text = string.Empty;
            txtIcecek.Text = string.Empty;
            txtCikolata.Text = string.Empty;
            txtCips.Text = string.Empty;
            lblBiletAdet.Text = Convert.ToString(biletadet);
            lblMisirAdet.Text = Convert.ToString(misiradet);
            lblIcecekAdet.Text = Convert.ToString(icecekadet);
            lblCikolataAdet.Text = Convert.ToString(cikolataadet);
            lblCipsAdet.Text = Convert.ToString(cipsadet);
            lblBiletUcret.Text = "00.00 TL";
            lblMisirUcret.Text = "00.00 TL";
            lblIcecekUcret.Text = "00.00 TL";
            lblCikolataUcret.Text = "00.00 TL";
            lblCipsUcret.Text = "00.00 TL";
            lblToplamFiyat.Text = "00.00 TL";
            btnGunsonu.Enabled = false;
        }
    }
}