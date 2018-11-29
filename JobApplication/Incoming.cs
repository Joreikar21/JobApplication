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
    public partial class Incoming : Form
    {
        public Incoming()
        {
            InitializeComponent();
        }

        private void incomingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.incomingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jobAppDBDataSet);

        }

        private void Incoming_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jobAppDBDataSet.Incoming". При необходимости она может быть перемещена или удалена.
            this.incomingTableAdapter.Fill(this.jobAppDBDataSet.Incoming);

        }
    }
}
