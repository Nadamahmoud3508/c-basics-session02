using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1
{
    public class Book
    {
        public String Title;

        public int Pages;
        public override string ToString()
        {
            return $"Title: {Title} Page: {Pages}";
        }

    }
}
