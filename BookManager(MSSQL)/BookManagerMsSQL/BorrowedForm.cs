﻿using System;
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
    public partial class BorrowedForm : Form
    {
        public BorrowedForm()
        {
            InitializeComponent();
            selectQuery_Book();
            selectQuery_User();
        }

        enum enumBook
        {
            Isbn, BookName
        }

        enum enumUser
        {
            UserId, UserName
        }


        public void selectQuery_Book(string Isbn = "")
        {
            if (Isbn == "")
            {
                //dataGridView에 DB에서 가져온 데이터 입력하기
                DBHelper.selectQuery_Book();
                dataGridView_BookManager.DataSource = DBHelper.ds;
                dataGridView_BookManager.DataMember = "BookTable";

            }
            else
            {
                DBHelper.selectQuery_Book(Isbn);
            }
        }

        public void selectQuery_User(int Id = -1)
        {
            if (Id < 0)
            {
                DBHelper.selectQuery_User();
                dataGridView_UserManager.DataSource = DBHelper.ds;
                dataGridView_UserManager.DataMember = "UserTable";

            }
            else
            {
                DBHelper.selectQuery_User(Id);
            }
        }

        private void updateQuery(int userId = 0, bool doBorrow = false)
        {
            try
            {
                if (doBorrow) //대여
                {
                    DBHelper.updateQuery(textBox_isbn.Text, userId, doBorrow);
                }
                else //반납
                {
                    DBHelper.updateQuery(textBox_isbn.Text);
                }
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.Message);
            }

        }

        private void dataGridView_UserManager_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                var user = dataGridView_UserManager.CurrentRow;
                textBox_id.Text = user.Cells[(int)enumUser.UserId].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView_BookManager_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                var book = dataGridView_BookManager.CurrentRow;
                textBox_isbn.Text = book.Cells[(int)enumBook.Isbn].Value.ToString();
                textBox_bookName.Text = book.Cells[(int)enumBook.BookName].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void button_Borrow_Click(object sender, EventArgs e)
        {
            if (textBox_isbn.Text.Trim() == "")
            {
                MessageBox.Show("Isbn을 입력해주세요.");
            }
            else if (textBox_id.Text.Trim() == "")
            {
                MessageBox.Show("사용자 Id를 입력해주세요.");
            }
            else
            {
                try
                {
                    int.TryParse(textBox_id.Text.Trim(), out int userid);
                    if (userid <= 0)
                    {
                        MessageBox.Show("유효한 사용자 Id를 입력해주세요. 0 이상의 숫자여야 합니다.");
                    }
                    //1. 해당 도서의 상태를 체크하기 위하여, 해당 도서를 조회함
                    selectQuery_Book(textBox_isbn.Text);

                    //2. isBorrowed 값을 이용하여 판별함
                    bool isBorrowed = bool.Parse(DBHelper.dt_book.Rows[0]["isBorrowed"].ToString());
                    if (isBorrowed)
                    {
                        //2-1. true이면 이미 대여중이라고 할 것
                        MessageBox.Show("이미 대여 중인 도서입니다.");
                    }
                    else
                    {
                        //대출할 책 이름 가져옴
                        string bookName = DBHelper.dt_book.Rows[0]["Name"].ToString();

                        // 대출자의 id를 이용하여 대출자의 이름을 가져옴
                        selectQuery_User(userid);
                        string userName = DBHelper.dt_user.Rows[0]["Name"].ToString();

                        bool doBorrow = true;
                        updateQuery(userid, doBorrow);

                        MessageBox.Show("\"" + bookName + "\"이/가\"" + userName + "\"님께 대여되었습니다.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
                }
            }
            selectQuery_Book();
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            if (textBox_isbn.Text.Trim() == "")
            {
                MessageBox.Show("Isbn을 입력해주세요.");
            }
            else
            {
                try
                {
                    //1. 해당 도서의 상태를 체크하기 위하여, 해당 도서를 조회함
                    selectQuery_Book(textBox_isbn.Text);

                    //2. isBorrowed 값을 이용하여 판별함
                    bool isBorrowed = bool.Parse(DBHelper.dt_book.Rows[0]["isBorrowed"].ToString());

                    string bookName = DBHelper.dt_book.Rows[0]["Name"].ToString();
                    if (isBorrowed)
                    {
                        DateTime oldDay = DateTime.Parse(DBHelper.dt_book.Rows[0]["BorrowedAt"].ToString());
                        updateQuery();

                        TimeSpan timeDiff = DateTime.Today - oldDay;
                        int diffDays = timeDiff.Days;

                        if (diffDays > 7)
                        {
                            MessageBox.Show("\"" + bookName + "\"이/가 연체 상태로 반납되었습니다.");
                        }
                        else
                        {
                            MessageBox.Show("\"" + bookName + "\"이/가 반납되었습니다.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("대여상태가 아닙니다.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
                }

            }
            selectQuery_Book();
        }
    }
}
