using Newtonsoft.Json;

namespace jsonOdeviAcunMedya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJsonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"C:\Users\suley\source\repos\jsonOdeviAcunMedya\product.json";

                List<Product> products = new List<Product>();
                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    using (JsonReader jr = new JsonTextReader(sr))
                    {
                        JsonSerializer jsonSerializer = new JsonSerializer();
                        products = jsonSerializer.Deserialize<List<Product>>(jr) ?? new List<Product>();
                    }
                }


                Product product = new Product
                {
                    Name = txtProductName.Text,
                    Price = Convert.ToDecimal(txtPrice.Text)
                };

                products.Add(product);


                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(filePath))
                using (JsonWriter jw = new JsonTextWriter(sw))
                {
                    serializer.Serialize(jw, products);
                    MessageBox.Show("Json serileştirme tamamlandı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu : " + ex.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"C:\Users\suley\source\repos\jsonOdeviAcunMedya\product.json";

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("Dosya bulunamadı.");
                    return;
                }

                List<Product> products = new List<Product>();

                using (StreamReader sr = new StreamReader(filePath))
                using (JsonReader jr = new JsonTextReader(sr))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    products = serializer.Deserialize<List<Product>>(jr);
                }

                if (products != null && products.Count > 0) // liste boş degilse 
                {
                    string message = "";
                    foreach (var product in products)
                    {
                        message += $"Ürün Adı: {product.Name}, Fiyat: {product.Price}\n";
                    }

                    MessageBox.Show(message, "Kayıtlı Ürünler");
                }
                else
                {
                    MessageBox.Show("Ürün listesi boş.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu : " + ex.Message.ToString());
            }
        }
    }
}
