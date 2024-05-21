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

namespace NdpProje
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new GirisFormu());
        }
    }
}