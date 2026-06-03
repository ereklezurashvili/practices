using practice12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice12.Services;

public static class BookService
{
    private static Book[] books = new Book[100];
    private static int count = 0;

    public static void Initialize()
    {
        Book[] initialBooks = new Book[10]
        {
            new Book { Id = 1, Title = "Clean Code", Author = "Robert Martin", Genre = "Programming", PublishedYear = 2008, IsBorrowed = false, BorrowedByMemberId = null },
            new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Genre = "Programming", PublishedYear = 1999, IsBorrowed = false, BorrowedByMemberId = null },
            new Book { Id = 3, Title = "Design Patterns", Author = "Erich Gamma", Genre = "Programming", PublishedYear = 1994, IsBorrowed = false, BorrowedByMemberId = null },
            new Book { Id = 4, Title = "The Hobbit", Author = "J.R.R. Tolkien", Genre = "Fantasy", PublishedYear = 1937, IsBorrowed = false, BorrowedByMemberId = null },
            new Book { Id = 5, Title = "1984", Author = "George Orwell", Genre = "Dystopian", PublishedYear = 1949, IsBorrowed = false, BorrowedByMemberId = null },
            new Book { Id = 6, Title = "Atomic Habits", Author = "James Clear", Genre = "Self Development", PublishedYear = 2018, IsBorrowed = false, BorrowedByMemberId = null },
            new Book { Id = 7, Title = "Deep Work", Author = "Cal Newport", Genre = "Productivity", PublishedYear = 2016, IsBorrowed = false, BorrowedByMemberId = null },
            new Book { Id = 8, Title = "Rich Dad Poor Dad", Author = "Robert Kiyosaki", Genre = "Finance", PublishedYear = 1997, IsBorrowed = false, BorrowedByMemberId = null },
            new Book { Id = 9, Title = "The Alchemist", Author = "Paulo Coelho", Genre = "Novel", PublishedYear = 1988, IsBorrowed = false, BorrowedByMemberId = null },
            new Book { Id = 10, Title = "To Kill a Mockingbird", Author = "Harper Lee", Genre = "Classic", PublishedYear = 1960, IsBorrowed = false, BorrowedByMemberId = null }
        };

        for (int i = 0; i < 10; i++)
        {
            books[i] = initialBooks[i];
        }

        count = 10;
    }

    public static void AddBook(
        string title,
        string author,
        string genre,
        int publishedYear)
    {
        books[count] = new Book
        {
            Id = count + 1,
            Title = title,
            Author = author,
            Genre = genre,
            PublishedYear = publishedYear,
            IsBorrowed = false,
            BorrowedByMemberId = null
        };

        count++;
    }

    public static void GetAllBooks()
    {
        for (int i = 0; i < count; i++)
        {
            books[i].PrintInfo();
            Console.WriteLine("--------------------");
        }
    }

    public static void UpdateBook(
        int id,
        string title,
        string author,
        string genre,
        int publishedYear)
    {
        for (int i = 0; i < count; i++)
        {
            if (books[i].Id == id)
            {
                books[i].Title = title;
                books[i].Author = author;
                books[i].Genre = genre;
                books[i].PublishedYear = publishedYear;

                Console.WriteLine("Book updated successfully.");
                return;
            }
        }

        Console.WriteLine("Book not found.");
    }

    public static void DeleteBook(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (books[i].Id == id)
            {
                for (int j = i; j < count - 1; j++)
                {
                    books[j] = books[j + 1];
                }

                books[count - 1] = null;
                count--;

                Console.WriteLine("Book deleted successfully.");
                return;
            }
        }

        Console.WriteLine("Book not found.");
    }

    public static Book GetBookById(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (books[i].Id == id)
            {
                return books[i];
            }
        }

        return null;
    }
}
