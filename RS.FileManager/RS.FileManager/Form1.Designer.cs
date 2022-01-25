
namespace RS.FileManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FMTree = new System.Windows.Forms.TreeView();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.MoveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.searchMask = new System.Windows.Forms.TextBox();
            this.UpdateDisksBtn = new System.Windows.Forms.Button();
            this.searchResult = new System.Windows.Forms.ListView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.FMListView = new System.Windows.Forms.ListView();
            this.iconsList = new System.Windows.Forms.ImageList(this.components);
            this.textBoxPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // FMTree
            // 
            this.FMTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FMTree.Location = new System.Drawing.Point(1154, 145);
            this.FMTree.Name = "FMTree";
            this.FMTree.Size = new System.Drawing.Size(89, 53);
            this.FMTree.TabIndex = 0;
            this.FMTree.DoubleClick += new System.EventHandler(this.FMTree_DoubleClick);
            // 
            // CopyBtn
            // 
            this.CopyBtn.Location = new System.Drawing.Point(12, 489);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(89, 23);
            this.CopyBtn.TabIndex = 1;
            this.CopyBtn.Text = "Копировать";
            this.CopyBtn.UseVisualStyleBackColor = true;
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // MoveBtn
            // 
            this.MoveBtn.Location = new System.Drawing.Point(107, 489);
            this.MoveBtn.Name = "MoveBtn";
            this.MoveBtn.Size = new System.Drawing.Size(89, 23);
            this.MoveBtn.TabIndex = 2;
            this.MoveBtn.Text = "Переместить";
            this.MoveBtn.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(202, 489);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(89, 23);
            this.DeleteBtn.TabIndex = 3;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // searchMask
            // 
            this.searchMask.Location = new System.Drawing.Point(761, 45);
            this.searchMask.Name = "searchMask";
            this.searchMask.Size = new System.Drawing.Size(184, 23);
            this.searchMask.TabIndex = 4;
            this.searchMask.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchMask_KeyUp);
            // 
            // UpdateDisksBtn
            // 
            this.UpdateDisksBtn.Location = new System.Drawing.Point(578, 12);
            this.UpdateDisksBtn.Name = "UpdateDisksBtn";
            this.UpdateDisksBtn.Size = new System.Drawing.Size(173, 23);
            this.UpdateDisksBtn.TabIndex = 5;
            this.UpdateDisksBtn.Text = "Обновить список дисков";
            this.UpdateDisksBtn.UseVisualStyleBackColor = true;
            this.UpdateDisksBtn.Click += new System.EventHandler(this.UpdateDisksBtn_Click);
            // 
            // searchResult
            // 
            this.searchResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchResult.HideSelection = false;
            this.searchResult.Location = new System.Drawing.Point(1154, 45);
            this.searchResult.Name = "searchResult";
            this.searchResult.Size = new System.Drawing.Size(103, 89);
            this.searchResult.TabIndex = 6;
            this.searchResult.UseCompatibleStateImageBehavior = false;
            this.searchResult.View = System.Windows.Forms.View.List;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // FMListView
            // 
            this.FMListView.HideSelection = false;
            this.FMListView.Location = new System.Drawing.Point(12, 84);
            this.FMListView.MultiSelect = false;
            this.FMListView.Name = "FMListView";
            this.FMListView.Size = new System.Drawing.Size(933, 399);
            this.FMListView.TabIndex = 7;
            this.FMListView.UseCompatibleStateImageBehavior = false;
            // 
            // iconsList
            // 
            this.iconsList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.iconsList.ImageSize = new System.Drawing.Size(32, 32);
            this.iconsList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(12, 45);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(559, 23);
            this.textBoxPath.TabIndex = 8;
            this.textBoxPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxPath_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 526);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.FMListView);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.UpdateDisksBtn);
            this.Controls.Add(this.searchMask);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.MoveBtn);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.FMTree);
            this.Name = "Form1";
            this.Text = "Мой файловый менеджер";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView FMTree;
        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.Button MoveBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox searchMask;
        private System.Windows.Forms.Button UpdateDisksBtn;
        private System.Windows.Forms.ListView searchResult;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ListView FMListView;
        private System.Windows.Forms.ImageList iconsList;
        private System.Windows.Forms.TextBox textBoxPath;
    }
}

