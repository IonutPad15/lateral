namespace App2
{
    partial class Verificare
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
            this.components = new System.ComponentModel.Container();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVerif = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnResend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(161, 96);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(116, 38);
            this.txtCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduceti codul de pe email";
            // 
            // lblVerif
            // 
            this.lblVerif.AutoSize = true;
            this.lblVerif.Location = new System.Drawing.Point(158, 137);
            this.lblVerif.Name = "lblVerif";
            this.lblVerif.Size = new System.Drawing.Size(0, 16);
            this.lblVerif.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(186, 163);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnResend
            // 
            this.btnResend.Location = new System.Drawing.Point(148, 209);
            this.btnResend.Name = "btnResend";
            this.btnResend.Size = new System.Drawing.Size(151, 23);
            this.btnResend.TabIndex = 4;
            this.btnResend.Text = "Resend Code";
            this.btnResend.UseVisualStyleBackColor = true;
            this.btnResend.Click += new System.EventHandler(this.btnResend_Click);
            // 
            // Verificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 240);
            this.Controls.Add(this.btnResend);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblVerif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.Name = "Verificare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVerif;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnResend;
    }
}