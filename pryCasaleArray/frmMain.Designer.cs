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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.gbVector.SuspendLayout();
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
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(84, 56);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 32);
            this.txtNumero.TabIndex = 0;
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
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(35, 20);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(323, 13);
            this.lblinfo.TabIndex = 2;
            this.lblinfo.Text = "Cargue nombres de sus mejores alumnos. Un maximo de 3 alumnos";
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
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.Location = new System.Drawing.Point(64, 101);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(120, 95);
            this.lstNombres.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 383);
            this.Controls.Add(this.gbVector);
            this.Name = "frmMain";
            this.Text = "Registro en ARRAYs";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbVector.ResumeLayout(false);
            this.gbVector.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbVector;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.Button btnListar;
    }
}

