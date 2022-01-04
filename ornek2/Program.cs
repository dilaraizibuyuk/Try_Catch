using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Yaşınızı giriniz:");
                int yas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bilgilendirmeniz için teşekkür ederiz.");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
          
            Console.ReadKey();
        }
    }
}
