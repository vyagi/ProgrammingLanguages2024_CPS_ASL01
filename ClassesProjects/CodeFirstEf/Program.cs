using CodeFirstEf;

using var dbContext = new LibraryDbContext();

// var newBook = new Book
// {
//     Title = "Programming in C#",
//     Author = new Author
//     {
//         Name = "Jon Skeet"
//     }
// };
//
// dbContext.Books.Add(newBook);

//var author = new Author
//{
//    Name = "Abay"
//};

//dbContext.Authors.Add(author);

//var author = dbContext.Authors.First(x => x.Name == "Abay");

//var hisBook = new Book
//{
//    Title = "40 wise words",
//    Author = author,
//};

//dbContext.Books.Add(hisBook);

//var bookToUpdate = dbContext.Books.First(x => x.Title == "40 wise words");

//bookToUpdate.Title = "Forty wise words";
//dbContext.SaveChanges();

var bookToRemove = dbContext.Books.First();
dbContext.Books.Remove(bookToRemove);
dbContext.SaveChanges();
var allBooks = dbContext.Books;

foreach (var book in allBooks)
{
    Console.WriteLine(book.Title);
}