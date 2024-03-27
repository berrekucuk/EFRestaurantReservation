namespace _03.EFRestaurantReservation.Froms
{
    partial class FrmCreateOrder
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
            label4 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(250, 22);
            label1.TabIndex = 0;
            label1.Text = "Reservation Date - Customer :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 79);
            label2.Name = "label2";
            label2.Size = new Size(73, 22);
            label2.TabIndex = 1;
            label2.Text = "Menus :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 125);
            label3.Name = "label3";
            label3.Size = new Size(110, 22);
            label3.TabIndex = 2;
            label3.Text = "Order Date :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 174);
            label4.Name = "label4";
            label4.Size = new Size(87, 22);
            label4.TabIndex = 3;
            label4.Text = "Quantity :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(301, 28);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(331, 30);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(151, 76);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(481, 30);
            comboBox2.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(151, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(481, 30);
            textBox2.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.ForeColor = SystemColors.ButtonHighlight;
            btnAdd.Location = new Point(681, 130);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(146, 71);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(804, 271);
            dataGridView1.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(151, 119);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(481, 30);
            dateTimePicker1.TabIndex = 10;
            // 
            // FrmCreateOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 494);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmCreateOrder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCreateOrder";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
    }
}