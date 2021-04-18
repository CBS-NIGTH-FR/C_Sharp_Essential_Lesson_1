using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class Program
    {
        static Address address;
        static void Main(string[] args)
        {
            CreateAddress();
            Console.WriteLine("Ваш адрес:\n");
            Console.WriteLine($"Индекс: {address.Index},\nСтрана: {address.Country},\nГород: {address.City},\nУлица: {address.Street},\nДом: {address.House},\nКвартира: {address.Apartment}.");
            Console.ReadKey();
        }

        public static Address CreateAddress()
        {
            Console.WriteLine("Введите индекс:");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введите Страну:");
            string country = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите Город:");
            string city = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите Улицу:");
            string street = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите Дом:");
            string house = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Введите Квартиру:");
            string apartment = Console.ReadLine();
            Console.Clear();

            address = new Address(index, country, city, street, house, apartment);

            return address;
        }
    }
}
