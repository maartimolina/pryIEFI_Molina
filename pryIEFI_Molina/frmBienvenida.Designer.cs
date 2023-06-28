namespace pryIEFI_Molina
{
    partial class frmBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenida));
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.pbEmpresa = new System.Windows.Forms.PictureBox();
            this.btnCargarVentas = new System.Windows.Forms.Button();
            this.btnCargarProductos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.AutoSize = true;
            this.lblBienvenidos.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.Location = new System.Drawing.Point(72, 42);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(270, 40);
            this.lblBienvenidos.TabIndex = 0;
            this.lblBienvenidos.Text = "Bienvenidos/as";
            // 
            // pbEmpresa
            // 
            this.pbEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("pbEmpresa.Image")));
            this.pbEmpresa.Location = new System.Drawing.Point(95, 106);
            this.pbEmpresa.Name = "pbEmpresa";
            this.pbEmpresa.Size = new System.Drawing.Size(231, 123);
            this.pbEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEmpresa.TabIndex = 1;
            this.pbEmpresa.TabStop = false;
            // 
            // btnCargarVentas
            // 
            this.btnCargarVentas.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarVentas.Location = new System.Drawing.Point(237, 267);
            this.btnCargarVentas.Name = "btnCargarVentas";
            this.btnCargarVentas.Size = new System.Drawing.Size(162, 82);
            this.btnCargarVentas.TabIndex = 1;
            this.btnCargarVentas.Text = "Carga de Ventas";
            this.btnCargarVentas.UseVisualStyleBackColor = true;
            this.btnCargarVentas.Click += new System.EventHandler(this.btnCargarVentas_Click);
            // 
            // btnCargarProductos
            // 
            this.btnCargarProductos.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarProductos.Location = new System.Drawing.Point(45, 267);
            this.btnCargarProductos.Name = "btnCargarProductos";
            this.btnCargarProductos.Size = new System.Drawing.Size(163, 82);
            this.btnCargarProductos.TabIndex = 0;
            this.btnCargarProductos.Text = "Carga de Productos";
            this.btnCargarProductos.UseVisualStyleBackColor = true;
            this.btnCargarProductos.Click += new System.EventHandler(this.btnCargarProductos_Click);
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 377);
            this.Controls.Add(this.btnCargarProductos);
            this.Controls.Add(this.btnCargarVentas);
            this.Controls.Add(this.pbEmpresa);
            this.Controls.Add(this.lblBienvenidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida";
            ((System.ComponentModel.ISupportInitialize)(this.pbEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenidos;
        private System.Windows.Forms.PictureBox pbEmpresa;
        private System.Windows.Forms.Button btnCargarVentas;
        private System.Windows.Forms.Button btnCargarProductos;
    }
}