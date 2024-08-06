using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privet__
{
    internal class LibraryItem
    {
        public LibraryItem() { }
        protected string title { get; set; } = "";

        public string GetTitle()
        {
            return title;
        }

    }
}
