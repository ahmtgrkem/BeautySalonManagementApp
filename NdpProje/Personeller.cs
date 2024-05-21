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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NdpProje
{
    public partial class Personeller : Form
    {
        private const string calisanlarDosyaYolu = "employees.txt";
        public Personeller()
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

        private void CalisanlariGoster()
        {
            listBox1.Items.Clear();

            // employees.txt dosyasından çalışan bilgilerini oku ve ListBox'a ekle
            if (File.Exists(calisanlarDosyaYolu))
            {
                using (StreamReader sr = new StreamReader(calisanlarDosyaYolu))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Satırdaki veriyi parçala
                        string[] calisanBilgileri = line.Split(',');

                        // Şifreyi gizle
                        string gizliSifre = new string('*', calisanBilgileri[4].Length);

                        // ListBox'a ekle (şifre yerine gizliSifre'i kullan)
                        listBox1.Items.Add($"{calisanBilgileri[0]}, {calisanBilgileri[1]}, {calisanBilgileri[2]}, {calisanBilgileri[3]}, {gizliSifre}");
                    }
                }
            }
            else
            {
                listBox1.Items.Add("Personel bulunamadı.");
            }
        }

        private void PersonelForm_Load(object sender, EventArgs e)
        {
            CalisanlariGoster();
        }

        private void personelSilBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                // Güncellenmiş randevu bilgilerini dosyaya yaz
                File.WriteAllLines(calisanlarDosyaYolu, listBox1.Items.Cast<string>().ToArray());

                MessageBox.Show("Personel başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void personelBulBtn_Click(object sender, EventArgs e)
        {
            // Ad textbox'ından girilen ismi al ve küçük harfe dönüştür
            string arananIsim = personelNameBox.Text.Trim().ToLower();

            // Eğer isim girilmemişse veya boş ise uyarı ver
            if (string.IsNullOrEmpty(arananIsim))
            {
                MessageBox.Show("Lütfen aranacak bir isim girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Listbox'ı temizle
            listBox1.Items.Clear();

            // employees.txt dosyasından çalışanların bilgilerini oku ve aranan isme sahip olanları listbox'a ekle
            try
            {
                string[] lines = File.ReadAllLines("employees.txt");

                foreach (string line in lines)
                {
                    // Satırdaki verileri virgülle ayırarak parçala
                    string[] parts = line.Split(',');

                    // İsim ve soyisim kısmını birleştir, küçük harfe dönüştür
                    string isim = parts[0].ToLower();

                    // Aranan isimle tam olarak eşleşen çalışanları listbox'a ekle
                    if (isim.Equals(arananIsim))
                    {
                        // Şifreyi göstermeden çalışan bilgilerini listbox'a ekle
                        listBox1.Items.Add($"{parts[0]} {parts[1]} - Yaş: {parts[2]} - Kullanıcı Adı: {parts[3]}");
                    }
                }

                // Eğer aranan isme sahip çalışan bulunamadıysa
                if (listBox1.Items.Count == 0)
                {
                    MessageBox.Show("Aranan isme sahip çalışan bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
