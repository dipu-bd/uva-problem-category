using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace CategoryEditor
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public class CategoryNode
    {
        public CategoryNode(string name = "", string note = "")
        {
            this.name = name;
            this.note = note;
        }

        public string name { get; set; }
        public string note { get; set; }
        public List<CategoryProblem> problems { get; set; }
        public List<CategoryNode> branches { get; set; }

        public bool hasProblem(int pnum)
        {
            if (problems == null) return false;
            foreach(CategoryProblem p in problems)
            {
                if (p.pnum == pnum) return true;
            }
            return false;
        }

        public bool hasBranch(string title)
        {
            if (branches == null) return false;
            foreach (CategoryNode b in branches)
            {
                if (b.name == title) return true;
            }
            return false;
        }
    }
}
