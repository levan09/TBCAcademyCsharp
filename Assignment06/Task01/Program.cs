using LibrarySystem;

Book witcher = new Book("Witcher", "Andrzej Sapkowski", new DateOnly(1990,12,01), "Fantacy");

Book LordOfTheRings = new Book("Lord of the rings", "J. R. R. Tolkien", new DateOnly(1954, 7, 19), "Fantacy");

Book HarryPotter = new Book("Harry Potter", "J. K. Rowling", new DateOnly(1997, 10, 01), "Fantacy");


Console.WriteLine(witcher.Genre + " " + witcher.Title + " " + witcher.Year + " " + witcher.Author);

Library Alexandria = new Library();

Book[] booklist = new Book[] { witcher, LordOfTheRings };

Alexandria.SetBookList(booklist);


Alexandria.AddBook(witcher);
Alexandria.AddBook(LordOfTheRings);

Alexandria.RemoveBook(HarryPotter);

Book Found = Alexandria.FindBook("Wtcher");
if (Found != null)
{
    Console.WriteLine(Found.Title + " " + Found.Author);
}
Alexandria[0] = HarryPotter;
Alexandria[10] = LordOfTheRings;

Console.WriteLine(Alexandria.Count);