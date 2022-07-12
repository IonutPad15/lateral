using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public partial class Verificare : Form
    {
        bool tick = false; //intervalul timer-ului e setat pe un minut initial//
        string code;
        string to;
        Form2 f2 = new Form2();
        public Verificare(string code, string to)
        {
            this.to = to;
            this.code = code;
            InitializeComponent();
            timer1.Start();//incepe timer-ul de cand suntem redirectionati pe pagina
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(tick == false)//nu au trecut 60 de secunde
            {

                if (txtCode.Text.Equals(code)) lblVerif.Text = "succes";
                else lblVerif.Text = "Incorect";
            }
            else//au trecut 60 de secunde si ofera retransmiterea
            {

                DialogResult result = MessageBox.Show("Timpul a expirat! Retrimitere cod?", "Atentie!", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    resend();
                }
            }
        }

        private void btnResend_Click(object sender, EventArgs e)//pentru eventuale neintelegeri
        {
            resend();
        }
        private void resend()
        {
            lblVerif.Text = "";
            tick = false;
            timer1.Start();
            code = f2.sendEmail(to);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick = true;
            timer1.Stop();
        }
    }
}
