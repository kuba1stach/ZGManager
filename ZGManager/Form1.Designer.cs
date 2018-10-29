namespace ZGManager
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zGNRDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zGWREALIZACJIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zGDataSet = new ZGManager.ZGDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.zGNRDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPISDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zGDOWGRANIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.zGNRDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oPISDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tYPDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zGZROBIONEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.sTATUSYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zGDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tYPYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.zG_W_REALIZACJITableAdapter1 = new ZGManager.ZGDataSetTableAdapters.ZG_W_REALIZACJITableAdapter();
            this.zG_DO_WGRANIATableAdapter = new ZGManager.ZGDataSetTableAdapters.ZG_DO_WGRANIATableAdapter();
            this.zG_ZROBIONETableAdapter = new ZGManager.ZGDataSetTableAdapters.ZG_ZROBIONETableAdapter();
            this.tYPYTableAdapter = new ZGManager.ZGDataSetTableAdapters.TYPYTableAdapter();
            this.sTATUSYTableAdapter = new ZGManager.ZGDataSetTableAdapters.STATUSYTableAdapter();
            this.zgTableAdapter1 = new ZGManager.ZGDataSetTableAdapters.ZGTableAdapter();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zGWREALIZACJIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zGDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zGDOWGRANIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zGZROBIONEBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTATUSYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zGDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zGNRDataGridViewTextBoxColumn,
            this.oPISDataGridViewTextBoxColumn,
            this.tYPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zGWREALIZACJIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 34);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(464, 73);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragDrop);
            this.dataGridView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragEnter);
            this.dataGridView1.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridView1_DragOver);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            this.dataGridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseMove);
            // 
            // zGNRDataGridViewTextBoxColumn
            // 
            this.zGNRDataGridViewTextBoxColumn.DataPropertyName = "ZG_NR";
            this.zGNRDataGridViewTextBoxColumn.HeaderText = "ZG_NR";
            this.zGNRDataGridViewTextBoxColumn.Name = "zGNRDataGridViewTextBoxColumn";
            this.zGNRDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oPISDataGridViewTextBoxColumn
            // 
            this.oPISDataGridViewTextBoxColumn.DataPropertyName = "OPIS";
            this.oPISDataGridViewTextBoxColumn.HeaderText = "OPIS";
            this.oPISDataGridViewTextBoxColumn.Name = "oPISDataGridViewTextBoxColumn";
            this.oPISDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tYPDataGridViewTextBoxColumn
            // 
            this.tYPDataGridViewTextBoxColumn.DataPropertyName = "TYP";
            this.tYPDataGridViewTextBoxColumn.HeaderText = "TYP";
            this.tYPDataGridViewTextBoxColumn.Name = "tYPDataGridViewTextBoxColumn";
            this.tYPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zGWREALIZACJIBindingSource
            // 
            this.zGWREALIZACJIBindingSource.DataMember = "ZG_W_REALIZACJI";
            this.zGWREALIZACJIBindingSource.DataSource = this.zGDataSet;
            // 
            // zGDataSet
            // 
            this.zGDataSet.DataSetName = "ZGDataSet";
            this.zGDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowDrop = true;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zGNRDataGridViewTextBoxColumn1,
            this.oPISDataGridViewTextBoxColumn1,
            this.tYPDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.zGDOWGRANIABindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(17, 31);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(349, 86);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView2_DragDrop);
            this.dataGridView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView2_DragEnter);
            this.dataGridView2.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridView2_DragOver);
            this.dataGridView2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseDown);
            this.dataGridView2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseMove);
            // 
            // zGNRDataGridViewTextBoxColumn1
            // 
            this.zGNRDataGridViewTextBoxColumn1.DataPropertyName = "ZG_NR";
            this.zGNRDataGridViewTextBoxColumn1.HeaderText = "ZG_NR";
            this.zGNRDataGridViewTextBoxColumn1.Name = "zGNRDataGridViewTextBoxColumn1";
            this.zGNRDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // oPISDataGridViewTextBoxColumn1
            // 
            this.oPISDataGridViewTextBoxColumn1.DataPropertyName = "OPIS";
            this.oPISDataGridViewTextBoxColumn1.HeaderText = "OPIS";
            this.oPISDataGridViewTextBoxColumn1.Name = "oPISDataGridViewTextBoxColumn1";
            this.oPISDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tYPDataGridViewTextBoxColumn1
            // 
            this.tYPDataGridViewTextBoxColumn1.DataPropertyName = "TYP";
            this.tYPDataGridViewTextBoxColumn1.HeaderText = "TYP";
            this.tYPDataGridViewTextBoxColumn1.Name = "tYPDataGridViewTextBoxColumn1";
            this.tYPDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // zGDOWGRANIABindingSource
            // 
            this.zGDOWGRANIABindingSource.DataMember = "ZG_DO_WGRANIA";
            this.zGDOWGRANIABindingSource.DataSource = this.zGDataSet;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowDrop = true;
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zGNRDataGridViewTextBoxColumn2,
            this.oPISDataGridViewTextBoxColumn2,
            this.tYPDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.zGZROBIONEBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(16, 31);
            this.dataGridView3.MultiSelect = false;
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(359, 72);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);
            this.dataGridView3.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridView3_DragDrop);
            this.dataGridView3.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridView3_DragEnter);
            this.dataGridView3.DragOver += new System.Windows.Forms.DragEventHandler(this.dataGridView3_DragOver);
            this.dataGridView3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView3_MouseDown);
            this.dataGridView3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridView3_MouseMove);
            // 
            // zGNRDataGridViewTextBoxColumn2
            // 
            this.zGNRDataGridViewTextBoxColumn2.DataPropertyName = "ZG_NR";
            this.zGNRDataGridViewTextBoxColumn2.HeaderText = "ZG_NR";
            this.zGNRDataGridViewTextBoxColumn2.Name = "zGNRDataGridViewTextBoxColumn2";
            this.zGNRDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // oPISDataGridViewTextBoxColumn2
            // 
            this.oPISDataGridViewTextBoxColumn2.DataPropertyName = "OPIS";
            this.oPISDataGridViewTextBoxColumn2.HeaderText = "OPIS";
            this.oPISDataGridViewTextBoxColumn2.Name = "oPISDataGridViewTextBoxColumn2";
            this.oPISDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // tYPDataGridViewTextBoxColumn2
            // 
            this.tYPDataGridViewTextBoxColumn2.DataPropertyName = "TYP";
            this.tYPDataGridViewTextBoxColumn2.HeaderText = "TYP";
            this.tYPDataGridViewTextBoxColumn2.Name = "tYPDataGridViewTextBoxColumn2";
            this.tYPDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // zGZROBIONEBindingSource
            // 
            this.zGZROBIONEBindingSource.DataMember = "ZG_ZROBIONE";
            this.zGZROBIONEBindingSource.DataSource = this.zGDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "W realizacji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Do wgrania";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(14, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zrobione";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 110);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 120);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 106);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.richTextBox2);
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 336);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(784, 100);
            this.panel4.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Zapisz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.sTATUSYBindingSource;
            this.comboBox2.DisplayMember = "NAZWA";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(527, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.ValueMember = "REF";
            // 
            // sTATUSYBindingSource
            // 
            this.sTATUSYBindingSource.DataMember = "STATUSY";
            this.sTATUSYBindingSource.DataSource = this.zGDataSetBindingSource;
            // 
            // zGDataSetBindingSource
            // 
            this.zGDataSetBindingSource.DataSource = this.zGDataSet;
            this.zGDataSetBindingSource.Position = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tYPYBindingSource;
            this.comboBox1.DisplayMember = "NAZWA";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(400, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "REF";
            // 
            // tYPYBindingSource
            // 
            this.tYPYBindingSource.DataMember = "TYPY";
            this.tYPYBindingSource.DataSource = this.zGDataSetBindingSource;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(93, 25);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(300, 21);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "OPIS";
            this.richTextBox2.Click += new System.EventHandler(this.richTextBox2_Click);
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(17, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(70, 21);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "ZG";
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(14, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dodaj";
            // 
            // zG_W_REALIZACJITableAdapter1
            // 
            this.zG_W_REALIZACJITableAdapter1.ClearBeforeFill = true;
            // 
            // zG_DO_WGRANIATableAdapter
            // 
            this.zG_DO_WGRANIATableAdapter.ClearBeforeFill = true;
            // 
            // zG_ZROBIONETableAdapter
            // 
            this.zG_ZROBIONETableAdapter.ClearBeforeFill = true;
            // 
            // tYPYTableAdapter
            // 
            this.tYPYTableAdapter.ClearBeforeFill = true;
            // 
            // sTATUSYTableAdapter
            // 
            this.sTATUSYTableAdapter.ClearBeforeFill = true;
            // 
            // zgTableAdapter1
            // 
            this.zgTableAdapter1.ClearBeforeFill = true;
            // 
            // panel5
            // 
            this.panel5.AllowDrop = true;
            this.panel5.BackgroundImage = global::ZGManager.Properties.Resources.garbage_icon;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(711, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(70, 60);
            this.panel5.TabIndex = 4;
            this.panel5.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel5_DragDrop);
            this.panel5.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel5_DragEnter);
            this.panel5.DragOver += new System.Windows.Forms.DragEventHandler(this.panel5_DragOver);
            this.panel5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ZGManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zGWREALIZACJIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zGDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zGDOWGRANIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zGZROBIONEBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTATUSYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zGDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tYPYBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZGDataSetTableAdapters.ZG_W_REALIZACJITableAdapter zG_W_REALIZACJITableAdapter1;
        private ZGDataSet zGDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zGNRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource zGWREALIZACJIBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource zGDOWGRANIABindingSource;
        private ZGDataSetTableAdapters.ZG_DO_WGRANIATableAdapter zG_DO_WGRANIATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn zGNRDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPISDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource zGZROBIONEBindingSource;
        private ZGDataSetTableAdapters.ZG_ZROBIONETableAdapter zG_ZROBIONETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn zGNRDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn oPISDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tYPDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource zGDataSetBindingSource;
        private System.Windows.Forms.BindingSource tYPYBindingSource;
        private ZGDataSetTableAdapters.TYPYTableAdapter tYPYTableAdapter;
        private System.Windows.Forms.BindingSource sTATUSYBindingSource;
        private ZGDataSetTableAdapters.STATUSYTableAdapter sTATUSYTableAdapter;
        private ZGDataSetTableAdapters.ZGTableAdapter zgTableAdapter1;
        private System.Windows.Forms.Panel panel5;
    }
}

