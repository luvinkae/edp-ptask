namespace $safeprojectname$
{
    partial class Orders
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
            listViewDrinks = new ListView();
            listViewFood = new ListView();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnOrder = new Button();
            SuspendLayout();
            // 
            // listViewDrinks
            // 
            listViewDrinks.Location = new Point(256, 101);
            listViewDrinks.Name = "listViewDrinks";
            listViewDrinks.Size = new Size(150, 200);
            listViewDrinks.TabIndex = 9;
            listViewDrinks.UseCompatibleStateImageBehavior = false;
            // 
            // listViewFood
            // 
            listViewFood.Location = new Point(29, 101);
            listViewFood.Name = "listViewFood";
            listViewFood.Size = new Size(150, 200);
            listViewFood.TabIndex = 8;
            listViewFood.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(302, 77);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 7;
            label3.Text = "DRINKS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 77);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 6;
            label2.Text = "FOOD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(168, 25);
            label1.Name = "label1";
            label1.Size = new Size(104, 32);
            label1.TabIndex = 5;
            label1.Text = "ORDERS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOrder.Location = new Point(159, 342);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(130, 38);
            btnOrder.TabIndex = 10;
            btnOrder.Text = "ORDER";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 411);
            Controls.Add(btnOrder);
            Controls.Add(listViewDrinks);
            Controls.Add(listViewFood);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Orders";
            Text = "Orders";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewDrinks;
        private ListView listViewFood;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnOrder;
    }
}