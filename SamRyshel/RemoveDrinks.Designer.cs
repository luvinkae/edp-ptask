namespace $safeprojectname$
{
    partial class RemoveDrinks
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
            lblPrintRemoveDrinks = new Label();
            btnDrinkRemove = new Button();
            tbDrink = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblPrintRemoveDrinks
            // 
            lblPrintRemoveDrinks.AutoSize = true;
            lblPrintRemoveDrinks.Location = new Point(248, 148);
            lblPrintRemoveDrinks.Name = "lblPrintRemoveDrinks";
            lblPrintRemoveDrinks.Size = new Size(0, 15);
            lblPrintRemoveDrinks.TabIndex = 18;
            lblPrintRemoveDrinks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDrinkRemove
            // 
            btnDrinkRemove.Location = new Point(199, 183);
            btnDrinkRemove.Name = "btnDrinkRemove";
            btnDrinkRemove.Size = new Size(96, 31);
            btnDrinkRemove.TabIndex = 17;
            btnDrinkRemove.Text = "REMOVE";
            btnDrinkRemove.UseVisualStyleBackColor = true;
            // 
            // tbDrink
            // 
            tbDrink.Location = new Point(152, 105);
            tbDrink.Name = "tbDrink";
            tbDrink.Size = new Size(180, 23);
            tbDrink.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 47);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 15;
            label1.Text = "REMOVE DRINKS";
            // 
            // RemoveDrinks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(lblPrintRemoveDrinks);
            Controls.Add(btnDrinkRemove);
            Controls.Add(tbDrink);
            Controls.Add(label1);
            Name = "RemoveDrinks";
            Text = "RemoveDrinks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrintRemoveDrinks;
        private Button btnDrinkRemove;
        private TextBox tbDrink;
        private Label label1;
    }
}