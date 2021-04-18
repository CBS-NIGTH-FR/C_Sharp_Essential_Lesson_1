using System;


namespace Exercise_3
{
    class Content
    {
        string content_name;
        public Content()
        {
            Console.WriteLine("Опишите содержание книги");
            content_name = Console.ReadLine();
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(content_name);
        }
    }
}
