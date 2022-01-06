using System;
using System.Collections;

namespace BlagoFinalProject
{
    public class Book: IComparable, IEnumerable
    {
        public int Pages { get; set; }
        public string Author { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        private DateTime taken;
        public DateTime Taken { get => taken  ; set { if (Status != true) { throw new Exception("You cannot put a Taken time on a book that is not taken "); } } }
        private DateTime back;
        public DateTime Back { get=>back; set { if (Status != true) { throw new Exception("You cannot put a Back time on a book that is not taken "); } } }

        public Book(string name, string author, int pages)
        {
            Pages = pages;
            Author = author;
            Name = name;
            Status = false;          
        }

        TimeSpan Remaining()
        {
            return Back - DateTime.Now;
        }

        public int CompareTo(object b)
        {
            BookComparer<Book> a = new BookComparer<Book>();
            return a.Compare(this,(Book)b);
        }

        public void Take(DateTime a)
        {
            Status = true;
            DateTime Now = DateTime.Now;
            taken = Now;
            back = a;

        }

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)Name).GetEnumerator();
        }

        public override string ToString()
        {
            return $"\"{Name}\", {Author}, {Pages}"; 
        }
    }
}