using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookmarkManager
{
    public partial class Form1 : Form
    {
        private Favorites favorite = new Favorites("name", "link", "keywords");
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)

        {   
            Bookmark bookmark = new Bookmark(textBoxName.Text, textBoxLink.Text, textBoxKeywords.Text);

            // Caută sau creează nodul cuvintelor cheie
            TreeNode keywordsNode = FindOrCreateNode(treeView1.Nodes, bookmark.getKeywords());

            // Caută sau creează nodul numelui sub nodul cuvintelor cheie
            TreeNode nameNode = FindOrCreateNode(keywordsNode.Nodes, bookmark.getName());

            // Adaugă link-ul ca sub-nod al nodului numelui
            TreeNode linkNode = new TreeNode(bookmark.getLink());
            nameNode.Nodes.Add(linkNode);

            
        }


        private TreeNode FindOrCreateNode(TreeNodeCollection nodes, string text)
        {
            foreach (TreeNode node in nodes)
            {
                if (node.Text == text)
                    return node;
            }
        
            TreeNode newNode = new TreeNode(text);
            nodes.Add(newNode);
            return newNode;
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Verifică dacă nodul are un nod părinte și este la nivelul link-ului
            if (e.Node.Parent != null && e.Node.Parent.Parent != null)
            {
                string url = e.Node.Text;
                System.Diagnostics.Process.Start(url);

            }

        }

        private void buttonAbc_Click(object sender, EventArgs e)
        {
            treeView1.Sort();
        }

        private void addToFav_Click(object sender, EventArgs e)
        {
            Favorites favorite = new Favorites(treeView1.SelectedNode.LastNode.Text, treeView1.SelectedNode.LastNode.LastNode.Text, treeView1.SelectedNode.Text);
            favorite.AddFavorite(this);
            TreeNode keywordsNode = FindOrCreateNode(treeView2.Nodes, favorite.getKeywords());
            TreeNode nameNode = FindOrCreateNode(keywordsNode.Nodes, favorite.getName());
            TreeNode linkNode = new TreeNode(favorite.getLink());
            nameNode.Nodes.Add(linkNode);

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            favorite.DeleteBookmark(this);
        }

        private void abc2_Click(object sender, EventArgs e)
        {
            treeView2.Sort();
        }

        private void treeView2_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent != null && e.Node.Parent.Parent != null)
            {
                string url = e.Node.Text;
                //Accesare link
                System.Diagnostics.Process.Start(url);

            }


        }
    }
    }
