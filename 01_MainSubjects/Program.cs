using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Kodlara ait kütüphaneleri tutuyor. 
namespace _01_MainSubjects // Projeye vermiş olduğumuz isim
{
    internal class Program //Program isminde bir tane sınıf verdi. Uygulamanın çalışacağı sınıf.
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            Console.Write("Merhaba Dünya"); //Write ifadesi imleci yazının en sağına atar
            Console.WriteLine("Selam"); //Bir değer yazar sonra imleci alt satıra indirir

            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine();
            Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region String Değişkenler

            // STRING
            // Değişken_türü  değişken_adı;

            string name;
            name = "Ayşe";
            Console.Write(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Ali";
            customerSurname = "Çınar";
            customerPhone = "+90 509 400 30 29";
            customerEmail = "deneme@gmail.com";
            district = "Kadıköy";
            city = "İstanbul";

            Console.WriteLine("**** Rezervasyon Kartı ****");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Müşteri:" + customerName + "" + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine();

            customerName = "Ayşegül";
            customerSurname = "Kaya";
            customerPhone = "+90 400 300 80 70";
            customerEmail = "test@gmail.com";
            district = "Sapanca";
            city = "Sakarya";

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Müşteri:" + customerName + "" + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine("-----------------------------------------------");


            #endregion

            #region INT Değişkenler

            //INT; Tam sayı türündeki değişkenler

            int number = 24;
            Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int fricePrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restorant Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger: " + hamburgerPrice + " TL ");
            Console.WriteLine("-----Pizza: " + pizzaPrice + " TL ");
            Console.WriteLine("-----Kola: " + cokePrice + " TL ");
            Console.WriteLine("-----Limonata: " + lemonadePrice + " TL ");
            Console.WriteLine("-----:Kızartma " + fricePrice + " TL ");
            Console.WriteLine("-----Su: " + waterPrice + " TL ");
            Console.WriteLine();
            Console.WriteLine("**** Restorant Menü Fiyatı ****");
            
            
            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friceCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friceCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friceCount * fricePrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + " TL ");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL ");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL ");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL ");
            Console.WriteLine("Pizza Tutar: " + totalPizzaPrice + " TL ");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL ");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice + totalHamburgerPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL ");


            #endregion

            Console.Read(); //ekranı bekletecek olan kod
        }
    }
}