namespace AbsenApp.View
{
    partial class AddMatkul
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbMatkul = new TextBox();
            label1 = new Label();
            btnTambahMk = new Button();
            SuspendLayout();
            // 
            // tbMatkul
            // 
            tbMatkul.Font = new Font("Segoe UI", 12F);
            tbMatkul.Location = new Point(371, 137);
            tbMatkul.Name = "tbMatkul";
            tbMatkul.Size = new Size(197, 34);
            tbMatkul.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(201, 143);
            label1.Name = "label1";
            label1.Size = new Size(130, 28);
            label1.TabIndex = 1;
            label1.Text = "Nama Matkul";
            label1.Click += label1_Click;
            // 
            // btnTambahMk
            // 
            btnTambahMk.Location = new Point(347, 294);
            btnTambahMk.Name = "btnTambahMk";
            btnTambahMk.Size = new Size(94, 29);
            btnTambahMk.TabIndex = 2;
            btnTambahMk.Text = "tambah";
            btnTambahMk.UseVisualStyleBackColor = true;
            btnTambahMk.Click += btnTambahMhs_Click;
            // 
            // AddMatkul
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTambahMk);
            Controls.Add(label1);
            Controls.Add(tbMatkul);
            Name = "AddMatkul";
            Text = "AddMatkul";
            Load += AddMatkul_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMatkul;
        private Label label1;
        private Button btnTambahMk;
    }
}