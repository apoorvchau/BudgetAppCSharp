namespace BudgetAppCSharp
{
    partial class ExpectedDash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.expectedBudgetDataSet = new BudgetAppCSharp.ExpectedBudgetDataSet();
            this.expectedBudgetDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExpDelete = new System.Windows.Forms.ToolStripButton();
            this.btnExpAdd = new System.Windows.Forms.ToolStripButton();
            this.btnExpShowAll = new System.Windows.Forms.ToolStripButton();
            this.btnExpUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnExpClose = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.expectedBudgetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expectedBudgetTableAdapter = new BudgetAppCSharp.ExpectedBudgetDataSetTableAdapters.ExpectedBudgetTableAdapter();
            this.weekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expectedBudgetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expectedBudgetDataSetBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expectedBudgetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.weekDataGridViewTextBoxColumn,
            this.expenseDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.addDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.expectedBudgetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(435, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // expectedBudgetDataSet
            // 
            this.expectedBudgetDataSet.DataSetName = "ExpectedBudgetDataSet";
            this.expectedBudgetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expectedBudgetDataSetBindingSource
            // 
            this.expectedBudgetDataSetBindingSource.DataSource = this.expectedBudgetDataSet;
            this.expectedBudgetDataSetBindingSource.Position = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExpShowAll,
            this.toolStripSeparator4,
            this.btnExpAdd,
            this.toolStripSeparator3,
            this.btnExpDelete,
            this.toolStripSeparator2,
            this.btnExpUpdate,
            this.toolStripSeparator1,
            this.btnExpClose,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(652, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExpDelete
            // 
            this.btnExpDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExpDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExpDelete.Name = "btnExpDelete";
            this.btnExpDelete.Size = new System.Drawing.Size(44, 22);
            this.btnExpDelete.Text = "Delete";
            // 
            // btnExpAdd
            // 
            this.btnExpAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExpAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExpAdd.Name = "btnExpAdd";
            this.btnExpAdd.Size = new System.Drawing.Size(33, 22);
            this.btnExpAdd.Text = "Add";
            // 
            // btnExpShowAll
            // 
            this.btnExpShowAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExpShowAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExpShowAll.Name = "btnExpShowAll";
            this.btnExpShowAll.Size = new System.Drawing.Size(57, 22);
            this.btnExpShowAll.Text = "Show All";
            // 
            // btnExpUpdate
            // 
            this.btnExpUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExpUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExpUpdate.Name = "btnExpUpdate";
            this.btnExpUpdate.Size = new System.Drawing.Size(49, 22);
            this.btnExpUpdate.Text = "Update";
            // 
            // btnExpClose
            // 
            this.btnExpClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExpClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExpClose.Name = "btnExpClose";
            this.btnExpClose.Size = new System.Drawing.Size(40, 22);
            this.btnExpClose.Text = "Close";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Week #:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Expense Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(540, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(540, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(540, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 290);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(652, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // expectedBudgetBindingSource
            // 
            this.expectedBudgetBindingSource.DataMember = "ExpectedBudget";
            this.expectedBudgetBindingSource.DataSource = this.expectedBudgetDataSet;
            // 
            // expectedBudgetTableAdapter
            // 
            this.expectedBudgetTableAdapter.ClearBeforeFill = true;
            // 
            // weekDataGridViewTextBoxColumn
            // 
            this.weekDataGridViewTextBoxColumn.DataPropertyName = "Week #";
            this.weekDataGridViewTextBoxColumn.HeaderText = "Week #";
            this.weekDataGridViewTextBoxColumn.Name = "weekDataGridViewTextBoxColumn";
            // 
            // expenseDataGridViewTextBoxColumn
            // 
            this.expenseDataGridViewTextBoxColumn.DataPropertyName = "Expense";
            this.expenseDataGridViewTextBoxColumn.HeaderText = "Expense";
            this.expenseDataGridViewTextBoxColumn.Name = "expenseDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // addDateDataGridViewTextBoxColumn
            // 
            this.addDateDataGridViewTextBoxColumn.DataPropertyName = "Add Date";
            this.addDateDataGridViewTextBoxColumn.HeaderText = "Add Date";
            this.addDateDataGridViewTextBoxColumn.Name = "addDateDataGridViewTextBoxColumn";
            // 
            // ExpectedDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 312);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ExpectedDash";
            this.Text = "ExpectedDash";
            this.Load += new System.EventHandler(this.ExpectedDash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expectedBudgetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expectedBudgetDataSetBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expectedBudgetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource expectedBudgetDataSetBindingSource;
        private ExpectedBudgetDataSet expectedBudgetDataSet;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExpShowAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnExpAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnExpDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnExpUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnExpClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.BindingSource expectedBudgetBindingSource;
        private ExpectedBudgetDataSetTableAdapters.ExpectedBudgetTableAdapter expectedBudgetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDateDataGridViewTextBoxColumn;
    }
}