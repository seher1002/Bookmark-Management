using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmarkManager
{
    public class Bookmark
    {
        protected string Name;
        protected string Link;
        protected string Keywords;

        public Bookmark(string name, string link, string keywords)
        {
            Name = name;
            Link = link;
            Keywords = keywords;
        }

        public string getName()
        {
            return Name;
        }

        public string getLink()
        {
            return Link;
        }

        public string getKeywords()
        {
            return Keywords;
        }

        public void DeleteBookmark(Form1 fereastra)
        {   if (fereastra.treeView2.SelectedNode != null)
                fereastra.treeView2.SelectedNode.Remove();
            if(fereastra.treeView1.SelectedNode != null)
                fereastra.treeView1.SelectedNode.Remove();
        }
    }

}
