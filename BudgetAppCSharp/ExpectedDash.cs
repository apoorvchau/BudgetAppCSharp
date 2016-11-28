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
    public partial class ExpectedDash : Form
    {
        public ExpectedDash()
        {
            InitializeComponent();
        }

        private void ExpectedDash_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'expectedBudgetDataSet.ExpectedBudget' table. You can move, or remove it, as needed.
            this.expectedBudgetTableAdapter.Fill(this.expectedBudgetDataSet.ExpectedBudget);

        }
    }
}
