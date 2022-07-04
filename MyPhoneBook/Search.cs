using PhonbookDatalayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPhoneBook
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            BindGrid(); 
        }

      public void  BindGrid()
        {
            using (unitOfWork db = new unitOfWork())
            {
                datagridViewSearch.DataSource = db.PhoneBookRepository.GetAllUsers();
            }
        }

        private void txt_serach_TextChanged(object sender, EventArgs e)
        {
            using (unitOfWork db = new unitOfWork())

            {
                datagridViewSearch.DataSource = db.PhoneBookRepository.GetAllUsersByFilter(txt_serach.Text);
            }
        }
    }
}
