namespace WebBrowser.UI
{
    partial class HistoryManagerForm
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
            this.listBoxHistoryManager = new System.Windows.Forms.ListBox();
            this.textBoxHistorySearch = new System.Windows.Forms.TextBox();
            this.buttonHistorySearch = new System.Windows.Forms.Button();
            this.buttonDeleteHistoryItem = new System.Windows.Forms.Button();
            this.buttonClearHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxHistoryManager
            // 
            this.listBoxHistoryManager.FormattingEnabled = true;
            this.listBoxHistoryManager.Location = new System.Drawing.Point(0, 0);
            this.listBoxHistoryManager.Name = "listBoxHistoryManager";
            this.listBoxHistoryManager.Size = new System.Drawing.Size(800, 420);
            this.listBoxHistoryManager.TabIndex = 0;
            // 
            // textBoxHistorySearch
            // 
            this.textBoxHistorySearch.Location = new System.Drawing.Point(0, 426);
            this.textBoxHistorySearch.Name = "textBoxHistorySearch";
            this.textBoxHistorySearch.Size = new System.Drawing.Size(545, 20);
            this.textBoxHistorySearch.TabIndex = 1;
            // 
            // buttonHistorySearch
            // 
            this.buttonHistorySearch.Location = new System.Drawing.Point(551, 424);
            this.buttonHistorySearch.Name = "buttonHistorySearch";
            this.buttonHistorySearch.Size = new System.Drawing.Size(75, 23);
            this.buttonHistorySearch.TabIndex = 2;
            this.buttonHistorySearch.Text = "Search";
            this.buttonHistorySearch.UseVisualStyleBackColor = true;
            this.buttonHistorySearch.Click += new System.EventHandler(this.buttonHistorySearch_Click);
            // 
            // buttonDeleteHistoryItem
            // 
            this.buttonDeleteHistoryItem.Location = new System.Drawing.Point(632, 424);
            this.buttonDeleteHistoryItem.Name = "buttonDeleteHistoryItem";
            this.buttonDeleteHistoryItem.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteHistoryItem.TabIndex = 3;
            this.buttonDeleteHistoryItem.Text = "Delete";
            this.buttonDeleteHistoryItem.UseVisualStyleBackColor = true;
            this.buttonDeleteHistoryItem.Click += new System.EventHandler(this.buttonDeleteHistoryItem_Click);
            // 
            // buttonClearHistory
            // 
            this.buttonClearHistory.Location = new System.Drawing.Point(713, 424);
            this.buttonClearHistory.Name = "buttonClearHistory";
            this.buttonClearHistory.Size = new System.Drawing.Size(75, 23);
            this.buttonClearHistory.TabIndex = 4;
            this.buttonClearHistory.Text = "Clear";
            this.buttonClearHistory.UseVisualStyleBackColor = true;
            this.buttonClearHistory.Click += new System.EventHandler(this.buttonClearHistory_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClearHistory);
            this.Controls.Add(this.buttonDeleteHistoryItem);
            this.Controls.Add(this.buttonHistorySearch);
            this.Controls.Add(this.textBoxHistorySearch);
            this.Controls.Add(this.listBoxHistoryManager);
            this.Name = "HistoryManagerForm";
            this.Text = "History Manager";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxHistoryManager;
        private System.Windows.Forms.TextBox textBoxHistorySearch;
        private System.Windows.Forms.Button buttonHistorySearch;
        private System.Windows.Forms.Button buttonDeleteHistoryItem;
        private System.Windows.Forms.Button buttonClearHistory;
    }
}