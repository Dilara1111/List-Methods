using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    {
            //        Book book = new Book("Sefiller", "Viktor Huqo", 456);
            //        Book book1 = new Book("Payiz", "Viktor Huqo", 456);
            //        Book book2 = new Book("Meyvelerin sohbeti", "Viktor Huqo", 456);

            //        Console.WriteLine($"No: {book.No} Name: {book.Name} Autorcount:{book.AutorName} Pagecount:{book.PageCount}");
            //        Console.WriteLine($"No: {book1.No} Name: {book1.Name} Autorcount:{book1.AutorName} Pagecount:{book1.PageCount}");
            //        Console.WriteLine($"No: {book2.No} Name: {book2.Name} Autorcount:{book2.AutorName} Pagecount:{book2.PageCount}");


            //        Library library = new Library();
            //        library.AddBook( book );
            //        library.AddBook( book1 );
            //        library.AddBook( book2 );
            //        List<Book> result = library.FindAllBooksByName("Sefiller");
            //        foreach(var item  in result)
            //        {
            //            Console.WriteLine(item.Name);
            //        }




            //    }
            //}

            ////// ////////////////// Task 1 ///////////////////

            //public class Book
            //{
            //    public int No { get; set; }
            //    public string Name { get; set; }
            //    public string AutorName { get; set; }
            //    public short PageCount { get; set; }
            //    private static int countNo { get; set; } = 0;
            //    public Book() { }

            //    public Book(string name, string autorName, short pageCount)
            //    {

            //        Name = name;
            //        AutorName = autorName;
            //        PageCount = pageCount;
            //        No = countNo++;

            //    }

            //}
            /////////////////// Task 2 ///////////////////
            //public class Library
            //{
            //    List<Book> books = new List<Book>();

            //    public void AddBook(Book book)
            //    {
            //        books.Add(book);
            //    }

            //    public List<Book> FindAllBooksByName(string a)
            //    {
            //        var b = books.Where(book => book.Name.Contains(a));
            //        return b.ToList();



            ///////////////// HOMEWORK ///////////////////
            // Custom Arraylist classı yazın, Capacity, Count propları olsun, Capacity qəbul edən constructoru olsun
            //Add metodu, Remove metodu, RemoveAt metodu, TrimToSize metodu, AddRange metodu olsun

        }
    }

}
