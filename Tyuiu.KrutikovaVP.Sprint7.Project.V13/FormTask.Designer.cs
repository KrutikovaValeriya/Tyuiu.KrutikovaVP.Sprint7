namespace Tyuiu.KrutikovaVP.Sprint7.Project.V13
{
    partial class FormTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTask));
            this.labelInfoTask_KVP = new System.Windows.Forms.Label();
            this.buttonOk_KVP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInfoTask_KVP
            // 
            this.labelInfoTask_KVP.AutoSize = true;
            this.labelInfoTask_KVP.Location = new System.Drawing.Point(12, 9);
            this.labelInfoTask_KVP.Name = "labelInfoTask_KVP";
            this.labelInfoTask_KVP.Size = new System.Drawing.Size(799, 221);
            this.labelInfoTask_KVP.TabIndex = 0;
            this.labelInfoTask_KVP.Text = resources.GetString("labelInfoTask_KVP.Text");
            // 
            // buttonOk_KVP
            // 
            this.buttonOk_KVP.Location = new System.Drawing.Point(700, 233);
            this.buttonOk_KVP.Name = "buttonOk_KVP";
            this.buttonOk_KVP.Size = new System.Drawing.Size(108, 23);
            this.buttonOk_KVP.TabIndex = 1;
            this.buttonOk_KVP.Text = "ок";
            this.buttonOk_KVP.UseVisualStyleBackColor = true;
            this.buttonOk_KVP.Click += new System.EventHandler(this.buttonOk_KVP_Click);
            // 
            // FormTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 264);
            this.Controls.Add(this.buttonOk_KVP);
            this.Controls.Add(this.labelInfoTask_KVP);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Техническое задание";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfoTask_KVP;
        private System.Windows.Forms.Button buttonOk_KVP;
    }
}