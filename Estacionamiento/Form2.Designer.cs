namespace Estacionamiento
{
    partial class Form2
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dBEstacionamientoDataSet = new Estacionamiento.DBEstacionamientoDataSet();
            this.cajonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cajonesTableAdapter = new Estacionamiento.DBEstacionamientoDataSetTableAdapters.cajonesTableAdapter();
            this.idcajonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statuscajonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipocajonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idautoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBEstacionamientoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajonesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button3.Location = new System.Drawing.Point(425, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 48);
            this.button3.TabIndex = 5;
            this.button3.Text = "Estacionamiento ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button2.Location = new System.Drawing.Point(217, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Registro";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button1.Location = new System.Drawing.Point(1, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Control";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(8, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 211);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button6.Location = new System.Drawing.Point(9, 139);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 55);
            this.button6.TabIndex = 11;
            this.button6.Text = "CAMBIO";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button5.Location = new System.Drawing.Point(9, 78);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 55);
            this.button5.TabIndex = 10;
            this.button5.Text = "SALIDA";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.button4.Location = new System.Drawing.Point(9, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 55);
            this.button4.TabIndex = 9;
            this.button4.Text = "ENTRADA ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Control ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcajonDataGridViewTextBoxColumn,
            this.statuscajonDataGridViewTextBoxColumn,
            this.seccionDataGridViewTextBoxColumn,
            this.tipocajonDataGridViewTextBoxColumn,
            this.idautoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cajonesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(217, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 144);
            this.dataGridView1.TabIndex = 8;
            // 
            // dBEstacionamientoDataSet
            // 
            this.dBEstacionamientoDataSet.DataSetName = "DBEstacionamientoDataSet";
            this.dBEstacionamientoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cajonesBindingSource
            // 
            this.cajonesBindingSource.DataMember = "cajones";
            this.cajonesBindingSource.DataSource = this.dBEstacionamientoDataSet;
            // 
            // cajonesTableAdapter
            // 
            this.cajonesTableAdapter.ClearBeforeFill = true;
            // 
            // idcajonDataGridViewTextBoxColumn
            // 
            this.idcajonDataGridViewTextBoxColumn.DataPropertyName = "idcajon";
            this.idcajonDataGridViewTextBoxColumn.HeaderText = "idcajon";
            this.idcajonDataGridViewTextBoxColumn.Name = "idcajonDataGridViewTextBoxColumn";
            // 
            // statuscajonDataGridViewTextBoxColumn
            // 
            this.statuscajonDataGridViewTextBoxColumn.DataPropertyName = "status_cajon";
            this.statuscajonDataGridViewTextBoxColumn.HeaderText = "status_cajon";
            this.statuscajonDataGridViewTextBoxColumn.Name = "statuscajonDataGridViewTextBoxColumn";
            // 
            // seccionDataGridViewTextBoxColumn
            // 
            this.seccionDataGridViewTextBoxColumn.DataPropertyName = "seccion";
            this.seccionDataGridViewTextBoxColumn.HeaderText = "seccion";
            this.seccionDataGridViewTextBoxColumn.Name = "seccionDataGridViewTextBoxColumn";
            // 
            // tipocajonDataGridViewTextBoxColumn
            // 
            this.tipocajonDataGridViewTextBoxColumn.DataPropertyName = "tipo_cajon";
            this.tipocajonDataGridViewTextBoxColumn.HeaderText = "tipo_cajon";
            this.tipocajonDataGridViewTextBoxColumn.Name = "tipocajonDataGridViewTextBoxColumn";
            // 
            // idautoDataGridViewTextBoxColumn
            // 
            this.idautoDataGridViewTextBoxColumn.DataPropertyName = "idauto";
            this.idautoDataGridViewTextBoxColumn.HeaderText = "idauto";
            this.idautoDataGridViewTextBoxColumn.Name = "idautoDataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 312);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Estacionamiento de FIME";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBEstacionamientoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajonesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBEstacionamientoDataSet dBEstacionamientoDataSet;
        private System.Windows.Forms.BindingSource cajonesBindingSource;
        private DBEstacionamientoDataSetTableAdapters.cajonesTableAdapter cajonesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcajonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statuscajonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipocajonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idautoDataGridViewTextBoxColumn;
    }
}