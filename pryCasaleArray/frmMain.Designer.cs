namespace pryCasaleArray
{
    partial class frmMain
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
            this.gbVector = new System.Windows.Forms.GroupBox();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.gbMatriz = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnListarMatriz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCargarMatriz = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.PARCIAL1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PARCIAL2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbVector.SuspendLayout();
            this.gbMatriz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // gbVector
            // 
            this.gbVector.Controls.Add(this.lstNombres);
            this.gbVector.Controls.Add(this.btnListar);
            this.gbVector.Controls.Add(this.lblinfo);
            this.gbVector.Controls.Add(this.btnCargar);
            this.gbVector.Controls.Add(this.txtNumero);
            this.gbVector.Location = new System.Drawing.Point(12, 12);
            this.gbVector.Name = "gbVector";
            this.gbVector.Size = new System.Drawing.Size(503, 220);
            this.gbVector.TabIndex = 0;
            this.gbVector.TabStop = false;
            this.gbVector.Text = "Vector";
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.Location = new System.Drawing.Point(64, 101);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(120, 95);
            this.lstNombres.TabIndex = 4;
            // 
            // btnListar
            // 
            this.btnListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.Location = new System.Drawing.Point(229, 101);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(181, 47);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(35, 20);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(323, 13);
            this.lblinfo.TabIndex = 2;
            this.lblinfo.Text = "Cargue nombres de sus mejores alumnos. Un maximo de 3 alumnos";
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(229, 48);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(181, 47);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(84, 56);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 32);
            this.txtNumero.TabIndex = 0;
            // 
            // gbMatriz
            // 
            this.gbMatriz.Controls.Add(this.btnCrear);
            this.gbMatriz.Controls.Add(this.listBox1);
            this.gbMatriz.Controls.Add(this.btnListarMatriz);
            this.gbMatriz.Controls.Add(this.label1);
            this.gbMatriz.Controls.Add(this.btnCargarMatriz);
            this.gbMatriz.Controls.Add(this.textBox1);
            this.gbMatriz.Location = new System.Drawing.Point(12, 238);
            this.gbMatriz.Name = "gbMatriz";
            this.gbMatriz.Size = new System.Drawing.Size(503, 220);
            this.gbMatriz.TabIndex = 5;
            this.gbMatriz.TabStop = false;
            this.gbMatriz.Text = "Matriz";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(64, 101);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // btnListarMatriz
            // 
            this.btnListarMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarMatriz.Location = new System.Drawing.Point(229, 154);
            this.btnListarMatriz.Name = "btnListarMatriz";
            this.btnListarMatriz.Size = new System.Drawing.Size(181, 47);
            this.btnListarMatriz.TabIndex = 3;
            this.btnListarMatriz.Text = "Listar";
            this.btnListarMatriz.UseVisualStyleBackColor = true;
            this.btnListarMatriz.Click += new System.EventHandler(this.btnListarMatriz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carga 3 NOTAS de ALUMNOS (parcial1 , parcial2, TP)";
            // 
            // btnCargarMatriz
            // 
            this.btnCargarMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarMatriz.Location = new System.Drawing.Point(229, 101);
            this.btnCargarMatriz.Name = "btnCargarMatriz";
            this.btnCargarMatriz.Size = new System.Drawing.Size(181, 47);
            this.btnCargarMatriz.TabIndex = 1;
            this.btnCargarMatriz.Text = "Cargar";
            this.btnCargarMatriz.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(64, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 32);
            this.textBox1.TabIndex = 0;
            // 
            // btnCrear
            // 
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.Location = new System.Drawing.Point(229, 48);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(181, 47);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dgvNotas
            // 
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PARCIAL1,
            this.PARCIAL2,
            this.TP});
            this.dgvNotas.Location = new System.Drawing.Point(12, 464);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.Size = new System.Drawing.Size(410, 150);
            this.dgvNotas.TabIndex = 6;
            // 
            // PARCIAL1
            // 
            this.PARCIAL1.HeaderText = "PARCIAL 1";
            this.PARCIAL1.Name = "PARCIAL1";
            // 
            // PARCIAL2
            // 
            this.PARCIAL2.HeaderText = "PARCIAL 2";
            this.PARCIAL2.Name = "PARCIAL2";
            // 
            // TP
            // 
            this.TP.HeaderText = "T P";
            this.TP.Name = "TP";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 573);
            this.Controls.Add(this.dgvNotas);
            this.Controls.Add(this.gbMatriz);
            this.Controls.Add(this.gbVector);
            this.Name = "frmMain";
            this.Text = "Registro en ARRAYs";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbVector.ResumeLayout(false);
            this.gbVector.PerformLayout();
            this.gbMatriz.ResumeLayout(false);
            this.gbMatriz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVector;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox gbMatriz;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnListarMatriz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCargarMatriz;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARCIAL1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PARCIAL2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TP;
    }
}

