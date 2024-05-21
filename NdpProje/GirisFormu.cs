/****************************************************************************
**					SAKARYA ÜNÝVERSÝTESÝ
**				BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ
**				    BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSÝ
**					2023-2024 BAHAR DÖNEMÝ
**	
**				ÖDEV NUMARASI..........: PROJE ÖDEVÝ
**				ÖÐRENCÝ ADI............: AHMET GÖRKEM YAVUZ
**				ÖÐRENCÝ NUMARASI.......: G231210032
**              DERSÝN ALINDIÐI GRUP...: 2. ÖÐRETÝM A GRUBU
****************************************************************************/

using System.Globalization;

namespace NdpProje
{
    public partial class GirisFormu : Form
    {
        private string calisanlarDosyaYolu = "employees.txt";

        public GirisFormu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nameLabel.Visible = false;
            nameBox.Visible = false;
            lastnameLabel.Visible = false;
            lastnameBox.Visible = false;
            ageLabel.Visible = false;
            ageBox.Visible = false;

            usernameLabel.Visible = false;
            usernameBox.Visible = false;
            passwordLabel.Visible = false;
            passwordBox.Visible = false;
            passwordAgainLabel.Visible = false;
            passwordAgainBox.Visible = false;

            continueBtn.Visible = false;
            grsBtn.Visible = false;
            kytBtn.Visible = false;
        }

        private void grsRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (grsRdBtn.Checked)
            {
                nameLabel.Visible = false;
                nameBox.Visible = false;
                nameBox.Text = string.Empty;
                lastnameLabel.Visible = false;
                lastnameBox.Visible = false;
                lastnameBox.Text = string.Empty;
                ageLabel.Visible = false;
                ageBox.Visible = false;
                ageBox.Text = string.Empty;

                usernameLabel.Visible = true;
                usernameBox.Visible = true;
                usernameBox.Text = string.Empty;
                passwordLabel.Visible = true;
                passwordBox.Visible = true;
                passwordBox.Text = string.Empty;
                passwordAgainLabel.Visible = false;
                passwordAgainBox.Visible = false;
                passwordAgainBox.Text = string.Empty;

                continueBtn.Visible = false;
                grsBtn.Visible = true;
                kytBtn.Visible = false;
            }
        }
        private void kytRdBtn_CheckedChanged(object sender, EventArgs e)
        {
            nameLabel.Visible = true;
            nameBox.Visible = true;
            nameBox.Text = string.Empty;
            lastnameLabel.Visible = true;
            lastnameBox.Visible = true;
            lastnameBox.Text = string.Empty;
            ageLabel.Visible = true;
            ageBox.Visible = true;
            ageBox.Text = string.Empty;

            usernameLabel.Visible = false;
            usernameBox.Visible = false;
            usernameBox.Text = string.Empty;
            passwordLabel.Visible = false;
            passwordBox.Visible = false;
            passwordBox.Text = string.Empty;
            passwordAgainLabel.Visible = false;
            passwordAgainBox.Visible = false;
            passwordAgainBox.Text = string.Empty;

            continueBtn.Visible = true;
            grsBtn.Visible = false;
            kytBtn.Visible = false;
        }
        private void continueBtn_Click(object sender, EventArgs e)
        {
            if (nameBox.Text != string.Empty &&
                lastnameBox.Text != string.Empty &&
                ageBox.Text != string.Empty)
            {
                nameLabel.Visible = false;
                nameBox.Visible = false;
                lastnameLabel.Visible = false;
                lastnameBox.Visible = false;
                ageLabel.Visible = false;
                ageBox.Visible = false;

                usernameLabel.Visible = true;
                usernameBox.Visible = true;
                passwordLabel.Visible = true;
                passwordBox.Visible = true;
                passwordAgainLabel.Visible = true;
                passwordAgainBox.Visible = true;

                continueBtn.Visible = false;
                grsBtn.Visible = false;
                kytBtn.Visible = true;
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanlarý doldurunuz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void kytBtn_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text != string.Empty &&
                passwordBox.Text != string.Empty &&
                passwordAgainBox.Text != string.Empty)
            {
                if (passwordBox.Text != passwordAgainBox.Text)
                {
                    MessageBox.Show("Þifreler eþleþmiyor. Lütfen ayný þifreyi girin!");
                    return;
                }

                Employee newEmployee = new Employee(nameBox.Text, lastnameBox.Text, Convert.ToInt32(ageBox.Text), usernameBox.Text, passwordBox.Text);

                using (StreamWriter sw = new StreamWriter(calisanlarDosyaYolu, true))
                {
                    sw.WriteLine($"{newEmployee.Name},{newEmployee.Lastname},{newEmployee.Age},{newEmployee.Username},{newEmployee.Password}");
                }
                MessageBox.Show("Baþarýyla kayýt oluþturdunuz!", "Kayýt Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usernameBox.Text = string.Empty;
                passwordBox.Text = string.Empty;
                passwordAgainBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanlarý doldurunuz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grsBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(calisanlarDosyaYolu))
            {
                MessageBox.Show("Personel kaydýnýz yok. Lütfen önce bir kayýt oluþturun.", "Kayýt Bulunamadý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (usernameBox.Text != string.Empty && passwordBox.Text != string.Empty)
            {
                using (StreamReader sr = new StreamReader(calisanlarDosyaYolu))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] informations = line.Split(',');
                        if (informations[3] == usernameBox.Text && informations[4] == passwordBox.Text)
                        {
                            GenelForm genelForm = new GenelForm();
                            this.Hide();
                            genelForm.FormClosed += (sender, e) => this.Close();
                            genelForm.Show();
                            return;
                        }
                    }
                }
                MessageBox.Show("Kullanýcý adý veya þifre hatalý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanlarý doldurunuz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void passwordBox_TextChanged(object sender, EventArgs e)
        {
            passwordBox.PasswordChar = '*';
        }
        private void passwordAgainBox_TextChanged(object sender, EventArgs e)
        {
            passwordAgainBox.PasswordChar = '*';
        }

        private void nameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Girilen karakterin bir harf veya kontrol karakteri (backspace, delete, vb.) olup olmadýðýný kontrol et
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                // Eðer girilen karakter bir harf veya kontrol karakteri deðilse ve boþluk deðilse, iþlemi engelle
                e.Handled = true;
            }
        }

        private void lastnameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Girilen karakterin bir harf veya kontrol karakteri (backspace, delete, vb.) olup olmadýðýný kontrol et
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                // Eðer girilen karakter bir harf veya kontrol karakteri deðilse ve boþluk deðilse, iþlemi engelle
                e.Handled = true;
            }
        }
        private void ageBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eðer girilen karakter bir sayý veya kontrol karakteri deðilse, iþlemi engelle
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            // Eðer girilen karakter bir sayý ise, yaþ deðerini kontrol et
            else if (char.IsDigit(e.KeyChar))
            {
                string newAge = ageBox.Text + e.KeyChar; // Þu anki yaþ deðeriyle girilen karakteri birleþtir
                if (!string.IsNullOrEmpty(newAge))
                {
                    int age;
                    if (int.TryParse(newAge, out age))
                    {
                        if (age > 100)
                        {
                            // Eðer yaþ deðeri 100'den büyükse, iþlemi engelle
                            e.Handled = true;
                        }
                    }
                }
            }
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameBox.Text))
            {
                // Ýlk ismin ilk harfini büyük harfe dönüþtür
                nameBox.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nameBox.Text.ToLower());
                nameBox.Select(nameBox.Text.Length, 0);
            }
        }

        private void lastnameBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameBox.Text))
            {
                // Ýlk ismin ilk harfini büyük harfe dönüþtür
                lastnameBox.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lastnameBox.Text.ToLower());
                lastnameBox.Select(lastnameBox.Text.Length, 0);
            }
        }
    }
}
