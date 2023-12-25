using AbsenApp.Model;
using AbsenApp.View;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Diagnostics;

namespace AbsenApp
{
    public partial class DataMatkul : Form
    {
        private string oldValue = "";
        public List<Matkul> matkuls { get; set; }
        private MatkulManager matkulManager;

        public DataMatkul()
        {
            InitializeComponent();
            refreshDataGrid();
            this.DataContext = matkuls;

            dgUser.DataSource = matkuls;
        }

        private void DataUser_Load(object sender, EventArgs e)
        {

        }

        private void dgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgUser_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Debug.WriteLine(this.oldValue.ToString());
        }

        private void dgUser_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var dataId = dgUser.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value.ToString();
            var newValue = dgUser.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            var filter = Builders<Matkul>.Filter.Eq("_id", ObjectId.Parse(dataId));
            var header = dgUser.Columns[e.ColumnIndex].HeaderText;
            Matkul tes = new Matkul("SDA");
            var isExist = matkuls.FirstOrDefault(m => m.Nama == "SDA");
            Debug.WriteLine(isExist == null);
            Debug.WriteLine(filter.ToJson());
            var query = Builders<Matkul>.Update.Set(header, newValue);
            matkulManager.UpdateMatkul(filter, query);
            refreshDataGrid();
            // Debug.WriteLine(dgUser.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
        }

        private void dgUser_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.oldValue = dgUser.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

        }

        private void btnTambahMhsWindow_Click(object sender, EventArgs e)
        {
            AddMatkul addMatkul = new AddMatkul(matkulManager, this);
            addMatkul.Show();
        }

        public void refreshDataGrid()
        {
            dgUser.DataSource = null;
            matkulManager = new MatkulManager();
            matkuls = matkulManager.getMatkul().AsQueryable().ToList<Matkul>();
            dgUser.DataSource = matkuls;
            dgUser.Refresh();
            dgUser.Update();
        }
    }
}
