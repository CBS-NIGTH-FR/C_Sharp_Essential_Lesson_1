using System;


namespace Exercise_3
{
    class Book
    {
        Title title = new Title();
        Author author = new Author();
        Content content = new Content();
        public Book()
        {
            title.Show();
            author.Show();
            content.Show();
        }
        
    }
}
