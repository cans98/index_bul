using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace index_bul
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sehirler = { "eskisehir", "ankara", "istanbul", "izmir", "sinop", "diyarbakir", "zonguldak", "tekirdag", "kocaeli" };
            Console.WriteLine("şehir gir");
            string girilensehir = Console.ReadLine();
            bool varMi = false;
            int n = 0;
            foreach (string sehir in sehirler)
            {


                n = n + 1; // index için tanımlanan counter
                if (sehir == girilensehir)
                {
                    varMi = true;
                    Console.WriteLine($"{girilensehir} arrayda var  ");
                    Console.WriteLine($"index numarası {n}");
                    break; // bi kere bulunca çık

                }
               
            }
            if (varMi == false) //surekli arrayda yok yazdırmaması için true false kontrolunu en son yaptım
            {
                Console.WriteLine($"{girilensehir} arrayda yok  "); 
            }

         
            Console.ReadKey();
        }
    }
}
