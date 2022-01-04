
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
            this.FMTree = new System.Windows.Forms.TreeView();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.MoveBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UpdateDisksBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FMTree
            // 
            this.FMTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FMTree.Location = new System.Drawing.Point(12, 74);
            this.FMTree.Name = "FMTree";
            this.FMTree.Size = new System.Drawing.Size(776, 401);
            this.FMTree.TabIndex = 0;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 23);
            this.textBox1.TabIndex = 4;
            // 
            // UpdateDisksBtn
            // 
            this.UpdateDisksBtn.Location = new System.Drawing.Point(615, 12);
            this.UpdateDisksBtn.Name = "UpdateDisksBtn";
            this.UpdateDisksBtn.Size = new System.Drawing.Size(173, 23);
            this.UpdateDisksBtn.TabIndex = 5;
            this.UpdateDisksBtn.Text = "Обновить список дисков";
            this.UpdateDisksBtn.UseVisualStyleBackColor = true;
            this.UpdateDisksBtn.Click += new System.EventHandler(this.UpdateDisksBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.UpdateDisksBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.MoveBtn);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.FMTree);
            this.Name = "Form1";
            this.Text = "Мой файловый менеджер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView FMTree;
        private System.Windows.Forms.Button CopyBtn;
        private System.Windows.Forms.Button MoveBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button UpdateDisksBtn;
    }
}

