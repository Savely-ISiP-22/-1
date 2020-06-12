using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("\n Покупателя - 1 \n Абонента - 2 \n Зоомагазин - 3 \n Выход - 4");
                Console.WriteLine();
                Console.Write("Ваш выбор: ");

                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Buyer Buyer = new Buyer();
                    Console.WriteLine("Пример: Name Familiya Otchestvo Adres NumberCreditCard NumberBankSchet");
                    Buyer.Name = "" + Console.ReadLine();
                    Buyer.Familiya = "" + Console.ReadLine();
                    Buyer.Otchestvo = "" + Console.ReadLine();
                    Buyer.Adres = "" + Console.ReadLine();
                    Buyer.NumberCreditCard = "" + Console.ReadLine();
                    Buyer.NumberBankSchet = "" + Console.ReadLine();

                    Console.WriteLine
                    ("\nПокупатель:\n" + "Имя: " + Buyer.Name + " Фамилия: " + Buyer.Familiya + " Отчество: " + Buyer.Otchestvo + " Адрес: " + Buyer.Adres + " Номер кредит. карты " + Buyer.NumberCreditCard + " Номер банк. счета: " + Buyer.NumberBankSchet);
                }
                else if (choice == 2)
                {
                    Sub Sub = new Sub();
                    Console.WriteLine("Пример: IndNumber Name Familiya Otchestvo Adres NumberCreditCard TimeMezGorTalk TimeGorTalk");
                    Sub.IndNumber = "" + Console.ReadLine();
                    Sub.Name = "" + Console.ReadLine();
                    Sub.Familiya = "" + Console.ReadLine();
                    Sub.Otchestvo = "" + Console.ReadLine();
                    Sub.Adres = "" + Console.ReadLine();
                    Sub.NumberCreditCard = "" + Console.ReadLine();
                    Sub.TimeMezGorTalk = "" + Console.ReadLine();
                    Sub.TimeGorTalk = "" + Console.ReadLine();

                    Console.WriteLine
                    ("\nАбонент:\n" + " Идентификационный номер: " + Sub.IndNumber + " Имя: " + Sub.Name + " Фамилия: " + Sub.Familiya + " Отчество: " + Sub.Otchestvo + " Адрес: " + Sub.Adres + " Номер кредит. карты: " + Sub.NumberCreditCard + " Время междугород. переговоров: " + Sub.TimeMezGorTalk + " Время город. переговоров: " + Sub.TimeGorTalk);
                }
                else if (choice == 3)
                {
                    PetShop PetShop = new PetShop();
                    Console.WriteLine("Пример: Name Price Animal Gender Quantity");
                    PetShop.Name = "" + Console.ReadLine();
                    PetShop.Price = "" + Console.ReadLine();
                    PetShop.Animal = "" + Console.ReadLine();
                    PetShop.Gender = "" + Console.ReadLine();
                    PetShop.Quantity = "" + Console.ReadLine();

                    Console.WriteLine
                   ("\nЗоо Магазин:\n" + " Имя: " + PetShop.Name + " Цена: " + PetShop.Price + " Животное: " + PetShop.Animal + " Пол: " + PetShop.Gender + " Количество: " + PetShop.Quantity);

                }
            }
        }
    }
}
