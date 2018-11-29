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
    public partial class Outgoing : Form
    {
        public Outgoing()
        {
            InitializeComponent();
        }

        private void outgoingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.outgoingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jobAppDBDataSet);

        }

        private void Outgoing_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jobAppDBDataSet.Outgoing". При необходимости она может быть перемещена или удалена.
            this.outgoingTableAdapter.Fill(this.jobAppDBDataSet.Outgoing);

        }
    }
}
