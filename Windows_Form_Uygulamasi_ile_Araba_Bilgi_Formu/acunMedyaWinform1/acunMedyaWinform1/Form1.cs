namespace acunMedyaWinform1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // Kullanıcıdan alınan girdiler değişkenlere atanıyor
            string marka = txtMarka.Text;
            string model = txtModel.Text;
            string renk = txtRenk.Text;
            int kapiSayisi = int.Parse(txtKapi.Text);
            int pencereSayisi = int.Parse(txtPencere.Text);
            int yakit = int.Parse(txtYakit.Text);
            string info = $"Marka:{marka}, Model:{model}, Renk: {renk}, Kapi Sayisi: {kapiSayisi},Pencere Sayisi: {pencereSayisi}, Yakit: {yakit}";

            // Bilgiler messagebox ile kullanııcya gösteriliyor
            MessageBox.Show($"{info}" , "Acun Medya Akademi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
