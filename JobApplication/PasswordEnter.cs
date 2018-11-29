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
    public partial class PasswordEnter : Form
    {
        public PasswordEnter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ujhbyjytc;bufq")
            {
                CreditsMenu creditsMenu = new CreditsMenu();
                this.Hide();
                creditsMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Хуй соси, быдло", "Неверный пароль!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
