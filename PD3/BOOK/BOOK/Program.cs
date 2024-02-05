using System;
using System.Collections.Generic;

class Book
{
    public string Title;
    public string Author;
    public int PublicationYear;
    public double Price;
    public int QuantityInStock;
    public Book()
    {

    }
    public Book(string title, string author, int publicationYear, double price, int quantityInStock)
    {
        Title = title;
        Author = author;
        PublicationYear = publicationYear;
        Price = price;
        QuantityInStock = quantityInStock;
    }

    public string GetTitle()
    {
        return "Title: " +Title;
    }

    public string GetAuthor()
    {
        return "Author: "+Author;
    }

    public string GetPublicationYear()
    {
        return "Publication Year: " +PublicationYear;
    }

    public string GetPrice()
    {
        return "Price: "+Price;
    }

    public void SellCopies(int numberOfCopies)
    {
        if (QuantityInStock >= numberOfCopies)
        {
            QuantityInStock -= numberOfCopies;
            Console.WriteLine($"{numberOfCopies} copies of '{Title}' sold successfully.");
        }
        else
        {
            Console.WriteLine($"Error: Not enough copies of '{Title}' in stock.");
        }
    }

    public void Restock(int additionalCopies)
    {
        QuantityInStock += additionalCopies;
        Console.WriteLine($"{additionalCopies} copies of '{Title}' restocked successfully.");
    }

    public string BookDetails()
    {
        return $"{GetTitle()}, {GetAuthor()}, {GetPublicationYear()}, {GetPrice()}, Quantity in Stock: {QuantityInStock}";
    }
}

class Program
{
    static void Main()
    {
        List<Book> bookList = new List<Book>();

        while (true)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. View All the Books information");
            Console.WriteLine("3. Get the Author details of a specific book");
            Console.WriteLine("4. Sell Copies of a Specific Book");
            Console.WriteLine("5. Restock a Specific Book");
            Console.WriteLine("6. See the count of the Books present in your bookList");
            Console.WriteLine("7. Exit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            if(choice == 1)
            {
                Console.Write("Enter Title: ");
                string title = Console.ReadLine();
                Console.Write("Enter Author: ");
                string author = Console.ReadLine();
                Console.Write("Enter Publication Year: ");
                int publicationYear = int.Parse(Console.ReadLine());
                Console.Write("Enter Price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Enter Quantity in Stock: ");
                int quantityInStock = int.Parse(Console.ReadLine());

                Book newBook = new Book(title, author, publicationYear, price, quantityInStock);
                bookList.Add(newBook);

                Console.WriteLine("Book added successfully!");
            }
            else if(choice == 2)
            {
                foreach (var book in bookList)
                {
                    Console.WriteLine(book.BookDetails());
                }
            }
            else if(choice == 3)
            {
                Console.Write("Enter the Title of the book: ");
                string searchTitle = Console.ReadLine();
                bool found_book = false;
                Book b = new Book();

                for (int i = 0; i < bookList.Count; i++)
                {
                    if (searchTitle == bookList[i].Title)
                    {
                        Console.WriteLine(b.GetAuthor());
                    }
                    else
                    {
                        Console.WriteLine("invalid title");
                    }
                }
            }
            else if(choice == 4)
            {
                  Console.Write("Enter the Title of the book: ");
                    string sellTitle = Console.ReadLine();
                    Book sellBook = bookList.Find(book => book.Title.Equals(sellTitle, StringComparison.OrdinalIgnoreCase));
                    if (sellBook != null)
                    {
                        Console.Write("Enter the number of copies to sell: ");
                        int sellCount = int.Parse(Console.ReadLine());
                        sellBook.SellCopies(sellCount);
                    }
                    else
                    {
                        Console.WriteLine($"Book with title '{sellTitle}' not found.");
                    }
            }
            else if(choice == 5)
            {
                Console.Write("Enter the Title of the book: ");
                string restockTitle = Console.ReadLine();
                Book restockBook = bookList.Find(book => book.Title.Equals(restockTitle, StringComparison.OrdinalIgnoreCase));
                if (restockBook != null)
                {
                    Console.Write("Enter the number of copies to restock: ");
                    int restockCount = int.Parse(Console.ReadLine());
                    restockBook.Restock(restockCount);
                }
                else
                {
                    Console.WriteLine($"Book with title '{restockTitle}' not found.");
                }
            }
            else if(choice == 6)
            {
                Console.WriteLine($"Number of Books: {bookList.Count}");
            }

          
        }
    }
}
