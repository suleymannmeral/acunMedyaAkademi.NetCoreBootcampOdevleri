

using AcunMedyaAkademi11MayisFormOdevi.Models;
using AcunMedyaAkademi11MayisFormOdevi.Validation;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace AcunMedyaAkademi11MayisFormOdevi
{
    public partial class Form1 : Form
    {
        string connectionString = @"server=SULEYMAN;database=AcunMedya;integrated security=true;TrustServerCertificate=True";
        int secilenBransId = 0;
        int secilenDoktorId = 0;
        ValidateAppointment validate = new ValidateAppointment();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetBrans();
            CenterToScreen();


        }

        public void GetBrans()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<Brans> bransListesi = null;
                try
                {
                    connection.Open();
                    string query = "Select * From Branslar";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    bransListesi = new List<Brans>();
                    bransListesi.Add(new Brans
                    {

                        ID = -1,
                        BransAdi = "Branş Seçiniz"
                    });
                    while (reader.Read())
                    {

                        bransListesi.Add(new Brans
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            BransAdi = reader["BransAdi"].ToString()
                        });
                    }
                    cmbBrans.DataSource = bransListesi;
                    cmbBrans.DisplayMember = "BransAdi";
                    cmbBrans.ValueMember = "ID";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }

        }

        public void GetDoctors(int BransID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<Doktor> doktorListesi = null;
                try
                {
                    connection.Open();
                    string query = "Select * from Doktorlar where BransID=" + BransID;
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    doktorListesi = new List<Doktor>();
                    doktorListesi.Add(new Doktor
                    {
                        ID = -1,
                        Name = "Doktor Seçiniz"
                    });
                    while (reader.Read())
                    {
                        doktorListesi.Add(new Doktor
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Name = reader["Name"].ToString(),
                            Surname = reader["Surname"].ToString(),

                        });
                    }
                    cmbDoktro.DataSource = doktorListesi;
                    cmbDoktro.DisplayMember = "FullName";
                    cmbDoktro.ValueMember = "ID";




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }

        }

        public bool CheckAppointment(Randevu rnd)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Randevular";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int bransID = Convert.ToInt32(reader["BransID"]);
                        int doktorID = Convert.ToInt32(reader["DoktorID"]);
                        DateTime tarih = Convert.ToDateTime(reader["Tarih"]);

                        if (bransID == rnd.BransID &&
                            doktorID == rnd.DoktorID &&
                            tarih == rnd.Tarih)
                        {
                            MessageBox.Show("Bu tarihte zaten bir randevu var!");
                            return false;
                        }
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();

                }
            }

        }


        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (cmbBrans.SelectedValue != null && int.TryParse(cmbBrans.SelectedValue.ToString(), out int id) && id != -1)
            {
                secilenBransId = id;

            }
            Brans secilenBrans = (Brans)cmbBrans.SelectedItem;
            secilenBransId = secilenBrans.ID;
            if (secilenBrans.ID > 0)
            {
                GetDoctors(secilenBransId);
            }

           

        }



        private void cmbDoktro_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbDoktro.SelectedValue != null && int.TryParse(cmbDoktro.SelectedValue.ToString(), out int id) && id != -1)
            {
                secilenDoktorId = id;

            }


        }
        public void CreateAppointment(Randevu rnd)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Randevular (HastaAdi, HastaSoyadi, BransID, DoktorID, Tarih) " +
                "VALUES (@HastaAdi, @HastaSoyadi, @BransID, @DoktorID, @Tarih)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HastaAdi", rnd.HastaAdi);
                        command.Parameters.AddWithValue("@HastaSoyadi", rnd.HastaSoyadi);
                        command.Parameters.AddWithValue("@BransID", rnd.BransID);
                        command.Parameters.AddWithValue("@DoktorID", rnd.DoktorID);
                        command.Parameters.AddWithValue("@Tarih", rnd.Tarih);

                        command.ExecuteNonQuery();
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connection.Close();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text=="")
            {
                MessageBox.Show("Saat seçimi Yapmadınız");
            }
            else
            {
                Randevu rnd = new Randevu();
                rnd.HastaAdi = txtAd.Text;
                rnd.HastaSoyadi = txtSoyad.Text;
                rnd.BransID = secilenBransId;
                rnd.DoktorID = secilenDoktorId;
                DateTime secilenZaman = dateTimePicker1.Value;
                string selectedTime = comboBox1.SelectedItem.ToString(); // örnek: "09:00"

                string[] parts = selectedTime.Split(':');
                int hour = int.Parse(parts[0]);
                int minute = int.Parse(parts[1]);

                secilenZaman = new DateTime(secilenZaman.Year, secilenZaman.Month, secilenZaman.Day, hour, minute, 0);
                rnd.Tarih = secilenZaman;


                if (validate.Validate(rnd))
                {

                    if (CheckAppointment(rnd) is true)
                    {
                        CreateAppointment(rnd);
                        MessageBox.Show(secilenBransId.ToString());
                        MessageBox.Show("Randevu Alma Başarılı");
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen Alanları Doğru Doldurunuz");
                }

            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
