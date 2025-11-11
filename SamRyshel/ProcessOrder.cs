using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SamRyshel
{
    public partial class ProcessOrder : Form
    {
        Orders _ordersForm;
        Hashtable inputOrder;

        string addOrder;
        string removeOrder;

        string fullPath;
        string fileName;
        string filePath;

        double totalPrice = 0.0;
        double payment;
        double totalChange;

        int orderNumber = 1;

        public ProcessOrder(Orders ordersForm)
        {
            InitializeComponent();
            this._ordersForm = ordersForm;
            inputOrder = new Hashtable();
            filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void SyncOrdersCurrentOrder()
        {
            Orders.currentOrder.Clear();

            foreach (DictionaryEntry entry in inputOrder)
            {
                if (entry.Key is string key && entry.Value is Tuple<int, double> itemData)
                {
                    int quantity = itemData.Item1;
                    double price = itemData.Item2;
                    for (int i = 0; i < quantity; i++)
                    {
                        Orders.currentOrder.Add(new Tuple<string, double>(key, price));
                    }
                }
            }
        }

        public void Order_List_Set()
        {
            listViewOrder.Items.Clear();
            totalPrice = 0;

            foreach (DictionaryEntry entry in inputOrder)
            {
                if (entry.Key is string key && entry.Value is Tuple<int, double> itemData)
                {
                    int quantity = itemData.Item1;
                    double price = itemData.Item2;
                    double subtotal = quantity * price;

                    listViewOrder.Items.Add($"{key} x{quantity} - {subtotal:C}");
                    totalPrice += subtotal;
                }
            }

            lblTotal.Text = $"{totalPrice:C}";
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            addOrder = tbItem.Text.Trim();
            double value = 0;

            if (string.IsNullOrWhiteSpace(addOrder))
            {
                MessageBox.Show("Please enter an item name.");
                return;
            }

            var foodItem = Products.foods.FirstOrDefault(item => string.Equals(item.Key, addOrder, StringComparison.OrdinalIgnoreCase));
            if (foodItem.Key != null)
            {
                value = foodItem.Value;
            }
            else
            {
                var drinkItem = Products.drinks.FirstOrDefault(item => string.Equals(item.Key, addOrder, StringComparison.OrdinalIgnoreCase));
                if (drinkItem.Key != null)
                {
                    value = drinkItem.Value;
                }
                else
                {
                    MessageBox.Show("Item not found in food or drink list.");
                    return;
                }
            }

            if (inputOrder.ContainsKey(addOrder))
            {
                var current = (Tuple<int, double>)inputOrder[addOrder];
                int newQty = current.Item1 + 1;
                inputOrder[addOrder] = new Tuple<int, double>(newQty, current.Item2);
            }
            else
            {
                inputOrder[addOrder] = new Tuple<int, double>(1, value);
            }

            Order_List_Set();
            SyncOrdersCurrentOrder();
            tbItem.Clear();
            _ordersForm.RefreshListViews();
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {
            removeOrder = tbItem.Text.Trim();

            if (string.IsNullOrWhiteSpace(removeOrder))
            {
                MessageBox.Show("Please enter an item name to remove.");
                return;
            }

            if (inputOrder.ContainsKey(removeOrder))
            {
                var current = (Tuple<int, double>)inputOrder[removeOrder];
                int newQty = current.Item1 - 1;

                if (newQty > 0)
                {
                    inputOrder[removeOrder] = new Tuple<int, double>(newQty, current.Item2);
                }
                else
                {
                    inputOrder.Remove(removeOrder);
                }

                MessageBox.Show($"{removeOrder} has been removed from your order.");
                Order_List_Set();
            }
            else
            {
                MessageBox.Show("Item not found in the current order list.");
            }
            tbItem.Clear();
            SyncOrdersCurrentOrder();
            _ordersForm.RefreshListViews();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (double.TryParse(tbPayment.Text, out payment))
            {
                totalChange = payment - totalPrice;
                lblChange.Text = $"Change: {totalChange:C}";
            }
            else
            {
                MessageBox.Show("Invalid payment amount.");
            }
        }

        public string Order_List_To_Text()
        {
            if (listViewOrder.Items.Count == 0)
                return "No items in the order.";

            StringBuilder sb = new StringBuilder();

            foreach (ListViewItem item in listViewOrder.Items)
            {
                sb.AppendLine(item.Text);
            }

            return sb.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                fileName = $"Order_{orderNumber}.txt";
                fullPath = Path.Combine(filePath, fileName);

                using (StreamWriter addInput = new StreamWriter(fullPath))
                {
                    addInput.WriteLine($"Order Number: {orderNumber}");
                    addInput.WriteLine("Orders: \n" + Order_List_To_Text());
                }
                MessageBox.Show($"Order successfully printed! Order # {orderNumber}");
                orderNumber++;
            }
            catch (FormatException)
            {
                MessageBox.Show("Error Occur!!\n  Please Input numbers on Payment.");
            }
            catch (Exception ix)
            {
                MessageBox.Show("Error Occur!!\n  " + ix.Message);
            }
        }
    }
}
