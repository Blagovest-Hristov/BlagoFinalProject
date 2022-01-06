using System.Collections.Generic;

namespace BlagoFinalProject
{
    public class BookComparer<T> : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Pages.CompareTo(y.Pages);
        }
    }
}