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

    public partial class Card : Form
    {
        public Card()
        {
            InitializeComponent();
        }

        private void buttonEditCard_Click(object sender, EventArgs e)
        {
            EditCard editCard = new EditCard();
            //editCard.Show();

            if (editCard.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
