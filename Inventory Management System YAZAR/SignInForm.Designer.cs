namespace Inventory_Management_System_YAZAR
{
    partial class SignInForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlYazarCard = new System.Windows.Forms.Panel();
            this.pnlYazarCardHeader = new System.Windows.Forms.Panel();
            this.lblYazarTitle = new System.Windows.Forms.Label();
            this.lblYazarSubtitle = new System.Windows.Forms.Label();
            this.lblYazarUsername = new System.Windows.Forms.Label();
            this.txtYazarUsername = new System.Windows.Forms.TextBox();
            this.lblYazarPassword = new System.Windows.Forms.Label();
            this.txtYazarPassword = new System.Windows.Forms.TextBox();
            this.btnYazarSignIn = new System.Windows.Forms.Button();
            this.lnkYazarRegister = new System.Windows.Forms.LinkLabel();
            this.pnlYazarCard.SuspendLayout();
            this.pnlYazarCardHeader.SuspendLayout();
            this.SuspendLayout();
            this.pnlYazarCard.BackColor = System.Drawing.Color.White;
            this.pnlYazarCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlYazarCard.Controls.Add(this.lnkYazarRegister);
            this.pnlYazarCard.Controls.Add(this.btnYazarSignIn);
            this.pnlYazarCard.Controls.Add(this.txtYazarPassword);
            this.pnlYazarCard.Controls.Add(this.lblYazarPassword);
            this.pnlYazarCard.Controls.Add(this.txtYazarUsername);
            this.pnlYazarCard.Controls.Add(this.lblYazarUsername);
            this.pnlYazarCard.Controls.Add(this.lblYazarSubtitle);
            this.pnlYazarCard.Controls.Add(this.pnlYazarCardHeader);
            this.pnlYazarCard.Location = new System.Drawing.Point(240, 55);
            this.pnlYazarCard.Name = "pnlYazarCard";
            this.pnlYazarCard.Size = new System.Drawing.Size(420, 400);
            this.pnlYazarCard.TabIndex = 0;
            this.pnlYazarCardHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(146)))), ((int)(((byte)(186)))));
            this.pnlYazarCardHeader.Controls.Add(this.lblYazarTitle);
            this.pnlYazarCardHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlYazarCardHeader.Name = "pnlYazarCardHeader";
            this.pnlYazarCardHeader.Size = new System.Drawing.Size(418, 80);
            this.pnlYazarCardHeader.TabIndex = 0;
            this.lblYazarTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYazarTitle.ForeColor = System.Drawing.Color.White;
            this.lblYazarTitle.Location = new System.Drawing.Point(0, 0);
            this.lblYazarTitle.Name = "lblYazarTitle";
            this.lblYazarTitle.Size = new System.Drawing.Size(418, 80);
            this.lblYazarTitle.TabIndex = 0;
            this.lblYazarTitle.Text = "INVENTORY MANAGEMENT\r\nSYSTEM YAZAR";
            this.lblYazarTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYazarSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYazarSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(115)))), ((int)(((byte)(130)))));
            this.lblYazarSubtitle.Location = new System.Drawing.Point(0, 92);
            this.lblYazarSubtitle.Name = "lblYazarSubtitle";
            this.lblYazarSubtitle.Size = new System.Drawing.Size(418, 24);
            this.lblYazarSubtitle.TabIndex = 1;
            this.lblYazarSubtitle.Text = "Sign in to your account";
            this.lblYazarSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYazarUsername.AutoSize = true;
            this.lblYazarUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYazarUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblYazarUsername.Location = new System.Drawing.Point(50, 130);
            this.lblYazarUsername.Name = "lblYazarUsername";
            this.lblYazarUsername.Size = new System.Drawing.Size(64, 19);
            this.lblYazarUsername.TabIndex = 2;
            this.lblYazarUsername.Text = "Username";
            this.txtYazarUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.txtYazarUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYazarUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYazarUsername.Location = new System.Drawing.Point(50, 154);
            this.txtYazarUsername.Name = "txtYazarUsername";
            this.txtYazarUsername.Size = new System.Drawing.Size(320, 29);
            this.txtYazarUsername.TabIndex = 3;
            this.lblYazarPassword.AutoSize = true;
            this.lblYazarPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYazarPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblYazarPassword.Location = new System.Drawing.Point(50, 200);
            this.lblYazarPassword.Name = "lblYazarPassword";
            this.lblYazarPassword.Size = new System.Drawing.Size(64, 19);
            this.lblYazarPassword.TabIndex = 4;
            this.lblYazarPassword.Text = "Password";
            this.txtYazarPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.txtYazarPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYazarPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYazarPassword.Location = new System.Drawing.Point(50, 224);
            this.txtYazarPassword.Name = "txtYazarPassword";
            this.txtYazarPassword.Size = new System.Drawing.Size(320, 29);
            this.txtYazarPassword.TabIndex = 5;
            this.txtYazarPassword.UseSystemPasswordChar = true;
            this.btnYazarSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYazarSignIn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYazarSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnYazarSignIn.Location = new System.Drawing.Point(50, 285);
            this.btnYazarSignIn.Name = "btnYazarSignIn";
            this.btnYazarSignIn.Size = new System.Drawing.Size(320, 42);
            this.btnYazarSignIn.TabIndex = 6;
            this.btnYazarSignIn.Text = "Sign In";
            this.btnYazarSignIn.UseVisualStyleBackColor = true;
            this.btnYazarSignIn.Click += new System.EventHandler(this.btnYazarSignIn_Click);
            this.lnkYazarRegister.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lnkYazarRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkYazarRegister.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkYazarRegister.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.lnkYazarRegister.Location = new System.Drawing.Point(0, 347);
            this.lnkYazarRegister.Name = "lnkYazarRegister";
            this.lnkYazarRegister.Size = new System.Drawing.Size(418, 24);
            this.lnkYazarRegister.TabIndex = 7;
            this.lnkYazarRegister.TabStop = true;
            this.lnkYazarRegister.Text = "Don't have an account? Register here.";
            this.lnkYazarRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkYazarRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkYazarRegister_LinkClicked);
            this.AcceptButton = this.btnYazarSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(900, 510);
            this.Controls.Add(this.pnlYazarCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SignInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System YAZAR - Sign In";
            this.pnlYazarCard.ResumeLayout(false);
            this.pnlYazarCard.PerformLayout();
            this.pnlYazarCardHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlYazarCard;
        private System.Windows.Forms.Panel pnlYazarCardHeader;
        private System.Windows.Forms.Label lblYazarTitle;
        private System.Windows.Forms.Label lblYazarSubtitle;
        private System.Windows.Forms.Label lblYazarUsername;
        private System.Windows.Forms.TextBox txtYazarUsername;
        private System.Windows.Forms.Label lblYazarPassword;
        private System.Windows.Forms.TextBox txtYazarPassword;
        private System.Windows.Forms.Button btnYazarSignIn;
        private System.Windows.Forms.LinkLabel lnkYazarRegister;
    }
}
