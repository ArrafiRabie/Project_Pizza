using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Pizza_Sr
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
            Back_GR_im();
        }
        void Back_GR_im()
        {
            this.BackgroundImage = Properties.Resources.R;
        }

        private void BT_Login_Click(object sender, EventArgs e)
        {
            TB_Email.Tag = "RabieArrafi@gmail.com";
            TB_Passworde.Tag = 7991;

            if ((TB_Passworde.Text == Convert.ToString(TB_Passworde.Tag)) && ( TB_Email.Text == Convert.ToString(TB_Email.Tag)))
            { 
                Form frm = new Pizza_Order();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Your information is incorrect, please verify it","Confirme",MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,MessageBoxDefaultButton.Button1);
                TB_Email.Text     = default;
                TB_Passworde.Text = default;
            }
        }
    }
}