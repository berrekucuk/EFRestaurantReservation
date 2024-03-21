namespace _03.EFRestaurantReservation.Froms
{
    partial class FrmMenu
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtAddTitle = new TextBox();
            txtAddDescription = new TextBox();
            txtAddPrice = new TextBox();
            btnAdd = new Button();
            dgvMenuList = new DataGridView();
            btnDelete = new Button();
            txtUpdatePrice = new TextBox();
            txtUpdateDescription = new TextBox();
            txtUpdateTitle = new TextBox();
            btnUpdate = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMenuList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 24);
            label1.Name = "label1";
            label1.Size = new Size(58, 22);
            label1.TabIndex = 0;
            label1.Text = "Title :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 65);
            label2.Name = "label2";
            label2.Size = new Size(114, 22);
            label2.TabIndex = 1;
            label2.Text = "Description :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(144, 107);
            label3.Name = "label3";
            label3.Size = new Size(52, 22);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // txtAddTitle
            // 
            txtAddTitle.Location = new Point(263, 21);
            txtAddTitle.Name = "txtAddTitle";
            txtAddTitle.Size = new Size(258, 30);
            txtAddTitle.TabIndex = 3;
            // 
            // txtAddDescription
            // 
            txtAddDescription.Location = new Point(263, 62);
            txtAddDescription.Name = "txtAddDescription";
            txtAddDescription.Size = new Size(258, 30);
            txtAddDescription.TabIndex = 4;
            // 
            // txtAddPrice
            // 
            txtAddPrice.Location = new Point(263, 104);
            txtAddPrice.Name = "txtAddPrice";
            txtAddPrice.Size = new Size(258, 30);
            txtAddPrice.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(427, 155);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 54);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvMenuList
            // 
            dgvMenuList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenuList.Location = new Point(18, 220);
            dgvMenuList.Name = "dgvMenuList";
            dgvMenuList.RowHeadersWidth = 51;
            dgvMenuList.Size = new Size(739, 253);
            dgvMenuList.TabIndex = 7;
            dgvMenuList.CellClick += dgvMenuList_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(659, 488);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 47);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtUpdatePrice
            // 
            txtUpdatePrice.Location = new Point(907, 303);
            txtUpdatePrice.Name = "txtUpdatePrice";
            txtUpdatePrice.Size = new Size(258, 30);
            txtUpdatePrice.TabIndex = 12;
            // 
            // txtUpdateDescription
            // 
            txtUpdateDescription.Location = new Point(907, 261);
            txtUpdateDescription.Name = "txtUpdateDescription";
            txtUpdateDescription.Size = new Size(258, 30);
            txtUpdateDescription.TabIndex = 13;
            // 
            // txtUpdateTitle
            // 
            txtUpdateTitle.Location = new Point(907, 220);
            txtUpdateTitle.Name = "txtUpdateTitle";
            txtUpdateTitle.Size = new Size(258, 30);
            txtUpdateTitle.TabIndex = 14;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(1071, 366);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 41);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(768, 306);
            label4.Name = "label4";
            label4.Size = new Size(52, 22);
            label4.TabIndex = 18;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(768, 264);
            label5.Name = "label5";
            label5.Size = new Size(114, 22);
            label5.TabIndex = 17;
            label5.Text = "Description :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(768, 223);
            label6.Name = "label6";
            label6.Size = new Size(58, 22);
            label6.TabIndex = 16;
            label6.Text = "Title :";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1188, 560);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(btnUpdate);
            Controls.Add(txtUpdateTitle);
            Controls.Add(txtUpdateDescription);
            Controls.Add(txtUpdatePrice);
            Controls.Add(btnDelete);
            Controls.Add(dgvMenuList);
            Controls.Add(btnAdd);
            Controls.Add(txtAddPrice);
            Controls.Add(txtAddDescription);
            Controls.Add(txtAddTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmMenu";
            Text = "FrmMenu";
            Load += FrmMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMenuList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtAddTitle;
        private TextBox txtAddDescription;
        private TextBox txtAddPrice;
        private Button btnAdd;
        private DataGridView dgvMenuList;
        private Button btnDelete;
        private TextBox txtUpdatePrice;
        private TextBox txtUpdateDescription;
        private TextBox txtUpdateTitle;
        private Button btnUpdate;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}