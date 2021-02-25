using System;

namespace Check
{
    class Program
    {

        static void Main(string[] args)
        {
            string shop = "Пятёрочка";
            string LegalName = "ООО \"Агроторг\"";
            const ulong INN = 7825706086;
            int index = 454014;
            string city = "Челябинск";
            string street = "Молодогвардейцев";
            byte HouseNumber = 32;
            char HouseLetter = 'а';

            string Cucumber = "Огурцы срденплод. гл. 600г";
            string Mandarin = "Мандарин GL.V. МАРОККО 1кг";
            string IceCream = "Морож.  CCCP.RU 80г эскимо";
            double PriceCucumber = 149.99;
            double PriceMandarin = 139.99;
            double PriceIceCream = 46.99;
            byte discount = 5;
            byte number = 1;
            double PriceCWD = PriceCucumber * (1 - discount / 100);
            double PriceMWD = PriceMandarin * (1 - discount / 100);
            double PriceIWD = PriceIceCream * (1 - discount / 100);
            double TotalCucumber = PriceCWD * number;
            double TotalMandarin = PriceMWD * number;
            double TotalIceCream = PriceIWD * number;
            double Total = TotalCucumber + TotalMandarin + TotalIceCream;

            DateTime DateOfCheck = DateTime.Now.ToUniversalTime ();
           
            Console.WriteLine($"                               {shop}");
            Console.WriteLine();
            Console.WriteLine("                              КАССОВЫЙ ЧЕК");
            Console.WriteLine("                                         Цена со");
            Console.WriteLine("     Наименование           Цена Скидка  скидкой Кол-во    Итого");
            Console.WriteLine($"{Cucumber} {PriceCucumber}  {discount}%     {PriceCWD}    {number}      {TotalCucumber}");
            Console.WriteLine($"{Mandarin} {PriceMandarin}  {discount}%     {PriceMWD}    {number}      {TotalMandarin}");
            Console.WriteLine($"{IceCream}  {PriceIceCream}  {discount}%      {PriceIWD}    {number}       {TotalIceCream}");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine($"ИТОГ:                                                      {Total}");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine($"{LegalName}");
            Console.WriteLine($"ИНН: {INN}");
            Console.WriteLine($"{index}, г.{city}, ул.{street}, {HouseNumber}{HouseLetter}");
            Console.WriteLine(DateOfCheck.AddHours (5));
            Console.ReadLine();

        }
    }
}
