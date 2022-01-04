using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("1. sayıyı giriniz:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz:");
            y = Convert.ToInt32(Console.ReadLine());


            try
            {
                Console.WriteLine("{0}/{1}={2}",x,y,x/y);
            }
            catch (Exception e)
            {
                Console.WriteLine("Hata oluştu:{0}",e);
                
            }
            finally
            {
                Console.WriteLine("İy günler..");
            }
            Console.ReadLine();
        }
    }
}
