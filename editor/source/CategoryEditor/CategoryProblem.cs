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

        private CategoryNode parent;

        public int pnum { get; set; }
        public bool star { get; set; }
        public string note { get; set; }

        public void setParent(CategoryNode v)
        {
            this.parent = v;
        }

        public CategoryNode getParent()
        {
            return this.parent;
        }

        /// <summary>
        /// Removes this problem from parent list
        /// </summary>
        public void remove()
        {
            this.parent.problems.Remove(this);
        }
    }
}
