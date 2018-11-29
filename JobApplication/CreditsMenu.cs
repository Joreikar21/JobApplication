using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobApplication
{
    public partial class CreditsMenu : Form
    {
        public CreditsMenu()
        {
            InitializeComponent();
        }

        private void InBtn_Click(object sender, EventArgs e)
        {
            Incoming incoming = new Incoming();
            this.Hide();
            incoming.ShowDialog();
            this.Show();
        }

        private void OutBtn_Click(object sender, EventArgs e)
        {
            Outgoing outgoing = new Outgoing();
            this.Hide();
            outgoing.ShowDialog();
            this.Show();
        }
    }
}
