using CefSharp.WinForms;

namespace RushPurchase
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnJson解析 = new System.Windows.Forms.Button();
            this.btnUTF8ToChinese = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUTF8 = new System.Windows.Forms.TextBox();
            this.txtChineseCharacter = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlBrowser_01 = new System.Windows.Forms.Panel();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtLoginUrl = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnJson解析);
            this.panel1.Controls.Add(this.btnUTF8ToChinese);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUTF8);
            this.panel1.Controls.Add(this.txtChineseCharacter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 399);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 69);
            this.panel1.TabIndex = 3;
            // 
            // btnJson解析
            // 
            this.btnJson解析.Location = new System.Drawing.Point(243, 12);
            this.btnJson解析.Name = "btnJson解析";
            this.btnJson解析.Size = new System.Drawing.Size(96, 25);
            this.btnJson解析.TabIndex = 11;
            this.btnJson解析.Text = "Json解析";
            this.btnJson解析.UseVisualStyleBackColor = true;
            this.btnJson解析.Click += new System.EventHandler(this.btnJson解析_Click);
            // 
            // btnUTF8ToChinese
            // 
            this.btnUTF8ToChinese.Location = new System.Drawing.Point(147, 42);
            this.btnUTF8ToChinese.Name = "btnUTF8ToChinese";
            this.btnUTF8ToChinese.Size = new System.Drawing.Size(80, 23);
            this.btnUTF8ToChinese.TabIndex = 10;
            this.btnUTF8ToChinese.Text = "UTF8->汉字";
            this.btnUTF8ToChinese.UseVisualStyleBackColor = true;
            this.btnUTF8ToChinese.Click += new System.EventHandler(this.btnUTF8ToChinese_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "登陆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(471, 20);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(69, 37);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "录入用户名密码";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(147, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 27);
            this.button3.TabIndex = 7;
            this.button3.Text = "汉字->UTF8";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "UTF-8";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "汉字";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtUTF8
            // 
            this.txtUTF8.Location = new System.Drawing.Point(51, 44);
            this.txtUTF8.Name = "txtUTF8";
            this.txtUTF8.Size = new System.Drawing.Size(90, 21);
            this.txtUTF8.TabIndex = 3;
            // 
            // txtChineseCharacter
            // 
            this.txtChineseCharacter.Location = new System.Drawing.Point(51, 11);
            this.txtChineseCharacter.Name = "txtChineseCharacter";
            this.txtChineseCharacter.Size = new System.Drawing.Size(90, 21);
            this.txtChineseCharacter.TabIndex = 2;
            this.txtChineseCharacter.Text = "茅台";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlBrowser_01);
            this.tabPage1.Controls.Add(this.txtUrl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlBrowser_01
            // 
            this.pnlBrowser_01.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlBrowser_01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBrowser_01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBrowser_01.Location = new System.Drawing.Point(3, 24);
            this.pnlBrowser_01.Name = "pnlBrowser_01";
            this.pnlBrowser_01.Size = new System.Drawing.Size(786, 346);
            this.pnlBrowser_01.TabIndex = 7;
            // 
            // txtUrl
            // 
            this.txtUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtUrl.Location = new System.Drawing.Point(3, 3);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(786, 21);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrl_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLogin);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 399);
            this.tabControl1.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.Controls.Add(this.pnlLogin);
            this.tabLogin.Controls.Add(this.txtLoginUrl);
            this.tabLogin.Location = new System.Drawing.Point(4, 22);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(792, 373);
            this.tabLogin.TabIndex = 1;
            this.tabLogin.Text = "登陆";
            this.tabLogin.UseVisualStyleBackColor = true;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(3, 24);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(786, 346);
            this.pnlLogin.TabIndex = 9;
            // 
            // txtLoginUrl
            // 
            this.txtLoginUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtLoginUrl.Location = new System.Drawing.Point(3, 3);
            this.txtLoginUrl.Name = "txtLoginUrl";
            this.txtLoginUrl.Size = new System.Drawing.Size(786, 21);
            this.txtLoginUrl.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "天狗抢购";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.Move += new System.EventHandler(this.Form2_Move);
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUTF8;
        private System.Windows.Forms.TextBox txtChineseCharacter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlBrowser_01;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabLogin;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtLoginUrl;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUTF8ToChinese;
        private System.Windows.Forms.Button btnJson解析;
    }
}