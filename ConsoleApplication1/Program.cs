using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            inputMulai:

            Console.Write("Masukkan Nomor Surat : ");
            string inputNomorSurat = Console.ReadLine();

            string jenisSurat = null;
            string diKeluarkanOleh = null;
            string tahun = null;
            string keterangan = null;

            if(inputNomorSurat == "001")
            {
                keterangan = "001/PENG/WK-1/2017";
                jenisSurat = "Pengumuman";
                diKeluarkanOleh = "Wakil Ketua 1";
                tahun = "2017";
            }else if(inputNomorSurat == "031")
            {
                keterangan = "031/SKEP/KETU/2014";
                jenisSurat = "Keputusan";
                diKeluarkanOleh = "ketua";
                tahun = "2014";
            }else if(inputNomorSurat == "065")
            {
                keterangan = "065/SEDR/KPT/2015";
                jenisSurat = "Surat Edaran";
                diKeluarkanOleh = "Kaprodi TI";
                tahun = "2015";
            }
            else
            {
                keterangan = "Tidak Diketahui";
                jenisSurat = "Tidak Diketahui";
                diKeluarkanOleh = "Tidak Diketahui";
                tahun = "Tidak Diketahui";
            }

            Console.WriteLine("Keterangan : " + keterangan);
            Console.WriteLine("Jenis Surat : " + jenisSurat);
            Console.WriteLine("DiKeluarkanOleh : " + diKeluarkanOleh);
            Console.WriteLine("Tahun : " + tahun);

            Console.WriteLine();
            Console.WriteLine("==============================");
            Console.WriteLine("Input lagi ? (y/n)");
            string inputLagi = Console.ReadLine();
            Console.WriteLine();

            if (inputLagi == "Y" || inputLagi == "y")
            {
                goto inputMulai;
            }else
            {
                Environment.Exit(0);
            }

            Console.ReadKey();

        }
    }
}
