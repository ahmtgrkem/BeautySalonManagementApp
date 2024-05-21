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
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace NdpProje
{
    public sealed class Employee : Person
    {
        private string username;
        private string password;
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public Employee() { }
        public Employee(string name, string lastname, int age, string username, string password) : base(name, lastname, age)
        {
            this.username = username;
            this.password = password;
        }
    }
}
