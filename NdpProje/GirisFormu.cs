/****************************************************************************
**					SAKARYA �N�VERS�TES�
**				B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
**				    B�LG�SAYAR M�HEND�SL��� B�L�M�
**				   NESNEYE DAYALI PROGRAMLAMA DERS�
**					2023-2024 BAHAR D�NEM�
**	
**				�DEV NUMARASI..........: PROJE �DEV�
**				��RENC� ADI............: AHMET G�RKEM YAVUZ
**				��RENC� NUMARASI.......: G231210032
**              DERS�N ALINDI�I GRUP...: 2. ��RET�M A GRUBU
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
                MessageBox.Show("L�tfen gerekli alanlar� doldurunuz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("�ifreler e�le�miyor. L�tfen ayn� �ifreyi girin!");
                    return;
                }

                Employee newEmployee = new Employee(nameBox.Text, lastnameBox.Text, Convert.ToInt32(ageBox.Text), usernameBox.Text, passwordBox.Text);

                using (StreamWriter sw = new StreamWriter(calisanlarDosyaYolu, true))
                {
                    sw.WriteLine($"{newEmployee.Name},{newEmployee.Lastname},{newEmployee.Age},{newEmployee.Username},{newEmployee.Password}");
                }
                MessageBox.Show("Ba�ar�yla kay�t olu�turdunuz!", "Kay�t Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usernameBox.Text = string.Empty;
                passwordBox.Text = string.Empty;
                passwordAgainBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("L�tfen gerekli alanlar� doldurunuz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void grsBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(calisanlarDosyaYolu))
            {
                MessageBox.Show("Personel kayd�n�z yok. L�tfen �nce bir kay�t olu�turun.", "Kay�t Bulunamad�", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Kullan�c� ad� veya �ifre hatal�!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("L�tfen gerekli alanlar� doldurunuz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Girilen karakterin bir harf veya kontrol karakteri (backspace, delete, vb.) olup olmad���n� kontrol et
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                // E�er girilen karakter bir harf veya kontrol karakteri de�ilse ve bo�luk de�ilse, i�lemi engelle
                e.Handled = true;
            }
        }

        private void lastnameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Girilen karakterin bir harf veya kontrol karakteri (backspace, delete, vb.) olup olmad���n� kontrol et
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                // E�er girilen karakter bir harf veya kontrol karakteri de�ilse ve bo�luk de�ilse, i�lemi engelle
                e.Handled = true;
            }
        }
        private void ageBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // E�er girilen karakter bir say� veya kontrol karakteri de�ilse, i�lemi engelle
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            // E�er girilen karakter bir say� ise, ya� de�erini kontrol et
            else if (char.IsDigit(e.KeyChar))
            {
                string newAge = ageBox.Text + e.KeyChar; // �u anki ya� de�eriyle girilen karakteri birle�tir
                if (!string.IsNullOrEmpty(newAge))
                {
                    int age;
                    if (int.TryParse(newAge, out age))
                    {
                        if (age > 100)
                        {
                            // E�er ya� de�eri 100'den b�y�kse, i�lemi engelle
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
                // �lk ismin ilk harfini b�y�k harfe d�n��t�r
                nameBox.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nameBox.Text.ToLower());
                nameBox.Select(nameBox.Text.Length, 0);
            }
        }

        private void lastnameBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameBox.Text))
            {
                // �lk ismin ilk harfini b�y�k harfe d�n��t�r
                lastnameBox.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lastnameBox.Text.ToLower());
                lastnameBox.Select(lastnameBox.Text.Length, 0);
            }
        }
    }
}
