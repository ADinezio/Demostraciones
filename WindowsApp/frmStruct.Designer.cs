namespace WindowsApp
{
    partial class frmStruct
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
            this.btnCreaStruct = new System.Windows.Forms.Button();
            this.btnStructYVector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreaStruct
            // 
            this.btnCreaStruct.Location = new System.Drawing.Point(286, 95);
            this.btnCreaStruct.Name = "btnCreaStruct";
            this.btnCreaStruct.Size = new System.Drawing.Size(196, 23);
            this.btnCreaStruct.TabIndex = 0;
            this.btnCreaStruct.Text = "Crear struct";
            this.btnCreaStruct.UseVisualStyleBackColor = true;
            this.btnCreaStruct.Click += new System.EventHandler(this.btnCreaStruct_Click);
            // 
            // btnStructYVector
            // 
            this.btnStructYVector.Location = new System.Drawing.Point(286, 165);
            this.btnStructYVector.Name = "btnStructYVector";
            this.btnStructYVector.Size = new System.Drawing.Size(196, 23);
            this.btnStructYVector.TabIndex = 1;
            this.btnStructYVector.Text = "Struct y Vector";
            this.btnStructYVector.UseVisualStyleBackColor = true;
            this.btnStructYVector.Click += new System.EventHandler(this.btnStructYVector_Click);
            // 
            // frmStruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStructYVector);
            this.Controls.Add(this.btnCreaStruct);
            this.Name = "frmStruct";
            this.Text = "frmStruct";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreaStruct;
        private System.Windows.Forms.Button btnStructYVector;
    }
}