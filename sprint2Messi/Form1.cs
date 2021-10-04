using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sprint2Messi
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            bool informacion = false;

            progressBar1.Increment(1);
            labelContadorProgressBar.Text = progressBar1.Value.ToString() + "%";

    
                    

            if (progressBar1.Value == progressBar1.Maximum)
            {
                timerSplash.Stop();
                this.Hide();

                if(informacion == true)
                {
                    FormAdmin frmlogin = new FormAdmin();
                    frmlogin.ShowDialog();
                }
                else
                {
                    FormUsuarioNormal frmusuarionormal = new FormUsuarioNormal();
                    frmusuarionormal.ShowDialog();
                }
                
            }
        }

        private void splash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Alt)
            {
                FormAdmin frmlogin = new FormAdmin();
                frmlogin.ShowDialog();
            }
        }
    }
}
