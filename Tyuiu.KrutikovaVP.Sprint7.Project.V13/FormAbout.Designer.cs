namespace Tyuiu.KrutikovaVP.Sprint7.Project.V13
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_KVP = new System.Windows.Forms.Label();
            this.buttonOK_KVP = new System.Windows.Forms.Button();
            this.pictureBoxOfMe_KVP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOfMe_KVP)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_KVP
            // 
            this.labelInfo_KVP.AutoSize = true;
            this.labelInfo_KVP.Location = new System.Drawing.Point(110, 21);
            this.labelInfo_KVP.Name = "labelInfo_KVP";
            this.labelInfo_KVP.Size = new System.Drawing.Size(284, 117);
            this.labelInfo_KVP.TabIndex = 0;
            this.labelInfo_KVP.Text = resources.GetString("labelInfo_KVP.Text");
            // 
            // buttonOK_KVP
            // 
            this.buttonOK_KVP.Location = new System.Drawing.Point(319, 141);
            this.buttonOK_KVP.Name = "buttonOK_KVP";
            this.buttonOK_KVP.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_KVP.TabIndex = 3;
            this.buttonOK_KVP.Text = "Ок";
            this.buttonOK_KVP.UseVisualStyleBackColor = true;
            this.buttonOK_KVP.Click += new System.EventHandler(this.buttonOK_KVP_Click);
            // 
            // pictureBoxOfMe_KVP
            // 
            this.pictureBoxOfMe_KVP.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOfMe_KVP.Image")));
            this.pictureBoxOfMe_KVP.Location = new System.Drawing.Point(4, 12);
            this.pictureBoxOfMe_KVP.Name = "pictureBoxOfMe_KVP";
            this.pictureBoxOfMe_KVP.Size = new System.Drawing.Size(100, 126);
            this.pictureBoxOfMe_KVP.TabIndex = 2;
            this.pictureBoxOfMe_KVP.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 171);
            this.Controls.Add(this.buttonOK_KVP);
            this.Controls.Add(this.pictureBoxOfMe_KVP);
            this.Controls.Add(this.labelInfo_KVP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOfMe_KVP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_KVP;
        private System.Windows.Forms.PictureBox pictureBoxOfMe_KVP;
        private System.Windows.Forms.Button buttonOK_KVP;
    }
}