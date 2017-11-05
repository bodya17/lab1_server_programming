namespace Interface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.save_book_to_db_btn = new System.Windows.Forms.Button();
            this.book_name_label = new System.Windows.Forms.Label();
            this.book_author_label = new System.Windows.Forms.Label();
            this.delete_book_btn = new System.Windows.Forms.Button();
            this.book_heading = new System.Windows.Forms.Label();
            this.author_heading = new System.Windows.Forms.Label();
            this.author_name_text_box = new System.Windows.Forms.TextBox();
            this.author_label = new System.Windows.Forms.Label();
            this.save_author_to_db_button = new System.Windows.Forms.Button();
            this.authors_list = new System.Windows.Forms.ListBox();
            this.delete_author_btn = new System.Windows.Forms.Button();
            this.edit_book_btn = new System.Windows.Forms.Button();
            this.book_data_grid = new MetroFramework.Controls.MetroGrid();
            this.author_data_grid = new MetroFramework.Controls.MetroGrid();
            this.book_name_text_box = new System.Windows.Forms.TextBox();
            this.edit_author_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.book_data_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.author_data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // save_book_to_db_btn
            // 
            this.save_book_to_db_btn.Location = new System.Drawing.Point(217, 522);
            this.save_book_to_db_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save_book_to_db_btn.Name = "save_book_to_db_btn";
            this.save_book_to_db_btn.Size = new System.Drawing.Size(112, 35);
            this.save_book_to_db_btn.TabIndex = 0;
            this.save_book_to_db_btn.Text = "Save to DB";
            this.save_book_to_db_btn.UseVisualStyleBackColor = true;
            this.save_book_to_db_btn.Click += new System.EventHandler(this.createNewBookInDb);
            // 
            // book_name_label
            // 
            this.book_name_label.AutoSize = true;
            this.book_name_label.Location = new System.Drawing.Point(115, 110);
            this.book_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.book_name_label.Name = "book_name_label";
            this.book_name_label.Size = new System.Drawing.Size(35, 20);
            this.book_name_label.TabIndex = 3;
            this.book_name_label.Text = "Title";
            // 
            // book_author_label
            // 
            this.book_author_label.AutoSize = true;
            this.book_author_label.Location = new System.Drawing.Point(364, 107);
            this.book_author_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.book_author_label.Name = "book_author_label";
            this.book_author_label.Size = new System.Drawing.Size(58, 20);
            this.book_author_label.TabIndex = 4;
            this.book_author_label.Text = "Author";
            // 
            // delete_book_btn
            // 
            this.delete_book_btn.Location = new System.Drawing.Point(356, 522);
            this.delete_book_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delete_book_btn.Name = "delete_book_btn";
            this.delete_book_btn.Size = new System.Drawing.Size(158, 35);
            this.delete_book_btn.TabIndex = 6;
            this.delete_book_btn.Text = "Delete selected";
            this.delete_book_btn.UseVisualStyleBackColor = true;
            this.delete_book_btn.Click += new System.EventHandler(this.deleteFromDb);
            // 
            // book_heading
            // 
            this.book_heading.AutoSize = true;
            this.book_heading.Font = new System.Drawing.Font("Arial", 18.215F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.book_heading.Location = new System.Drawing.Point(339, 41);
            this.book_heading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.book_heading.Name = "book_heading";
            this.book_heading.Size = new System.Drawing.Size(83, 28);
            this.book_heading.TabIndex = 7;
            this.book_heading.Text = "Books";
            // 
            // author_heading
            // 
            this.author_heading.AutoSize = true;
            this.author_heading.Font = new System.Drawing.Font("Arial", 18.215F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author_heading.Location = new System.Drawing.Point(1032, 41);
            this.author_heading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.author_heading.Name = "author_heading";
            this.author_heading.Size = new System.Drawing.Size(99, 28);
            this.author_heading.TabIndex = 8;
            this.author_heading.Text = "Authors";
            // 
            // author_name_text_box
            // 
            this.author_name_text_box.Location = new System.Drawing.Point(939, 104);
            this.author_name_text_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.author_name_text_box.Name = "author_name_text_box";
            this.author_name_text_box.Size = new System.Drawing.Size(148, 26);
            this.author_name_text_box.TabIndex = 11;
            // 
            // author_label
            // 
            this.author_label.AutoSize = true;
            this.author_label.Location = new System.Drawing.Point(827, 107);
            this.author_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(104, 20);
            this.author_label.TabIndex = 12;
            this.author_label.Text = "Author name";
            // 
            // save_author_to_db_button
            // 
            this.save_author_to_db_button.Location = new System.Drawing.Point(831, 525);
            this.save_author_to_db_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save_author_to_db_button.Name = "save_author_to_db_button";
            this.save_author_to_db_button.Size = new System.Drawing.Size(112, 35);
            this.save_author_to_db_button.TabIndex = 13;
            this.save_author_to_db_button.Text = "Save to DB";
            this.save_author_to_db_button.UseVisualStyleBackColor = true;
            this.save_author_to_db_button.Click += new System.EventHandler(this.saveAuthorToDB);
            // 
            // authors_list
            // 
            this.authors_list.FormattingEnabled = true;
            this.authors_list.ItemHeight = 20;
            this.authors_list.Location = new System.Drawing.Point(430, 107);
            this.authors_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.authors_list.Name = "authors_list";
            this.authors_list.Size = new System.Drawing.Size(178, 144);
            this.authors_list.TabIndex = 14;
            // 
            // delete_author_btn
            // 
            this.delete_author_btn.Location = new System.Drawing.Point(1118, 525);
            this.delete_author_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delete_author_btn.Name = "delete_author_btn";
            this.delete_author_btn.Size = new System.Drawing.Size(141, 35);
            this.delete_author_btn.TabIndex = 15;
            this.delete_author_btn.Text = "Delete Selected";
            this.delete_author_btn.UseVisualStyleBackColor = true;
            this.delete_author_btn.Click += new System.EventHandler(this.delete_author_btn_Click);
            // 
            // edit_book_btn
            // 
            this.edit_book_btn.Location = new System.Drawing.Point(63, 523);
            this.edit_book_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edit_book_btn.Name = "edit_book_btn";
            this.edit_book_btn.Size = new System.Drawing.Size(112, 34);
            this.edit_book_btn.TabIndex = 17;
            this.edit_book_btn.Text = "Edit";
            this.edit_book_btn.UseVisualStyleBackColor = true;
            this.edit_book_btn.Click += new System.EventHandler(this.edit_book_btn_Click);
            // 
            // book_data_grid
            // 
            this.book_data_grid.AllowUserToResizeRows = false;
            this.book_data_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.book_data_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.book_data_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.book_data_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.book_data_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.book_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.book_data_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.book_data_grid.EnableHeadersVisualStyles = false;
            this.book_data_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.book_data_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.book_data_grid.Location = new System.Drawing.Point(63, 261);
            this.book_data_grid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.book_data_grid.Name = "book_data_grid";
            this.book_data_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.book_data_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.book_data_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.book_data_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.book_data_grid.Size = new System.Drawing.Size(676, 229);
            this.book_data_grid.TabIndex = 18;
            this.book_data_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showImage);
            // 
            // author_data_grid
            // 
            this.author_data_grid.AllowUserToResizeRows = false;
            this.author_data_grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.author_data_grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.author_data_grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.author_data_grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.author_data_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.author_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.author_data_grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.author_data_grid.EnableHeadersVisualStyles = false;
            this.author_data_grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.author_data_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.author_data_grid.Location = new System.Drawing.Point(831, 219);
            this.author_data_grid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.author_data_grid.Name = "author_data_grid";
            this.author_data_grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.author_data_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.author_data_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.author_data_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.author_data_grid.Size = new System.Drawing.Size(750, 229);
            this.author_data_grid.TabIndex = 19;
            // 
            // book_name_text_box
            // 
            this.book_name_text_box.Location = new System.Drawing.Point(157, 110);
            this.book_name_text_box.Name = "book_name_text_box";
            this.book_name_text_box.Size = new System.Drawing.Size(123, 26);
            this.book_name_text_box.TabIndex = 20;
            // 
            // edit_author_btn
            // 
            this.edit_author_btn.Location = new System.Drawing.Point(990, 525);
            this.edit_author_btn.Name = "edit_author_btn";
            this.edit_author_btn.Size = new System.Drawing.Size(97, 35);
            this.edit_author_btn.TabIndex = 21;
            this.edit_author_btn.Text = "Edit Author";
            this.edit_author_btn.UseVisualStyleBackColor = true;
            this.edit_author_btn.Click += new System.EventHandler(this.edit_author_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 694);
            this.Controls.Add(this.edit_author_btn);
            this.Controls.Add(this.book_name_text_box);
            this.Controls.Add(this.author_data_grid);
            this.Controls.Add(this.book_data_grid);
            this.Controls.Add(this.edit_book_btn);
            this.Controls.Add(this.delete_author_btn);
            this.Controls.Add(this.authors_list);
            this.Controls.Add(this.save_author_to_db_button);
            this.Controls.Add(this.author_label);
            this.Controls.Add(this.author_name_text_box);
            this.Controls.Add(this.author_heading);
            this.Controls.Add(this.book_heading);
            this.Controls.Add(this.delete_book_btn);
            this.Controls.Add(this.book_author_label);
            this.Controls.Add(this.book_name_label);
            this.Controls.Add(this.save_book_to_db_btn);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.book_data_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.author_data_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_book_to_db_btn;
        private System.Windows.Forms.Label book_name_label;
        private System.Windows.Forms.Label book_author_label;
        private System.Windows.Forms.Button delete_book_btn;
        private System.Windows.Forms.Label book_heading;
        private System.Windows.Forms.Label author_heading;
        private System.Windows.Forms.TextBox author_name_text_box;
        private System.Windows.Forms.Label author_label;
        private System.Windows.Forms.Button save_author_to_db_button;
        private System.Windows.Forms.ListBox authors_list;
        private System.Windows.Forms.Button delete_author_btn;
        private System.Windows.Forms.Button edit_book_btn;
        private MetroFramework.Controls.MetroGrid book_data_grid;
        private MetroFramework.Controls.MetroGrid author_data_grid;
        private System.Windows.Forms.TextBox book_name_text_box;
        private System.Windows.Forms.Button edit_author_btn;
    }
}

