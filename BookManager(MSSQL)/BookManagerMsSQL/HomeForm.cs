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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            refreshStatus();
        }

        private void refreshStatus()
        {

            //전체 도서 수
            label_allBookCount.Text = DBHelper.dt_book.Rows.Count.ToString();
            //사용자 수
            label_allUserCount.Text = DBHelper.dt_user.Rows.Count.ToString();

            int borrowCount = 0;

            //대출중인 도서의 수
            foreach (DataRow item in DBHelper.dt_book.Rows)
            {
                if (bool.Parse(item["isBorrowed"].ToString()))
                    borrowCount++;
            }
            label_allBorrowedBook.Text = borrowCount.ToString();

            //연체중인 도서의 수
            borrowCount = 0;
            foreach (DataRow item in DBHelper.dt_book.Rows)
            {
                if (bool.Parse(item["isBorrowed"].ToString()))
                {
                    DateTime oldDay = DateTime.Parse(item["BorrowedAt"].ToString());
                    TimeSpan timeDiff = DateTime.Today - oldDay;
                    int diffDays = timeDiff.Days;
                    if (diffDays > 7)
                    {
                        borrowCount++;
                    }
                }
            }
            label_allDelayedBook.Text = borrowCount.ToString();
        }
    }
}
