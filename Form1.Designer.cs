namespace PersonalFinanceTracker
{
    partial class Form1
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
            this.labelMainHeading = new System.Windows.Forms.Label();
            this.labelMonthlyBudget = new System.Windows.Forms.Label();
            this.textBoxMonthlyBudget = new System.Windows.Forms.TextBox();
            this.buttonSetMonthlyBudget = new System.Windows.Forms.Button();
            this.labelExpenseName = new System.Windows.Forms.Label();
            this.textBoxExpenseName = new System.Windows.Forms.TextBox();
            this.textBoxExpenseAmount = new System.Windows.Forms.TextBox();
            this.buttonAddExpense = new System.Windows.Forms.Button();
            this.buttonEditExpense = new System.Windows.Forms.Button();
            this.buttonDeleteExpense = new System.Windows.Forms.Button();
            this.labelTotalExpense = new System.Windows.Forms.Label();
            this.labelRemainingBudget = new System.Windows.Forms.Label();
            this.labelExpenseAmount = new System.Windows.Forms.Label();
            this.dataGridViewExpenseDisplay = new System.Windows.Forms.DataGridView();
            this.buttonResetEverything = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenseDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMainHeading
            // 
            this.labelMainHeading.AutoSize = true;
            this.labelMainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMainHeading.Location = new System.Drawing.Point(298, 9);
            this.labelMainHeading.Name = "labelMainHeading";
            this.labelMainHeading.Size = new System.Drawing.Size(398, 29);
            this.labelMainHeading.TabIndex = 0;
            this.labelMainHeading.Text = "PERSONAL FINANCE TRACKER";
            // 
            // labelMonthlyBudget
            // 
            this.labelMonthlyBudget.AutoSize = true;
            this.labelMonthlyBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonthlyBudget.Location = new System.Drawing.Point(13, 74);
            this.labelMonthlyBudget.Name = "labelMonthlyBudget";
            this.labelMonthlyBudget.Size = new System.Drawing.Size(243, 22);
            this.labelMonthlyBudget.TabIndex = 1;
            this.labelMonthlyBudget.Text = "MONTHLY BUDGET (Rs.)";
            this.labelMonthlyBudget.Click += new System.EventHandler(this.labelMonthlyBudget_Click);
            // 
            // textBoxMonthlyBudget
            // 
            this.textBoxMonthlyBudget.Location = new System.Drawing.Point(262, 74);
            this.textBoxMonthlyBudget.Name = "textBoxMonthlyBudget";
            this.textBoxMonthlyBudget.Size = new System.Drawing.Size(208, 26);
            this.textBoxMonthlyBudget.TabIndex = 2;
            this.textBoxMonthlyBudget.TextChanged += new System.EventHandler(this.textBoxMonthlyBudget_TextChanged);
            // 
            // buttonSetMonthlyBudget
            // 
            this.buttonSetMonthlyBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetMonthlyBudget.Location = new System.Drawing.Point(507, 74);
            this.buttonSetMonthlyBudget.Name = "buttonSetMonthlyBudget";
            this.buttonSetMonthlyBudget.Size = new System.Drawing.Size(109, 75);
            this.buttonSetMonthlyBudget.TabIndex = 3;
            this.buttonSetMonthlyBudget.Text = "SET BUDGET";
            this.buttonSetMonthlyBudget.UseVisualStyleBackColor = true;
            this.buttonSetMonthlyBudget.Click += new System.EventHandler(this.buttonSetMonthlyBudget_Click);
            // 
            // labelExpenseName
            // 
            this.labelExpenseName.AutoSize = true;
            this.labelExpenseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpenseName.Location = new System.Drawing.Point(13, 193);
            this.labelExpenseName.Name = "labelExpenseName";
            this.labelExpenseName.Size = new System.Drawing.Size(163, 22);
            this.labelExpenseName.TabIndex = 4;
            this.labelExpenseName.Text = "EXPENSE NAME";
            this.labelExpenseName.Click += new System.EventHandler(this.labelExpenseName_Click);
            // 
            // textBoxExpenseName
            // 
            this.textBoxExpenseName.Location = new System.Drawing.Point(262, 192);
            this.textBoxExpenseName.Name = "textBoxExpenseName";
            this.textBoxExpenseName.Size = new System.Drawing.Size(301, 26);
            this.textBoxExpenseName.TabIndex = 5;
            this.textBoxExpenseName.TextChanged += new System.EventHandler(this.textBoxExpenseName_TextChanged);
            // 
            // textBoxExpenseAmount
            // 
            this.textBoxExpenseAmount.Location = new System.Drawing.Point(854, 192);
            this.textBoxExpenseAmount.Name = "textBoxExpenseAmount";
            this.textBoxExpenseAmount.Size = new System.Drawing.Size(136, 26);
            this.textBoxExpenseAmount.TabIndex = 7;
            this.textBoxExpenseAmount.TextChanged += new System.EventHandler(this.textBoxExpenseAmount_TextChanged);
            // 
            // buttonAddExpense
            // 
            this.buttonAddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddExpense.Location = new System.Drawing.Point(262, 261);
            this.buttonAddExpense.Name = "buttonAddExpense";
            this.buttonAddExpense.Size = new System.Drawing.Size(127, 78);
            this.buttonAddExpense.TabIndex = 8;
            this.buttonAddExpense.Text = "ADD EXPENSE";
            this.buttonAddExpense.UseVisualStyleBackColor = true;
            this.buttonAddExpense.Click += new System.EventHandler(this.buttonAddExpense_Click);
            // 
            // buttonEditExpense
            // 
            this.buttonEditExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditExpense.Location = new System.Drawing.Point(416, 261);
            this.buttonEditExpense.Name = "buttonEditExpense";
            this.buttonEditExpense.Size = new System.Drawing.Size(126, 78);
            this.buttonEditExpense.TabIndex = 9;
            this.buttonEditExpense.Text = "EDIT EXPENSE";
            this.buttonEditExpense.UseVisualStyleBackColor = true;
            this.buttonEditExpense.Click += new System.EventHandler(this.buttonEditExpense_Click);
            // 
            // buttonDeleteExpense
            // 
            this.buttonDeleteExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteExpense.Location = new System.Drawing.Point(571, 261);
            this.buttonDeleteExpense.Name = "buttonDeleteExpense";
            this.buttonDeleteExpense.Size = new System.Drawing.Size(125, 79);
            this.buttonDeleteExpense.TabIndex = 10;
            this.buttonDeleteExpense.Text = "DELETE EXPENSE";
            this.buttonDeleteExpense.UseVisualStyleBackColor = true;
            this.buttonDeleteExpense.Click += new System.EventHandler(this.buttonDeleteExpense_Click);
            // 
            // labelTotalExpense
            // 
            this.labelTotalExpense.AutoSize = true;
            this.labelTotalExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalExpense.Location = new System.Drawing.Point(13, 368);
            this.labelTotalExpense.Name = "labelTotalExpense";
            this.labelTotalExpense.Size = new System.Drawing.Size(179, 22);
            this.labelTotalExpense.TabIndex = 11;
            this.labelTotalExpense.Text = "TOTAL EXPENSE:";
            this.labelTotalExpense.Click += new System.EventHandler(this.labelTotalExpense_Click);
            // 
            // labelRemainingBudget
            // 
            this.labelRemainingBudget.AutoSize = true;
            this.labelRemainingBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRemainingBudget.Location = new System.Drawing.Point(17, 412);
            this.labelRemainingBudget.Name = "labelRemainingBudget";
            this.labelRemainingBudget.Size = new System.Drawing.Size(212, 22);
            this.labelRemainingBudget.TabIndex = 12;
            this.labelRemainingBudget.Text = "REMAINING BUDGET:";
            this.labelRemainingBudget.Click += new System.EventHandler(this.labelRemainingBudget_Click);
            // 
            // labelExpenseAmount
            // 
            this.labelExpenseAmount.AutoSize = true;
            this.labelExpenseAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpenseAmount.Location = new System.Drawing.Point(595, 193);
            this.labelExpenseAmount.Name = "labelExpenseAmount";
            this.labelExpenseAmount.Size = new System.Drawing.Size(242, 22);
            this.labelExpenseAmount.TabIndex = 13;
            this.labelExpenseAmount.Text = "EXPENSE AMOUNT (Rs.)";
            this.labelExpenseAmount.Click += new System.EventHandler(this.labelExpenseAmount_Click);
            // 
            // dataGridViewExpenseDisplay
            // 
            this.dataGridViewExpenseDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewExpenseDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpenseDisplay.Location = new System.Drawing.Point(507, 368);
            this.dataGridViewExpenseDisplay.Name = "dataGridViewExpenseDisplay";
            this.dataGridViewExpenseDisplay.RowTemplate.Height = 28;
            this.dataGridViewExpenseDisplay.Size = new System.Drawing.Size(454, 302);
            this.dataGridViewExpenseDisplay.TabIndex = 14;
            this.dataGridViewExpenseDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewExpenseDisplay_CellContentClick);
            // 
            // buttonResetEverything
            // 
            this.buttonResetEverything.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetEverything.Location = new System.Drawing.Point(21, 517);
            this.buttonResetEverything.Name = "buttonResetEverything";
            this.buttonResetEverything.Size = new System.Drawing.Size(108, 34);
            this.buttonResetEverything.TabIndex = 15;
            this.buttonResetEverything.Text = "RESET";
            this.buttonResetEverything.UseVisualStyleBackColor = true;
            this.buttonResetEverything.Click += new System.EventHandler(this.buttonResetEverything_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 682);
            this.Controls.Add(this.buttonResetEverything);
            this.Controls.Add(this.dataGridViewExpenseDisplay);
            this.Controls.Add(this.labelExpenseAmount);
            this.Controls.Add(this.labelRemainingBudget);
            this.Controls.Add(this.labelTotalExpense);
            this.Controls.Add(this.buttonDeleteExpense);
            this.Controls.Add(this.buttonEditExpense);
            this.Controls.Add(this.buttonAddExpense);
            this.Controls.Add(this.textBoxExpenseAmount);
            this.Controls.Add(this.textBoxExpenseName);
            this.Controls.Add(this.labelExpenseName);
            this.Controls.Add(this.buttonSetMonthlyBudget);
            this.Controls.Add(this.textBoxMonthlyBudget);
            this.Controls.Add(this.labelMonthlyBudget);
            this.Controls.Add(this.labelMainHeading);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpenseDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMainHeading;
        private System.Windows.Forms.Label labelMonthlyBudget;
        private System.Windows.Forms.TextBox textBoxMonthlyBudget;
        private System.Windows.Forms.Button buttonSetMonthlyBudget;
        private System.Windows.Forms.Label labelExpenseName;
        private System.Windows.Forms.TextBox textBoxExpenseName;
        private System.Windows.Forms.TextBox textBoxExpenseAmount;
        private System.Windows.Forms.Button buttonAddExpense;
        private System.Windows.Forms.Button buttonEditExpense;
        private System.Windows.Forms.Button buttonDeleteExpense;
        private System.Windows.Forms.Label labelTotalExpense;
        private System.Windows.Forms.Label labelRemainingBudget;
        private System.Windows.Forms.Label labelExpenseAmount;
        private System.Windows.Forms.DataGridView dataGridViewExpenseDisplay;
        private System.Windows.Forms.Button buttonResetEverything;
    }
}

