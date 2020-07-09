using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManager
{
    public partial class NewForm : Form
    {
        enum enumBook
        {
            Isbn, BookName
        }

        enum enumUser
        {
            UserId, UserName
        }

        private Point mCurrentPosition = new Point(0, 0);

        public NewForm()
        {
            InitializeComponent();
            Text = "도서관 관리";

            BookMangerForm temp = new BookMangerForm();


            temp.TopLevel = false;
            ChangePanel.Controls.Add(temp);
            temp.Show();

            ChangePanel.Controls.Clear();



            UserManagerForm temp2 = new UserManagerForm();

            temp2.TopLevel = false;
            ChangePanel.Controls.Add(temp2);
            temp2.Show();

            ChangePanel.Controls.Clear();



            HomeForm temp3 = new HomeForm();

            temp3.TopLevel = false;
            ChangePanel.Controls.Add(temp3);
            temp3.Show();
        }



        private void BorrowedBt_Click(object sender, EventArgs e)
        {
            sidepanel.Height = BorrowedBt.Height;
            sidepanel.Top = BorrowedBt.Top;

            BorrowedBt.BackColor = Color.FromArgb(133, 114, 238);
            BookManagerBt.BackColor = Color.FromArgb(163, 144, 238);
            UserManagerBt.BackColor = Color.FromArgb(163, 144, 238);
            HomeBt.BackColor = Color.FromArgb(163, 144, 238);

            ChangePanel.Controls.Clear();
            try
            {
                
                BorrowedForm temp = new BorrowedForm();
                

                temp.TopLevel = false;
                ChangePanel.Controls.Add(temp);
                temp.Show();

                
            }
            catch (IndexOutOfRangeException ie)
            {

            }
            catch (Exception ex)
            {

            }
        }

        private void BookManagerBt_Click(object sender, EventArgs e)
        {
            sidepanel.Height = BookManagerBt.Height;
            sidepanel.Top = BookManagerBt.Top;

            BookManagerBt.BackColor = Color.FromArgb(133, 114, 238);
            UserManagerBt.BackColor = Color.FromArgb(163, 144, 238);
            HomeBt.BackColor = Color.FromArgb(163, 144, 238);
            BorrowedBt.BackColor = Color.FromArgb(163, 144, 238);

            ChangePanel.Controls.Clear();
            try
            {
                BookMangerForm temp = new BookMangerForm();


                temp.TopLevel = false;
                ChangePanel.Controls.Add(temp);
                temp.Show();

            }
            catch (IndexOutOfRangeException ie)
            {

            }
            catch (Exception ex)
            {

            }
        }

        private void UserManagerBt_Click(object sender, EventArgs e)
        {
            sidepanel.Height = UserManagerBt.Height;
            sidepanel.Top = UserManagerBt.Top;

            UserManagerBt.BackColor = Color.FromArgb(133, 114, 238);
            HomeBt.BackColor = Color.FromArgb(163, 144, 238);
            BookManagerBt.BackColor = Color.FromArgb(163, 144, 238);
            BorrowedBt.BackColor = Color.FromArgb(163, 144, 238);

            ChangePanel.Controls.Clear();
            try
            {
                UserManagerForm temp = new UserManagerForm();

                temp.TopLevel = false;
                ChangePanel.Controls.Add(temp);
                temp.Show();


            }
            catch (IndexOutOfRangeException ie)
            {

            }
            catch (Exception ex)
            {

            }
        }

        private void HomeBt_Click(object sender, EventArgs e)
        {
            sidepanel.Height = HomeBt.Height;
            sidepanel.Top = HomeBt.Top;

            HomeBt.BackColor = Color.FromArgb(133, 114, 238);
            UserManagerBt.BackColor = Color.FromArgb(163, 144, 238);
            BookManagerBt.BackColor = Color.FromArgb(163, 144, 238);
            BorrowedBt.BackColor = Color.FromArgb(163, 144, 238);

            ChangePanel.Controls.Clear();
            try
            {
                HomeForm temp = new HomeForm();

                temp.TopLevel = false;
                ChangePanel.Controls.Add(temp);
                temp.Show();

            }
            catch (IndexOutOfRangeException ie)
            {

            }
            catch (Exception ex)
            {

            }
        }

        private void CloseBt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mCurrentPosition = new Point(-e.X, -e.Y);
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                this.Location.X + (mCurrentPosition.X + e.X),
                this.Location.Y + (mCurrentPosition.Y + e.Y));
            }
        }
    }
}
