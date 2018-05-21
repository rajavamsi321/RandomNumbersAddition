namespace RandomNumbersAddition
{
    partial class frmAdd
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
            this.lblTwoNumAdd = new System.Windows.Forms.Label();
            this.lblAns = new System.Windows.Forms.Label();
            this.tBoxAdd = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTwoNumAdd
            // 
            this.lblTwoNumAdd.AutoSize = true;
            this.lblTwoNumAdd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTwoNumAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTwoNumAdd.Cursor = System.Windows.Forms.Cursors.No;
            this.lblTwoNumAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoNumAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTwoNumAdd.Location = new System.Drawing.Point(306, 84);
            this.lblTwoNumAdd.Name = "lblTwoNumAdd";
            this.lblTwoNumAdd.Padding = new System.Windows.Forms.Padding(15, 25, 15, 25);
            this.lblTwoNumAdd.Size = new System.Drawing.Size(32, 76);
            this.lblTwoNumAdd.TabIndex = 0;
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(183, 202);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(126, 17);
            this.lblAns.TabIndex = 1;
            this.lblAns.Text = "Enter Your Answer";
            // 
            // tBoxAdd
            // 
            this.tBoxAdd.Location = new System.Drawing.Point(398, 197);
            this.tBoxAdd.Name = "tBoxAdd";
            this.tBoxAdd.Size = new System.Drawing.Size(100, 22);
            this.tBoxAdd.TabIndex = 2;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(274, 300);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(115, 17);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "Display Message";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(398, 241);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 24);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.tBoxAdd);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.lblTwoNumAdd);
            this.Name = "frmAdd";
            this.Text = "Addition of Two Random Numbers";
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTwoNumAdd;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.TextBox tBoxAdd;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Button btnSubmit;
    }
}

