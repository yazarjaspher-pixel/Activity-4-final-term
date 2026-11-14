namespace Inventory_Management_System_YAZAR
{
    partial class RegisterForm
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
            this.lblYazarFullName = new System.Windows.Forms.Label();
            this.txtYazarFullName = new System.Windows.Forms.TextBox();
            this.lblYazarUsername = new System.Windows.Forms.Label();
            this.txtYazarUsername = new System.Windows.Forms.TextBox();
            this.lblYazarPassword = new System.Windows.Forms.Label();
            this.txtYazarPassword = new System.Windows.Forms.TextBox();
            this.lblYazarConfirmPassword = new System.Windows.Forms.Label();
            this.txtYazarConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnYazarRegister = new System.Windows.Forms.Button();
            this.lnkYazarSignIn = new System.Windows.Forms.LinkLabel();
            this.pnlYazarCard.SuspendLayout();
            this.pnlYazarCardHeader.SuspendLayout();
            this.SuspendLayout();
            this.pnlYazarCard.BackColor = System.Drawing.Color.White;
            this.pnlYazarCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlYazarCard.Controls.Add(this.lnkYazarSignIn);
            this.pnlYazarCard.Controls.Add(this.btnYazarRegister);
            this.pnlYazarCard.Controls.Add(this.txtYazarConfirmPassword);
            this.pnlYazarCard.Controls.Add(this.lblYazarConfirmPassword);
            this.pnlYazarCard.Controls.Add(this.txtYazarPassword);
            this.pnlYazarCard.Controls.Add(this.lblYazarPassword);
            this.pnlYazarCard.Controls.Add(this.txtYazarUsername);
            this.pnlYazarCard.Controls.Add(this.lblYazarUsername);
            this.pnlYazarCard.Controls.Add(this.txtYazarFullName);
            this.pnlYazarCard.Controls.Add(this.lblYazarFullName);
            this.pnlYazarCard.Controls.Add(this.lblYazarSubtitle);
            this.pnlYazarCard.Controls.Add(this.pnlYazarCardHeader);
            this.pnlYazarCard.Location = new System.Drawing.Point(240, 40);
            this.pnlYazarCard.Name = "pnlYazarCard";
            this.pnlYazarCard.Size = new System.Drawing.Size(420, 535);
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
            this.lblYazarSubtitle.Text = "Fill in your details below";
            this.lblYazarSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYazarFullName.AutoSize = true;
            this.lblYazarFullName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYazarFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblYazarFullName.Location = new System.Drawing.Point(50, 130);
            this.lblYazarFullName.Name = "lblYazarFullName";
            this.lblYazarFullName.Size = new System.Drawing.Size(72, 19);
            this.lblYazarFullName.TabIndex = 2;
            this.lblYazarFullName.Text = "Full Name";
            this.txtYazarFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.txtYazarFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYazarFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYazarFullName.Location = new System.Drawing.Point(50, 154);
            this.txtYazarFullName.Name = "txtYazarFullName";
            this.txtYazarFullName.Size = new System.Drawing.Size(320, 29);
            this.txtYazarFullName.TabIndex = 3;
            this.lblYazarUsername.AutoSize = true;
            this.lblYazarUsername.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYazarUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblYazarUsername.Location = new System.Drawing.Point(50, 200);
            this.lblYazarUsername.Name = "lblYazarUsername";
            this.lblYazarUsername.Size = new System.Drawing.Size(64, 19);
            this.lblYazarUsername.TabIndex = 4;
            this.lblYazarUsername.Text = "Username";
            this.txtYazarUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.txtYazarUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYazarUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYazarUsername.Location = new System.Drawing.Point(50, 224);
            this.txtYazarUsername.Name = "txtYazarUsername";
            this.txtYazarUsername.Size = new System.Drawing.Size(320, 29);
            this.txtYazarUsername.TabIndex = 5;
            this.lblYazarPassword.AutoSize = true;
            this.lblYazarPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYazarPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblYazarPassword.Location = new System.Drawing.Point(50, 270);
            this.lblYazarPassword.Name = "lblYazarPassword";
            this.lblYazarPassword.Size = new System.Drawing.Size(64, 19);
            this.lblYazarPassword.TabIndex = 6;
            this.lblYazarPassword.Text = "Password";
            this.txtYazarPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.txtYazarPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYazarPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYazarPassword.Location = new System.Drawing.Point(50, 294);
            this.txtYazarPassword.Name = "txtYazarPassword";
            this.txtYazarPassword.Size = new System.Drawing.Size(320, 29);
            this.txtYazarPassword.TabIndex = 7;
            this.txtYazarPassword.UseSystemPasswordChar = true;
            this.lblYazarConfirmPassword.AutoSize = true;
            this.lblYazarConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYazarConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lblYazarConfirmPassword.Location = new System.Drawing.Point(50, 340);
            this.lblYazarConfirmPassword.Name = "lblYazarConfirmPassword";
            this.lblYazarConfirmPassword.Size = new System.Drawing.Size(128, 19);
            this.lblYazarConfirmPassword.TabIndex = 8;
            this.lblYazarConfirmPassword.Text = "Confirm Password";
            this.txtYazarConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(226)))), ((int)(((byte)(240)))));
            this.txtYazarConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYazarConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYazarConfirmPassword.Location = new System.Drawing.Point(50, 364);
            this.txtYazarConfirmPassword.Name = "txtYazarConfirmPassword";
            this.txtYazarConfirmPassword.Size = new System.Drawing.Size(320, 29);
            this.txtYazarConfirmPassword.TabIndex = 9;
            this.txtYazarConfirmPassword.UseSystemPasswordChar = true;
            this.btnYazarRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYazarRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYazarRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.btnYazarRegister.Location = new System.Drawing.Point(50, 425);
            this.btnYazarRegister.Name = "btnYazarRegister";
            this.btnYazarRegister.Size = new System.Drawing.Size(320, 42);
            this.btnYazarRegister.TabIndex = 10;
            this.btnYazarRegister.Text = "Register";
            this.btnYazarRegister.UseVisualStyleBackColor = true;
            this.btnYazarRegister.Click += new System.EventHandler(this.btnYazarRegister_Click);
            this.lnkYazarSignIn.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(60)))), ((int)(((byte)(90)))));
            this.lnkYazarSignIn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkYazarSignIn.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkYazarSignIn.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(90)))), ((int)(((byte)(160)))));
            this.lnkYazarSignIn.Location = new System.Drawing.Point(0, 487);
            this.lnkYazarSignIn.Name = "lnkYazarSignIn";
            this.lnkYazarSignIn.Size = new System.Drawing.Size(418, 24);
            this.lnkYazarSignIn.TabIndex = 11;
            this.lnkYazarSignIn.TabStop = true;
            this.lnkYazarSignIn.Text = "Already have an account? Sign in here.";
            this.lnkYazarSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkYazarSignIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkYazarSignIn_LinkClicked);
            this.AcceptButton = this.btnYazarRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(900, 615);
            this.Controls.Add(this.pnlYazarCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System YAZAR - Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.pnlYazarCard.ResumeLayout(false);
            this.pnlYazarCard.PerformLayout();
            this.pnlYazarCardHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnlYazarCard;
        private System.Windows.Forms.Panel pnlYazarCardHeader;
        private System.Windows.Forms.Label lblYazarTitle;
        private System.Windows.Forms.Label lblYazarSubtitle;
        private System.Windows.Forms.Label lblYazarFullName;
        private System.Windows.Forms.TextBox txtYazarFullName;
        private System.Windows.Forms.Label lblYazarUsername;
        private System.Windows.Forms.TextBox txtYazarUsername;
        private System.Windows.Forms.Label lblYazarPassword;
        private System.Windows.Forms.TextBox txtYazarPassword;
        private System.Windows.Forms.Label lblYazarConfirmPassword;
        private System.Windows.Forms.TextBox txtYazarConfirmPassword;
        private System.Windows.Forms.Button btnYazarRegister;
        private System.Windows.Forms.LinkLabel lnkYazarSignIn;
    }
}
