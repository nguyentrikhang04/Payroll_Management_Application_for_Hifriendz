namespace G107NTKSlrHF
{
    partial class Fr4ChuyenNhom
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxS = new System.Windows.Forms.ListBox();
            this.dMNSHFBindingSourceS = new System.Windows.Forms.BindingSource(this.components);
            this.g107NTKSalaHFDsDmnsHfS = new G107NTKSlrHF.G107NTKSalaHFDsDmnsHfS();
            this.comboBoxS = new System.Windows.Forms.ComboBox();
            this.dMBPBindingSourceS = new System.Windows.Forms.BindingSource(this.components);
            this.g107NTKSalaHFDsDmbpS = new G107NTKSlrHF.G107NTKSalaHFDsDmbpS();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxD = new System.Windows.Forms.ListBox();
            this.dMNSHFBindingSourceD = new System.Windows.Forms.BindingSource(this.components);
            this.g107NTKSalaHFDsDmnsHfD = new G107NTKSlrHF.G107NTKSalaHFDsDmnsHfD();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxD = new System.Windows.Forms.ComboBox();
            this.dMBPBindingSourceD = new System.Windows.Forms.BindingSource(this.components);
            this.g107NTKSalaHFDsDmbpD = new G107NTKSlrHF.G107NTKSalaHFDsDmbpD();
            this.groupBoxN = new System.Windows.Forms.GroupBox();
            this.btnARL = new System.Windows.Forms.Button();
            this.btnALR = new System.Windows.Forms.Button();
            this.btnRL = new System.Windows.Forms.Button();
            this.btnLR = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dMBPTableAdapterS = new G107NTKSlrHF.G107NTKSalaHFDsDmbpSTableAdapters.DMBPTableAdapter();
            this.dMBPTableAdapterD = new G107NTKSlrHF.G107NTKSalaHFDsDmbpDTableAdapters.DMBPTableAdapter();
            this.dMNSHFTableAdapterS = new G107NTKSlrHF.G107NTKSalaHFDsDmnsHfSTableAdapters.DMNSHFTableAdapter();
            this.dMNSHFTableAdapterD = new G107NTKSlrHF.G107NTKSalaHFDsDmnsHfDTableAdapters.DMNSHFTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dMNSHFBindingSourceS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g107NTKSalaHFDsDmnsHfS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMBPBindingSourceS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g107NTKSalaHFDsDmbpS)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dMNSHFBindingSourceD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g107NTKSalaHFDsDmnsHfD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMBPBindingSourceD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.g107NTKSalaHFDsDmbpD)).BeginInit();
            this.groupBoxN.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1080, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐÂY LÀ MÀN HÌNH CHUYỂN <<NHÂN VIÊN>> TỪ BỘ PHẬN NÀY SANG BỘ PHẬN KHÁC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxS);
            this.groupBox1.Controls.Add(this.comboBoxS);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 474);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NHÓM NGUỒN (SOURCE)";
            // 
            // listBoxS
            // 
            this.listBoxS.DataSource = this.dMNSHFBindingSourceS;
            this.listBoxS.DisplayMember = "tenns";
            this.listBoxS.FormattingEnabled = true;
            this.listBoxS.ItemHeight = 20;
            this.listBoxS.Location = new System.Drawing.Point(6, 152);
            this.listBoxS.Name = "listBoxS";
            this.listBoxS.Size = new System.Drawing.Size(454, 304);
            this.listBoxS.TabIndex = 3;
            this.listBoxS.ValueMember = "msns";
            // 
            // dMNSHFBindingSourceS
            // 
            this.dMNSHFBindingSourceS.DataMember = "DMNSHF";
            this.dMNSHFBindingSourceS.DataSource = this.g107NTKSalaHFDsDmnsHfS;
            // 
            // g107NTKSalaHFDsDmnsHfS
            // 
            this.g107NTKSalaHFDsDmnsHfS.DataSetName = "G107NTKSalaHFDsDmnsHfS";
            this.g107NTKSalaHFDsDmnsHfS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxS
            // 
            this.comboBoxS.DataSource = this.dMBPBindingSourceS;
            this.comboBoxS.DisplayMember = "tenbp";
            this.comboBoxS.FormattingEnabled = true;
            this.comboBoxS.Location = new System.Drawing.Point(179, 44);
            this.comboBoxS.Name = "comboBoxS";
            this.comboBoxS.Size = new System.Drawing.Size(220, 28);
            this.comboBoxS.TabIndex = 1;
            this.comboBoxS.ValueMember = "msbp";
            this.comboBoxS.SelectedIndexChanged += new System.EventHandler(this.comboBoxS_SelectedIndexChanged);
            // 
            // dMBPBindingSourceS
            // 
            this.dMBPBindingSourceS.DataMember = "DMBP";
            this.dMBPBindingSourceS.DataSource = this.g107NTKSalaHFDsDmbpS;
            // 
            // g107NTKSalaHFDsDmbpS
            // 
            this.g107NTKSalaHFDsDmbpS.DataSetName = "G107NTKSalaHFDsDmbpS";
            this.g107NTKSalaHFDsDmbpS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh sách các Nhân viên thuộc Bộ phận (Nguồn):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chọn Bộ phận (Nguồn):";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxD);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBoxD);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(667, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(466, 474);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NHÓM ĐÍCH (DESTINATION)";
            // 
            // listBoxD
            // 
            this.listBoxD.DataSource = this.dMNSHFBindingSourceD;
            this.listBoxD.DisplayMember = "tenns";
            this.listBoxD.FormattingEnabled = true;
            this.listBoxD.ItemHeight = 20;
            this.listBoxD.Location = new System.Drawing.Point(9, 152);
            this.listBoxD.Name = "listBoxD";
            this.listBoxD.Size = new System.Drawing.Size(451, 304);
            this.listBoxD.TabIndex = 3;
            this.listBoxD.ValueMember = "msns";
            // 
            // dMNSHFBindingSourceD
            // 
            this.dMNSHFBindingSourceD.DataMember = "DMNSHF";
            this.dMNSHFBindingSourceD.DataSource = this.g107NTKSalaHFDsDmnsHfD;
            // 
            // g107NTKSalaHFDsDmnsHfD
            // 
            this.g107NTKSalaHFDsDmnsHfD.DataSetName = "G107NTKSalaHFDsDmnsHfD";
            this.g107NTKSalaHFDsDmnsHfD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chọn Bộ phận (Đích):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Danh sách các Nhân viên thuộc Bộ phận (Đích):";
            // 
            // comboBoxD
            // 
            this.comboBoxD.DataSource = this.dMBPBindingSourceD;
            this.comboBoxD.DisplayMember = "tenbp";
            this.comboBoxD.FormattingEnabled = true;
            this.comboBoxD.Location = new System.Drawing.Point(172, 44);
            this.comboBoxD.Name = "comboBoxD";
            this.comboBoxD.Size = new System.Drawing.Size(220, 28);
            this.comboBoxD.TabIndex = 1;
            this.comboBoxD.ValueMember = "msbp";
            this.comboBoxD.SelectedIndexChanged += new System.EventHandler(this.comboBoxD_SelectedIndexChanged);
            // 
            // dMBPBindingSourceD
            // 
            this.dMBPBindingSourceD.DataMember = "DMBP";
            this.dMBPBindingSourceD.DataSource = this.g107NTKSalaHFDsDmbpD;
            // 
            // g107NTKSalaHFDsDmbpD
            // 
            this.g107NTKSalaHFDsDmbpD.DataSetName = "G107NTKSalaHFDsDmbpD";
            this.g107NTKSalaHFDsDmbpD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBoxN
            // 
            this.groupBoxN.Controls.Add(this.btnARL);
            this.groupBoxN.Controls.Add(this.btnALR);
            this.groupBoxN.Controls.Add(this.btnRL);
            this.groupBoxN.Controls.Add(this.btnLR);
            this.groupBoxN.Location = new System.Drawing.Point(524, 222);
            this.groupBoxN.Name = "groupBoxN";
            this.groupBoxN.Size = new System.Drawing.Size(120, 345);
            this.groupBoxN.TabIndex = 5;
            this.groupBoxN.TabStop = false;
            // 
            // btnARL
            // 
            this.btnARL.Enabled = false;
            this.btnARL.Location = new System.Drawing.Point(19, 278);
            this.btnARL.Name = "btnARL";
            this.btnARL.Size = new System.Drawing.Size(82, 51);
            this.btnARL.TabIndex = 0;
            this.btnARL.Text = "<<";
            this.btnARL.UseVisualStyleBackColor = true;
            this.btnARL.Click += new System.EventHandler(this.btnARL_Click);
            // 
            // btnALR
            // 
            this.btnALR.Enabled = false;
            this.btnALR.Location = new System.Drawing.Point(19, 212);
            this.btnALR.Name = "btnALR";
            this.btnALR.Size = new System.Drawing.Size(82, 51);
            this.btnALR.TabIndex = 0;
            this.btnALR.Text = ">>";
            this.btnALR.UseVisualStyleBackColor = true;
            this.btnALR.Click += new System.EventHandler(this.btnALR_Click);
            // 
            // btnRL
            // 
            this.btnRL.Enabled = false;
            this.btnRL.Location = new System.Drawing.Point(19, 98);
            this.btnRL.Name = "btnRL";
            this.btnRL.Size = new System.Drawing.Size(82, 51);
            this.btnRL.TabIndex = 0;
            this.btnRL.Text = "<";
            this.btnRL.UseVisualStyleBackColor = true;
            this.btnRL.Click += new System.EventHandler(this.btnRL_Click);
            // 
            // btnLR
            // 
            this.btnLR.Enabled = false;
            this.btnLR.Location = new System.Drawing.Point(19, 32);
            this.btnLR.Name = "btnLR";
            this.btnLR.Size = new System.Drawing.Size(82, 51);
            this.btnLR.TabIndex = 0;
            this.btnLR.Text = ">";
            this.btnLR.UseVisualStyleBackColor = true;
            this.btnLR.Click += new System.EventHandler(this.btnLR_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(320, 585);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(176, 51);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "VỀ MÀN HÌNH CHÍNH";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(684, 585);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(176, 51);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "THOÁT CHƯƠNG TRÌNH";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dMBPTableAdapterS
            // 
            this.dMBPTableAdapterS.ClearBeforeFill = true;
            // 
            // dMBPTableAdapterD
            // 
            this.dMBPTableAdapterD.ClearBeforeFill = true;
            // 
            // dMNSHFTableAdapterS
            // 
            this.dMNSHFTableAdapterS.ClearBeforeFill = true;
            // 
            // dMNSHFTableAdapterD
            // 
            this.dMNSHFTableAdapterD.ClearBeforeFill = true;
            // 
            // Fr4ChuyenNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 686);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBoxN);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Fr4ChuyenNhom";
            this.Text = "CHUYỂN MỘT NHÂN VIÊN TỪ BỘ PHẬN NÀY SANG BỘ PHẬN KHÁC";
            this.Load += new System.EventHandler(this.FrChuyenNhom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dMNSHFBindingSourceS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g107NTKSalaHFDsDmnsHfS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMBPBindingSourceS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g107NTKSalaHFDsDmbpS)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dMNSHFBindingSourceD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g107NTKSalaHFDsDmnsHfD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMBPBindingSourceD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.g107NTKSalaHFDsDmbpD)).EndInit();
            this.groupBoxN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxD;
        private System.Windows.Forms.GroupBox groupBoxN;
        private System.Windows.Forms.Button btnARL;
        private System.Windows.Forms.Button btnALR;
        private System.Windows.Forms.Button btnRL;
        private System.Windows.Forms.Button btnLR;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBoxS;
        private System.Windows.Forms.ListBox listBoxD;
        private G107NTKSalaHFDsDmbpS g107NTKSalaHFDsDmbpS;
        private System.Windows.Forms.BindingSource dMBPBindingSourceS;
        private G107NTKSalaHFDsDmbpSTableAdapters.DMBPTableAdapter dMBPTableAdapterS;
        private G107NTKSalaHFDsDmbpD g107NTKSalaHFDsDmbpD;
        private System.Windows.Forms.BindingSource dMBPBindingSourceD;
        private G107NTKSalaHFDsDmbpDTableAdapters.DMBPTableAdapter dMBPTableAdapterD;
        private G107NTKSalaHFDsDmnsHfS g107NTKSalaHFDsDmnsHfS;
        private System.Windows.Forms.BindingSource dMNSHFBindingSourceS;
        private G107NTKSalaHFDsDmnsHfSTableAdapters.DMNSHFTableAdapter dMNSHFTableAdapterS;
        private G107NTKSalaHFDsDmnsHfD g107NTKSalaHFDsDmnsHfD;
        private System.Windows.Forms.BindingSource dMNSHFBindingSourceD;
        private G107NTKSalaHFDsDmnsHfDTableAdapters.DMNSHFTableAdapter dMNSHFTableAdapterD;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}