
namespace vista_uni
{
    partial class MenuUniversidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUniversidad));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.panelCatalogo = new System.Windows.Forms.Panel();
            this.buttonAlum = new System.Windows.Forms.Button();
            this.btnProf = new System.Windows.Forms.Button();
            this.buttonProceso = new System.Windows.Forms.Button();
            this.panelProceso = new System.Windows.Forms.Panel();
            this.btnRegitroNotaP = new System.Windows.Forms.Button();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.panelSeguridad = new System.Windows.Forms.Panel();
            this.btnSeg = new System.Windows.Forms.Button();
            this.btnHerra = new System.Windows.Forms.Button();
            this.panelHerra = new System.Windows.Forms.Panel();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelSalir = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelGeneral.SuspendLayout();
            this.panelCatalogo.SuspendLayout();
            this.panelProceso.SuspendLayout();
            this.panelSeguridad.SuspendLayout();
            this.panelHerra.SuspendLayout();
            this.panelSalir.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 630);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 119);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCatalogo.Location = new System.Drawing.Point(0, 0);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(183, 38);
            this.btnCatalogo.TabIndex = 1;
            this.btnCatalogo.Text = "Catalogo";
            this.btnCatalogo.UseVisualStyleBackColor = true;
            // 
            // panelGeneral
            // 
            this.panelGeneral.AutoScroll = true;
            this.panelGeneral.Controls.Add(this.panelSalir);
            this.panelGeneral.Controls.Add(this.button2);
            this.panelGeneral.Controls.Add(this.panelHerra);
            this.panelGeneral.Controls.Add(this.pictureBox1);
            this.panelGeneral.Controls.Add(this.btnHerra);
            this.panelGeneral.Controls.Add(this.panelSeguridad);
            this.panelGeneral.Controls.Add(this.btnSeguridad);
            this.panelGeneral.Controls.Add(this.panelProceso);
            this.panelGeneral.Controls.Add(this.buttonProceso);
            this.panelGeneral.Controls.Add(this.panelCatalogo);
            this.panelGeneral.Controls.Add(this.btnCatalogo);
            this.panelGeneral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(200, 543);
            this.panelGeneral.TabIndex = 2;
            // 
            // panelCatalogo
            // 
            this.panelCatalogo.Controls.Add(this.btnProf);
            this.panelCatalogo.Controls.Add(this.buttonAlum);
            this.panelCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCatalogo.Location = new System.Drawing.Point(0, 38);
            this.panelCatalogo.Name = "panelCatalogo";
            this.panelCatalogo.Size = new System.Drawing.Size(183, 100);
            this.panelCatalogo.TabIndex = 2;
            // 
            // buttonAlum
            // 
            this.buttonAlum.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAlum.Location = new System.Drawing.Point(0, 0);
            this.buttonAlum.Name = "buttonAlum";
            this.buttonAlum.Size = new System.Drawing.Size(183, 23);
            this.buttonAlum.TabIndex = 0;
            this.buttonAlum.Text = "Alumno";
            this.buttonAlum.UseVisualStyleBackColor = true;
            this.buttonAlum.Click += new System.EventHandler(this.buttonAlum_Click);
            // 
            // btnProf
            // 
            this.btnProf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProf.Location = new System.Drawing.Point(0, 23);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(183, 23);
            this.btnProf.TabIndex = 1;
            this.btnProf.Text = "Profesor";
            this.btnProf.UseVisualStyleBackColor = true;
            // 
            // buttonProceso
            // 
            this.buttonProceso.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProceso.Location = new System.Drawing.Point(0, 138);
            this.buttonProceso.Name = "buttonProceso";
            this.buttonProceso.Size = new System.Drawing.Size(183, 23);
            this.buttonProceso.TabIndex = 3;
            this.buttonProceso.Text = "Proceso";
            this.buttonProceso.UseVisualStyleBackColor = true;
            // 
            // panelProceso
            // 
            this.panelProceso.Controls.Add(this.btnRegitroNotaP);
            this.panelProceso.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProceso.Location = new System.Drawing.Point(0, 161);
            this.panelProceso.Name = "panelProceso";
            this.panelProceso.Size = new System.Drawing.Size(183, 100);
            this.panelProceso.TabIndex = 4;
            // 
            // btnRegitroNotaP
            // 
            this.btnRegitroNotaP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegitroNotaP.Location = new System.Drawing.Point(0, 0);
            this.btnRegitroNotaP.Name = "btnRegitroNotaP";
            this.btnRegitroNotaP.Size = new System.Drawing.Size(183, 23);
            this.btnRegitroNotaP.TabIndex = 0;
            this.btnRegitroNotaP.Text = "Registro Notas";
            this.btnRegitroNotaP.UseVisualStyleBackColor = true;
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeguridad.Location = new System.Drawing.Point(0, 261);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Size = new System.Drawing.Size(183, 23);
            this.btnSeguridad.TabIndex = 5;
            this.btnSeguridad.Text = "Seguridad";
            this.btnSeguridad.UseVisualStyleBackColor = true;
            // 
            // panelSeguridad
            // 
            this.panelSeguridad.Controls.Add(this.btnSeg);
            this.panelSeguridad.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeguridad.Location = new System.Drawing.Point(0, 284);
            this.panelSeguridad.Name = "panelSeguridad";
            this.panelSeguridad.Size = new System.Drawing.Size(183, 100);
            this.panelSeguridad.TabIndex = 6;
            // 
            // btnSeg
            // 
            this.btnSeg.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeg.Location = new System.Drawing.Point(0, 0);
            this.btnSeg.Name = "btnSeg";
            this.btnSeg.Size = new System.Drawing.Size(183, 23);
            this.btnSeg.TabIndex = 0;
            this.btnSeg.Text = "Seguridad";
            this.btnSeg.UseVisualStyleBackColor = true;
            // 
            // btnHerra
            // 
            this.btnHerra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHerra.Location = new System.Drawing.Point(0, 384);
            this.btnHerra.Name = "btnHerra";
            this.btnHerra.Size = new System.Drawing.Size(183, 23);
            this.btnHerra.TabIndex = 7;
            this.btnHerra.Text = "Herramientas";
            this.btnHerra.UseVisualStyleBackColor = true;
            // 
            // panelHerra
            // 
            this.panelHerra.Controls.Add(this.btnConsulta);
            this.panelHerra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHerra.Location = new System.Drawing.Point(0, 407);
            this.panelHerra.Name = "panelHerra";
            this.panelHerra.Size = new System.Drawing.Size(183, 100);
            this.panelHerra.TabIndex = 8;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.Location = new System.Drawing.Point(0, 0);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(183, 23);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consulta Avanzada";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 507);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panelSalir
            // 
            this.panelSalir.Controls.Add(this.btnSalir);
            this.panelSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSalir.Location = new System.Drawing.Point(0, 530);
            this.panelSalir.Name = "panelSalir";
            this.panelSalir.Size = new System.Drawing.Size(183, 100);
            this.panelSalir.TabIndex = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.Location = new System.Drawing.Point(0, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(183, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // MenuUniversidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 543);
            this.Controls.Add(this.panelGeneral);
            this.IsMdiContainer = true;
            this.Name = "MenuUniversidad";
            this.Text = "MenuUniversidad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelGeneral.ResumeLayout(false);
            this.panelCatalogo.ResumeLayout(false);
            this.panelProceso.ResumeLayout(false);
            this.panelSeguridad.ResumeLayout(false);
            this.panelHerra.ResumeLayout(false);
            this.panelSalir.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Panel panelSalir;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelHerra;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnHerra;
        private System.Windows.Forms.Panel panelSeguridad;
        private System.Windows.Forms.Button btnSeg;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.Panel panelProceso;
        private System.Windows.Forms.Button btnRegitroNotaP;
        private System.Windows.Forms.Button buttonProceso;
        private System.Windows.Forms.Panel panelCatalogo;
        private System.Windows.Forms.Button btnProf;
        private System.Windows.Forms.Button buttonAlum;
    }
}