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
    public partial class ConfirmedTasks : Form
    {
        public ConfirmedTasks()
        {
            InitializeComponent();
            
        }

        private void confirmedBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.confirmedBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jobAppDBDataSet);

        }

        private void ConfirmedTasks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "jobAppDBDataSet.Confirmed". При необходимости она может быть перемещена или удалена.
            this.confirmedTableAdapter.Fill(this.jobAppDBDataSet.Confirmed);

        }
    }
}
