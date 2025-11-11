namespace $safeprojectname$
{
    partial class RemoveFood
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
            lblPrintRemoveFood = new Label();
            btnFoodRemove = new Button();
            tbFood = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblPrintRemoveFood
            // 
            lblPrintRemoveFood.AutoSize = true;
            lblPrintRemoveFood.Location = new Point(252, 150);
            lblPrintRemoveFood.Name = "lblPrintRemoveFood";
            lblPrintRemoveFood.Size = new Size(0, 15);
            lblPrintRemoveFood.TabIndex = 14;
            lblPrintRemoveFood.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFoodRemove
            // 
            btnFoodRemove.Location = new Point(203, 185);
            btnFoodRemove.Name = "btnFoodRemove";
            btnFoodRemove.Size = new Size(96, 31);
            btnFoodRemove.TabIndex = 13;
            btnFoodRemove.Text = "REMOVE";
            btnFoodRemove.UseVisualStyleBackColor = true;
            // 
            // tbFood
            // 
            tbFood.Location = new Point(156, 107);
            tbFood.Name = "tbFood";
            tbFood.Size = new Size(180, 23);
            tbFood.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(156, 48);
            label1.Name = "label1";
            label1.Size = new Size(180, 32);
            label1.TabIndex = 10;
            label1.Text = "REMOVE FOOD";
            // 
            // RemoveFood
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(lblPrintRemoveFood);
            Controls.Add(btnFoodRemove);
            Controls.Add(tbFood);
            Controls.Add(label1);
            Name = "RemoveFood";
            Text = "RemoveFood";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrintRemoveFood;
        private Button btnFoodRemove;
        private TextBox tbFood;
        private Label label1;
    }
}