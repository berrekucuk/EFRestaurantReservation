namespace _03.EFRestaurantReservation.Froms
{
    partial class FrmMainOperations
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
            btnCustomer = new Button();
            btnMenu = new Button();
            btnReservation = new Button();
            btnOrder = new Button();
            SuspendLayout();
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.LightSeaGreen;
            btnCustomer.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnCustomer.ForeColor = SystemColors.ButtonHighlight;
            btnCustomer.Location = new Point(474, 12);
            btnCustomer.Margin = new Padding(4, 3, 4, 3);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(242, 117);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Customers";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.LightSeaGreen;
            btnMenu.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnMenu.ForeColor = SystemColors.ButtonHighlight;
            btnMenu.Location = new Point(724, 12);
            btnMenu.Margin = new Padding(4, 3, 4, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(242, 117);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnReservation
            // 
            btnReservation.BackColor = Color.LightSeaGreen;
            btnReservation.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnReservation.ForeColor = SystemColors.ButtonHighlight;
            btnReservation.Location = new Point(974, 12);
            btnReservation.Margin = new Padding(4, 3, 4, 3);
            btnReservation.Name = "btnReservation";
            btnReservation.Size = new Size(242, 117);
            btnReservation.TabIndex = 2;
            btnReservation.Text = "Resevation";
            btnReservation.UseVisualStyleBackColor = false;
            btnReservation.Click += btnReservation_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.LightSeaGreen;
            btnOrder.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnOrder.ForeColor = SystemColors.ButtonHighlight;
            btnOrder.Location = new Point(1224, 12);
            btnOrder.Margin = new Padding(4, 3, 4, 3);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(242, 117);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = false;
            // 
            // FrmMainOperations
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1539, 720);
            Controls.Add(btnOrder);
            Controls.Add(btnReservation);
            Controls.Add(btnMenu);
            Controls.Add(btnCustomer);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            IsMdiContainer = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmMainOperations";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMainOperations";
            WindowState = FormWindowState.Maximized;
            Load += FrmMainOperations_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCustomer;
        private Button btnMenu;
        private Button btnReservation;
        private Button btnOrder;
    }
}