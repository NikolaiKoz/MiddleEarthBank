namespace MiddleEarthBank
{
    partial class Loan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loan));
            this.Welcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PersonalInformation = new System.Windows.Forms.Panel();
            this.Birdthplace = new System.Windows.Forms.ComboBox();
            this.Race = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoanDetails = new System.Windows.Forms.Panel();
            this.LoanAmount = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.Dues = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PersonalInformation.SuspendLayout();
            this.LoanDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Welcome.Location = new System.Drawing.Point(49, 33);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(136, 29);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome, ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(717, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.SaddleBrown;
            this.BtnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnConfirm.Location = new System.Drawing.Point(327, 384);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(140, 65);
            this.BtnConfirm.TabIndex = 2;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Personal information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(482, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loan details";
            // 
            // PersonalInformation
            // 
            this.PersonalInformation.BackColor = System.Drawing.Color.SandyBrown;
            this.PersonalInformation.Controls.Add(this.Birdthplace);
            this.PersonalInformation.Controls.Add(this.Race);
            this.PersonalInformation.Controls.Add(this.label4);
            this.PersonalInformation.Controls.Add(this.label3);
            this.errorProvider1.SetIconAlignment(this.PersonalInformation, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.PersonalInformation.Location = new System.Drawing.Point(57, 122);
            this.PersonalInformation.Name = "PersonalInformation";
            this.PersonalInformation.Size = new System.Drawing.Size(266, 167);
            this.PersonalInformation.TabIndex = 5;
            // 
            // Birdthplace
            // 
            this.Birdthplace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Birdthplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Birdthplace.FormattingEnabled = true;
            this.Birdthplace.Location = new System.Drawing.Point(114, 96);
            this.Birdthplace.Name = "Birdthplace";
            this.Birdthplace.Size = new System.Drawing.Size(121, 21);
            this.Birdthplace.TabIndex = 3;
            this.Birdthplace.SelectedIndexChanged += new System.EventHandler(this.Birdthplace_SelectedIndexChanged);
            // 
            // Race
            // 
            this.Race.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Race.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Race.FormattingEnabled = true;
            this.Race.Location = new System.Drawing.Point(114, 33);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(121, 21);
            this.Race.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(20, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Birthplace:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(56, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Race:";
            // 
            // LoanDetails
            // 
            this.LoanDetails.BackColor = System.Drawing.Color.SandyBrown;
            this.LoanDetails.Controls.Add(this.LoanAmount);
            this.LoanDetails.Controls.Add(this.comboBox3);
            this.LoanDetails.Controls.Add(this.Dues);
            this.LoanDetails.Controls.Add(this.label5);
            this.LoanDetails.Location = new System.Drawing.Point(485, 122);
            this.LoanDetails.Name = "LoanDetails";
            this.LoanDetails.Size = new System.Drawing.Size(266, 167);
            this.LoanDetails.TabIndex = 6;
            // 
            // LoanAmount
            // 
            this.LoanAmount.Location = new System.Drawing.Point(132, 36);
            this.LoanAmount.Name = "LoanAmount";
            this.LoanAmount.Size = new System.Drawing.Size(100, 20);
            this.LoanAmount.TabIndex = 3;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(111, 96);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 2;
            // 
            // Dues
            // 
            this.Dues.AutoSize = true;
            this.Dues.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Dues.Location = new System.Drawing.Point(53, 99);
            this.Dues.Name = "Dues";
            this.Dues.Size = new System.Drawing.Size(52, 18);
            this.Dues.TabIndex = 1;
            this.Dues.Text = "Dues:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(15, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loan amount:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.LoanDetails);
            this.Controls.Add(this.PersonalInformation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Loan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan";
            this.Load += new System.EventHandler(this.Loan_Load);
            this.PersonalInformation.ResumeLayout(false);
            this.PersonalInformation.PerformLayout();
            this.LoanDetails.ResumeLayout(false);
            this.LoanDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PersonalInformation;
        private System.Windows.Forms.ComboBox Birdthplace;
        private System.Windows.Forms.ComboBox Race;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel LoanDetails;
        private System.Windows.Forms.TextBox LoanAmount;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label Dues;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}