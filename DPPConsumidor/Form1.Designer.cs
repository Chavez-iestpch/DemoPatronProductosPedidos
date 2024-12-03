namespace DPPConsumidor
{
    partial class Form1
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
            panel1 = new Panel();
            BtnRegistrar = new Button();
            TxtCorreo = new TextBox();
            TxtNombres = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            BtnProcesar = new Button();
            DgvUsuario = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvUsuario).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnRegistrar);
            panel1.Controls.Add(TxtCorreo);
            panel1.Controls.Add(TxtNombres);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(29, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(694, 258);
            panel1.TabIndex = 1;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.Location = new Point(567, 197);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(114, 36);
            BtnRegistrar.TabIndex = 2;
            BtnRegistrar.Text = "Registrar";
            BtnRegistrar.UseVisualStyleBackColor = true;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // TxtCorreo
            // 
            TxtCorreo.Location = new Point(9, 131);
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.Size = new Size(652, 27);
            TxtCorreo.TabIndex = 1;
            // 
            // TxtNombres
            // 
            TxtNombres.Location = new Point(9, 44);
            TxtNombres.Name = "TxtNombres";
            TxtNombres.Size = new Size(652, 27);
            TxtNombres.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 100);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 0;
            label2.Text = "Correo Electronico";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 21);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombres";
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnProcesar);
            panel2.Controls.Add(DgvUsuario);
            panel2.Location = new Point(29, 320);
            panel2.Name = "panel2";
            panel2.Size = new Size(694, 331);
            panel2.TabIndex = 2;
            // 
            // BtnProcesar
            // 
            BtnProcesar.Location = new Point(595, 30);
            BtnProcesar.Name = "BtnProcesar";
            BtnProcesar.Size = new Size(86, 31);
            BtnProcesar.TabIndex = 1;
            BtnProcesar.Text = "Procesar";
            BtnProcesar.UseVisualStyleBackColor = true;
            BtnProcesar.Click += BtnProcesar_Click;
            // 
            // DgvUsuario
            // 
            DgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvUsuario.Columns.AddRange(new DataGridViewColumn[] { Id, Nombres, Correo, Fecha });
            DgvUsuario.Location = new Point(7, 15);
            DgvUsuario.Name = "DgvUsuario";
            DgvUsuario.RowHeadersWidth = 51;
            DgvUsuario.Size = new Size(563, 314);
            DgvUsuario.TabIndex = 0;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Nombres
            // 
            Nombres.HeaderText = "Nombres";
            Nombres.MinimumWidth = 6;
            Nombres.Name = "Nombres";
            Nombres.Width = 125;
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            Correo.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 701);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnRegistrar;
        private TextBox TxtCorreo;
        private TextBox TxtNombres;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Button BtnProcesar;
        private DataGridView DgvUsuario;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Fecha;
    }
}
