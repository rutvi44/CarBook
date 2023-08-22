namespace Assignment2_RutviM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label9 = new Label();
            txtCustomerName = new TextBox();
            txtAddress = new TextBox();
            txtCity = new TextBox();
            txtProvince = new TextBox();
            txtPostalCode = new TextBox();
            txtHomePhone = new TextBox();
            txtCellPhone = new TextBox();
            txtEmail = new TextBox();
            txtMake_Model = new TextBox();
            txtYear = new TextBox();
            dateTimePickerAppointment = new DateTimePicker();
            richTextBoxProblem = new RichTextBox();
            btnBookAppointment = new Button();
            btnReset = new Button();
            btnClose = new Button();
            btnPrefill = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 25);
            label1.TabIndex = 0;
            label1.Text = "Customer Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 53);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 1;
            label2.Text = "Address:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 100);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 2;
            label3.Text = "City:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 143);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(118, 25);
            label4.TabIndex = 3;
            label4.Text = "Province:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 188);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(152, 25);
            label5.TabIndex = 4;
            label5.Text = "Postal Code:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 239);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(162, 25);
            label6.TabIndex = 5;
            label6.Text = "Home Phone:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 288);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(138, 25);
            label7.TabIndex = 6;
            label7.Text = "Cell Phone:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 333);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(82, 25);
            label8.TabIndex = 7;
            label8.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(740, 58);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(71, 25);
            label10.TabIndex = 9;
            label10.Text = "Year:";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(740, 108);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(224, 25);
            label11.TabIndex = 10;
            label11.Text = "Appointment Date:";
            label11.Click += label11_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(740, 161);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(114, 25);
            label12.TabIndex = 11;
            label12.Text = "Problem:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(740, 15);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(159, 25);
            label9.TabIndex = 12;
            label9.Text = "Make & Model:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(213, 12);
            txtCustomerName.Margin = new Padding(2);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(329, 37);
            txtCustomerName.TabIndex = 13;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(213, 55);
            txtAddress.Margin = new Padding(2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(326, 37);
            txtAddress.TabIndex = 14;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(213, 98);
            txtCity.Margin = new Padding(2);
            txtCity.Multiline = true;
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(326, 35);
            txtCity.TabIndex = 15;
            // 
            // txtProvince
            // 
            txtProvince.Location = new Point(213, 143);
            txtProvince.Margin = new Padding(2);
            txtProvince.Multiline = true;
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(327, 33);
            txtProvince.TabIndex = 16;
            // 
            // txtPostalCode
            // 
            txtPostalCode.Location = new Point(213, 188);
            txtPostalCode.Margin = new Padding(2);
            txtPostalCode.Multiline = true;
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.Size = new Size(329, 34);
            txtPostalCode.TabIndex = 17;
            // 
            // txtHomePhone
            // 
            txtHomePhone.Location = new Point(210, 235);
            txtHomePhone.Margin = new Padding(2);
            txtHomePhone.Multiline = true;
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(330, 37);
            txtHomePhone.TabIndex = 18;
            // 
            // txtCellPhone
            // 
            txtCellPhone.Location = new Point(211, 281);
            txtCellPhone.Margin = new Padding(2);
            txtCellPhone.Multiline = true;
            txtCellPhone.Name = "txtCellPhone";
            txtCellPhone.Size = new Size(329, 40);
            txtCellPhone.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(209, 330);
            txtEmail.Margin = new Padding(2);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(332, 36);
            txtEmail.TabIndex = 20;
            // 
            // txtMake_Model
            // 
            txtMake_Model.Location = new Point(1026, 9);
            txtMake_Model.Margin = new Padding(2);
            txtMake_Model.Multiline = true;
            txtMake_Model.Name = "txtMake_Model";
            txtMake_Model.Size = new Size(382, 38);
            txtMake_Model.TabIndex = 21;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(1026, 58);
            txtYear.Margin = new Padding(2);
            txtYear.Multiline = true;
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(382, 37);
            txtYear.TabIndex = 22;
            // 
            // dateTimePickerAppointment
            // 
            dateTimePickerAppointment.Format = DateTimePickerFormat.Custom;
            dateTimePickerAppointment.Location = new Point(1026, 108);
            dateTimePickerAppointment.Margin = new Padding(2);
            dateTimePickerAppointment.Name = "dateTimePickerAppointment";
            dateTimePickerAppointment.Size = new Size(382, 31);
            dateTimePickerAppointment.TabIndex = 23;
            // 
            // richTextBoxProblem
            // 
            richTextBoxProblem.Location = new Point(1026, 158);
            richTextBoxProblem.Margin = new Padding(2);
            richTextBoxProblem.Name = "richTextBoxProblem";
            richTextBoxProblem.Size = new Size(382, 163);
            richTextBoxProblem.TabIndex = 24;
            richTextBoxProblem.Text = "";
            richTextBoxProblem.TextChanged += richTextBoxProblem_TextChanged;
            // 
            // btnBookAppointment
            // 
            btnBookAppointment.BackColor = SystemColors.ActiveCaption;
            btnBookAppointment.Location = new Point(805, 364);
            btnBookAppointment.Margin = new Padding(2);
            btnBookAppointment.Name = "btnBookAppointment";
            btnBookAppointment.Size = new Size(114, 41);
            btnBookAppointment.TabIndex = 26;
            btnBookAppointment.Text = "Book Appointment";
            btnBookAppointment.UseVisualStyleBackColor = false;
            btnBookAppointment.Click += btnBookAppointment_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ActiveCaption;
            btnReset.Location = new Point(958, 364);
            btnReset.Margin = new Padding(2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(130, 39);
            btnReset.TabIndex = 27;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ActiveCaption;
            btnClose.Location = new Point(1271, 361);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(137, 42);
            btnClose.TabIndex = 28;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnPrefill
            // 
            btnPrefill.BackColor = SystemColors.ActiveCaption;
            btnPrefill.Location = new Point(1117, 362);
            btnPrefill.Margin = new Padding(2);
            btnPrefill.Name = "btnPrefill";
            btnPrefill.Size = new Size(130, 41);
            btnPrefill.TabIndex = 29;
            btnPrefill.Text = "Pre-Fill";
            btnPrefill.UseVisualStyleBackColor = false;
            btnPrefill.Click += btnPrefill_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.FromArgb(192, 0, 0);
            lblError.Location = new Point(24, 442);
            lblError.Margin = new Padding(2, 0, 2, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(70, 25);
            lblError.TabIndex = 30;
            lblError.Text = "Error";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1440, 718);
            Controls.Add(lblError);
            Controls.Add(btnPrefill);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(btnBookAppointment);
            Controls.Add(richTextBoxProblem);
            Controls.Add(dateTimePickerAppointment);
            Controls.Add(txtYear);
            Controls.Add(txtMake_Model);
            Controls.Add(txtEmail);
            Controls.Add(txtCellPhone);
            Controls.Add(txtHomePhone);
            Controls.Add(txtPostalCode);
            Controls.Add(txtProvince);
            Controls.Add(txtCity);
            Controls.Add(txtAddress);
            Controls.Add(txtCustomerName);
            Controls.Add(label9);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Book Car Maintenance";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label9;
        private TextBox txtCustomerName;
        private TextBox txtAddress;
        private TextBox txtCity;
        private TextBox txtProvince;
        private TextBox txtPostalCode;
        private TextBox txtHomePhone;
        private TextBox txtCellPhone;
        private TextBox txtEmail;
        private TextBox txtMake_Model;
        private TextBox txtYear;
        private DateTimePicker dateTimePickerAppointment;
        private RichTextBox richTextBoxProblem;
        private Button btnBookAppointment;
        private Button btnReset;
        private Button btnClose;
        private Button btnPrefill;
        private Label lblError;
    }
}