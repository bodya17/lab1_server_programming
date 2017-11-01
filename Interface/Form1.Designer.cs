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
            this.save_book_to_db_btn = new System.Windows.Forms.Button();
            this.book_name_text_box = new System.Windows.Forms.TextBox();
            this.book_name_label = new System.Windows.Forms.Label();
            this.book_author_label = new System.Windows.Forms.Label();
            this.delete_book_btn = new System.Windows.Forms.Button();
            this.book_heading = new System.Windows.Forms.Label();
            this.author_heading = new System.Windows.Forms.Label();
            this.author_data_grid = new System.Windows.Forms.DataGridView();
            this.author_name_text_box = new System.Windows.Forms.TextBox();
            this.author_label = new System.Windows.Forms.Label();
            this.save_author_to_db_button = new System.Windows.Forms.Button();
            this.authors_list = new System.Windows.Forms.ListBox();
            this.delete_author_btn = new System.Windows.Forms.Button();
            this.edit_book_btn = new System.Windows.Forms.Button();
            this.book_data_grid = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.author_data_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_data_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // save_book_to_db_btn
            // 
            this.save_book_to_db_btn.Location = new System.Drawing.Point(307, 340);
            this.save_book_to_db_btn.Name = "save_book_to_db_btn";
            this.save_book_to_db_btn.Size = new System.Drawing.Size(75, 23);
            this.save_book_to_db_btn.TabIndex = 0;
            this.save_book_to_db_btn.Text = "Save to DB";
            this.save_book_to_db_btn.UseVisualStyleBackColor = true;
            this.save_book_to_db_btn.Click += new System.EventHandler(this.createNewBookInDb);
            // 
            // book_name_text_box
            // 
            this.book_name_text_box.Location = new System.Drawing.Point(112, 51);
            this.book_name_text_box.Name = "book_name_text_box";
            this.book_name_text_box.Size = new System.Drawing.Size(100, 20);
            this.book_name_text_box.TabIndex = 1;
            // 
            // book_name_label
            // 
            this.book_name_label.AutoSize = true;
            this.book_name_label.Location = new System.Drawing.Point(79, 54);
            this.book_name_label.Name = "book_name_label";
            this.book_name_label.Size = new System.Drawing.Size(27, 13);
            this.book_name_label.TabIndex = 3;
            this.book_name_label.Text = "Title";
            // 
            // book_author_label
            // 
            this.book_author_label.AutoSize = true;
            this.book_author_label.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.book_author_label.Location = new System.Drawing.Point(262, 51);
            this.book_author_label.Name = "book_author_label";
            this.book_author_label.Size = new System.Drawing.Size(42, 16);
            this.book_author_label.TabIndex = 4;
            this.book_author_label.Text = "Author";
            // 
            // delete_book_btn
            // 
            this.delete_book_btn.Location = new System.Drawing.Point(388, 340);
            this.delete_book_btn.Name = "delete_book_btn";
            this.delete_book_btn.Size = new System.Drawing.Size(105, 23);
            this.delete_book_btn.TabIndex = 6;
            this.delete_book_btn.Text = "Delete selected";
            this.delete_book_btn.UseVisualStyleBackColor = true;
            this.delete_book_btn.Click += new System.EventHandler(this.deleteFromDb);
            // 
            // book_heading
            // 
            this.book_heading.AutoSize = true;
            this.book_heading.Font = new System.Drawing.Font("Arial", 18.215F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.book_heading.Location = new System.Drawing.Point(234, 9);
            this.book_heading.Name = "book_heading";
            this.book_heading.Size = new System.Drawing.Size(83, 28);
            this.book_heading.TabIndex = 7;
            this.book_heading.Text = "Books";
            // 
            // author_heading
            // 
            this.author_heading.AutoSize = true;
            this.author_heading.Font = new System.Drawing.Font("Arial", 18.215F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author_heading.Location = new System.Drawing.Point(688, 9);
            this.author_heading.Name = "author_heading";
            this.author_heading.Size = new System.Drawing.Size(99, 28);
            this.author_heading.TabIndex = 8;
            this.author_heading.Text = "Authors";
            // 
            // author_data_grid
            // 
            this.author_data_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.author_data_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.author_data_grid.Location = new System.Drawing.Point(542, 142);
            this.author_data_grid.Name = "author_data_grid";
            this.author_data_grid.Size = new System.Drawing.Size(436, 150);
            this.author_data_grid.TabIndex = 9;
            // 
            // author_name_text_box
            // 
            this.author_name_text_box.Location = new System.Drawing.Point(663, 57);
            this.author_name_text_box.Name = "author_name_text_box";
            this.author_name_text_box.Size = new System.Drawing.Size(100, 20);
            this.author_name_text_box.TabIndex = 11;
            // 
            // author_label
            // 
            this.author_label.AutoSize = true;
            this.author_label.Location = new System.Drawing.Point(581, 60);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(67, 13);
            this.author_label.TabIndex = 12;
            this.author_label.Text = "Author name";
            // 
            // save_author_to_db_button
            // 
            this.save_author_to_db_button.Location = new System.Drawing.Point(789, 57);
            this.save_author_to_db_button.Name = "save_author_to_db_button";
            this.save_author_to_db_button.Size = new System.Drawing.Size(75, 23);
            this.save_author_to_db_button.TabIndex = 13;
            this.save_author_to_db_button.Text = "Save to DB";
            this.save_author_to_db_button.UseVisualStyleBackColor = true;
            this.save_author_to_db_button.Click += new System.EventHandler(this.saveAuthorToDB);
            // 
            // authors_list
            // 
            this.authors_list.FormattingEnabled = true;
            this.authors_list.Location = new System.Drawing.Point(307, 51);
            this.authors_list.Name = "authors_list";
            this.authors_list.Size = new System.Drawing.Size(120, 95);
            this.authors_list.TabIndex = 14;
            // 
            // delete_author_btn
            // 
            this.delete_author_btn.Location = new System.Drawing.Point(870, 57);
            this.delete_author_btn.Name = "delete_author_btn";
            this.delete_author_btn.Size = new System.Drawing.Size(94, 23);
            this.delete_author_btn.TabIndex = 15;
            this.delete_author_btn.Text = "Delete Selected";
            this.delete_author_btn.UseVisualStyleBackColor = true;
            this.delete_author_btn.Click += new System.EventHandler(this.delete_author_btn_Click);
            // 
            // edit_book_btn
            // 
            this.edit_book_btn.Location = new System.Drawing.Point(225, 341);
            this.edit_book_btn.Name = "edit_book_btn";
            this.edit_book_btn.Size = new System.Drawing.Size(75, 22);
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
            this.book_data_grid.Location = new System.Drawing.Point(42, 152);
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
            this.book_data_grid.Size = new System.Drawing.Size(451, 149);
            this.book_data_grid.TabIndex = 18;
            this.book_data_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showImage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 451);
            this.Controls.Add(this.book_data_grid);
            this.Controls.Add(this.edit_book_btn);
            this.Controls.Add(this.delete_author_btn);
            this.Controls.Add(this.authors_list);
            this.Controls.Add(this.save_author_to_db_button);
            this.Controls.Add(this.author_label);
            this.Controls.Add(this.author_name_text_box);
            this.Controls.Add(this.author_data_grid);
            this.Controls.Add(this.author_heading);
            this.Controls.Add(this.book_heading);
            this.Controls.Add(this.delete_book_btn);
            this.Controls.Add(this.book_author_label);
            this.Controls.Add(this.book_name_label);
            this.Controls.Add(this.book_name_text_box);
            this.Controls.Add(this.save_book_to_db_btn);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.author_data_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_data_grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_book_to_db_btn;
        private System.Windows.Forms.TextBox book_name_text_box;
        private System.Windows.Forms.Label book_name_label;
        private System.Windows.Forms.Label book_author_label;
        private System.Windows.Forms.Button delete_book_btn;
        private System.Windows.Forms.Label book_heading;
        private System.Windows.Forms.Label author_heading;
        public System.Windows.Forms.DataGridView author_data_grid;
        private System.Windows.Forms.TextBox author_name_text_box;
        private System.Windows.Forms.Label author_label;
        private System.Windows.Forms.Button save_author_to_db_button;
        private System.Windows.Forms.ListBox authors_list;
        private System.Windows.Forms.Button delete_author_btn;
        private System.Windows.Forms.Button edit_book_btn;
        private MetroFramework.Controls.MetroGrid book_data_grid;
    }
}

