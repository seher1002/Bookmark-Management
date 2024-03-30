using System.Windows.Forms;

namespace BookmarkManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLink = new System.Windows.Forms.TextBox();
            this.textBoxKeywords = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLink = new System.Windows.Forms.Label();
            this.labelKeywords = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonAbc = new System.Windows.Forms.Button();
            this.addToFav = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.abc2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(80, 12);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(160, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxLink
            // 
            this.textBoxLink.Location = new System.Drawing.Point(80, 39);
            this.textBoxLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLink.Name = "textBoxLink";
            this.textBoxLink.Size = new System.Drawing.Size(160, 22);
            this.textBoxLink.TabIndex = 1;
            // 
            // textBoxKeywords
            // 
            this.textBoxKeywords.Location = new System.Drawing.Point(80, 69);
            this.textBoxKeywords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxKeywords.Name = "textBoxKeywords";
            this.textBoxKeywords.Size = new System.Drawing.Size(160, 22);
            this.textBoxKeywords.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 18);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 16);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name";
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(3, 46);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(31, 16);
            this.labelLink.TabIndex = 4;
            this.labelLink.Text = "Link";
            // 
            // labelKeywords
            // 
            this.labelKeywords.AutoSize = true;
            this.labelKeywords.Location = new System.Drawing.Point(3, 71);
            this.labelKeywords.Name = "labelKeywords";
            this.labelKeywords.Size = new System.Drawing.Size(70, 16);
            this.labelKeywords.TabIndex = 5;
            this.labelKeywords.Text = "KeyWords";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(5, 138);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(284, 299);
            this.treeView1.TabIndex = 6;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(287, 11);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(73, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonAbc
            // 
            this.buttonAbc.Location = new System.Drawing.Point(109, 111);
            this.buttonAbc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAbc.Name = "buttonAbc";
            this.buttonAbc.Size = new System.Drawing.Size(75, 23);
            this.buttonAbc.TabIndex = 8;
            this.buttonAbc.Text = "ABC";
            this.buttonAbc.UseVisualStyleBackColor = true;
            this.buttonAbc.Click += new System.EventHandler(this.buttonAbc_Click);
            // 
            // addToFav
            // 
            this.addToFav.Location = new System.Drawing.Point(287, 41);
            this.addToFav.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addToFav.Name = "addToFav";
            this.addToFav.Size = new System.Drawing.Size(73, 23);
            this.addToFav.TabIndex = 9;
            this.addToFav.Text = "Favorit";
            this.addToFav.UseVisualStyleBackColor = true;
            this.addToFav.Click += new System.EventHandler(this.addToFav_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(287, 71);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(73, 23);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(337, 138);
            this.treeView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(300, 298);
            this.treeView2.TabIndex = 11;
            this.treeView2.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView2_NodeMouseDoubleClick);
            // 
            // abc2
            // 
            this.abc2.Location = new System.Drawing.Point(477, 111);
            this.abc2.Name = "abc2";
            this.abc2.Size = new System.Drawing.Size(75, 23);
            this.abc2.TabIndex = 12;
            this.abc2.Text = "ABC";
            this.abc2.UseVisualStyleBackColor = true;
            this.abc2.Click += new System.EventHandler(this.abc2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 446);
            this.Controls.Add(this.abc2);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.addToFav);
            this.Controls.Add(this.buttonAbc);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.labelKeywords);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxKeywords);
            this.Controls.Add(this.textBoxLink);
            this.Controls.Add(this.textBoxName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLink;
        private System.Windows.Forms.TextBox textBoxKeywords;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.Label labelKeywords;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonAbc;
        private Button addToFav;
        public TreeView treeView1;
        private Button buttonDelete;
        public TreeView treeView2;
        private Button abc2;
    }
}

