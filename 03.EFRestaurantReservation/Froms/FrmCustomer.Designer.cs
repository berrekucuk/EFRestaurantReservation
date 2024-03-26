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
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            dgvCustomerList = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
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
            label2.Location = new Point(390, 28);
            label2.Name = "label2";
            label2.Size = new Size(89, 22);
            label2.TabIndex = 1;
            label2.Text = "Surname :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 76);
            label3.Name = "label3";
            label3.Size = new Size(68, 22);
            label3.TabIndex = 2;
            label3.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(390, 76);
            label4.Name = "label4";
            label4.Size = new Size(69, 22);
            label4.TabIndex = 3;
            label4.Text = "Phone :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 124);
            label5.Name = "label5";
            label5.Size = new Size(87, 22);
            label5.TabIndex = 4;
            label5.Text = "Address :";
            // 
            // txtName
            // 
            txtName.Location = new Point(119, 25);
            txtName.Name = "txtName";
            txtName.Size = new Size(247, 30);
            txtName.TabIndex = 5;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(485, 25);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(247, 30);
            txtSurname.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(119, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(247, 30);
            txtEmail.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(485, 73);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(247, 30);
            txtPhone.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(119, 121);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(247, 30);
            txtAddress.TabIndex = 9;
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerList.Location = new Point(30, 182);
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.RowHeadersWidth = 51;
            dgvCustomerList.Size = new Size(910, 290);
            dgvCustomerList.TabIndex = 10;
            dgvCustomerList.CellClick += dgvCustomerList_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(753, 25);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(187, 43);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(753, 131);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(187, 45);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(753, 74);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(187, 49);
            btnUpdate.TabIndex = 67;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FrmCustomer
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 494);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dgvCustomerList);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
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
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private DataGridView dgvCustomerList;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
    }
}
