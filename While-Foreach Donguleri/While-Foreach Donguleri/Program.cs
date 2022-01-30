using System;

namespace While_Foreach_Donguleri
{
    internal class Program
    {
        static void Main(string[] args)

        {   //While 
            //1'den başlayarak konsoldan girilen sayıya kadar bulunan sayıların ortalamasını hesaplayan program

            Console.WriteLine("Lütfen Bir Sayı Giriniz !");

             int  sayi = int.Parse(Console.ReadLine());
             int  sayac = 1;
             int  toplam = 0;

              while (sayac <= sayi)
               {
                 toplam  += sayac;
                sayac++;
              
               }
             Console.WriteLine( "Ortalama : "+ toplam / sayi);


            // 'a' dan 'z'ye kadar tüm harfleri yazdıran program
            char character = 'a';
            while (character <= 'z')
            {
               
                Console.WriteLine(character);
                character++;
            }
            Console.WriteLine("******** FOREACH *********");

            string[] car = { "Audi", "Mercedes", "BMV", "Ford", "Dacia", "Opel" };

            foreach (var i in car)
            {
                Console.WriteLine(i);
            }
            
            
        }  
    }
}
