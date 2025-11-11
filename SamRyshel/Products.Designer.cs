namespace $safeprojectname$
{
    partial class Products
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
            listViewFood = new ListView();
            listViewDrinks = new ListView();
            btnAddFood = new Button();
            btnDelFood = new Button();
            btnDelDrinks = new Button();
            btnAddDrinks = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(153, 22);
            label1.Name = "label1";
            label1.Size = new Size(136, 32);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTS";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(76, 75);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 1;
            label2.Text = "FOOD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(302, 75);
            label3.Name = "label3";
            label3.Size = new Size(65, 21);
            label3.TabIndex = 2;
            label3.Text = "DRINKS";
            // 
            // listViewFood
            // 
            listViewFood.Location = new Point(29, 99);
            listViewFood.Name = "listViewFood";
            listViewFood.Size = new Size(150, 200);
            listViewFood.TabIndex = 3;
            listViewFood.UseCompatibleStateImageBehavior = false;
            // 
            // listViewDrinks
            // 
            listViewDrinks.Location = new Point(256, 99);
            listViewDrinks.Name = "listViewDrinks";
            listViewDrinks.Size = new Size(150, 200);
            listViewDrinks.TabIndex = 4;
            listViewDrinks.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(29, 331);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(70, 23);
            btnAddFood.TabIndex = 5;
            btnAddFood.Text = "ADD";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // btnDelFood
            // 
            btnDelFood.Location = new Point(109, 331);
            btnDelFood.Name = "btnDelFood";
            btnDelFood.Size = new Size(70, 23);
            btnDelFood.TabIndex = 6;
            btnDelFood.Text = "DEL";
            btnDelFood.UseVisualStyleBackColor = true;
            btnDelFood.Click += btnDelFood_Click;
            // 
            // btnDelDrinks
            // 
            btnDelDrinks.Location = new Point(336, 331);
            btnDelDrinks.Name = "btnDelDrinks";
            btnDelDrinks.Size = new Size(70, 23);
            btnDelDrinks.TabIndex = 8;
            btnDelDrinks.Text = "DEL";
            btnDelDrinks.UseVisualStyleBackColor = true;
            btnDelDrinks.Click += btnDelDrinks_Click;
            // 
            // btnAddDrinks
            // 
            btnAddDrinks.Location = new Point(256, 331);
            btnAddDrinks.Name = "btnAddDrinks";
            btnAddDrinks.Size = new Size(70, 23);
            btnAddDrinks.TabIndex = 7;
            btnAddDrinks.Text = "ADD";
            btnAddDrinks.UseVisualStyleBackColor = true;
            btnAddDrinks.Click += btnAddDrinks_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 411);
            Controls.Add(btnDelDrinks);
            Controls.Add(btnAddDrinks);
            Controls.Add(btnDelFood);
            Controls.Add(btnAddFood);
            Controls.Add(listViewDrinks);
            Controls.Add(listViewFood);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Products";
            Text = "Products";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListView listViewFood;
        private ListView listViewDrinks;
        private Button btnAddFood;
        private Button btnDelFood;
        private Button btnDelDrinks;
        private Button btnAddDrinks;
    }
}