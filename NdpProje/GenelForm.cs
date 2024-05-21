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
    public partial class GenelForm : Form
    {
        public GenelForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Randevular randevular = new Randevular();
            this.Hide();
            randevular.FormClosed += (sender, e) => this.Close();
            randevular.Show();
            return;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Randevular randevular = new Randevular();
            this.Hide();
            randevular.FormClosed += (sender, e) => this.Close();
            randevular.Show();
            return;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Personeller personelForm = new Personeller();
            this.Hide();
            personelForm.FormClosed += (sender, e) => this.Close();
            personelForm.Show();
            return;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Islemler islemlerForm = new Islemler();
            this.Hide();
            islemlerForm.FormClosed += (sender, e) => this.Close();
            islemlerForm.Show();
            return;
        }

        private void GenelForm_Load(object sender, EventArgs e)
        {

        }
    }
}
