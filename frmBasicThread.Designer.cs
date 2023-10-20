namespace frmBasicThread_Reyes
{
    partial class frmBasicThread
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
            this.lblThread = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThread
            // 
            this.lblThread.AutoSize = true;
            this.lblThread.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThread.Location = new System.Drawing.Point(44, 37);
            this.lblThread.Name = "lblThread";
            this.lblThread.Size = new System.Drawing.Size(306, 26);
            this.lblThread.TabIndex = 0;
            this.lblThread.Text = "- Before starting threading - ";
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Crimson;
            this.btnRun.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.btnRun.Location = new System.Drawing.Point(119, 91);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(154, 40);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // frmBasicThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(389, 158);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblThread);
            this.Name = "frmBasicThread";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblThread;
        private System.Windows.Forms.Button btnRun;
    }
}

