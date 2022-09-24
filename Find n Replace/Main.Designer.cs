namespace Find_n_Replace
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.openFileBtn = new System.Windows.Forms.Button();
            this.pathBox = new System.Windows.Forms.ListBox();
            this.findNreplaceBtn = new System.Windows.Forms.Button();
            this.findBox = new System.Windows.Forms.TextBox();
            this.replaceBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.removeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.previewBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(255, 311);
            this.openFileBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(100, 28);
            this.openFileBtn.TabIndex = 0;
            this.openFileBtn.Text = "Open file";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // pathBox
            // 
            this.pathBox.AllowDrop = true;
            this.pathBox.FormattingEnabled = true;
            this.pathBox.ItemHeight = 16;
            this.pathBox.Location = new System.Drawing.Point(43, 39);
            this.pathBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pathBox.Name = "pathBox";
            this.pathBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.pathBox.Size = new System.Drawing.Size(436, 260);
            this.pathBox.TabIndex = 1;
            this.pathBox.SelectedIndexChanged += new System.EventHandler(this.pathBox_SelectedIndexChanged);
            this.pathBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pathBox_DragDrop);
            this.pathBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.pathBox_DragEnter);
            this.pathBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pathBox_KeyDown);
            // 
            // findNreplaceBtn
            // 
            this.findNreplaceBtn.Location = new System.Drawing.Point(363, 311);
            this.findNreplaceBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findNreplaceBtn.Name = "findNreplaceBtn";
            this.findNreplaceBtn.Size = new System.Drawing.Size(117, 66);
            this.findNreplaceBtn.TabIndex = 2;
            this.findNreplaceBtn.Text = "Find and Replace";
            this.findNreplaceBtn.UseVisualStyleBackColor = true;
            this.findNreplaceBtn.Click += new System.EventHandler(this.findNreplaceBtn_Click);
            // 
            // findBox
            // 
            this.findBox.Location = new System.Drawing.Point(113, 315);
            this.findBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.findBox.Name = "findBox";
            this.findBox.Size = new System.Drawing.Size(132, 22);
            this.findBox.TabIndex = 4;
            // 
            // replaceBox
            // 
            this.replaceBox.Location = new System.Drawing.Point(113, 353);
            this.replaceBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.replaceBox.Name = "replaceBox";
            this.replaceBox.Size = new System.Drawing.Size(132, 22);
            this.replaceBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 319);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 357);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Replace";
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(255, 350);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(100, 28);
            this.removeBtn.TabIndex = 6;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Text Files:";
            // 
            // previewBox
            // 
            this.previewBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.previewBox.Location = new System.Drawing.Point(503, 39);
            this.previewBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.previewBox.Multiline = true;
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(205, 260);
            this.previewBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preview:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 395);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.replaceBox);
            this.Controls.Add(this.findBox);
            this.Controls.Add(this.findNreplaceBtn);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.openFileBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Find and Replace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.ListBox pathBox;
        private System.Windows.Forms.Button findNreplaceBtn;
        private System.Windows.Forms.TextBox findBox;
        private System.Windows.Forms.TextBox replaceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox previewBox;
        private System.Windows.Forms.Label label4;
    }
}

