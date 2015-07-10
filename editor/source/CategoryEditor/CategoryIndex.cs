using System;
using System.Collections.Generic;
using System.Text;

namespace CategoryEditor
{
    public class CategoryIndex
    {
        public CategoryIndex(string file = "", int version = 0)
        {
            this.file = file;
            this.ver = version;
        }

        public string file { get; set; }
        public int ver { get; set; } 
    }


}
