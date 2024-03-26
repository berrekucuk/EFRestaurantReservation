namespace _03.EFRestaurantReservation.Froms
{
    partial class FrmReservationCreate
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
            cmbCustomer = new ComboBox();
            dtpreservationDate = new DateTimePicker();
            txtDescription = new TextBox();
            btnAdd = new Button();
            dgvResevationList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResevationList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 40);
            label1.Name = "label1";
            label1.Size = new Size(96, 22);
            label1.TabIndex = 0;
            label1.Text = "Customer :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 96);
            label2.Name = "label2";
            label2.Size = new Size(158, 22);
            label2.TabIndex = 1;
            label2.Text = "Reservation Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 158);
            label3.Name = "label3";
            label3.Size = new Size(114, 22);
            label3.TabIndex = 2;
            label3.Text = "Description :";
            // 
            // cmbCustomer
            // 
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(220, 37);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(321, 30);
            cmbCustomer.TabIndex = 3;
            // 
            // dtpreservationDate
            // 
            dtpreservationDate.Location = new Point(220, 90);
            dtpreservationDate.Name = "dtpreservationDate";
            dtpreservationDate.Size = new Size(321, 30);
            dtpreservationDate.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(220, 155);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(321, 30);
            txtDescription.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(612, 113);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 72);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvResevationList
            // 
            dgvResevationList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvResevationList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResevationList.Location = new Point(32, 213);
            dgvResevationList.Name = "dgvResevationList";
            dgvResevationList.RowHeadersWidth = 51;
            dgvResevationList.Size = new Size(796, 257);
            dgvResevationList.TabIndex = 7;
            // 
            // FrmReservationCreate
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 494);
            Controls.Add(dgvResevationList);
            Controls.Add(btnAdd);
            Controls.Add(txtDescription);
            Controls.Add(dtpreservationDate);
            Controls.Add(cmbCustomer);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmReservationCreate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmReservationCreate";
            Load += FrmReservationCreate_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResevationList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbCustomer;
        private DateTimePicker dtpreservationDate;
        private TextBox txtDescription;
        private Button btnAdd;
        private DataGridView dgvResevationList;
    }
}