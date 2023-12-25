using AbsenApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsenApp.View
{
    public partial class AddMatkul : Form
    {
        private MatkulManager matkulManager;
        private DataMatkul dataMatkulForm; // Add this field to hold the reference to the main form


        public AddMatkul(MatkulManager manager, DataMatkul dataMatkul)
        {
            InitializeComponent();
            matkulManager = manager;
            this.dataMatkulForm = dataMatkul;


        }

        private void AddMatkul_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTambahMhs_Click(object sender, EventArgs e)
        {
            var namaMk = tbMatkul.Text;
            Matkul mhsMatkul = new Matkul(namaMk);
            if (matkulManager.InsertNewMatkul(mhsMatkul))
            {
                MessageBox.Show("Berhasil menambah data matkul!", "Sukses",
    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataMatkulForm.refreshDataGrid();

            } else
            {
                MessageBox.Show("Gagal menambah data matkul!", "Gagal",
MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }


    }
}
