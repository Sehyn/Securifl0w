namespace Securifl0w
{
    partial class FrmMinuteurLock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMinuteurLock));
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.TxtCodeNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnDeverouiller = new Guna.UI2.WinForms.Guna2Button();
            this.LblFermer = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(831, 470);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(331, 97);
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            this.gunaPictureBox1.UseTransfarantBackground = true;
            // 
            // TxtCodeNum
            // 
            this.TxtCodeNum.Animated = true;
            this.TxtCodeNum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.TxtCodeNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCodeNum.DefaultText = "";
            this.TxtCodeNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCodeNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCodeNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodeNum.DisabledState.Parent = this.TxtCodeNum;
            this.TxtCodeNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodeNum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.TxtCodeNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCodeNum.FocusedState.Parent = this.TxtCodeNum;
            this.TxtCodeNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodeNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCodeNum.HoverState.Parent = this.TxtCodeNum;
            this.TxtCodeNum.Location = new System.Drawing.Point(843, 573);
            this.TxtCodeNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtCodeNum.Name = "TxtCodeNum";
            this.TxtCodeNum.PasswordChar = '*';
            this.TxtCodeNum.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodeNum.PlaceholderText = "Code numérique à 6 chiffres..";
            this.TxtCodeNum.SelectedText = "";
            this.TxtCodeNum.ShadowDecoration.Parent = this.TxtCodeNum;
            this.TxtCodeNum.ShortcutsEnabled = false;
            this.TxtCodeNum.Size = new System.Drawing.Size(217, 36);
            this.TxtCodeNum.TabIndex = 4;
            this.TxtCodeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCodeNum.UseSystemPasswordChar = true;
            this.TxtCodeNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodeNum_KeyPress);
            // 
            // BtnDeverouiller
            // 
            this.BtnDeverouiller.Animated = true;
            this.BtnDeverouiller.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.BtnDeverouiller.BorderRadius = 5;
            this.BtnDeverouiller.BorderThickness = 1;
            this.BtnDeverouiller.CheckedState.Parent = this.BtnDeverouiller;
            this.BtnDeverouiller.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.BtnDeverouiller.CustomImages.Parent = this.BtnDeverouiller;
            this.BtnDeverouiller.FillColor = System.Drawing.Color.Transparent;
            this.BtnDeverouiller.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeverouiller.ForeColor = System.Drawing.Color.White;
            this.BtnDeverouiller.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.BtnDeverouiller.HoverState.Parent = this.BtnDeverouiller;
            this.BtnDeverouiller.Image = ((System.Drawing.Image)(resources.GetObject("BtnDeverouiller.Image")));
            this.BtnDeverouiller.Location = new System.Drawing.Point(843, 615);
            this.BtnDeverouiller.Name = "BtnDeverouiller";
            this.BtnDeverouiller.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.BtnDeverouiller.ShadowDecoration.Parent = this.BtnDeverouiller;
            this.BtnDeverouiller.Size = new System.Drawing.Size(217, 45);
            this.BtnDeverouiller.TabIndex = 14;
            this.BtnDeverouiller.Text = "Deverrouiller Securifl0w";
            this.BtnDeverouiller.Click += new System.EventHandler(this.BtnDeverouiller_Click);
            // 
            // LblFermer
            // 
            this.LblFermer.AutoSize = true;
            this.LblFermer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LblFermer.ForeColor = System.Drawing.Color.White;
            this.LblFermer.Location = new System.Drawing.Point(779, 676);
            this.LblFermer.Name = "LblFermer";
            this.LblFermer.Size = new System.Drawing.Size(362, 15);
            this.LblFermer.TabIndex = 15;
            this.LblFermer.Text = "*Impossible de fermer l\'application sans code administrateur entré !";
            this.LblFermer.Visible = false;
            // 
            // FrmMinuteurLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.LblFermer);
            this.Controls.Add(this.BtnDeverouiller);
            this.Controls.Add(this.TxtCodeNum);
            this.Controls.Add(this.gunaPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMinuteurLock";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMinuteurLock";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMinuteurLock_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox TxtCodeNum;
        private Guna.UI2.WinForms.Guna2Button BtnDeverouiller;
        private Guna.UI.WinForms.GunaLabel LblFermer;
    }
}