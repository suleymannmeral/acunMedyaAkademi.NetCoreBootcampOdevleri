namespace dosyaYapisiOdeviAcunMedyaAkademi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)  //kullanıcı ok butonuna bastıysa 
            {
                listBox1.Items.Clear();
                string selectedPath = dialog.SelectedPath;  // seçilen klasörün pathi(yolu) selectedPath değişkenine atandı

                
                string[] folders = Directory.GetDirectories(selectedPath); // pathdeki klasörler folders adında string bir değere atandı

                foreach (string folder in folders)  // dizinin elemanları foreach loop ile sırasıyla işleniyor. 
                {
                    string folderName = Path.GetFileName(folder);   
                    listBox1.Items.Add("Folder->" + folderName);  // klasör ismi listboxa yazdırılıyor 

               
                    string[] csFiles = Directory.GetFiles(folder, "*.cs"); // klasördeki .cs uzantılı tüm dosyalar csFiles dizisine atanıyor * simgesi all anlamına gelir.

                    foreach (string file in csFiles)
                    {
                        string[] lines = File.ReadAllLines(file); 
                        foreach (string line in lines)
                        {
                            if (line.Contains("class "))
                            {
                                string className = line.Trim().Split(' ')[^1];
                                listBox1.Items.Add(" Class-> " + className); // class isimleri listboxa ekleniyor
                                break; 
                            }
                        }
                    }

                }
            }
        }
    }
}
