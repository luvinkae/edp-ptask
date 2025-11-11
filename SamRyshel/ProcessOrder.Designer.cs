namespace $safeprojectname$
{
    partial class ProcessOrder
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
            tbItem = new TextBox();
            btnAddOrder = new Button();
            btnRemoveOrder = new Button();
            listViewOrder = new ListView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbPayment = new TextBox();
            btnPay = new Button();
            btnPrint = new Button();
            lblTotal = new Label();
            lblChange = new Label();
            SuspendLayout();
            // 
            // tbItem
            // 
            tbItem.Location = new Point(55, 21);
            tbItem.Name = "tbItem";
            tbItem.Size = new Size(163, 23);
            tbItem.TabIndex = 0;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(239, 21);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(92, 23);
            btnAddOrder.TabIndex = 1;
            btnAddOrder.Text = "ADD";
            btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // btnRemoveOrder
            // 
            btnRemoveOrder.Location = new Point(337, 20);
            btnRemoveOrder.Name = "btnRemoveOrder";
            btnRemoveOrder.Size = new Size(92, 23);
            btnRemoveOrder.TabIndex = 2;
            btnRemoveOrder.Text = "REMOVE";
            btnRemoveOrder.UseVisualStyleBackColor = true;
            // 
            // listViewOrder
            // 
            listViewOrder.Location = new Point(107, 62);
            listViewOrder.Name = "listViewOrder";
            listViewOrder.Size = new Size(276, 145);
            listViewOrder.TabIndex = 3;
            listViewOrder.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 221);
            label1.Name = "label1";
            label1.Size = new Size(45, 21);
            label1.TabIndex = 4;
            label1.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 267);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(107, 242);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 6;
            label3.Text = "Payment";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(107, 263);
            label4.Name = "label4";
            label4.Size = new Size(66, 21);
            label4.TabIndex = 7;
            label4.Text = "Change:";
            // 
            // tbPayment
            // 
            tbPayment.Location = new Point(183, 242);
            tbPayment.Name = "tbPayment";
            tbPayment.Size = new Size(100, 23);
            tbPayment.TabIndex = 8;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(298, 242);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(75, 23);
            btnPay.TabIndex = 9;
            btnPay.Text = "PAY";
            btnPay.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(195, 304);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(99, 32);
            btnPrint.TabIndex = 10;
            btnPrint.Text = "PRINT";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(158, 224);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 15);
            lblTotal.TabIndex = 11;
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(183, 269);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(0, 15);
            lblChange.TabIndex = 12;
            // 
            // ProcessOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(lblChange);
            Controls.Add(lblTotal);
            Controls.Add(btnPrint);
            Controls.Add(btnPay);
            Controls.Add(tbPayment);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listViewOrder);
            Controls.Add(btnRemoveOrder);
            Controls.Add(btnAddOrder);
            Controls.Add(tbItem);
            Name = "ProcessOrder";
            Text = "ProcessOrder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbItem;
        private Button btnAddOrder;
        private Button btnRemoveOrder;
        private ListView listViewOrder;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbPayment;
        private Button btnPay;
        private Button btnPrint;
        private Label lblTotal;
        private Label lblChange;
    }
}