﻿namespace BasicQueueForm
{
    partial class CashierWindowQueue
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.listCashierView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(12, 70);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // listCashierView
            // 
            this.listCashierView.HideSelection = false;
            this.listCashierView.Location = new System.Drawing.Point(93, 26);
            this.listCashierView.Name = "listCashierView";
            this.listCashierView.Size = new System.Drawing.Size(286, 343);
            this.listCashierView.TabIndex = 2;
            this.listCashierView.UseCompatibleStateImageBehavior = false;
            // 
            // CashierWindowQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 407);
            this.Controls.Add(this.listCashierView);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnRefresh);
            this.Name = "CashierWindowQueue";
            this.Text = "CashierWindowQueueForm";
            this.Load += new System.EventHandler(this.CashierWindowQueue_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListView listCashierView;
    }
}