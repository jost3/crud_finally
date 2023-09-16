namespace present_grafic
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaliendo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.btnSaliendo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 60);
            this.panel1.TabIndex = 0;
            // 
            // btnSaliendo
            // 
            this.btnSaliendo.BackColor = System.Drawing.Color.Red;
            this.btnSaliendo.ForeColor = System.Drawing.Color.White;
            this.btnSaliendo.Location = new System.Drawing.Point(528, 12);
            this.btnSaliendo.Name = "btnSaliendo";
            this.btnSaliendo.Size = new System.Drawing.Size(40, 29);
            this.btnSaliendo.TabIndex = 0;
            this.btnSaliendo.Text = "X";
            this.btnSaliendo.UseVisualStyleBackColor = false;
            this.btnSaliendo.Click += new System.EventHandler(this.btnSaliendo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::present_grafic.Properties.Resources.log;
            this.pictureBox1.Location = new System.Drawing.Point(201, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTRASEÑA";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(139, 307);
            this.textUser.Multiline = true;
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(259, 37);
            this.textUser.TabIndex = 4;
            this.textUser.Text = "Ingrese Su usuario";
            this.textUser.Enter += new System.EventHandler(this.textUser_Enter);
            this.textUser.Leave += new System.EventHandler(this.textUser_Leave);
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(139, 415);
            this.textContraseña.Multiline = true;
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.Size = new System.Drawing.Size(259, 37);
            this.textContraseña.TabIndex = 5;
            this.textContraseña.Text = "Ingrese Su Contraseña";
            this.textContraseña.FontChanged += new System.EventHandler(this.textContraseña_FontChanged);
            this.textContraseña.Enter += new System.EventHandler(this.textContraseña_Enter);
            this.textContraseña.Leave += new System.EventHandler(this.textContraseña_Leave);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Red;
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(220, 476);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(104, 43);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "INGRESAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 531);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaliendo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Button btnRegistrar;
    }
}