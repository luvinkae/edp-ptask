namespace $safeprojectname$
{
    partial class AddDrinks
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
            lblPrintAddDrinks = new Label();
            btnDrinkAdd = new Button();
            tbDrinkPrice = new TextBox();
            tbDrinkName = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblPrintAddDrinks
            // 
            lblPrintAddDrinks.AutoSize = true;
            lblPrintAddDrinks.Location = new Point(240, 143);
            lblPrintAddDrinks.Name = "lblPrintAddDrinks";
            lblPrintAddDrinks.Size = new Size(0, 15);
            lblPrintAddDrinks.TabIndex = 9;
            lblPrintAddDrinks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDrinkAdd
            // 
            btnDrinkAdd.Location = new Point(191, 178);
            btnDrinkAdd.Name = "btnDrinkAdd";
            btnDrinkAdd.Size = new Size(96, 31);
            btnDrinkAdd.TabIndex = 8;
            btnDrinkAdd.Text = "ADD";
            btnDrinkAdd.UseVisualStyleBackColor = true;
            // 
            // tbDrinkPrice
            // 
            tbDrinkPrice.Location = new Point(271, 96);
            tbDrinkPrice.Name = "tbDrinkPrice";
            tbDrinkPrice.Size = new Size(102, 23);
            tbDrinkPrice.TabIndex = 7;
            // 
            // tbDrinkName
            // 
            tbDrinkName.Location = new Point(87, 96);
            tbDrinkName.Name = "tbDrinkName";
            tbDrinkName.Size = new Size(165, 23);
            tbDrinkName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 38);
            label1.Name = "label1";
            label1.Size = new Size(156, 32);
            label1.TabIndex = 5;
            label1.Text = "ADD DRINKS";
            // 
            // AddDrinks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(lblPrintAddDrinks);
            Controls.Add(btnDrinkAdd);
            Controls.Add(tbDrinkPrice);
            Controls.Add(tbDrinkName);
            Controls.Add(label1);
            Name = "AddDrinks";
            Text = "AddDrinks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrintAddDrinks;
        private Button btnDrinkAdd;
        private TextBox tbDrinkPrice;
        private TextBox tbDrinkName;
        private Label label1;
    }
}