namespace BookManager
{
    partial class BorrowedForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_BookManager = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView_UserManager = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Return = new System.Windows.Forms.Button();
            this.button_Borrow = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_bookName = new System.Windows.Forms.TextBox();
            this.textBox_isbn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isBorrowedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.borrowedAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BookManager)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserManager)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_BookManager);
            this.groupBox3.Location = new System.Drawing.Point(12, 251);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(865, 210);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "도서 현황";
            // 
            // dataGridView_BookManager
            // 
            this.dataGridView_BookManager.AllowUserToAddRows = false;
            this.dataGridView_BookManager.AllowUserToDeleteRows = false;
            this.dataGridView_BookManager.AutoGenerateColumns = false;
            this.dataGridView_BookManager.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_BookManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BookManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbnDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.pageDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.isBorrowedDataGridViewCheckBoxColumn,
            this.borrowedAtDataGridViewTextBoxColumn});
            this.dataGridView_BookManager.DataSource = this.bookBindingSource;
            this.dataGridView_BookManager.GridColor = System.Drawing.Color.White;
            this.dataGridView_BookManager.Location = new System.Drawing.Point(6, 18);
            this.dataGridView_BookManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_BookManager.Name = "dataGridView_BookManager";
            this.dataGridView_BookManager.ReadOnly = true;
            this.dataGridView_BookManager.RowHeadersWidth = 51;
            this.dataGridView_BookManager.RowTemplate.Height = 27;
            this.dataGridView_BookManager.Size = new System.Drawing.Size(851, 187);
            this.dataGridView_BookManager.TabIndex = 0;
            this.dataGridView_BookManager.CurrentCellChanged += new System.EventHandler(this.dataGridView_BookManager_CurrentCellChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_UserManager);
            this.groupBox4.Location = new System.Drawing.Point(18, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(266, 227);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "사용자 현황";
            // 
            // dataGridView_UserManager
            // 
            this.dataGridView_UserManager.AllowUserToAddRows = false;
            this.dataGridView_UserManager.AllowUserToDeleteRows = false;
            this.dataGridView_UserManager.AutoGenerateColumns = false;
            this.dataGridView_UserManager.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_UserManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_UserManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridView_UserManager.DataSource = this.userBindingSource;
            this.dataGridView_UserManager.GridColor = System.Drawing.Color.White;
            this.dataGridView_UserManager.Location = new System.Drawing.Point(6, 20);
            this.dataGridView_UserManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_UserManager.Name = "dataGridView_UserManager";
            this.dataGridView_UserManager.ReadOnly = true;
            this.dataGridView_UserManager.RowHeadersWidth = 51;
            this.dataGridView_UserManager.RowTemplate.Height = 27;
            this.dataGridView_UserManager.Size = new System.Drawing.Size(253, 202);
            this.dataGridView_UserManager.TabIndex = 0;
            this.dataGridView_UserManager.CurrentCellChanged += new System.EventHandler(this.dataGridView_UserManager_CurrentCellChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Return);
            this.groupBox2.Controls.Add(this.button_Borrow);
            this.groupBox2.Controls.Add(this.textBox_id);
            this.groupBox2.Controls.Add(this.textBox_bookName);
            this.groupBox2.Controls.Add(this.textBox_isbn);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(336, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(541, 202);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "대여/반납";
            // 
            // button_Return
            // 
            this.button_Return.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Return.ForeColor = System.Drawing.SystemColors.Info;
            this.button_Return.Location = new System.Drawing.Point(377, 137);
            this.button_Return.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(81, 32);
            this.button_Return.TabIndex = 7;
            this.button_Return.Text = "반납";
            this.button_Return.UseVisualStyleBackColor = false;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // button_Borrow
            // 
            this.button_Borrow.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button_Borrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Borrow.ForeColor = System.Drawing.SystemColors.Info;
            this.button_Borrow.Location = new System.Drawing.Point(81, 137);
            this.button_Borrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Borrow.Name = "button_Borrow";
            this.button_Borrow.Size = new System.Drawing.Size(81, 32);
            this.button_Borrow.TabIndex = 6;
            this.button_Borrow.Text = "대여";
            this.button_Borrow.UseVisualStyleBackColor = false;
            this.button_Borrow.Click += new System.EventHandler(this.button_Borrow_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(81, 91);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(452, 21);
            this.textBox_id.TabIndex = 5;
            // 
            // textBox_bookName
            // 
            this.textBox_bookName.Location = new System.Drawing.Point(81, 48);
            this.textBox_bookName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_bookName.Name = "textBox_bookName";
            this.textBox_bookName.Size = new System.Drawing.Size(452, 21);
            this.textBox_bookName.TabIndex = 4;
            // 
            // textBox_isbn
            // 
            this.textBox_isbn.Location = new System.Drawing.Point(81, 9);
            this.textBox_isbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_isbn.Name = "textBox_isbn";
            this.textBox_isbn.Size = new System.Drawing.Size(452, 21);
            this.textBox_isbn.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "사용자 ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "도서 이름";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "Isbn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(BookManager.User);
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "Isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "Isbn";
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pageDataGridViewTextBoxColumn
            // 
            this.pageDataGridViewTextBoxColumn.DataPropertyName = "Page";
            this.pageDataGridViewTextBoxColumn.HeaderText = "Page";
            this.pageDataGridViewTextBoxColumn.Name = "pageDataGridViewTextBoxColumn";
            this.pageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isBorrowedDataGridViewCheckBoxColumn
            // 
            this.isBorrowedDataGridViewCheckBoxColumn.DataPropertyName = "isBorrowed";
            this.isBorrowedDataGridViewCheckBoxColumn.HeaderText = "isBorrowed";
            this.isBorrowedDataGridViewCheckBoxColumn.Name = "isBorrowedDataGridViewCheckBoxColumn";
            this.isBorrowedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // borrowedAtDataGridViewTextBoxColumn
            // 
            this.borrowedAtDataGridViewTextBoxColumn.DataPropertyName = "BorrowedAt";
            this.borrowedAtDataGridViewTextBoxColumn.HeaderText = "BorrowedAt";
            this.borrowedAtDataGridViewTextBoxColumn.Name = "borrowedAtDataGridViewTextBoxColumn";
            this.borrowedAtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(BookManager.Book);
            // 
            // BorrowedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(887, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowedForm";
            this.Text = "BorrowedForm";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BookManager)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserManager)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView_BookManager;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView_UserManager;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.Button button_Borrow;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_bookName;
        private System.Windows.Forms.TextBox textBox_isbn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isBorrowedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrowedAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}