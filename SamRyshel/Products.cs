using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            AddFood addFood = new AddFood();
            addFood.Show();
        }

        private void btnAddDrinks_Click(object sender, EventArgs e)
        {
            AddDrinks addDrinks = new AddDrinks();
            addDrinks.Show();
        }

        private void btnDelFood_Click(object sender, EventArgs e)
        {
            RemoveFood removeFood = new RemoveFood();
            removeFood.Show();
        }

        private void btnDelDrinks_Click(object sender, EventArgs e)
        {
            RemoveDrinks removeDrinks = new RemoveDrinks();
            removeDrinks.Show();
        }
    }
}
