using practice12.Services;

MemberService.Initialize();
BookService.Initialize();

bool isRunning = true;

while (isRunning)
{
    Console.WriteLine("\n===== LIBRARY MANAGEMENT =====");
    Console.WriteLine("1. Add Member");
    Console.WriteLine("2. Show All Members");
    Console.WriteLine("3. Update Member");
    Console.WriteLine("4. Delete Member");
    Console.WriteLine("5. Add Book");
    Console.WriteLine("6. Show All Books");
    Console.WriteLine("7. Update Book");
    Console.WriteLine("8. Delete Book");
    Console.WriteLine("9. Borrow Book");
    Console.WriteLine("10. Return Book");
    Console.WriteLine("0. Exit");

    Console.Write("Choose option: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            AddMemberMenu();
            break;

        case 2:
            MemberService.GetAllMembers();
            break;

        case 3:
            UpdateMemberMenu();
            break;

        case 4:
            DeleteMemberMenu();
            break;

        case 5:
            AddBookMenu();
            break;

        case 6:
            BookService.GetAllBooks();
            break;

        case 7:
            UpdateBookMenu();
            break;

        case 8:
            DeleteBookMenu();
            break;

        case 9:
            BorrowBookMenu();
            break;

        case 10:
            ReturnBookMenu();
            break;

        case 0:
            isRunning = false;
            break;

        default:
            Console.WriteLine("Invalid choice.");
            break;
    }
}
    

    static void AddMemberMenu()
{
    Console.Write("First Name: ");
    string firstName = Console.ReadLine();

    Console.Write("Last Name: ");
    string lastName = Console.ReadLine();

    Console.Write("Age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.Write("Email: ");
    string email = Console.ReadLine();

    Console.Write("Personal Number: ");
    string personalNumber = Console.ReadLine();

    MemberService.AddMember(
        firstName,
        lastName,
        age,
        email,
        personalNumber);
}

static void UpdateMemberMenu()
{
    MemberService.GetAllMembers();

    Console.Write("Enter Member Id: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.Write("First Name: ");
    string firstName = Console.ReadLine();

    Console.Write("Last Name: ");
    string lastName = Console.ReadLine();

    Console.Write("Age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.Write("Email: ");
    string email = Console.ReadLine();

    Console.Write("Personal Number: ");
    string personalNumber = Console.ReadLine();

    MemberService.UpdateMember(
        id,
        firstName,
        lastName,
        age,
        email,
        personalNumber);
}

static void DeleteMemberMenu()
{
    MemberService.GetAllMembers();

    Console.Write("Enter Member Id: ");
    int id = Convert.ToInt32(Console.ReadLine());

    MemberService.DeleteMember(id);
}

static void AddBookMenu()
{
    Console.Write("Title: ");
    string title = Console.ReadLine();

    Console.Write("Author: ");
    string author = Console.ReadLine();

    Console.Write("Genre: ");
    string genre = Console.ReadLine();

    Console.Write("Published Year: ");
    int year = Convert.ToInt32(Console.ReadLine());

    BookService.AddBook(
        title,
        author,
        genre,
        year);
}

static void UpdateBookMenu()
{
    BookService.GetAllBooks();

    Console.Write("Enter Book Id: ");
    int id = Convert.ToInt32(Console.ReadLine());

    Console.Write("Title: ");
    string title = Console.ReadLine();

    Console.Write("Author: ");
    string author = Console.ReadLine();

    Console.Write("Genre: ");
    string genre = Console.ReadLine();

    Console.Write("Published Year: ");
    int year = Convert.ToInt32(Console.ReadLine());

    BookService.UpdateBook(
        id,
        title,
        author,
        genre,
        year);
}

static void DeleteBookMenu()
{
    BookService.GetAllBooks();

    Console.Write("Enter Book Id: ");
    int id = Convert.ToInt32(Console.ReadLine());

    BookService.DeleteBook(id);
}

static void BorrowBookMenu()
{
    MemberService.GetAllMembers();

    Console.Write("Enter Member Id: ");
    int memberId = Convert.ToInt32(Console.ReadLine());

    BookService.GetAllBooks();

    Console.Write("Enter Book Id: ");
    int bookId = Convert.ToInt32(Console.ReadLine());

    LibraryService.BorrowBook(memberId, bookId);
}

static void ReturnBookMenu()
{
    BookService.GetAllBooks();

    Console.Write("Enter Book Id: ");
    int bookId = Convert.ToInt32(Console.ReadLine());

    LibraryService.ReturnBook(bookId);
}