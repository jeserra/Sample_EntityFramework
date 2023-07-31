// See https://aka.ms/new-console-template for more information
using Sample.Data;
using Sample.Data.Entities;

Console.WriteLine("Hello, World!");


using var db = new LibraryContext();


var bookstodelete = db.Books.Where(x => x.Author == "Robert Greener");

foreach(var deletebook in bookstodelete)
    db.Books.Remove(deletebook);


Book book = new Book()
{
    Author = "Robert Greener",
    Title = "MAestria",
    Created= DateTime.Now,
    Description= "Tomar las riendas de nuestro destino para lograr metas extraordinarias",
    ISBN = "978-607-100-978-1",
    Updated= DateTime.Now,
};


Book book2 = new Book()
{
    Author = "Robert Greener",
    Title = "Las 48 leyes del poder",
    Created= DateTime.Now,
    Description= "Tomar las riendas de nuestro destino para lograr metas extraordinarias",
    ISBN = "978-607-100-44-1",
    Updated= DateTime.Now,
};


Book book3 = new Book()
{
    Author = "Nassim Nicholas Taleb",
    Title = "El Cisne Negro",
    Created= DateTime.Now,
    Description= "",
    ISBN = "978-607-100-348-1",
    Updated= DateTime.Now,
};

db.Books.Add(book);
db.Books.Add(book2);
db.Books.Add(book3);
 

db.SaveChanges();


var founderbooks = db.Books.Where(x => x.Author == "Robert Greener");

foreach(var item in founderbooks)
{
    Console.WriteLine(item.Title);
    Console.WriteLine(item.Description);
    Console.WriteLine(item.ISBN);
    Console.WriteLine(item.Author);
}
