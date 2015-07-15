using System;
using System.Windows.Forms;

namespace CategoryEditor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //downloadCPBook(1);
            //downloadCPBook(2);
            //downloadCPBook(3);

            if (!System.IO.File.Exists(Properties.Settings.Default.INDEX))
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                path = System.IO.Path.Combine(path, "UVA Arena");
                path = System.IO.Path.Combine(path, "Category");
                path = System.IO.Path.Combine(path, "INDEX");
                Properties.Settings.Default.INDEX = path;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            Properties.Settings.Default.Save();
        }

        static void downloadCPBook(int ed)
        {
            string url = "http://uhunt.felix-halim.net/api/cpbook/" + ed.ToString();
            string path = @"J:\Projects\GitHub\uva-problem-category\data\CP Book" + ed.ToString() + ".cat";

            //download data
            Console.WriteLine("Downloading \"" + url + "\" ...");
            var client = new System.Net.WebClient();
            byte[] data = client.DownloadData(url);

            //parse data
            Console.WriteLine("Parsing ...");
            string json = System.Text.Encoding.UTF8.GetString(data);
            object alldat = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

            //build category branch
            Console.WriteLine("Building ...");
            CategoryNode cb = new CategoryNode();
            cb.name = "Context Programming Book " + ed.ToString();
            cb.note = "Contains category description from uHunt server";
            cb.branches = new System.Collections.Generic.List<CategoryNode>();

            //getting top branches
            foreach (var o in (Newtonsoft.Json.Linq.JArray)alldat)
            {
                //add new branch
                CategoryNode b1 = new CategoryNode();
                b1.branches = new System.Collections.Generic.List<CategoryNode>();
                cb.branches.Add(b1);
                //extract name of the branch
                b1.name = o.Value<string>("title");
                //get sub branches
                foreach (var o2 in o.Value<Newtonsoft.Json.Linq.JArray>("arr"))
                {
                    //add new branch
                    CategoryNode b2 = new CategoryNode();
                    b2.branches = new System.Collections.Generic.List<CategoryNode>();
                    b1.branches.Add(b2);
                    //extract name of the branch
                    b2.name = o2.Value<string>("title");
                    //get sub branches
                    foreach (var o3 in o2.Value<Newtonsoft.Json.Linq.JArray>("arr"))
                    {
                        //add new branch
                        CategoryNode b3 = new CategoryNode();
                        b3.problems = new System.Collections.Generic.List<CategoryProblem>();
                        b2.branches.Add(b3);
                        //extract name  
                        var o4 = (Newtonsoft.Json.Linq.JArray)o3;
                        b3.name = o4[0].ToString(); 
                        for (int i = 1; i < o4.Count; ++i)
                        {
                            //add category problem
                            CategoryProblem p1 = new CategoryProblem();
                            b3.problems.Add(p1);
                            //extract values
                            int pn = (int)o4[i].ToObject(typeof(int));
                            p1.pnum = (pn < 0 ? -pn : pn);
                            p1.star = (pn < 0);
                        }
                    }

                }
            }

            Console.WriteLine("Saving Data...");
            json = Newtonsoft.Json.JsonConvert.SerializeObject(cb, Newtonsoft.Json.Formatting.Indented);
            System.IO.File.WriteAllText(path, json);
            Console.WriteLine("Process completed.\n");
        }
    }
}
