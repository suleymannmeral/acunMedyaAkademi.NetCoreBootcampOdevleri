namespace CustomAttributeOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();

            ogr.Surname = txtOgrSoyad.Text;
            ogr.Department = txtOgrBolum.Text;
            ogr.Name = txtOgrAd.Text;

            var error = ValidationControl.Validate(ogr);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                label4.Text = $"{ogr.Name}  {ogr.Surname}   {ogr.Department}   ";
            }




        }
    }
}
