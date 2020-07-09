namespace BookManager
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_allDelayedBook = new System.Windows.Forms.Label();
            this.label_allBorrowedBook = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_allUserCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_allBookCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutPanel1.BackgroundImage")));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 165);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(349, 335);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // label_allDelayedBook
            // 
            this.label_allDelayedBook.AutoSize = true;
            this.label_allDelayedBook.Font = new System.Drawing.Font("나눔바른고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_allDelayedBook.Location = new System.Drawing.Point(673, 400);
            this.label_allDelayedBook.Name = "label_allDelayedBook";
            this.label_allDelayedBook.Size = new System.Drawing.Size(89, 31);
            this.label_allDelayedBook.TabIndex = 16;
            this.label_allDelayedBook.Text = "label8";
            // 
            // label_allBorrowedBook
            // 
            this.label_allBorrowedBook.AutoSize = true;
            this.label_allBorrowedBook.Font = new System.Drawing.Font("나눔바른고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_allBorrowedBook.Location = new System.Drawing.Point(661, 320);
            this.label_allBorrowedBook.Name = "label_allBorrowedBook";
            this.label_allBorrowedBook.Size = new System.Drawing.Size(89, 31);
            this.label_allBorrowedBook.TabIndex = 15;
            this.label_allBorrowedBook.Text = "label7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔바른고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(423, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "대출 중인 도서의 수:";
            // 
            // label_allUserCount
            // 
            this.label_allUserCount.AutoSize = true;
            this.label_allUserCount.Font = new System.Drawing.Font("나눔바른고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_allUserCount.Location = new System.Drawing.Point(553, 242);
            this.label_allUserCount.Name = "label_allUserCount";
            this.label_allUserCount.Size = new System.Drawing.Size(89, 31);
            this.label_allUserCount.TabIndex = 14;
            this.label_allUserCount.Text = "label6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔바른고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(421, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "전체 도서 수:";
            // 
            // label_allBookCount
            // 
            this.label_allBookCount.AutoSize = true;
            this.label_allBookCount.Font = new System.Drawing.Font("나눔바른고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_allBookCount.Location = new System.Drawing.Point(581, 168);
            this.label_allBookCount.Name = "label_allBookCount";
            this.label_allBookCount.Size = new System.Drawing.Size(89, 31);
            this.label_allBookCount.TabIndex = 13;
            this.label_allBookCount.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔바른고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(423, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "사용자 수:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔바른고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(423, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "연체 중인 도서의 수 : ";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(988, 545);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label_allDelayedBook);
            this.Controls.Add(this.label_allBorrowedBook);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_allUserCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_allBookCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "Form0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_allDelayedBook;
        private System.Windows.Forms.Label label_allBorrowedBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_allUserCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_allBookCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}