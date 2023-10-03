
//todo Udfra Book.cs vil man lave en instans af book

using Session_8___Giraffe_Academy;


// 1. book object 'book1' istancieres 
Book book1 = new Book();

// 2. Nu angives værdierne i book1
book1.title = "Harry Potter";
book1.author = "J.K. Rowling";
book1.pages = 437;

Console.WriteLine(book1.title);
Console.WriteLine(book1.author);
Console.WriteLine(book1.pages);


//todo Nu oprettes en ny instans af Book

// 1. book object istancieres
Book book2 = new Book();

book2.title = "Lord of the rings";
book2.author = "J.R.R. Tolkien";
book2.pages = 459;

Console.WriteLine(book2.title);
Console.WriteLine(book2.author);
Console.WriteLine(book2.pages);

