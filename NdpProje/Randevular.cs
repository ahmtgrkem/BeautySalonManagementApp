/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: PROJE ÖDEVİ
**				ÖĞRENCİ ADI............: AHMET GÖRKEM YAVUZ
**				ÖĞRENCİ NUMARASI.......: G231210032
**              DERSİN ALINDIĞI GRUP...: 2. ÖĞRETİM A GRUBU
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NdpProje
{
    public partial class Randevular : Form
    {
        private const string randevularDosyaYolu = "appointment.txt";
        private const string IslemlerDosyaYolu = "services.txt";

        public Randevular()
        {
            InitializeComponent();
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            GenelForm genelForm = new GenelForm();
            this.Hide();
            genelForm.FormClosed += (sender, e) => this.Close();
            genelForm.Show();
            return;
        }
        private void Randevular_Load(object sender, EventArgs e)
        {
            RandevulariGoster();
            ComboBoxuGuncelle();
        }

        private void RandevulariGoster()
        {
            listBox1.Items.Clear();

            // randevular.txt dosyasından randevu bilgilerini oku ve ListBox'a ekle
            if (File.Exists(randevularDosyaYolu))
            {
                using (StreamReader sr = new StreamReader(randevularDosyaYolu))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line);
                    }
                }
            }
            else
            {
                listBox1.Items.Add("Randevu bulunamadı.");
            }

        }

        private void ComboBoxuGuncelle()
        {
            comboBox1.Items.Clear();

            // services.txt dosyasından hizmet bilgilerini oku ve ComboBox'a ekle
            if (File.Exists(IslemlerDosyaYolu))
            {
                using (StreamReader sr = new StreamReader(IslemlerDosyaYolu))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Her bir satırı ayır ve sadece hizmet adını ComboBox'a ekle
                        string[] parts = line.Split(',');
                        if (parts.Length == 2)
                        {
                            string serviceName = parts[0];
                            comboBox1.Items.Add(serviceName);
                        }
                    }
                }
            }
            else
            {
                comboBox1.Items.Add("İşlem bulunamadı.");
            }
        }

        private void randevuVerBtn_Click(object sender, EventArgs e)
        {
            // Giriş kontrollerini kontrol et
            if (dateTimePicker1.Value == DateTime.MinValue || // Tarih seçilmedi
                maskedTextBox1.Text == "" || // Saat girilmedi
                customerNameBox.Text == "" || // Müşteri adı girilmedi
                customerLastnameBox.Text == "" || // Müşteri soyadı girilmedi
                numericUpDown1.Value == 0 || // Miktar sıfır
                maskedTextBox2.Text == "" || // Telefon numarası girilmedi
                comboBox1.SelectedIndex == -1) // Hizmet seçilmedi
            {
                MessageBox.Show("Lütfen tüm giriş kontrollerini doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Yeni randevu bilgilerini oluştur
            string yeniRandevu = $"{dateTimePicker1.Value.ToShortDateString()} | {maskedTextBox1.Text} | {customerNameBox.Text} | {customerLastnameBox.Text} | {numericUpDown1.Value} | {maskedTextBox2.Text} | {comboBox1.Text}";

            // Mevcut randevuları kontrol et
            foreach (var item in listBox1.Items)
            {
                if (item.ToString() == yeniRandevu)
                {
                    MessageBox.Show("Bu randevu zaten mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Yeni randevu bilgilerini dosyaya yaz
            using (StreamWriter sw = new StreamWriter(randevularDosyaYolu, true))
            {
                sw.WriteLine(yeniRandevu);
            }

            // ListBox'ı güncelle
            RandevulariGoster();

            // TextBox ve diğer giriş kontrollerini temizle
            maskedTextBox1.Clear();
            customerNameBox.Clear();
            customerLastnameBox.Clear();
            maskedTextBox2.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ListBox'ta herhangi bir öğe seçiliyken bu metod çalışır
            if (listBox1.SelectedItem != null)
            {
                if (listBox1.SelectedItem.ToString() == "Randevu bulunamadı.")
                {
                    // Eğer "Randevu bulunamadı." metni seçiliyse, tarih dönüşümü yapma
                    return;
                }
                // Seçilen randevunun bilgilerini al
                string selectedRandevu = listBox1.SelectedItem.ToString();
                string[] randevuBilgileri = selectedRandevu.Split('|');

                // Randevu bilgilerini ilgili TextBox ve diğer giriş kontrollerine yerleştir
                dateTimePicker1.Value = Convert.ToDateTime(randevuBilgileri[0].Trim());
                maskedTextBox1.Text = randevuBilgileri[1].Trim(); // Saat
                customerNameBox.Text = randevuBilgileri[2].Trim(); // Müşteri Adı
                customerLastnameBox.Text = randevuBilgileri[3].Trim(); // Müşteri Soyadı
                numericUpDown1.Value = Convert.ToDecimal(randevuBilgileri[4].Trim());
                maskedTextBox2.Text = randevuBilgileri[5].Trim(); // Telefon
                comboBox1.SelectedItem = randevuBilgileri[6].Trim(); // Hizmet
            }
        }

        private void randevuGnclBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Seçilen randevunun indeksini al
                int selectedIndex = listBox1.SelectedIndex;

                // Yeni randevu bilgilerini al
                string yeniRandevu = $"{dateTimePicker1.Value.ToShortDateString()} | {maskedTextBox1.Text} | {customerNameBox.Text} | {customerLastnameBox.Text} | {numericUpDown1.Value} | {maskedTextBox2.Text} | {comboBox1.SelectedItem}";

                // Yeni randevuyu listbox'ta güncelle
                listBox1.Items[selectedIndex] = yeniRandevu;

                // Güncellenmiş randevu bilgilerini dosyaya yaz
                File.WriteAllLines(randevularDosyaYolu, listBox1.Items.Cast<string>().ToArray());

                MessageBox.Show("Randevu başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir randevu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void randevuSilBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                // Güncellenmiş randevu bilgilerini dosyaya yaz
                File.WriteAllLines(randevularDosyaYolu, listBox1.Items.Cast<string>().ToArray());

                MessageBox.Show("Randevu başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir randevu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void customerNameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Girilen karakterin bir harf olup olmadığını kontrol et
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Eğer girilen karakter bir harf veya kontrol karakteri değilse, işlemi engelle
                e.Handled = true;
            }
        }

        private void customerLastnameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Girilen karakterin bir harf olup olmadığını kontrol et
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Eğer girilen karakter bir harf veya kontrol karakteri değilse, işlemi engelle
                e.Handled = true;
            }
        }
    }
}
