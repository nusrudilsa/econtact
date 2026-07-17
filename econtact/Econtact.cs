using System;
using System.Data;
using System.Windows.Forms;

namespace econtact
{
    public partial class Form1 : Form
    {

        DataTable rehberTablosu = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rehberTablosu.Columns.Add("Contact ID", typeof(int));
            rehberTablosu.Columns.Add("First Name", typeof(string));
            rehberTablosu.Columns.Add("Last Name", typeof(string));
            rehberTablosu.Columns.Add("Contact No", typeof(string));
            rehberTablosu.Columns.Add("Address", typeof(string));
            rehberTablosu.Columns.Add("Gender", typeof(string));

            dtvContactList .DataSource = rehberTablosu;

        }

        private void MetinKutulariniTemizle()
        {
            txtboxContactID.Text = "";
            txtboxFirstName.Text = ""; // kutuları bosalt
            txtboxLastName.Text = "";
            txtboxContactNumber.Text = "";
            txtboxAddress.Text = "";
            cmbGender.SelectedIndex = -1; // cinsiyet seçimini sıfırla
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int yeniID = rehberTablosu.Rows.Count + 1; // tabloda kac satir varsa 1 fazlası

            rehberTablosu.Rows.Add(yeniID, txtboxFirstName.Text, txtboxLastName.Text, txtboxContactNumber.Text, txtboxAddress.Text, cmbGender.SelectedItem?.ToString());

          
          //ekleme bitince temizle kutuları  
            MetinKutulariniTemizle();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtboxContactID.Text = "";
            txtboxFirstName.Text = "";
            txtboxLastName.Text = "";
            txtboxContactNumber.Text = "";
            txtboxAddress.Text = "";
            cmbGender.SelectedIndex = -1;
        
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rehberTablosu.Rows.Count > 0)
            {
                rehberTablosu.Rows.RemoveAt(rehberTablosu.Rows.Count - 1);
            }
            else
            {
                MessageBox.Show("Silinecek hiçbir kayıt bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void txtboxSearch_TextChanged (object sender, EventArgs e)
        {
            string aramaMetni = txtboxSearch.Text; // arama kutusuna yazılan metni alıyoruz


            DataView dv = rehberTablosu.DefaultView;  // sanal tabloda first name sütunu filrtlere 
            dv.RowFilter = string.Format("[First Name] LIKE '%{0}%' ", aramaMetni);

            dtvContactList.DataSource = dv; //  filtrelenmis sonucu ekrandaki gri tabloya koy
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // programı kapatma fonksiyonu    
        }
    }
}
