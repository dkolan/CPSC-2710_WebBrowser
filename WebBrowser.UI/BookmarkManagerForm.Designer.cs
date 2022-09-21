namespace WebBrowser.UI
{
    partial class BookmarkManagerForm
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
            this.listBoxBookmarkManager = new System.Windows.Forms.ListBox();
            this.textBoxBookmarkSearch = new System.Windows.Forms.TextBox();
            this.buttonBookmarkSearch = new System.Windows.Forms.Button();
            this.buttonBookmarkDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBookmarkManager
            // 
            this.listBoxBookmarkManager.FormattingEnabled = true;
            this.listBoxBookmarkManager.Location = new System.Drawing.Point(0, 0);
            this.listBoxBookmarkManager.Name = "listBoxBookmarkManager";
            this.listBoxBookmarkManager.Size = new System.Drawing.Size(800, 420);
            this.listBoxBookmarkManager.TabIndex = 0;
            // 
            // textBoxBookmarkSearch
            // 
            this.textBoxBookmarkSearch.Location = new System.Drawing.Point(0, 426);
            this.textBoxBookmarkSearch.Name = "textBoxBookmarkSearch";
            this.textBoxBookmarkSearch.Size = new System.Drawing.Size(626, 20);
            this.textBoxBookmarkSearch.TabIndex = 1;
            // 
            // buttonBookmarkSearch
            // 
            this.buttonBookmarkSearch.Location = new System.Drawing.Point(632, 424);
            this.buttonBookmarkSearch.Name = "buttonBookmarkSearch";
            this.buttonBookmarkSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonBookmarkSearch.TabIndex = 2;
            this.buttonBookmarkSearch.Text = "Search";
            this.buttonBookmarkSearch.UseVisualStyleBackColor = true;
            this.buttonBookmarkSearch.Click += new System.EventHandler(this.buttonBookmarkSearch_Click);
            // 
            // buttonBookmarkDelete
            // 
            this.buttonBookmarkDelete.Location = new System.Drawing.Point(713, 423);
            this.buttonBookmarkDelete.Name = "buttonBookmarkDelete";
            this.buttonBookmarkDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonBookmarkDelete.TabIndex = 3;
            this.buttonBookmarkDelete.Text = "Delete";
            this.buttonBookmarkDelete.UseVisualStyleBackColor = true;
            this.buttonBookmarkDelete.Click += new System.EventHandler(this.buttonBookmarkDelete_Click);
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBookmarkDelete);
            this.Controls.Add(this.buttonBookmarkSearch);
            this.Controls.Add(this.textBoxBookmarkSearch);
            this.Controls.Add(this.listBoxBookmarkManager);
            this.Name = "BookmarkManagerForm";
            this.Text = "Bookmark Manager";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBookmarkManager;
        private System.Windows.Forms.TextBox textBoxBookmarkSearch;
        private System.Windows.Forms.Button buttonBookmarkSearch;
        private System.Windows.Forms.Button buttonBookmarkDelete;
    }
}