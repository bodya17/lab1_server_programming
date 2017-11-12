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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorEditForm));
            this.name_label = new System.Windows.Forms.Label();
            this.author_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.city_text_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.age_text_box = new System.Windows.Forms.TextBox();
            this.books_list = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.save_author_btn = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(73, 62);
            this.name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(53, 20);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Name";
            // 
            // author_name
            // 
            this.author_name.Location = new System.Drawing.Point(165, 59);
            this.author_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.author_name.Name = "author_name";
            this.author_name.Size = new System.Drawing.Size(148, 26);
            this.author_name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "City";
            // 
            // city_text_box
            // 
            this.city_text_box.Location = new System.Drawing.Point(165, 121);
            this.city_text_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.city_text_box.Name = "city_text_box";
            this.city_text_box.Size = new System.Drawing.Size(148, 26);
            this.city_text_box.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Age";
            // 
            // age_text_box
            // 
            this.age_text_box.Location = new System.Drawing.Point(165, 186);
            this.age_text_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.age_text_box.Name = "age_text_box";
            this.age_text_box.Size = new System.Drawing.Size(148, 26);
            this.age_text_box.TabIndex = 6;
            // 
            // books_list
            // 
            this.books_list.FormattingEnabled = true;
            this.books_list.ItemHeight = 20;
            this.books_list.Location = new System.Drawing.Point(423, 68);
            this.books_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.books_list.Name = "books_list";
            this.books_list.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.books_list.Size = new System.Drawing.Size(178, 144);
            this.books_list.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Books";
            // 
            // save_author_btn
            // 
            this.save_author_btn.ActiveControl = null;
            this.save_author_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_author_btn.Location = new System.Drawing.Point(395, 314);
            this.save_author_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save_author_btn.Name = "save_author_btn";
            this.save_author_btn.Size = new System.Drawing.Size(206, 85);
            this.save_author_btn.TabIndex = 9;
            this.save_author_btn.Text = "Save";
            this.save_author_btn.TileImage = ((System.Drawing.Image)(resources.GetObject("save_author_btn.TileImage")));
            this.save_author_btn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.save_author_btn.UseSelectable = true;
            this.save_author_btn.UseTileImage = true;
            // 
            // AuthorEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.save_author_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.books_list);
            this.Controls.Add(this.age_text_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.city_text_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.author_name);
            this.Controls.Add(this.name_label);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Location = new System.Drawing.Point(20, 20);
            this.Margin = new System.Windows.Forms.Padding(30, 31, 30, 31);
            this.Name = "AuthorEditForm";
            this.Size = new System.Drawing.Size(631, 439);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox author_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox city_text_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox age_text_box;
        private System.Windows.Forms.ListBox books_list;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTile save_author_btn;
    }
}
