using System;
using System.Collections.Generic;
using System.Text;

namespace CategoryEditor
{
    public class CategoryProblem
    {
        public CategoryProblem(int pnum = 0, bool star = false, string note = "")
        {
            this.pnum = pnum;
            this.star = star;
            this.note = note;
        }

        public int pnum { get; set; }
        public bool star { get; set; }
        public string note { get; set; }
    }
}
