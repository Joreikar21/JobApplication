using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JobApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmedTasks confirmed = new ConfirmedTasks();
            this.Hide();
            confirmed.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PerspectiveTasks perspective = new PerspectiveTasks();
            this.Hide();
            perspective.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExecutedTasks executed = new ExecutedTasks();
            this.Hide();
            executed.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UnexecutedTasks unexecuted = new UnexecutedTasks();
            this.Hide();
            unexecuted.ShowDialog();
            this.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            notifyIcon1.Visible = true;
            this.Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                notifyIcon1.Visible = false;
                this.Show();
            }
            else
            {
            ContextMenu contextMenu1 = new ContextMenu();
            MenuItem menuItem1 = new MenuItem();
            MenuItem menuItem2 = new MenuItem();
            contextMenu1.MenuItems.AddRange(new MenuItem[] { menuItem2, menuItem1 });
            menuItem1.Index = 1;
            menuItem1.Text = "Закрыть приложение";
            menuItem1.Click += new EventHandler(menuItem1_Click);
            menuItem2.Index = 0;
            menuItem2.Text = "Развернуть";
            menuItem2.Click += new EventHandler(menuItem2_Click);
            notifyIcon1.ContextMenu = contextMenu1;
            }
            
        }
        private void menuItem1_Click(object Sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void menuItem2_Click(object Sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PasswordEnter password = new PasswordEnter();
            password.ShowDialog();
        }
    }
}
