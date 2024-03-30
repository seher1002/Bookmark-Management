using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmarkManager
{
    public class Favorites : Bookmark
    {

        public Favorites(string name, string link, string keywords) : base(name, link, keywords)
        {

        }

        public void AddFavorite(Form1 fereastra)
        {
            fereastra.treeView1.SelectedNode.BackColor = Color.Yellow;

        }
    }
}
