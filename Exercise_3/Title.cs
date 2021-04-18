using System;


namespace Exercise_3
{
    class Title
    {
        string title_name;
        public Title()
        {
            Console.WriteLine("Введите название книги");
            title_name = Console.ReadLine();
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(title_name);
        }
    }
}
