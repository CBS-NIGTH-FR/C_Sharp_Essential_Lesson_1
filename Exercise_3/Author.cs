using System;


namespace Exercise_3
{
    class Author
    {
        string author_name;
        public Author()
        {
            Console.WriteLine("Введите имя автора");
            author_name = Console.ReadLine();
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(author_name);
        }
    }
}
