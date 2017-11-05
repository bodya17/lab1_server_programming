namespace Interface
{
    partial class AuthorEditForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.save_author_btn = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // save_author_btn
            // 
            this.save_author_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.save_author_btn.Location = new System.Drawing.Point(52, 226);
            this.save_author_btn.Name = "save_author_btn";
            this.save_author_btn.Size = new System.Drawing.Size(135, 23);
            this.save_author_btn.TabIndex = 0;
            this.save_author_btn.Text = "Save changes";
            this.save_author_btn.UseVisualStyleBackColor = true;
            this.save_author_btn.Click += new System.EventHandler(this.save_author_btn_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(49, 41);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // AuthorEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.save_author_btn);
            this.Location = new System.Drawing.Point(20, 20);
            this.Margin = new System.Windows.Forms.Padding(20);
            this.Name = "AuthorEditForm";
            this.Size = new System.Drawing.Size(298, 274);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_author_btn;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox textBox1;
    }
}
