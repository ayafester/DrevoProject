using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drevo_Project
{
    public partial class RegForm : Form
    {


        public String Mail { get; set; }

        public String Password { get; set; }
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            
        }



        private void btOK_Click(object sender, EventArgs e)
        {
            if (textBoxMail.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные");
            }
            
            Mail = textBoxMail.Text;
            Password = textBoxPassword.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
