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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.book_name_label = new System.Windows.Forms.Label();
            this.book_author_label = new System.Windows.Forms.Label();
            this.book_heading = new System.Windows.Forms.Label();
            this.author_heading = new System.Windows.Forms.Label();
            this.author_name_text_box = new System.Windows.Forms.TextBox();
            this.author_label = new System.Windows.Forms.Label();
            this.authors_list = new System.Windows.Forms.ListBox();
            this.book_data_grid = new MetroFramework.Controls.MetroGrid();
            this.author_data_grid = new MetroFramework.Controls.MetroGrid();
            this.book_name_text_box = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete_author_btn = new MetroFramework.Controls.MetroTile();
            this.edit_author_btn = new MetroFramework.Controls.MetroTile();
            this.save_author_to_db_button = new MetroFramework.Controls.MetroTile();
            this.age_text_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.city_text_box = new System.Windows.Forms.TextBox();
            this.city_input = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.delete_book_btn = new MetroFramework.Controls.MetroTile();
            this.save_book_to_db_btn = new MetroFramework.Controls.MetroTile();
            this.edit_book_btn = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.book_data_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.author_data_grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // book_name_label
            // 
            this.book_name_label.AutoSize = true;
            this.book_name_label.Location = new System.Drawing.Point(48, 78);
            this.book_name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.book_name_label.Name = "book_name_label";
            this.book_name_label.Size = new System.Drawing.Size(35, 20);
            this.book_name_label.TabIndex = 3;
            this.book_name_label.Text = "Title";
            // 
            // book_author_label
            // 
            this.book_author_label.AutoSize = true;
            this.book_author_label.Location = new System.Drawing.Point(301, 81);
            this.book_author_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.book_author_label.Name = "book_author_label";
            this.book_author_label.Size = new System.Drawing.Size(58, 20);
            this.book_author_label.TabIndex = 4;
            this.book_author_label.Text = "Author";
            // 
            // book_heading
            // 
            this.book_heading.AutoSize = true;
            this.book_heading.Font = new System.Drawing.Font("Arial", 18.215F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.book_heading.Location = new System.Drawing.Point(16, 0);
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
            this.author_heading.Location = new System.Drawing.Point(16, 0);
            this.author_heading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.author_heading.Name = "author_heading";
            this.author_heading.Size = new System.Drawing.Size(99, 28);
            this.author_heading.TabIndex = 8;
            this.author_heading.Text = "Authors";
            // 
            // author_name_text_box
            // 
            this.author_name_text_box.Location = new System.Drawing.Point(266, 43);
            this.author_name_text_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.author_name_text_box.Name = "author_name_text_box";
            this.author_name_text_box.Size = new System.Drawing.Size(148, 26);
            this.author_name_text_box.TabIndex = 11;
            // 
            // author_label
            // 
            this.author_label.AutoSize = true;
            this.author_label.Location = new System.Drawing.Point(84, 43);
            this.author_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(104, 20);
            this.author_label.TabIndex = 12;
            this.author_label.Text = "Author name";
            // 
            // authors_list
            // 
            this.authors_list.FormattingEnabled = true;
            this.authors_list.ItemHeight = 20;
            this.authors_list.Location = new System.Drawing.Point(384, 43);
            this.authors_list.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.authors_list.Name = "authors_list";
            this.authors_list.Size = new System.Drawing.Size(178, 124);
            this.authors_list.TabIndex = 2;
            // 
            // book_data_grid
            // 
            this.book_data_grid.AllowUserToResizeRows = false;
            this.book_data_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.book_data_grid.Location = new System.Drawing.Point(21, 182);
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
            this.book_data_grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.book_data_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.book_data_grid.Size = new System.Drawing.Size(541, 133);
            this.book_data_grid.TabIndex = 3;
            this.book_data_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showImage);
            // 
            // author_data_grid
            // 
            this.author_data_grid.AllowUserToResizeRows = false;
            this.author_data_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.author_data_grid.Location = new System.Drawing.Point(21, 166);
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
            this.author_data_grid.Size = new System.Drawing.Size(463, 118);
            this.author_data_grid.TabIndex = 14;
            // 
            // book_name_text_box
            // 
            this.book_name_text_box.Location = new System.Drawing.Point(113, 78);
            this.book_name_text_box.Name = "book_name_text_box";
            this.book_name_text_box.Size = new System.Drawing.Size(123, 26);
            this.book_name_text_box.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete_author_btn);
            this.groupBox1.Controls.Add(this.edit_author_btn);
            this.groupBox1.Controls.Add(this.save_author_to_db_button);
            this.groupBox1.Controls.Add(this.age_text_box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.city_text_box);
            this.groupBox1.Controls.Add(this.city_input);
            this.groupBox1.Controls.Add(this.author_label);
            this.groupBox1.Controls.Add(this.author_data_grid);
            this.groupBox1.Controls.Add(this.author_name_text_box);
            this.groupBox1.Controls.Add(this.author_heading);
            this.groupBox1.Location = new System.Drawing.Point(665, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 406);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // delete_author_btn
            // 
            this.delete_author_btn.ActiveControl = null;
            this.delete_author_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_author_btn.Location = new System.Drawing.Point(364, 336);
            this.delete_author_btn.Name = "delete_author_btn";
            this.delete_author_btn.Size = new System.Drawing.Size(120, 62);
            this.delete_author_btn.TabIndex = 27;
            this.delete_author_btn.Text = "Delete";
            this.delete_author_btn.TileImage = ((System.Drawing.Image)(resources.GetObject("delete_author_btn.TileImage")));
            this.delete_author_btn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete_author_btn.UseSelectable = true;
            this.delete_author_btn.UseTileImage = true;
            this.delete_author_btn.Click += new System.EventHandler(this.delete_author_btn_Click);
            // 
            // edit_author_btn
            // 
            this.edit_author_btn.ActiveControl = null;
            this.edit_author_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_author_btn.Location = new System.Drawing.Point(21, 336);
            this.edit_author_btn.Name = "edit_author_btn";
            this.edit_author_btn.Size = new System.Drawing.Size(123, 62);
            this.edit_author_btn.TabIndex = 26;
            this.edit_author_btn.Text = "Edit";
            this.edit_author_btn.TileImage = ((System.Drawing.Image)(resources.GetObject("edit_author_btn.TileImage")));
            this.edit_author_btn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edit_author_btn.UseSelectable = true;
            this.edit_author_btn.UseTileImage = true;
            this.edit_author_btn.Click += new System.EventHandler(this.edit_author_btn_Click);
            // 
            // save_author_to_db_button
            // 
            this.save_author_to_db_button.ActiveControl = null;
            this.save_author_to_db_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_author_to_db_button.Location = new System.Drawing.Point(196, 336);
            this.save_author_to_db_button.Name = "save_author_to_db_button";
            this.save_author_to_db_button.Size = new System.Drawing.Size(122, 62);
            this.save_author_to_db_button.TabIndex = 25;
            this.save_author_to_db_button.Text = "Save";
            this.save_author_to_db_button.TileImage = ((System.Drawing.Image)(resources.GetObject("save_author_to_db_button.TileImage")));
            this.save_author_to_db_button.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.save_author_to_db_button.UseSelectable = true;
            this.save_author_to_db_button.UseTileImage = true;
            this.save_author_to_db_button.Click += new System.EventHandler(this.saveAuthorToDB);
            // 
            // age_text_box
            // 
            this.age_text_box.Location = new System.Drawing.Point(266, 119);
            this.age_text_box.Name = "age_text_box";
            this.age_text_box.Size = new System.Drawing.Size(148, 26);
            this.age_text_box.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Age";
            // 
            // city_text_box
            // 
            this.city_text_box.Location = new System.Drawing.Point(266, 81);
            this.city_text_box.Name = "city_text_box";
            this.city_text_box.Size = new System.Drawing.Size(148, 26);
            this.city_text_box.TabIndex = 12;
            // 
            // city_input
            // 
            this.city_input.AutoSize = true;
            this.city_input.Location = new System.Drawing.Point(84, 81);
            this.city_input.Name = "city_input";
            this.city_input.Size = new System.Drawing.Size(37, 20);
            this.city_input.TabIndex = 22;
            this.city_input.Text = "City";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.delete_book_btn);
            this.groupBox2.Controls.Add(this.save_book_to_db_btn);
            this.groupBox2.Controls.Add(this.edit_book_btn);
            this.groupBox2.Controls.Add(this.book_heading);
            this.groupBox2.Controls.Add(this.authors_list);
            this.groupBox2.Controls.Add(this.book_data_grid);
            this.groupBox2.Controls.Add(this.book_name_text_box);
            this.groupBox2.Controls.Add(this.book_author_label);
            this.groupBox2.Controls.Add(this.book_name_label);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 406);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // delete_book_btn
            // 
            this.delete_book_btn.ActiveControl = null;
            this.delete_book_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete_book_btn.Location = new System.Drawing.Point(426, 336);
            this.delete_book_btn.Name = "delete_book_btn";
            this.delete_book_btn.Size = new System.Drawing.Size(136, 62);
            this.delete_book_btn.TabIndex = 10;
            this.delete_book_btn.Text = "Delete";
            this.delete_book_btn.TileImage = ((System.Drawing.Image)(resources.GetObject("delete_book_btn.TileImage")));
            this.delete_book_btn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delete_book_btn.UseSelectable = true;
            this.delete_book_btn.UseTileImage = true;
            this.delete_book_btn.Click += new System.EventHandler(this.deleteBookFromDb);
            // 
            // save_book_to_db_btn
            // 
            this.save_book_to_db_btn.ActiveControl = null;
            this.save_book_to_db_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_book_to_db_btn.Location = new System.Drawing.Point(215, 336);
            this.save_book_to_db_btn.Name = "save_book_to_db_btn";
            this.save_book_to_db_btn.Size = new System.Drawing.Size(144, 64);
            this.save_book_to_db_btn.TabIndex = 9;
            this.save_book_to_db_btn.Text = "Save";
            this.save_book_to_db_btn.TileImage = ((System.Drawing.Image)(resources.GetObject("save_book_to_db_btn.TileImage")));
            this.save_book_to_db_btn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.save_book_to_db_btn.UseSelectable = true;
            this.save_book_to_db_btn.UseTileImage = true;
            this.save_book_to_db_btn.Click += new System.EventHandler(this.createNewBookInDb);
            // 
            // edit_book_btn
            // 
            this.edit_book_btn.ActiveControl = null;
            this.edit_book_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.edit_book_btn.Location = new System.Drawing.Point(21, 336);
            this.edit_book_btn.Name = "edit_book_btn";
            this.edit_book_btn.Size = new System.Drawing.Size(136, 64);
            this.edit_book_btn.TabIndex = 8;
            this.edit_book_btn.Text = "Edit";
            this.edit_book_btn.TileImage = ((System.Drawing.Image)(resources.GetObject("edit_book_btn.TileImage")));
            this.edit_book_btn.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.edit_book_btn.UseSelectable = true;
            this.edit_book_btn.UseTileImage = true;
            this.edit_book_btn.Click += new System.EventHandler(this.edit_book_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1200, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(30, 92, 30, 31);
            this.Text = "Book and Authors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.book_data_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.author_data_grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label book_name_label;
        private System.Windows.Forms.Label book_author_label;
        private System.Windows.Forms.Label book_heading;
        private System.Windows.Forms.Label author_heading;
        private System.Windows.Forms.TextBox author_name_text_box;
        private System.Windows.Forms.Label author_label;
        private System.Windows.Forms.ListBox authors_list;
        private MetroFramework.Controls.MetroGrid book_data_grid;
        private MetroFramework.Controls.MetroGrid author_data_grid;
        private System.Windows.Forms.TextBox book_name_text_box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox city_text_box;
        private System.Windows.Forms.Label city_input;
        private System.Windows.Forms.TextBox age_text_box;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile delete_book_btn;
        private MetroFramework.Controls.MetroTile save_book_to_db_btn;
        private MetroFramework.Controls.MetroTile edit_book_btn;
        private MetroFramework.Controls.MetroTile delete_author_btn;
        private MetroFramework.Controls.MetroTile edit_author_btn;
        private MetroFramework.Controls.MetroTile save_author_to_db_button;
    }
}

