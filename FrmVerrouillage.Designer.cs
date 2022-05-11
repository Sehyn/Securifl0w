namespace Securifl0w
{
    partial class FrmVerrouillage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVerrouillage));
            this.Timer_Minuteur = new System.Windows.Forms.Timer(this.components);
            this.GunaGroupBoxVerifLogiciel = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GunaDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.GunaAnimate = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.GunaGroupboxNameVerifLogi = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GunaAnimateControl = new Guna.UI.WinForms.GunaAnimateWindow(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BtnDiscord = new Guna.UI2.WinForms.Guna2Button();
            this.BtnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.BtnMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.TxtCodeNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GunaGroupBoxVerifLogiciel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GunaGroupBoxVerifLogiciel
            // 
            this.GunaGroupBoxVerifLogiciel.BackColor = System.Drawing.Color.Transparent;
            this.GunaGroupBoxVerifLogiciel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.GunaGroupBoxVerifLogiciel.Controls.Add(this.TxtCodeNum);
            this.GunaGroupBoxVerifLogiciel.Controls.Add(this.BtnDiscord);
            this.GunaGroupBoxVerifLogiciel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(29)))));
            this.GunaGroupBoxVerifLogiciel.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.GunaGroupBoxVerifLogiciel.FillColor = System.Drawing.Color.Transparent;
            this.GunaGroupBoxVerifLogiciel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GunaGroupBoxVerifLogiciel.ForeColor = System.Drawing.Color.White;
            this.GunaGroupBoxVerifLogiciel.Location = new System.Drawing.Point(26, 154);
            this.GunaGroupBoxVerifLogiciel.Name = "GunaGroupBoxVerifLogiciel";
            this.GunaGroupBoxVerifLogiciel.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.GunaGroupBoxVerifLogiciel.ShadowDecoration.Parent = this.GunaGroupBoxVerifLogiciel;
            this.GunaGroupBoxVerifLogiciel.Size = new System.Drawing.Size(239, 163);
            this.GunaGroupBoxVerifLogiciel.TabIndex = 26;
            // 
            // GunaDrag
            // 
            this.GunaDrag.TargetControl = null;
            // 
            // GunaAnimate
            // 
            this.GunaAnimate.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND;
            this.GunaAnimate.Interval = 255;
            this.GunaAnimate.TargetControl = null;
            // 
            // GunaGroupboxNameVerifLogi
            // 
            this.GunaGroupboxNameVerifLogi.BackColor = System.Drawing.Color.Transparent;
            this.GunaGroupboxNameVerifLogi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.GunaGroupboxNameVerifLogi.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.GunaGroupboxNameVerifLogi.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.GunaGroupboxNameVerifLogi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.GunaGroupboxNameVerifLogi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GunaGroupboxNameVerifLogi.ForeColor = System.Drawing.Color.White;
            this.GunaGroupboxNameVerifLogi.Location = new System.Drawing.Point(26, 113);
            this.GunaGroupboxNameVerifLogi.Name = "GunaGroupboxNameVerifLogi";
            this.GunaGroupboxNameVerifLogi.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.GunaGroupboxNameVerifLogi.ShadowDecoration.Parent = this.GunaGroupboxNameVerifLogi;
            this.GunaGroupboxNameVerifLogi.Size = new System.Drawing.Size(239, 41);
            this.GunaGroupboxNameVerifLogi.TabIndex = 25;
            this.GunaGroupboxNameVerifLogi.Text = "Mode sécurisé";
            // 
            // GunaAnimateControl
            // 
            this.GunaAnimateControl.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_HOR_POSITIVE;
            this.GunaAnimateControl.Interval = 500;
            this.GunaAnimateControl.TargetControl = this.GunaGroupBoxVerifLogiciel;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(26, 31);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 99);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 23;
            this.guna2PictureBox1.TabStop = false;
            // 
            // BtnDiscord
            // 
            this.BtnDiscord.Animated = true;
            this.BtnDiscord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.BtnDiscord.BorderRadius = 5;
            this.BtnDiscord.BorderThickness = 1;
            this.BtnDiscord.CheckedState.Parent = this.BtnDiscord;
            this.BtnDiscord.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.BtnDiscord.CustomImages.Parent = this.BtnDiscord;
            this.BtnDiscord.FillColor = System.Drawing.Color.Transparent;
            this.BtnDiscord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDiscord.ForeColor = System.Drawing.Color.White;
            this.BtnDiscord.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.BtnDiscord.HoverState.Parent = this.BtnDiscord;
            this.BtnDiscord.Image = ((System.Drawing.Image)(resources.GetObject("BtnDiscord.Image")));
            this.BtnDiscord.Location = new System.Drawing.Point(6, 71);
            this.BtnDiscord.Name = "BtnDiscord";
            this.BtnDiscord.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.BtnDiscord.ShadowDecoration.Parent = this.BtnDiscord;
            this.BtnDiscord.Size = new System.Drawing.Size(228, 45);
            this.BtnDiscord.TabIndex = 22;
            this.BtnDiscord.Text = "Déverrouiller Securifl0w";
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.BorderColor = System.Drawing.Color.BlueViolet;
            this.BtnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.BtnExit.HoverState.Parent = this.BtnExit;
            this.BtnExit.IconColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(238, 9);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.ShadowDecoration.Parent = this.BtnExit;
            this.BtnExit.Size = new System.Drawing.Size(46, 16);
            this.BtnExit.TabIndex = 27;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.BtnMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.BtnMinimize.HoverState.Parent = this.BtnMinimize;
            this.BtnMinimize.IconColor = System.Drawing.Color.White;
            this.BtnMinimize.Location = new System.Drawing.Point(188, 9);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.ShadowDecoration.Parent = this.BtnMinimize;
            this.BtnMinimize.Size = new System.Drawing.Size(44, 16);
            this.BtnMinimize.TabIndex = 28;
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
            this.TxtCodeNum.Location = new System.Drawing.Point(6, 23);
            this.TxtCodeNum.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TxtCodeNum.Name = "TxtCodeNum";
            this.TxtCodeNum.PasswordChar = '*';
            this.TxtCodeNum.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCodeNum.PlaceholderText = "Code numérique à 6 chiffres..";
            this.TxtCodeNum.SelectedText = "";
            this.TxtCodeNum.ShadowDecoration.Parent = this.TxtCodeNum;
            this.TxtCodeNum.ShortcutsEnabled = false;
            this.TxtCodeNum.Size = new System.Drawing.Size(228, 42);
            this.TxtCodeNum.TabIndex = 5;
            this.TxtCodeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCodeNum.UseSystemPasswordChar = true;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Red;
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(31)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(26, 323);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(242)))));
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(239, 31);
            this.guna2GroupBox1.TabIndex = 29;
            this.guna2GroupBox1.Text = "3 essais avant verrouillage";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, -3);
            this.guna2GroupBox1.Visible = false;
            // 
            // FrmVerrouillage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(295, 364);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnMinimize);
            this.Controls.Add(this.GunaGroupBoxVerifLogiciel);
            this.Controls.Add(this.GunaGroupboxNameVerifLogi);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVerrouillage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVerrouillage";
            this.GunaGroupBoxVerifLogiciel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer_Minuteur;
        private Guna.UI2.WinForms.Guna2GroupBox GunaGroupBoxVerifLogiciel;
        private Guna.UI2.WinForms.Guna2DragControl GunaDrag;
        private Guna.UI.WinForms.GunaAnimateWindow GunaAnimate;
        private Guna.UI2.WinForms.Guna2GroupBox GunaGroupboxNameVerifLogi;
        private Guna.UI.WinForms.GunaAnimateWindow GunaAnimateControl;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button BtnDiscord;
        private Guna.UI2.WinForms.Guna2ControlBox BtnExit;
        private Guna.UI2.WinForms.Guna2ControlBox BtnMinimize;
        private Guna.UI2.WinForms.Guna2TextBox TxtCodeNum;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
    }
}