namespace WindowsFormsApp3
{
    partial class Maint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maint));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.makinatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentalRTADataSet = new WindowsFormsApp3.RentalRTADataSet();
            this.makinatTableAdapter = new WindowsFormsApp3.RentalRTADataSetTableAdapters.MakinatTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.makinatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rentalRTADataSet5 = new WindowsFormsApp3.RentalRTADataSet5();
            this.makinatTableAdapter1 = new WindowsFormsApp3.RentalRTADataSet5TableAdapters.MakinatTableAdapter();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rentalRTADataSet6 = new WindowsFormsApp3.RentalRTADataSet6();
            this.makinatBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.makinatTableAdapter2 = new WindowsFormsApp3.RentalRTADataSet6TableAdapters.MakinatTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gjendjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demtimetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.makinatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalRTADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makinatBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalRTADataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalRTADataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makinatBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(122, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gjendja e Automjeteve";
            // 
            // makinatBindingSource
            // 
            this.makinatBindingSource.DataMember = "Makinat";
            this.makinatBindingSource.DataSource = this.rentalRTADataSet;
            // 
            // rentalRTADataSet
            // 
            this.rentalRTADataSet.DataSetName = "RentalRTADataSet";
            this.rentalRTADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // makinatTableAdapter
            // 
            this.makinatTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Perditeso gjendjen e mjeteve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID mjeti:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gjendja tani:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(268, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 62);
            this.button1.TabIndex = 7;
            this.button1.Text = "Perditeso!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(518, 398);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // makinatBindingSource1
            // 
            this.makinatBindingSource1.DataMember = "Makinat";
            this.makinatBindingSource1.DataSource = this.rentalRTADataSet5;
            // 
            // rentalRTADataSet5
            // 
            this.rentalRTADataSet5.DataSetName = "RentalRTADataSet5";
            this.rentalRTADataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // makinatTableAdapter1
            // 
            this.makinatTableAdapter1.ClearBeforeFill = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(351, 225);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(221, 196);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.makinaDataGridViewTextBoxColumn,
            this.gjendjaDataGridViewTextBoxColumn,
            this.demtimetDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.makinatBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(17, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(320, 168);
            this.dataGridView1.TabIndex = 13;
            // 
            // rentalRTADataSet6
            // 
            this.rentalRTADataSet6.DataSetName = "RentalRTADataSet6";
            this.rentalRTADataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // makinatBindingSource2
            // 
            this.makinatBindingSource2.DataMember = "Makinat";
            this.makinatBindingSource2.DataSource = this.rentalRTADataSet6;
            // 
            // makinatTableAdapter2
            // 
            this.makinatTableAdapter2.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // makinaDataGridViewTextBoxColumn
            // 
            this.makinaDataGridViewTextBoxColumn.DataPropertyName = "Makina";
            this.makinaDataGridViewTextBoxColumn.HeaderText = "Makina";
            this.makinaDataGridViewTextBoxColumn.Name = "makinaDataGridViewTextBoxColumn";
            // 
            // gjendjaDataGridViewTextBoxColumn
            // 
            this.gjendjaDataGridViewTextBoxColumn.DataPropertyName = "Gjendja";
            this.gjendjaDataGridViewTextBoxColumn.HeaderText = "Gjendja";
            this.gjendjaDataGridViewTextBoxColumn.Name = "gjendjaDataGridViewTextBoxColumn";
            // 
            // demtimetDataGridViewTextBoxColumn
            // 
            this.demtimetDataGridViewTextBoxColumn.DataPropertyName = "Demtimet";
            this.demtimetDataGridViewTextBoxColumn.HeaderText = "Demtimet";
            this.demtimetDataGridViewTextBoxColumn.Name = "demtimetDataGridViewTextBoxColumn";
            // 
            // Maint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Maint";
            this.Text = "Maint";
            this.Load += new System.EventHandler(this.Maint_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.makinatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalRTADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makinatBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalRTADataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentalRTADataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makinatBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private RentalRTADataSet rentalRTADataSet;
        private System.Windows.Forms.BindingSource makinatBindingSource;
        private RentalRTADataSetTableAdapters.MakinatTableAdapter makinatTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private RentalRTADataSet5 rentalRTADataSet5;
        private System.Windows.Forms.BindingSource makinatBindingSource1;
        private RentalRTADataSet5TableAdapters.MakinatTableAdapter makinatTableAdapter1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RentalRTADataSet6 rentalRTADataSet6;
        private System.Windows.Forms.BindingSource makinatBindingSource2;
        private RentalRTADataSet6TableAdapters.MakinatTableAdapter makinatTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gjendjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demtimetDataGridViewTextBoxColumn;
    }
}