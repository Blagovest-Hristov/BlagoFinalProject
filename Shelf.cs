using System.Collections;
using System.Collections.Generic;

namespace BlagoFinalProject
{
    internal class Shelf 
    {
        public int Number { get; set; }
        public List<Book> Books { get; set; } 
        public int Size { get; set; }
        
        public Shelf(int a, int b)
        {
            this.Number = a;
            this.Size = b;
        }
        public void Add(Book a)
        {
            Books.Add(a);
            Books.Sort();
        }

        public void Remove(Book a)
        {
            Books.Remove(a);
        }
        public void Move(Book a, Shelf b)
        {
            this.Remove(a);
            b.Add(a);
        }
      
    }
}