﻿namespace PlenBotLogUploader
{
    partial class FormEditBossData
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
            this.labelSuccessMsg = new System.Windows.Forms.Label();
            this.labelFailMsg = new System.Windows.Forms.Label();
            this.textBoxSuccessMsg = new System.Windows.Forms.TextBox();
            this.textBoxFailMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSuccessMsg
            // 
            this.labelSuccessMsg.AutoSize = true;
            this.labelSuccessMsg.Location = new System.Drawing.Point(12, 9);
            this.labelSuccessMsg.Name = "labelSuccessMsg";
            this.labelSuccessMsg.Size = new System.Drawing.Size(110, 13);
            this.labelSuccessMsg.TabIndex = 0;
            this.labelSuccessMsg.Text = "Message on success:";
            // 
            // labelFailMsg
            // 
            this.labelFailMsg.AutoSize = true;
            this.labelFailMsg.Location = new System.Drawing.Point(12, 61);
            this.labelFailMsg.Name = "labelFailMsg";
            this.labelFailMsg.Size = new System.Drawing.Size(84, 13);
            this.labelFailMsg.TabIndex = 1;
            this.labelFailMsg.Text = "Message on fail:";
            // 
            // textBoxSuccessMsg
            // 
            this.textBoxSuccessMsg.Location = new System.Drawing.Point(15, 25);
            this.textBoxSuccessMsg.Name = "textBoxSuccessMsg";
            this.textBoxSuccessMsg.Size = new System.Drawing.Size(375, 20);
            this.textBoxSuccessMsg.TabIndex = 2;
            // 
            // textBoxFailMsg
            // 
            this.textBoxFailMsg.Location = new System.Drawing.Point(15, 77);
            this.textBoxFailMsg.Name = "textBoxFailMsg";
            this.textBoxFailMsg.Size = new System.Drawing.Size(375, 20);
            this.textBoxFailMsg.TabIndex = 3;
            // 
            // FormEditBossData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 113);
            this.Controls.Add(this.textBoxFailMsg);
            this.Controls.Add(this.textBoxSuccessMsg);
            this.Controls.Add(this.labelFailMsg);
            this.Controls.Add(this.labelSuccessMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditBossData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditBossData";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditBossData_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSuccessMsg;
        private System.Windows.Forms.Label labelFailMsg;
        private System.Windows.Forms.TextBox textBoxSuccessMsg;
        private System.Windows.Forms.TextBox textBoxFailMsg;
    }
}