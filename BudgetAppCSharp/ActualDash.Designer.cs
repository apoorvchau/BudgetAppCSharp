namespace BudgetAppCSharp
{
    partial class ActualDash
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnActShowAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.actualBudgetDataSet = new BudgetAppCSharp.ActualBudgetDataSet();
            this.actualBudgetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualBudgetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualBudgetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 290);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(652, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(540, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(540, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(540, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Expense Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Week #:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(453, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Year:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnActShowAll,
            this.toolStripSeparator4,
            this.btnActAdd,
            this.toolStripSeparator3,
            this.btnActDelete,
            this.toolStripSeparator2,
            this.btnActUpdate,
            this.toolStripSeparator1,
            this.btnActClose,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(652, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnActShowAll
            // 
            this.btnActShowAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnActShowAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActShowAll.Name = "btnActShowAll";
            this.btnActShowAll.Size = new System.Drawing.Size(57, 22);
            this.btnActShowAll.Text = "Show All";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnActAdd
            // 
            this.btnActAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnActAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActAdd.Name = "btnActAdd";
            this.btnActAdd.Size = new System.Drawing.Size(33, 22);
            this.btnActAdd.Text = "Add";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnActDelete
            // 
            this.btnActDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnActDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActDelete.Name = "btnActDelete";
            this.btnActDelete.Size = new System.Drawing.Size(44, 22);
            this.btnActDelete.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnActUpdate
            // 
            this.btnActUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnActUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActUpdate.Name = "btnActUpdate";
            this.btnActUpdate.Size = new System.Drawing.Size(49, 22);
            this.btnActUpdate.Text = "Update";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnActClose
            // 
            this.btnActClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnActClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActClose.Name = "btnActClose";
            this.btnActClose.Size = new System.Drawing.Size(40, 22);
            this.btnActClose.Text = "Close";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
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
            this.dataGridView1.DataSource = this.actualBudgetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 242);
            this.dataGridView1.TabIndex = 11;
            // 
            // actualBudgetDataSet
            // 
            this.actualBudgetDataSet.DataSetName = "ActualBudget";
            this.actualBudgetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actualBudgetBindingSource
            // 
            this.actualBudgetBindingSource.DataMember = "ActualBudget";
            this.actualBudgetBindingSource.DataSource = this.actualBudgetDataSet;
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
            // ActualDash
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
            this.Name = "ActualDash";
            this.Text = "ActualDash";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualBudgetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualBudgetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnActShowAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnActAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnActDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnActUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnActClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn weekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource actualBudgetBindingSource;
        private ActualBudgetDataSet actualBudgetDataSet;
    }
}