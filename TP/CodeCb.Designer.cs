
namespace TP
{
    partial class CodeCb
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

            this.pavNum1 = new TP.PavNum();
            this.SuspendLayout();

            // 
            // pavNum1
            // 
            this.pavNum1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pavNum1.Location = new System.Drawing.Point(78, 136);
            this.pavNum1.Name = "pavNum1";
            this.pavNum1.Size = new System.Drawing.Size(372, 302);
            this.pavNum1.TabIndex = 2;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(538, 450);
            this.Controls.Add(this.pavNum1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.PerformLayout();

        }

        #endregion
        private PavNum pavNum1;
    }
}