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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Reg_Data rg = new Reg_Data();
           
            rg.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Search rg = new Search();
           
            rg.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Ab_Us rg = new Ab_Us();
          
            rg.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            process2.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            process2.Start();   
        }

        
    }
}
