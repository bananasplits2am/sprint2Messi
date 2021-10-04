
namespace sprint2Messi
{
    partial class splash
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
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.labelContadorProgressBar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerSplash
            // 
            this.timerSplash.Enabled = true;
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(193, 332);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(417, 57);
            this.progressBar1.TabIndex = 0;
            // 
            // labelContadorProgressBar
            // 
            this.labelContadorProgressBar.AutoSize = true;
            this.labelContadorProgressBar.Location = new System.Drawing.Point(367, 292);
            this.labelContadorProgressBar.Name = "labelContadorProgressBar";
            this.labelContadorProgressBar.Size = new System.Drawing.Size(32, 20);
            this.labelContadorProgressBar.TabIndex = 1;
            this.labelContadorProgressBar.Text = "0%";
            // 
            // splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelContadorProgressBar);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.splash_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerSplash;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label labelContadorProgressBar;
    }
}

