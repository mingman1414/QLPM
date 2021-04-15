namespace QuanLyPhongMach
{
    partial class frm_Admin
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
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpIncome = new System.Windows.Forms.TabPage();
            this.dgvStat = new System.Windows.Forms.DataGridView();
            this.dtToDate = new System.Windows.Forms.DateTimePicker();
            this.dtFromDate = new System.Windows.Forms.DateTimePicker();
            this.btnStat = new System.Windows.Forms.Button();
            this.tpDoctor = new System.Windows.Forms.TabPage();
            this.tbMedicine = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDoctorId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDoctorLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDrAdd = new System.Windows.Forms.Button();
            this.btnDrEdit = new System.Windows.Forms.Button();
            this.btnDrDelete = new System.Windows.Forms.Button();
            this.btnDrSave = new System.Windows.Forms.Button();
            this.grpDoctorList = new System.Windows.Forms.GroupBox();
            this.dgvDoctor = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDoctorSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDrSearch = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMedId = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMedName = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMedUnit = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProductionDate = new System.Windows.Forms.DateTimePicker();
            this.txtExp = new System.Windows.Forms.DateTimePicker();
            this.btnMedAdd = new System.Windows.Forms.Button();
            this.btnMedEdit = new System.Windows.Forms.Button();
            this.btnMedDelete = new System.Windows.Forms.Button();
            this.btnMedSave = new System.Windows.Forms.Button();
            this.grpMed = new System.Windows.Forms.GroupBox();
            this.dgvMedicine = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMedSearch = new System.Windows.Forms.TextBox();
            this.btnMedSearch = new System.Windows.Forms.Button();
            this.tcAdmin.SuspendLayout();
            this.tpIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStat)).BeginInit();
            this.tpDoctor.SuspendLayout();
            this.tbMedicine.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grpDoctorList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.grpMed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpIncome);
            this.tcAdmin.Controls.Add(this.tpDoctor);
            this.tcAdmin.Controls.Add(this.tbMedicine);
            this.tcAdmin.Location = new System.Drawing.Point(12, 12);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(814, 493);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpIncome
            // 
            this.tpIncome.Controls.Add(this.dgvStat);
            this.tpIncome.Controls.Add(this.dtToDate);
            this.tpIncome.Controls.Add(this.dtFromDate);
            this.tpIncome.Controls.Add(this.btnStat);
            this.tpIncome.Location = new System.Drawing.Point(4, 25);
            this.tpIncome.Name = "tpIncome";
            this.tpIncome.Padding = new System.Windows.Forms.Padding(3);
            this.tpIncome.Size = new System.Drawing.Size(806, 464);
            this.tpIncome.TabIndex = 0;
            this.tpIncome.Text = "Doanh thu";
            this.tpIncome.UseVisualStyleBackColor = true;
            // 
            // dgvStat
            // 
            this.dgvStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStat.Location = new System.Drawing.Point(6, 77);
            this.dgvStat.Name = "dgvStat";
            this.dgvStat.RowHeadersWidth = 51;
            this.dgvStat.RowTemplate.Height = 24;
            this.dgvStat.Size = new System.Drawing.Size(794, 381);
            this.dgvStat.TabIndex = 3;
            // 
            // dtToDate
            // 
            this.dtToDate.CustomFormat = "dd/MM/yyyy";
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtToDate.Location = new System.Drawing.Point(558, 19);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(200, 22);
            this.dtToDate.TabIndex = 2;
            // 
            // dtFromDate
            // 
            this.dtFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFromDate.Location = new System.Drawing.Point(49, 19);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(200, 22);
            this.dtFromDate.TabIndex = 1;
            // 
            // btnStat
            // 
            this.btnStat.Location = new System.Drawing.Point(319, 6);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(155, 52);
            this.btnStat.TabIndex = 0;
            this.btnStat.Text = "Thống kê";
            this.btnStat.UseVisualStyleBackColor = true;
            // 
            // tpDoctor
            // 
            this.tpDoctor.Controls.Add(this.grpDoctorList);
            this.tpDoctor.Controls.Add(this.btnDrSave);
            this.tpDoctor.Controls.Add(this.btnDrDelete);
            this.tpDoctor.Controls.Add(this.btnDrEdit);
            this.tpDoctor.Controls.Add(this.btnDrAdd);
            this.tpDoctor.Controls.Add(this.panel3);
            this.tpDoctor.Controls.Add(this.panel1);
            this.tpDoctor.Controls.Add(this.panel2);
            this.tpDoctor.Location = new System.Drawing.Point(4, 25);
            this.tpDoctor.Name = "tpDoctor";
            this.tpDoctor.Padding = new System.Windows.Forms.Padding(3);
            this.tpDoctor.Size = new System.Drawing.Size(806, 464);
            this.tpDoctor.TabIndex = 1;
            this.tpDoctor.Text = "Bác sĩ";
            this.tpDoctor.UseVisualStyleBackColor = true;
            // 
            // tbMedicine
            // 
            this.tbMedicine.Controls.Add(this.grpMed);
            this.tbMedicine.Controls.Add(this.btnMedSave);
            this.tbMedicine.Controls.Add(this.btnMedDelete);
            this.tbMedicine.Controls.Add(this.btnMedEdit);
            this.tbMedicine.Controls.Add(this.btnMedAdd);
            this.tbMedicine.Controls.Add(this.panel10);
            this.tbMedicine.Controls.Add(this.panel9);
            this.tbMedicine.Controls.Add(this.panel8);
            this.tbMedicine.Controls.Add(this.panel7);
            this.tbMedicine.Controls.Add(this.panel6);
            this.tbMedicine.Controls.Add(this.panel5);
            this.tbMedicine.Location = new System.Drawing.Point(4, 25);
            this.tbMedicine.Name = "tbMedicine";
            this.tbMedicine.Padding = new System.Windows.Forms.Padding(3);
            this.tbMedicine.Size = new System.Drawing.Size(806, 464);
            this.tbMedicine.TabIndex = 2;
            this.tbMedicine.Text = "Thuốc";
            this.tbMedicine.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtDoctorId);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(486, 53);
            this.panel2.TabIndex = 7;
            // 
            // txtDoctorId
            // 
            this.txtDoctorId.Location = new System.Drawing.Point(145, 16);
            this.txtDoctorId.Name = "txtDoctorId";
            this.txtDoctorId.Size = new System.Drawing.Size(329, 22);
            this.txtDoctorId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã bác sĩ:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDoctorLastName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 53);
            this.panel1.TabIndex = 8;
            // 
            // txtDoctorLastName
            // 
            this.txtDoctorLastName.Location = new System.Drawing.Point(145, 16);
            this.txtDoctorLastName.Name = "txtDoctorLastName";
            this.txtDoctorLastName.Size = new System.Drawing.Size(329, 22);
            this.txtDoctorLastName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ lót:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDoctorName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(498, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(278, 53);
            this.panel3.TabIndex = 9;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(84, 16);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(184, 22);
            this.txtDoctorName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên:";
            // 
            // btnDrAdd
            // 
            this.btnDrAdd.Location = new System.Drawing.Point(56, 124);
            this.btnDrAdd.Name = "btnDrAdd";
            this.btnDrAdd.Size = new System.Drawing.Size(97, 64);
            this.btnDrAdd.TabIndex = 10;
            this.btnDrAdd.Text = "Thêm";
            this.btnDrAdd.UseVisualStyleBackColor = true;
            // 
            // btnDrEdit
            // 
            this.btnDrEdit.Location = new System.Drawing.Point(194, 124);
            this.btnDrEdit.Name = "btnDrEdit";
            this.btnDrEdit.Size = new System.Drawing.Size(97, 64);
            this.btnDrEdit.TabIndex = 11;
            this.btnDrEdit.Text = "Sửa";
            this.btnDrEdit.UseVisualStyleBackColor = true;
            // 
            // btnDrDelete
            // 
            this.btnDrDelete.Location = new System.Drawing.Point(343, 124);
            this.btnDrDelete.Name = "btnDrDelete";
            this.btnDrDelete.Size = new System.Drawing.Size(97, 64);
            this.btnDrDelete.TabIndex = 12;
            this.btnDrDelete.Text = "Xóa";
            this.btnDrDelete.UseVisualStyleBackColor = true;
            // 
            // btnDrSave
            // 
            this.btnDrSave.Location = new System.Drawing.Point(489, 124);
            this.btnDrSave.Name = "btnDrSave";
            this.btnDrSave.Size = new System.Drawing.Size(97, 64);
            this.btnDrSave.TabIndex = 13;
            this.btnDrSave.Text = "Lưu";
            this.btnDrSave.UseVisualStyleBackColor = true;
            // 
            // grpDoctorList
            // 
            this.grpDoctorList.Controls.Add(this.btnDrSearch);
            this.grpDoctorList.Controls.Add(this.panel4);
            this.grpDoctorList.Controls.Add(this.dgvDoctor);
            this.grpDoctorList.Location = new System.Drawing.Point(6, 194);
            this.grpDoctorList.Name = "grpDoctorList";
            this.grpDoctorList.Size = new System.Drawing.Size(794, 264);
            this.grpDoctorList.TabIndex = 14;
            this.grpDoctorList.TabStop = false;
            // 
            // dgvDoctor
            // 
            this.dgvDoctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoctor.Location = new System.Drawing.Point(6, 58);
            this.dgvDoctor.Name = "dgvDoctor";
            this.dgvDoctor.RowHeadersWidth = 51;
            this.dgvDoctor.RowTemplate.Height = 24;
            this.dgvDoctor.Size = new System.Drawing.Size(782, 200);
            this.dgvDoctor.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtDoctorSearch);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(7, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(467, 31);
            this.panel4.TabIndex = 10;
            // 
            // txtDoctorSearch
            // 
            this.txtDoctorSearch.Location = new System.Drawing.Point(138, 3);
            this.txtDoctorSearch.Name = "txtDoctorSearch";
            this.txtDoctorSearch.Size = new System.Drawing.Size(326, 22);
            this.txtDoctorSearch.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(12, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tìm kiếm:";
            // 
            // btnDrSearch
            // 
            this.btnDrSearch.Location = new System.Drawing.Point(509, 13);
            this.btnDrSearch.Name = "btnDrSearch";
            this.btnDrSearch.Size = new System.Drawing.Size(111, 39);
            this.btnDrSearch.TabIndex = 15;
            this.btnDrSearch.Text = "Tìm";
            this.btnDrSearch.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtMedId);
            this.panel5.Location = new System.Drawing.Point(6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(338, 32);
            this.panel5.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã thuốc:";
            // 
            // txtMedId
            // 
            this.txtMedId.Location = new System.Drawing.Point(174, 5);
            this.txtMedId.Name = "txtMedId";
            this.txtMedId.Size = new System.Drawing.Size(161, 22);
            this.txtMedId.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtMedName);
            this.panel6.Location = new System.Drawing.Point(6, 44);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(338, 32);
            this.panel6.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tên thuốc:";
            // 
            // txtMedName
            // 
            this.txtMedName.Location = new System.Drawing.Point(174, 5);
            this.txtMedName.Name = "txtMedName";
            this.txtMedName.Size = new System.Drawing.Size(161, 22);
            this.txtMedName.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.txtMedUnit);
            this.panel7.Location = new System.Drawing.Point(6, 82);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(338, 32);
            this.panel7.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(3, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đơn vị:";
            // 
            // txtMedUnit
            // 
            this.txtMedUnit.Location = new System.Drawing.Point(174, 5);
            this.txtMedUnit.Name = "txtMedUnit";
            this.txtMedUnit.Size = new System.Drawing.Size(161, 22);
            this.txtMedUnit.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtProductionDate);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(6, 120);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(338, 32);
            this.panel8.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày sản xuất:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtExp);
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(6, 158);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(338, 32);
            this.panel9.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(3, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Hạn sử dụng:";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.txtPrice);
            this.panel10.Location = new System.Drawing.Point(6, 196);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(338, 32);
            this.panel10.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Giá tiền:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(174, 5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(161, 22);
            this.txtPrice.TabIndex = 1;
            // 
            // txtProductionDate
            // 
            this.txtProductionDate.CustomFormat = "dd/MM/yyyy";
            this.txtProductionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtProductionDate.Location = new System.Drawing.Point(174, 3);
            this.txtProductionDate.Name = "txtProductionDate";
            this.txtProductionDate.Size = new System.Drawing.Size(161, 22);
            this.txtProductionDate.TabIndex = 1;
            // 
            // txtExp
            // 
            this.txtExp.CustomFormat = "dd/MM/yyyy";
            this.txtExp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtExp.Location = new System.Drawing.Point(174, 6);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(161, 22);
            this.txtExp.TabIndex = 2;
            // 
            // btnMedAdd
            // 
            this.btnMedAdd.Location = new System.Drawing.Point(28, 248);
            this.btnMedAdd.Name = "btnMedAdd";
            this.btnMedAdd.Size = new System.Drawing.Size(98, 63);
            this.btnMedAdd.TabIndex = 5;
            this.btnMedAdd.Text = "Thêm";
            this.btnMedAdd.UseVisualStyleBackColor = true;
            // 
            // btnMedEdit
            // 
            this.btnMedEdit.Location = new System.Drawing.Point(194, 248);
            this.btnMedEdit.Name = "btnMedEdit";
            this.btnMedEdit.Size = new System.Drawing.Size(98, 63);
            this.btnMedEdit.TabIndex = 6;
            this.btnMedEdit.Text = "Sửa";
            this.btnMedEdit.UseVisualStyleBackColor = true;
            // 
            // btnMedDelete
            // 
            this.btnMedDelete.Location = new System.Drawing.Point(28, 351);
            this.btnMedDelete.Name = "btnMedDelete";
            this.btnMedDelete.Size = new System.Drawing.Size(98, 63);
            this.btnMedDelete.TabIndex = 7;
            this.btnMedDelete.Text = "Xóa";
            this.btnMedDelete.UseVisualStyleBackColor = true;
            // 
            // btnMedSave
            // 
            this.btnMedSave.Location = new System.Drawing.Point(194, 351);
            this.btnMedSave.Name = "btnMedSave";
            this.btnMedSave.Size = new System.Drawing.Size(98, 63);
            this.btnMedSave.TabIndex = 8;
            this.btnMedSave.Text = "Lưu";
            this.btnMedSave.UseVisualStyleBackColor = true;
            // 
            // grpMed
            // 
            this.grpMed.Controls.Add(this.btnMedSearch);
            this.grpMed.Controls.Add(this.panel11);
            this.grpMed.Controls.Add(this.dgvMedicine);
            this.grpMed.Location = new System.Drawing.Point(350, 6);
            this.grpMed.Name = "grpMed";
            this.grpMed.Size = new System.Drawing.Size(450, 452);
            this.grpMed.TabIndex = 9;
            this.grpMed.TabStop = false;
            // 
            // dgvMedicine
            // 
            this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicine.Location = new System.Drawing.Point(6, 90);
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.RowHeadersWidth = 51;
            this.dgvMedicine.RowTemplate.Height = 24;
            this.dgvMedicine.Size = new System.Drawing.Size(438, 356);
            this.dgvMedicine.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label11);
            this.panel11.Controls.Add(this.txtMedSearch);
            this.panel11.Location = new System.Drawing.Point(6, 38);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(324, 32);
            this.panel11.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(3, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tìm kiếm:";
            // 
            // txtMedSearch
            // 
            this.txtMedSearch.Location = new System.Drawing.Point(119, 5);
            this.txtMedSearch.Name = "txtMedSearch";
            this.txtMedSearch.Size = new System.Drawing.Size(194, 22);
            this.txtMedSearch.TabIndex = 1;
            // 
            // btnMedSearch
            // 
            this.btnMedSearch.Location = new System.Drawing.Point(346, 21);
            this.btnMedSearch.Name = "btnMedSearch";
            this.btnMedSearch.Size = new System.Drawing.Size(98, 63);
            this.btnMedSearch.TabIndex = 10;
            this.btnMedSearch.Text = "Tìm";
            this.btnMedSearch.UseVisualStyleBackColor = true;
            // 
            // frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 517);
            this.Controls.Add(this.tcAdmin);
            this.Name = "frm_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tcAdmin.ResumeLayout(false);
            this.tpIncome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStat)).EndInit();
            this.tpDoctor.ResumeLayout(false);
            this.tbMedicine.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grpDoctorList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctor)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.grpMed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpIncome;
        private System.Windows.Forms.TabPage tpDoctor;
        private System.Windows.Forms.TabPage tbMedicine;
        private System.Windows.Forms.DataGridView dgvStat;
        private System.Windows.Forms.DateTimePicker dtToDate;
        private System.Windows.Forms.DateTimePicker dtFromDate;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.GroupBox grpDoctorList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDoctorSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDoctor;
        private System.Windows.Forms.Button btnDrSave;
        private System.Windows.Forms.Button btnDrDelete;
        private System.Windows.Forms.Button btnDrEdit;
        private System.Windows.Forms.Button btnDrAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDoctorLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDrSearch;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DateTimePicker txtExp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DateTimePicker txtProductionDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMedUnit;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMedName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMedId;
        private System.Windows.Forms.GroupBox grpMed;
        private System.Windows.Forms.Button btnMedSearch;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMedSearch;
        private System.Windows.Forms.DataGridView dgvMedicine;
        private System.Windows.Forms.Button btnMedSave;
        private System.Windows.Forms.Button btnMedDelete;
        private System.Windows.Forms.Button btnMedEdit;
        private System.Windows.Forms.Button btnMedAdd;
    }
}