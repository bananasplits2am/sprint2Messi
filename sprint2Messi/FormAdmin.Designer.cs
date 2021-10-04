
namespace sprint2Messi
{
    partial class FormAdmin
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
            this.labelPrueba = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPrueba
            // 
            this.labelPrueba.AutoSize = true;
            this.labelPrueba.Location = new System.Drawing.Point(457, 83);
            this.labelPrueba.Name = "labelPrueba";
            this.labelPrueba.Size = new System.Drawing.Size(54, 20);
            this.labelPrueba.TabIndex = 0;
            this.labelPrueba.Text = "Admin";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPrueba);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrueba;
    }
}