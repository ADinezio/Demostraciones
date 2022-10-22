namespace WindowsApp
{
    partial class frmVector
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
            this.btnCrearVector = new System.Windows.Forms.Button();
            this.btnMostrarVector = new System.Windows.Forms.Button();
            this.lstVector = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCrearVector
            // 
            this.btnCrearVector.Location = new System.Drawing.Point(272, 110);
            this.btnCrearVector.Name = "btnCrearVector";
            this.btnCrearVector.Size = new System.Drawing.Size(75, 23);
            this.btnCrearVector.TabIndex = 0;
            this.btnCrearVector.Text = "Crear Vector";
            this.btnCrearVector.UseVisualStyleBackColor = true;
            this.btnCrearVector.Click += new System.EventHandler(this.btnCrearVector_Click);
            // 
            // btnMostrarVector
            // 
            this.btnMostrarVector.Location = new System.Drawing.Point(385, 110);
            this.btnMostrarVector.Name = "btnMostrarVector";
            this.btnMostrarVector.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarVector.TabIndex = 1;
            this.btnMostrarVector.Text = "Mostrar Vector";
            this.btnMostrarVector.UseVisualStyleBackColor = true;
            this.btnMostrarVector.Click += new System.EventHandler(this.btnMostrarVector_Click);
            // 
            // lstVector
            // 
            this.lstVector.FormattingEnabled = true;
            this.lstVector.Location = new System.Drawing.Point(272, 170);
            this.lstVector.Name = "lstVector";
            this.lstVector.Size = new System.Drawing.Size(224, 147);
            this.lstVector.TabIndex = 2;
            // 
            // frmVector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstVector);
            this.Controls.Add(this.btnMostrarVector);
            this.Controls.Add(this.btnCrearVector);
            this.Name = "frmVector";
            this.Text = "frmVector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearVector;
        private System.Windows.Forms.Button btnMostrarVector;
        private System.Windows.Forms.ListBox lstVector;
    }
}