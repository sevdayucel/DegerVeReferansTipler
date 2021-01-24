using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);
            //sayi1=30
            //int decimal ... değer tipidir
            // soldan başlayarak okunur ve sayı 1 in değeri eşittir eşitliğin sağ tarafındaki değer yani 30 olur
            //belleğin stack bölümünde tutulur
            int[] sayilar1 = new int[] {10,20,30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0]= 999;
            //sayilar1=999
            //array class gibi türler referans tipidir 
            //sayılar 1 in referans numarası eşittir sayılar 2 nin referans numarası olarak okunur sayılar 2 nin ref. no 999 olduğundan sayılar1 999 olur
            //belleğin heap bölümünde alan oluşturulur ve ordaki değer eşitliğin sol tarafındaki veriye atanır

        }

    }
}
