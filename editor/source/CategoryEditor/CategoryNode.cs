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
        public CategoryNode(string name = "", string note = "", CategoryNode parent = null)
        {
            this.name = name;
            this.note = note;
            problems = new List<CategoryProblem>();
            branches = new List<CategoryNode>();
            this.parent = parent;
        }

        [Newtonsoft.Json.JsonIgnore]
        private CategoryNode parent;

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

        public String getPath()
        {
            if (this.parent == null) 
            {
                return name;
            }
            else
            {
                return this.parent.getPath() + "/" + name;
            }
        }

        public bool isTop()
        {
            return this.parent == null;
        }

        public void setParent(CategoryNode v)
        {
            this.parent = v;
        }
        public CategoryNode getParent()
        {
            return this.parent;
        }

        public void remove()
        {
            this.parent.branches.Remove(this);
        }

        public void updateParent()
        { 
            foreach(var v in branches)
            {
                v.setParent(this);
                v.updateParent();
            }
            foreach(var v in problems)
            {
                v.setParent(this);
            }
        }
    }
}
