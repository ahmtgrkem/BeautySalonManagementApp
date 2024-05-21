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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NdpProje
{
    public partial class Islemler : Form
    {
        private const string IslemlerDosyaYolu = "services.txt";

        public Islemler()
        {
            InitializeComponent();

        }

        private void Islemler_Load(object sender, EventArgs e)
        {
            IslemleriGoster();
        }

        private void serviceAddBtn_Click(object sender, EventArgs e)
        {
            string serviceName = serviceNameBox.Text;
            string serviceFeeText = serviceFeeBox.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(serviceName) || string.IsNullOrWhiteSpace(serviceFeeText))
            {
                MessageBox.Show("Lütfen hizmet adı ve ücreti giriniz.");
                return;
            }

            if (!int.TryParse(serviceFeeText, out int serviceFee))
            {
                MessageBox.Show("Lütfen geçerli bir ücret giriniz.");
                return;
            }

            // Aynı isimli bir işlem olup olmadığını kontrol et
            foreach (var item in listBox1.Items)
            {
                string[] serviceDetails = item.ToString().Split(',');
                if (serviceDetails[0].Trim().Equals(serviceName, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Bu isimde bir işlem zaten mevcut.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Write to file
            using (StreamWriter sw = new StreamWriter(IslemlerDosyaYolu, true))
            {
                sw.WriteLine($"{serviceName},{serviceFee}");
            }

            // Update the list box
            IslemleriGoster();

            // Clear the textboxes
            serviceNameBox.Text = "";
            serviceFeeBox.Text = "";
        }

        private void serviceDltBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                // Güncellenmiş randevu bilgilerini dosyaya yaz
                File.WriteAllLines(IslemlerDosyaYolu, listBox1.Items.Cast<string>().ToArray());

                MessageBox.Show("İşlem başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir işlem seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void IslemleriGoster()
        {
            listBox1.Items.Clear();

            // randevular.txt dosyasından randevu bilgilerini oku ve ListBox'a ekle
            if (File.Exists(IslemlerDosyaYolu))
            {
                using (StreamReader sr = new StreamReader(IslemlerDosyaYolu))
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
                listBox1.Items.Add("İşlem bulunamadı.");
            }
        }

        private void undoBtn_Click(object sender, EventArgs e)
        {
            GenelForm genelForm = new GenelForm();
            this.Hide();
            genelForm.FormClosed += (sender, e) => this.Close();
            genelForm.Show();
            return;
        }

        private void serviceUpdtBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedService = listBox1.SelectedItem.ToString();
                string[] serviceDetails = selectedService.Split(',');

                string updatedServiceName = serviceNameBox.Text;
                string updatedServiceFeeText = serviceFeeBox.Text;

                // Validate input
                if (string.IsNullOrWhiteSpace(updatedServiceName) || string.IsNullOrWhiteSpace(updatedServiceFeeText))
                {
                    MessageBox.Show("Lütfen hizmet adı ve ücreti giriniz.");
                    return;
                }

                if (!int.TryParse(updatedServiceFeeText, out int updatedServiceFee))
                {
                    MessageBox.Show("Lütfen geçerli bir ücret giriniz.");
                    return;
                }

                string updatedService = $"{updatedServiceName},{updatedServiceFee}";

                // ListBox'ta ve dosyada güncelle
                int selectedIndex = listBox1.SelectedIndex;
                listBox1.Items[selectedIndex] = updatedService;
                File.WriteAllLines(IslemlerDosyaYolu, listBox1.Items.Cast<string>().ToArray());

                MessageBox.Show("İşlem başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TextBox'ları temizle
                serviceNameBox.Text = "";
                serviceFeeBox.Text = "";
            }
            else
            {
                MessageBox.Show("Lütfen güncellenecek bir işlem seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedService = listBox1.SelectedItem.ToString();
                string[] serviceDetails = selectedService.Split(',');

                if (serviceDetails.Length == 2)
                {
                    serviceNameBox.Text = serviceDetails[0];
                    serviceFeeBox.Text = serviceDetails[1];
                }
            }
        }
    }
}
