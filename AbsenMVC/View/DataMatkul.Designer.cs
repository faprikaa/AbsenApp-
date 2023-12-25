namespace AbsenApp
{
    partial class DataMatkul
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgUser = new DataGridView();
            btnTambahMhsWindow = new Button();
            ((System.ComponentModel.ISupportInitialize)dgUser).BeginInit();
            SuspendLayout();
            // 
            // dgUser
            // 
            dgUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUser.Location = new Point(104, 27);
            dgUser.Name = "dgUser";
            dgUser.RowHeadersWidth = 51;
            dgUser.Size = new Size(592, 328);
            dgUser.TabIndex = 0;
            dgUser.CellBeginEdit += dgUser_CellBeginEdit;
            dgUser.CellContentClick += dgUser_CellContentClick;
            dgUser.CellEndEdit += dgUser_CellEndEdit;
            dgUser.CellValueChanged += dgUser_CellValueChanged;
            // 
            // btnTambahMhsWindow
            // 
            btnTambahMhsWindow.Location = new Point(507, 376);
            btnTambahMhsWindow.Name = "btnTambahMhsWindow";
            btnTambahMhsWindow.Size = new Size(189, 29);
            btnTambahMhsWindow.TabIndex = 1;
            btnTambahMhsWindow.Text = "Tambah Mahasiswa";
            btnTambahMhsWindow.UseVisualStyleBackColor = true;
            btnTambahMhsWindow.Click += btnTambahMhsWindow_Click;
            // 
            // DataMatkul
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTambahMhsWindow);
            Controls.Add(dgUser);
            Name = "DataMatkul";
            Text = "Form1";
            Load += DataUser_Load;
            ((System.ComponentModel.ISupportInitialize)dgUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgUser;
        private Button btnTambahMhsWindow;
    }
}
