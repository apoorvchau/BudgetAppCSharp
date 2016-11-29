using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetAppCSharp
{
    public partial class ActualForm : Form
    {
        public ActualForm()
        {
            InitializeComponent();
        }

        private void ActualForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'actualBudgetDataSet.ActualBudget' table. You can move, or remove it, as needed.
            this.actualBudgetTableAdapter.Fill(this.actualBudgetDataSet.ActualBudget);

        }
    }
}
