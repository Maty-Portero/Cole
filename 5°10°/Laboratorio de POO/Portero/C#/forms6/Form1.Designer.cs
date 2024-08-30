namespace forms6
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.peneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vERDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aZULToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Presione el boton derecho del mouse para cambiar el color del fondo";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peneToolStripMenuItem,
            this.vERDEToolStripMenuItem,
            this.aZULToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 70);
            // 
            // peneToolStripMenuItem
            // 
            this.peneToolStripMenuItem.Name = "peneToolStripMenuItem";
            this.peneToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.peneToolStripMenuItem.Text = "ROJO";
            this.peneToolStripMenuItem.Click += new System.EventHandler(this.RojoToolStripMenuItem_Click);
            // 
            // vERDEToolStripMenuItem
            // 
            this.vERDEToolStripMenuItem.Name = "vERDEToolStripMenuItem";
            this.vERDEToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.vERDEToolStripMenuItem.Text = "VERDE";
            this.vERDEToolStripMenuItem.Click += new System.EventHandler(this.VerdeToolStripMenuItem_Click);
            // 
            // aZULToolStripMenuItem
            // 
            this.aZULToolStripMenuItem.Name = "aZULToolStripMenuItem";
            this.aZULToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.aZULToolStripMenuItem.Text = "AZUL";
            this.aZULToolStripMenuItem.Click += new System.EventHandler(this.aZULToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem peneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vERDEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aZULToolStripMenuItem;
    }
}

