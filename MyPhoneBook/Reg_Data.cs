using PhonbookDatalayer;
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
using ValidationComponents;

namespace MyPhoneBook
{
    public partial class Reg_Data : Form
    {
        unitOfWork db = new unitOfWork();   
        public Reg_Data()
        {
            InitializeComponent();

        }

        private void Add_New_Click(object sender, EventArgs e)
        {
            Mainfunc(false,true);
            ResetText();
        }

        private void Save_data_Click(object sender, EventArgs e)
        {
            Mainfunc(true,false);

        }

        private void Mainfunc(bool add_new,bool group_enabel)
        {
            Add_New.Enabled = add_new;
       
            GroupBox.Enabled = group_enabel;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            GroupBox.Enabled = false;
        }


        private void ResetText()
        {
            
            fn_txt.ResetText();
            ln_txt.ResetText();
            tel_txt.ResetText();
            cell_txt.ResetText();
            email_txt.ResetText();
            adres_txt.ResetText();
            comm_txt.ResetText();
        }

        private void Reg_Data_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        void BindGrid()
        {
            using (unitOfWork db = new unitOfWork())
            {
                dataGridView1.DataSource = db.PhoneBookRepository.GetAllUsers();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow !=null)
            {
                using (unitOfWork db = new unitOfWork())
                {
                    int UserId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    db.PhoneBookRepository.DeleteUsers(UserId);
                    db.Save();
                    BindGrid();
                }

            }
            else
            {
                MessageBox.Show("Pls Select a Person");
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                Users users = new Users()
                {
                    FirstName = fn_txt.Text,
                    LastName = ln_txt.Text,
                    Tell = tel_txt.Text,
                    Cell = cell_txt.Text,
                    Email = fn_txt.Text,
                    Comment = comm_txt.Text,


                };

                db.PhoneBookRepository.InsertUsers(users);
                db.Save();
                DialogResult = DialogResult.OK;
                BindGrid();
            }
        }

       
    }
}
