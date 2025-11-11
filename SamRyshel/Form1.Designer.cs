namespace $safeprojectname$
{
    partial class Main
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
            btnViewProducts = new Button();
            btnOrders = new Button();
            SuspendLayout();
            // 
            // btnViewProducts
            // 
            btnViewProducts.Location = new Point(106, 44);
            btnViewProducts.Name = "btnViewProducts";
            btnViewProducts.Size = new Size(188, 52);
            btnViewProducts.TabIndex = 0;
            btnViewProducts.Text = "VIEW PRODUCTS";
            btnViewProducts.UseVisualStyleBackColor = true;
            btnViewProducts.Click += btnViewProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.Location = new Point(106, 123);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(188, 52);
            btnOrders.TabIndex = 1;
            btnOrders.Text = "ORDERS";
            btnOrders.UseVisualStyleBackColor = true;
            btnOrders.Click += btnOrders_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 228);
            Controls.Add(btnOrders);
            Controls.Add(btnViewProducts);
            Name = "Main";
            Text = "$safeprojectname$";
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewProducts;
        private Button btnOrders;
    }
}
