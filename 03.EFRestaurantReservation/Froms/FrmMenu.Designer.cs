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
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            dgvMenuList = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMenuList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 33);
            label1.Name = "label1";
            label1.Size = new Size(58, 22);
            label1.TabIndex = 0;
            label1.Text = "Title :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 83);
            label2.Name = "label2";
            label2.Size = new Size(114, 22);
            label2.TabIndex = 1;
            label2.Text = "Description :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 137);
            label3.Name = "label3";
            label3.Size = new Size(52, 22);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(172, 30);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(391, 30);
            txtTitle.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(172, 80);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(391, 30);
            txtDescription.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(172, 134);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(391, 30);
            txtPrice.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.ForeColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(638, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(152, 48);
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
            dgvMenuList.Size = new Size(802, 316);
            dgvMenuList.TabIndex = 7;
            dgvMenuList.CellClick += dgvMenuList_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Brown;
            btnDelete.ForeColor = SystemColors.ButtonFace;
            btnDelete.Location = new Point(638, 134);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(152, 47);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.ForeColor = SystemColors.ButtonFace;
            btnUpdate.Location = new Point(638, 80);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(152, 48);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 560);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dgvMenuList);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
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
        private TextBox txtTitle;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Button btnAdd;
        private DataGridView dgvMenuList;
        private Button btnDelete;
        private Button btnUpdate;
    }
}