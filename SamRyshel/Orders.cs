using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamRyshel
{
    public partial class Orders : Form
    {
        public static List<Tuple<string, double>> currentOrder = new List<Tuple<string, double>>();
        public Orders()
        {
            InitializeComponent();
            RefreshListViews();
        }
        public void RefreshListViews()
        {
            listViewFood.Items.Clear();
            listViewDrinks.Items.Clear();
            foreach (var item in currentOrder)
            {
                if (item == null || item.Item1 == null) continue;

                if (Products.foods.Any(f => string.Equals(f.Key, item.Item1, StringComparison.OrdinalIgnoreCase)))
                    listViewFood.Items.Add($"{item.Item1} - {item.Item2:C2}");
                else if (Products.drinks.Any(d => string.Equals(d.Key, item.Item1, StringComparison.OrdinalIgnoreCase)))
                    listViewDrinks.Items.Add($"{item.Item1} - {item.Item2:C2}");
            }
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            ProcessOrder processOrder = new ProcessOrder(this);
            processOrder.Show();
        }
    }
}
