using Ab104_22_10_23;
class Program
{
    static void Main()
    {
        //    List<ProgrammingLanguage> programmingLanguages = new List<ProgrammingLanguage>();

        //    programmingLanguages.Add(new ProgrammingLanguage { Name = "C#", Year = 2000});
        //    programmingLanguages.Add(new ProgrammingLanguage { Name = "C++", Year = 1983});
        //    programmingLanguages.Add(new ProgrammingLanguage { Name = "Java", Year = 1995});
        //    programmingLanguages.Add(new ProgrammingLanguage { Name = "Fortran", Year = 1957});
        //    programmingLanguages.Add(new ProgrammingLanguage { Name = "Algorithm for the Analytical Engine", Year = 1883}); //Ada Lovelace Ilk Programci



        //    var sortedLanguagesasc = programmingLanguages.OrderBy(language => language.Year).ToList();
        //    var sortedLanguagesdesc = programmingLanguages.OrderByDescending(language => language.Year).ToList();

        //    Console.WriteLine("Yaradildiqlari ile gore sirasi ilkden sona:");
        //    foreach (ProgrammingLanguage language in sortedLanguagesasc)
        //    {
        //        Console.WriteLine($"{language.Name} - {language.Year}");
        //    }

        //    Console.WriteLine("Yaradildiqlari ile gore sirasi sondan ilke:");
        //    foreach (ProgrammingLanguage language in sortedLanguagesdesc)
        //    {
        //        Console.WriteLine($"{language.Name} - {language.Year}");
        //    }


        List<Category> categories = new List<Category>()
        {
            new Category("Klasik"),
            new Category("Komediya")
        };

        List<Book> books = new List<Book>()
        {
            new Book("name1","author1",categories[0]),
            new Book("name2","author2",categories[1]),
            new Book("name3","author3",categories[0]),
            new Book("name4","author4",categories[1]),
            new Book("name5","author5",categories[0]),
        };

        List<Library> libraries = new List<Library>()
        {
            new Library("Library1"),
            new Library("Library2"),
            new Library("Library3"),
            new Library("Library4")
        };

        libraries[0].AddBook(books[0]);
        libraries[1].AddBook(books[1]);

        bool exitProgram=false;
        while (!exitProgram)
        {
            Console.WriteLine($"===========\n  Ana Menyu \n =========== \n [1] Yeni kitabxana yarat \n [2] Yeni kateqoriya yarat \n [3] Yeni kitab yarat \n [4] Kitabxanaya daxil ol \n [0] Proqramdan chix \n >>>");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("======================\n Yeni kitabxana yarat\n ====================== \n Kitabxananin adini daxil et:");
                    var libraryname = Console.ReadLine();
                    Library librarynew = new Library(libraryname);
                    libraries.Add(librarynew);
                    Console.WriteLine($"{libraryname} adli kitabxana yaradildi ");
                    break;
                case 2:
                    Console.WriteLine("======================\n Yeni kateqoriya yarat\n ====================== \n Kateqoriyanin adini daxil et:");
                    var categoryname = Console.ReadLine();
                    Category categorynew = new Category(categoryname);
                    categories.Add(categorynew);
                    Console.WriteLine($"{categorynew} adli kateqoriya yaradildi ");
                    break;
                case 3:
                    Console.WriteLine("======================\n Yeni kitab yarat\n ====================== \n Kitabin adini daxil et:");
                    var bookname = Console.ReadLine();
                    Console.WriteLine("Yazari daxil et: ");
                    var aurhorname = Console.ReadLine();
                    Console.WriteLine("Kategoriya sec: ");
                    foreach (Category category in categories)
                    {
                        Console.WriteLine($"Id: {category.Id} - Name: {category.Name}");
                    }
                    Console.WriteLine("Id daxil et");
                    int categoryId =int.Parse(Console.ReadLine());
                    if (categoryId>=categories.Count)
                    {
                        Console.WriteLine("Bele kategoriya yoxdu ");
                    }
                    Book book =new Book(bookname,aurhorname,categories[categoryId]);
                    Console.WriteLine($"{bookname} adli kitab yaradildi");
                    books.Add(book);

                    break;

                case 4:
                    Console.WriteLine("======================\n Kitabxana sec\n ======================");
                    foreach ( Library item in libraries)
                    {
                        Console.WriteLine();
                    }
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }

        }
    }
}
