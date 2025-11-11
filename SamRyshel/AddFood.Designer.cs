namespace $safeprojectname$
{
    partial class AddFood
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
            tbFoodName = new TextBox();
            tbFoodPrice = new TextBox();
            btnFoodAdd = new Button();
            lblPrintAddFood = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 37);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 0;
            label1.Text = "ADD FOOD";
            // 
            // tbFoodName
            // 
            tbFoodName.Location = new Point(87, 95);
            tbFoodName.Name = "tbFoodName";
            tbFoodName.Size = new Size(165, 23);
            tbFoodName.TabIndex = 1;
            // 
            // tbFoodPrice
            // 
            tbFoodPrice.Location = new Point(271, 95);
            tbFoodPrice.Name = "tbFoodPrice";
            tbFoodPrice.Size = new Size(102, 23);
            tbFoodPrice.TabIndex = 2;
            // 
            // btnFoodAdd
            // 
            btnFoodAdd.Location = new Point(191, 177);
            btnFoodAdd.Name = "btnFoodAdd";
            btnFoodAdd.Size = new Size(96, 31);
            btnFoodAdd.TabIndex = 3;
            btnFoodAdd.Text = "ADD";
            btnFoodAdd.UseVisualStyleBackColor = true;
            // 
            // lblPrintAddFood
            // 
            lblPrintAddFood.AutoSize = true;
            lblPrintAddFood.Location = new Point(240, 142);
            lblPrintAddFood.Name = "lblPrintAddFood";
            lblPrintAddFood.Size = new Size(0, 15);
            lblPrintAddFood.TabIndex = 4;
            lblPrintAddFood.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddFood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(lblPrintAddFood);
            Controls.Add(btnFoodAdd);
            Controls.Add(tbFoodPrice);
            Controls.Add(tbFoodName);
            Controls.Add(label1);
            Name = "AddFood";
            Text = "AddFood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbFoodName;
        private TextBox tbFoodPrice;
        private Button btnFoodAdd;
        private Label lblPrintAddFood;
    }
}