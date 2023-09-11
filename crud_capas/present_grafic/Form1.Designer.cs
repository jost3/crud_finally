namespace present_grafic
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textDni = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SkyBlue;
            this.panelTop.Controls.Add(this.btnMax);
            this.panelTop.Controls.Add(this.btnMin);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(922, 60);
            this.panelTop.TabIndex = 0;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMax.Font = new System.Drawing.Font("Agency FB", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(822, 12);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(42, 31);
            this.btnMax.TabIndex = 1;
            this.btnMax.Text = "0";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(774, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(42, 31);
            this.btnMin.TabIndex = 1;
            this.btnMin.Text = "---";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(870, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 371);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(900, 483);
            this.dataGridView1.TabIndex = 1;
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(12, 145);
            this.textNombre.Multiline = true;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(226, 34);
            this.textNombre.TabIndex = 2;
            this.textNombre.Text = "Nombre";
            this.textNombre.Enter += new System.EventHandler(this.textNombre_Enter);
            this.textNombre.Leave += new System.EventHandler(this.textNombre_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // textApellido
            // 
            this.textApellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.Location = new System.Drawing.Point(16, 238);
            this.textApellido.Multiline = true;
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(222, 34);
            this.textApellido.TabIndex = 4;
            this.textApellido.Text = "Apellido";
            this.textApellido.Enter += new System.EventHandler(this.textApellido_Enter);
            this.textApellido.Leave += new System.EventHandler(this.textApellido_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(285, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // textID
            // 
            this.textID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(289, 145);
            this.textID.Multiline = true;
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(228, 34);
            this.textID.TabIndex = 6;
            this.textID.Text = "ID";
            this.textID.Enter += new System.EventHandler(this.textID_Enter);
            this.textID.Leave += new System.EventHandler(this.textID_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(285, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sexo";
            // 
            // comboSexo
            // 
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otros"});
            this.comboSexo.Location = new System.Drawing.Point(289, 248);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(228, 24);
            this.comboSexo.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(538, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 163);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(211, 106);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(106, 41);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(211, 36);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(106, 41);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(38, 106);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 41);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(38, 36);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 41);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(143, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "DNI";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textDni
            // 
            this.textDni.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDni.Location = new System.Drawing.Point(147, 312);
            this.textDni.Multiline = true;
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(222, 34);
            this.textDni.TabIndex = 13;
            this.textDni.Text = "Dni";
            this.textDni.Enter += new System.EventHandler(this.textDni_Enter);
            this.textDni.Leave += new System.EventHandler(this.textDni_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(922, 622);
            this.Controls.Add(this.textDni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboSexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelTop);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDni;
    }
}

