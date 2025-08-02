namespace PersonalFinanceTracker
{
    partial class LoginSignupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUSERNAME = new System.Windows.Forms.TextBox();
            this.textBoxPASSWORD = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPASSWORD = new System.Windows.Forms.Label();
            this.buttonLOGIN = new System.Windows.Forms.Button();
            this.buttonSIGNUP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN or SIGNUP";
            // 
            // textBoxUSERNAME
            // 
            this.textBoxUSERNAME.Location = new System.Drawing.Point(187, 130);
            this.textBoxUSERNAME.Name = "textBoxUSERNAME";
            this.textBoxUSERNAME.Size = new System.Drawing.Size(222, 26);
            this.textBoxUSERNAME.TabIndex = 1;
            this.textBoxUSERNAME.TextChanged += new System.EventHandler(this.textBoxUSERNAME_TextChanged);
            // 
            // textBoxPASSWORD
            // 
            this.textBoxPASSWORD.Location = new System.Drawing.Point(187, 210);
            this.textBoxPASSWORD.Name = "textBoxPASSWORD";
            this.textBoxPASSWORD.Size = new System.Drawing.Size(222, 26);
            this.textBoxPASSWORD.TabIndex = 2;
            this.textBoxPASSWORD.TextChanged += new System.EventHandler(this.textBoxPASSWORD_TextChanged);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(26, 130);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(125, 22);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "USER NAME";
            this.labelUserName.Click += new System.EventHandler(this.labelUserName_Click);
            // 
            // labelPASSWORD
            // 
            this.labelPASSWORD.AutoSize = true;
            this.labelPASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPASSWORD.Location = new System.Drawing.Point(28, 210);
            this.labelPASSWORD.Name = "labelPASSWORD";
            this.labelPASSWORD.Size = new System.Drawing.Size(123, 22);
            this.labelPASSWORD.TabIndex = 4;
            this.labelPASSWORD.Text = "PASSWORD";
            this.labelPASSWORD.Click += new System.EventHandler(this.labelPASSWORD_Click);
            // 
            // buttonLOGIN
            // 
            this.buttonLOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLOGIN.Location = new System.Drawing.Point(187, 329);
            this.buttonLOGIN.Name = "buttonLOGIN";
            this.buttonLOGIN.Size = new System.Drawing.Size(92, 101);
            this.buttonLOGIN.TabIndex = 5;
            this.buttonLOGIN.Text = "LOGIN";
            this.buttonLOGIN.UseVisualStyleBackColor = true;
            this.buttonLOGIN.Click += new System.EventHandler(this.buttonLOGIN_Click);
            // 
            // buttonSIGNUP
            // 
            this.buttonSIGNUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSIGNUP.Location = new System.Drawing.Point(318, 329);
            this.buttonSIGNUP.Name = "buttonSIGNUP";
            this.buttonSIGNUP.Size = new System.Drawing.Size(91, 101);
            this.buttonSIGNUP.TabIndex = 6;
            this.buttonSIGNUP.Text = "SIGN  UP";
            this.buttonSIGNUP.UseVisualStyleBackColor = true;
            this.buttonSIGNUP.Click += new System.EventHandler(this.buttonSIGNUP_Click);
            // 
            // LoginSignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 520);
            this.Controls.Add(this.buttonSIGNUP);
            this.Controls.Add(this.buttonLOGIN);
            this.Controls.Add(this.labelPASSWORD);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.textBoxPASSWORD);
            this.Controls.Add(this.textBoxUSERNAME);
            this.Controls.Add(this.label1);
            this.Name = "LoginSignupForm";
            this.Text = "LoginSignupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUSERNAME;
        private System.Windows.Forms.TextBox textBoxPASSWORD;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPASSWORD;
        private System.Windows.Forms.Button buttonLOGIN;
        private System.Windows.Forms.Button buttonSIGNUP;
    }
}