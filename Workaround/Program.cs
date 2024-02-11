using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
	class Program
	{
		static void Main(string[] args)
		{
			Person p1 = new Person();

			SelamVer("Ahmet");
			SelamVer("Engin");
			SelamVer();
			
			Topla();


			Console.ReadLine();

			
		}

		static void SelamVer()
		{
			Console.WriteLine("Merhaba isimsiz");
		}

		static void SelamVer(string isim)
		{
            Console.WriteLine("Merhaba " +isim);
        }



		static int Topla(int sayi1=1, int sayi2=2)
		{
			int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : "+sonuc);


            return sonuc;
		}



	}
	
}
















