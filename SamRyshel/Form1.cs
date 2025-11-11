namespace $safeprojectname$
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            Products prod = new Products();
            prod.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
        }
    }
}
