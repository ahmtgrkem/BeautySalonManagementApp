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
using System.Text;
using System.Threading.Tasks;

namespace NdpProje
{
    public abstract class Person
    {
        protected string name;
        protected string lastname;
        protected int age;
        public string Name { get { return name; } set { name = value; } }
        public string Lastname { get {  return lastname; } set {  lastname = value; } }
        public int Age { get { return age; } set { age = value; } }
        public Person() { }
        public Person(string name, string lastname, int age)
        {
            this.name = name;
            this.lastname = lastname;
            this.age = age;
        }
    }
}
