namespace eventMechanism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTikla_Click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Red;
        }

        ProductService productService = new ProductService();
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void button24_Click(object sender, EventArgs e)
        {
            productService.ProductCreated += ProductService_ProductCreated;
            productService.AddNewProduct(new Product { Name = "Üzüm", Price = 150 });
        }

        private void ProductService_ProductCreated(object sender, ProductCreatedEventArgs e)
        {
            MessageBox.Show(e.Product.Name + "isimli ürün, " + e.CreatedBy + " tarafından eklendi");
        }
    }
}
