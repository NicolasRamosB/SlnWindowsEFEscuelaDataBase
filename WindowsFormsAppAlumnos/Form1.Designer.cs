namespace WindowsFormsAppAlumnos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFindIdAlumno = new System.Windows.Forms.Button();
            this.btnDeleteAlumno = new System.Windows.Forms.Button();
            this.btnUpdateAlumno = new System.Windows.Forms.Button();
            this.btnInsertAlumno = new System.Windows.Forms.Button();
            this.dataGridAlumno = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindIdAlumno
            // 
            this.btnFindIdAlumno.Location = new System.Drawing.Point(37, 188);
            this.btnFindIdAlumno.Name = "btnFindIdAlumno";
            this.btnFindIdAlumno.Size = new System.Drawing.Size(95, 68);
            this.btnFindIdAlumno.TabIndex = 24;
            this.btnFindIdAlumno.Text = "Buscar por ID";
            this.btnFindIdAlumno.UseVisualStyleBackColor = true;
            this.btnFindIdAlumno.Click += new System.EventHandler(this.btnFindIdAlumno_Click);
            // 
            // btnDeleteAlumno
            // 
            this.btnDeleteAlumno.Location = new System.Drawing.Point(37, 277);
            this.btnDeleteAlumno.Name = "btnDeleteAlumno";
            this.btnDeleteAlumno.Size = new System.Drawing.Size(95, 68);
            this.btnDeleteAlumno.TabIndex = 23;
            this.btnDeleteAlumno.Text = "Eliminar";
            this.btnDeleteAlumno.UseVisualStyleBackColor = true;
            this.btnDeleteAlumno.Click += new System.EventHandler(this.btnDeleteAlumno_Click);
            // 
            // btnUpdateAlumno
            // 
            this.btnUpdateAlumno.Location = new System.Drawing.Point(37, 95);
            this.btnUpdateAlumno.Name = "btnUpdateAlumno";
            this.btnUpdateAlumno.Size = new System.Drawing.Size(95, 68);
            this.btnUpdateAlumno.TabIndex = 22;
            this.btnUpdateAlumno.Text = "Modificar";
            this.btnUpdateAlumno.UseVisualStyleBackColor = true;
            this.btnUpdateAlumno.Click += new System.EventHandler(this.btnUpdateAlumno_Click);
            // 
            // btnInsertAlumno
            // 
            this.btnInsertAlumno.Location = new System.Drawing.Point(37, 12);
            this.btnInsertAlumno.Name = "btnInsertAlumno";
            this.btnInsertAlumno.Size = new System.Drawing.Size(95, 68);
            this.btnInsertAlumno.TabIndex = 21;
            this.btnInsertAlumno.Text = "Insertar";
            this.btnInsertAlumno.UseVisualStyleBackColor = true;
            this.btnInsertAlumno.Click += new System.EventHandler(this.btnInsertAlumno_Click);
            // 
            // dataGridAlumno
            // 
            this.dataGridAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAlumno.Location = new System.Drawing.Point(175, 159);
            this.dataGridAlumno.Name = "dataGridAlumno";
            this.dataGridAlumno.Size = new System.Drawing.Size(581, 266);
            this.dataGridAlumno.TabIndex = 29;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(341, 64);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(247, 20);
            this.textBoxName.TabIndex = 28;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(341, 37);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(247, 20);
            this.textBoxID.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(341, 95);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(247, 20);
            this.textBoxApellido.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFecha.Location = new System.Drawing.Point(341, 121);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFecha.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimeFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.dataGridAlumno);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFindIdAlumno);
            this.Controls.Add(this.btnDeleteAlumno);
            this.Controls.Add(this.btnUpdateAlumno);
            this.Controls.Add(this.btnInsertAlumno);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAlumno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindIdAlumno;
        private System.Windows.Forms.Button btnDeleteAlumno;
        private System.Windows.Forms.Button btnUpdateAlumno;
        private System.Windows.Forms.Button btnInsertAlumno;
        private System.Windows.Forms.DataGridView dataGridAlumno;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
    }
}

