using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB;

//meniul de logare
//user si parola sunt "admin"

namespace App2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text; 

            if(Class1.logare(user, pass))//mettoda din Class1 de autentificare, Class1 fiind intr-un DLL
            {                           //am folosit legare statica, acum doar testez

                Form2 form2 = new Form2();
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Date incorecte", "Atentie",MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
        }
    }
}
