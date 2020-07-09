namespace BookManager
{
    partial class NewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidepanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserManagerBt = new System.Windows.Forms.Button();
            this.BookManagerBt = new System.Windows.Forms.Button();
            this.BorrowedBt = new System.Windows.Forms.Button();
            this.HomeBt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CloseBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ChangePanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(144)))), ((int)(((byte)(238)))));
            this.panel1.Controls.Add(this.sidepanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.UserManagerBt);
            this.panel1.Controls.Add(this.BookManagerBt);
            this.panel1.Controls.Add(this.BorrowedBt);
            this.panel1.Controls.Add(this.HomeBt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 632);
            this.panel1.TabIndex = 0;
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(165)))), ((int)(((byte)(255)))));
            this.sidepanel.Location = new System.Drawing.Point(0, 230);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(10, 54);
            this.sidepanel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville BT", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(29, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Library";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Location = new System.Drawing.Point(36, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(124, 123);
            this.panel2.TabIndex = 1;
            // 
            // UserManagerBt
            // 
            this.UserManagerBt.FlatAppearance.BorderSize = 0;
            this.UserManagerBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserManagerBt.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UserManagerBt.ForeColor = System.Drawing.SystemColors.Info;
            this.UserManagerBt.Image = ((System.Drawing.Image)(resources.GetObject("UserManagerBt.Image")));
            this.UserManagerBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserManagerBt.Location = new System.Drawing.Point(12, 410);
            this.UserManagerBt.Name = "UserManagerBt";
            this.UserManagerBt.Size = new System.Drawing.Size(188, 54);
            this.UserManagerBt.TabIndex = 4;
            this.UserManagerBt.Text = "          UserManager";
            this.UserManagerBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UserManagerBt.UseVisualStyleBackColor = true;
            this.UserManagerBt.Click += new System.EventHandler(this.UserManagerBt_Click);
            // 
            // BookManagerBt
            // 
            this.BookManagerBt.FlatAppearance.BorderSize = 0;
            this.BookManagerBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookManagerBt.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BookManagerBt.ForeColor = System.Drawing.SystemColors.Info;
            this.BookManagerBt.Image = ((System.Drawing.Image)(resources.GetObject("BookManagerBt.Image")));
            this.BookManagerBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BookManagerBt.Location = new System.Drawing.Point(12, 350);
            this.BookManagerBt.Name = "BookManagerBt";
            this.BookManagerBt.Size = new System.Drawing.Size(188, 54);
            this.BookManagerBt.TabIndex = 3;
            this.BookManagerBt.Text = "          BookManager";
            this.BookManagerBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BookManagerBt.UseVisualStyleBackColor = true;
            this.BookManagerBt.Click += new System.EventHandler(this.BookManagerBt_Click);
            // 
            // BorrowedBt
            // 
            this.BorrowedBt.FlatAppearance.BorderSize = 0;
            this.BorrowedBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowedBt.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BorrowedBt.ForeColor = System.Drawing.SystemColors.Info;
            this.BorrowedBt.Image = ((System.Drawing.Image)(resources.GetObject("BorrowedBt.Image")));
            this.BorrowedBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrowedBt.Location = new System.Drawing.Point(12, 290);
            this.BorrowedBt.Name = "BorrowedBt";
            this.BorrowedBt.Size = new System.Drawing.Size(188, 54);
            this.BorrowedBt.TabIndex = 2;
            this.BorrowedBt.Text = "          Borrowed";
            this.BorrowedBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BorrowedBt.UseVisualStyleBackColor = true;
            this.BorrowedBt.Click += new System.EventHandler(this.BorrowedBt_Click);
            // 
            // HomeBt
            // 
            this.HomeBt.FlatAppearance.BorderSize = 0;
            this.HomeBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeBt.Font = new System.Drawing.Font("나눔바른고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HomeBt.ForeColor = System.Drawing.SystemColors.Info;
            this.HomeBt.Image = ((System.Drawing.Image)(resources.GetObject("HomeBt.Image")));
            this.HomeBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeBt.Location = new System.Drawing.Point(12, 230);
            this.HomeBt.Name = "HomeBt";
            this.HomeBt.Size = new System.Drawing.Size(188, 54);
            this.HomeBt.TabIndex = 1;
            this.HomeBt.Text = "          Home";
            this.HomeBt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeBt.UseVisualStyleBackColor = true;
            this.HomeBt.Click += new System.EventHandler(this.HomeBt_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(114)))), ((int)(((byte)(238)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(888, 124);
            this.panel3.TabIndex = 1;
            // 
            // CloseBt
            // 
            this.CloseBt.BackColor = System.Drawing.Color.SeaShell;
            this.CloseBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloseBt.FlatAppearance.BorderSize = 0;
            this.CloseBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBt.ForeColor = System.Drawing.Color.White;
            this.CloseBt.Image = ((System.Drawing.Image)(resources.GetObject("CloseBt.Image")));
            this.CloseBt.Location = new System.Drawing.Point(818, -1);
            this.CloseBt.Name = "CloseBt";
            this.CloseBt.Size = new System.Drawing.Size(67, 60);
            this.CloseBt.TabIndex = 0;
            this.CloseBt.UseVisualStyleBackColor = false;
            this.CloseBt.Click += new System.EventHandler(this.CloseBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville BT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(141, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(552, 60);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome To My Library";
            // 
            // ChangePanel
            // 
            this.ChangePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChangePanel.Location = new System.Drawing.Point(200, 121);
            this.ChangePanel.Name = "ChangePanel";
            this.ChangePanel.Size = new System.Drawing.Size(888, 511);
            this.ChangePanel.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaShell;
            this.panel5.Controls.Add(this.CloseBt);
            this.panel5.Location = new System.Drawing.Point(0, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(888, 60);
            this.panel5.TabIndex = 0;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            // 
            // NewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 632);
            this.Controls.Add(this.ChangePanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HomeBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button UserManagerBt;
        private System.Windows.Forms.Button BookManagerBt;
        private System.Windows.Forms.Button BorrowedBt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel ChangePanel;
        private System.Windows.Forms.Button CloseBt;
        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel panel5;
    }
}