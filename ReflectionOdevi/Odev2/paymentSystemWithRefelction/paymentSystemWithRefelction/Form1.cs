using paymentSystemWithRefelction.Contracts;

namespace paymentSystemWithRefelction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            var odemeYontemiTipleri = AppDomain.CurrentDomain.GetAssemblies()
               .SelectMany(x => x.GetTypes())
               .Where(t => typeof(IOdemeYontemi).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
               .ToList();  // assemblyleri tarıyoruz  
                           // t tipi IOdemeYontemi interfacinden türemişse ve interface değilse  ve soyut sınıf değilse 
                           // çünkü bize implement edilmiş sınıflar laızm kendisi lazım değil
                           // son olarak tolist metodu ile bu yapıları yani IOdemeYontemini implement eden sınıfları
                           //listeliyoruz


            foreach (var tip in odemeYontemiTipleri)
            {
                cmbPaymentType.Items.Add(tip);  //comboboxa filtrelediğimiz değişkenleri ekliyoruz
            }


            cmbPaymentType.DisplayMember = "Name"; // sadece class ismini göster
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(txtAmount.Text);   // girilen tutarı al ve integer değere çevir
            if (cmbPaymentType.SelectedItem is Type selectedType)  // seçilen değer bir type ise selectedType değişekine ata
            {
                // interfaceden erişim sağladık 
                IOdemeYontemi odemeYontemi = (IOdemeYontemi)Activator.CreateInstance(selectedType);

                //labela yazdır
                label3.Text = $"Tutar: {odemeYontemi?.Ode(amount):C2}"; 


            }
        }
    }
}
