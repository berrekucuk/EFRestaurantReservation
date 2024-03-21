namespace _03.EFRestaurantReservation
{
    partial class FrmCustomer
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
            txtAddName = new TextBox();
            txtAddSurname = new TextBox();
            txtAddEmail = new TextBox();
            txtAddPhone = new TextBox();
            txtAddAddress = new TextBox();
            dgvCustomerList = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtUpdateAddress = new TextBox();
            txtUpdatePhone = new TextBox();
            txtUpdateEmail = new TextBox();
            txtUpdateSurname = new TextBox();
            txtUpdateName = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 28);
            label1.Name = "label1";
            label1.Size = new Size(67, 22);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 71);
            label2.Name = "label2";
            label2.Size = new Size(89, 22);
            label2.TabIndex = 1;
            label2.Text = "Surname :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 117);
            label3.Name = "label3";
            label3.Size = new Size(68, 22);
            label3.TabIndex = 2;
            label3.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 160);
            label4.Name = "label4";
            label4.Size = new Size(69, 22);
            label4.TabIndex = 3;
            label4.Text = "Phone :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 208);
            label5.Name = "label5";
            label5.Size = new Size(87, 22);
            label5.TabIndex = 4;
            label5.Text = "Address :";
            // 
            // txtAddName
            // 
            txtAddName.Location = new Point(119, 25);
            txtAddName.Name = "txtAddName";
            txtAddName.Size = new Size(247, 30);
            txtAddName.TabIndex = 5;
            // 
            // txtAddSurname
            // 
            txtAddSurname.Location = new Point(119, 68);
            txtAddSurname.Name = "txtAddSurname";
            txtAddSurname.Size = new Size(247, 30);
            txtAddSurname.TabIndex = 6;
            // 
            // txtAddEmail
            // 
            txtAddEmail.Location = new Point(119, 114);
            txtAddEmail.Name = "txtAddEmail";
            txtAddEmail.Size = new Size(247, 30);
            txtAddEmail.TabIndex = 7;
            // 
            // txtAddPhone
            // 
            txtAddPhone.Location = new Point(119, 157);
            txtAddPhone.Name = "txtAddPhone";
            txtAddPhone.Size = new Size(247, 30);
            txtAddPhone.TabIndex = 8;
            // 
            // txtAddAddress
            // 
            txtAddAddress.Location = new Point(119, 205);
            txtAddAddress.Name = "txtAddAddress";
            txtAddAddress.Size = new Size(247, 30);
            txtAddAddress.TabIndex = 9;
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerList.Location = new Point(393, 25);
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.RowHeadersWidth = 51;
            dgvCustomerList.Size = new Size(910, 281);
            dgvCustomerList.TabIndex = 10;
            dgvCustomerList.CellClick += dgvCustomerList_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(227, 263);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(139, 43);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(1180, 325);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(123, 45);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(802, 504);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(187, 49);
            btnUpdate.TabIndex = 67;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtUpdateAddress
            // 
            txtUpdateAddress.Location = new Point(345, 504);
            txtUpdateAddress.Name = "txtUpdateAddress";
            txtUpdateAddress.Size = new Size(247, 30);
            txtUpdateAddress.TabIndex = 66;
            // 
            // txtUpdatePhone
            // 
            txtUpdatePhone.Location = new Point(742, 456);
            txtUpdatePhone.Name = "txtUpdatePhone";
            txtUpdatePhone.Size = new Size(247, 30);
            txtUpdatePhone.TabIndex = 65;
            // 
            // txtUpdateEmail
            // 
            txtUpdateEmail.Location = new Point(742, 413);
            txtUpdateEmail.Name = "txtUpdateEmail";
            txtUpdateEmail.Size = new Size(247, 30);
            txtUpdateEmail.TabIndex = 64;
            // 
            // txtUpdateSurname
            // 
            txtUpdateSurname.Location = new Point(345, 456);
            txtUpdateSurname.Name = "txtUpdateSurname";
            txtUpdateSurname.Size = new Size(247, 30);
            txtUpdateSurname.TabIndex = 63;
            // 
            // txtUpdateName
            // 
            txtUpdateName.Location = new Point(345, 413);
            txtUpdateName.Name = "txtUpdateName";
            txtUpdateName.Size = new Size(247, 30);
            txtUpdateName.TabIndex = 62;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 507);
            label6.Name = "label6";
            label6.Size = new Size(87, 22);
            label6.TabIndex = 61;
            label6.Text = "Address :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(647, 459);
            label7.Name = "label7";
            label7.Size = new Size(69, 22);
            label7.TabIndex = 60;
            label7.Text = "Phone :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(647, 416);
            label8.Name = "label8";
            label8.Size = new Size(68, 22);
            label8.TabIndex = 59;
            label8.Text = "Email :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(250, 459);
            label9.Name = "label9";
            label9.Size = new Size(89, 22);
            label9.TabIndex = 58;
            label9.Text = "Surname :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(250, 416);
            label10.Name = "label10";
            label10.Size = new Size(67, 22);
            label10.TabIndex = 57;
            label10.Text = "Name :";
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 665);
            Controls.Add(btnUpdate);
            Controls.Add(txtUpdateAddress);
            Controls.Add(txtUpdatePhone);
            Controls.Add(txtUpdateEmail);
            Controls.Add(txtUpdateSurname);
            Controls.Add(txtUpdateName);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvCustomerList);
            Controls.Add(txtAddAddress);
            Controls.Add(txtAddPhone);
            Controls.Add(txtAddEmail);
            Controls.Add(txtAddSurname);
            Controls.Add(txtAddName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAddName;
        private TextBox txtAddSurname;
        private TextBox txtAddEmail;
        private TextBox txtAddPhone;
        private TextBox txtAddAddress;
        private DataGridView dgvCustomerList;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtUpdateAddress;
        private TextBox txtUpdatePhone;
        private TextBox txtUpdateEmail;
        private TextBox txtUpdateSurname;
        private TextBox txtUpdateName;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
