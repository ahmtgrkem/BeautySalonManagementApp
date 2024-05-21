namespace NdpProje
{
    partial class GirisFormu : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            ageLabel = new Label();
            nameLabel = new Label();
            passwordAgainLabel = new Label();
            passwordLabel = new Label();
            usernameLabel = new Label();
            label4 = new Label();
            panel3 = new Panel();
            kytRdBtn = new RadioButton();
            grsRdBtn = new RadioButton();
            grsBtn = new Button();
            lastnameLabel = new Label();
            lastnameBox = new TextBox();
            continueBtn = new Button();
            kytBtn = new Button();
            nameBox = new TextBox();
            passwordBox = new TextBox();
            passwordAgainBox = new TextBox();
            ageBox = new TextBox();
            usernameBox = new TextBox();
            panel2 = new Panel();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ageLabel);
            panel1.Controls.Add(nameLabel);
            panel1.Controls.Add(passwordAgainLabel);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(grsBtn);
            panel1.Controls.Add(lastnameLabel);
            panel1.Controls.Add(lastnameBox);
            panel1.Controls.Add(continueBtn);
            panel1.Controls.Add(kytBtn);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(passwordAgainBox);
            panel1.Controls.Add(ageBox);
            panel1.Controls.Add(usernameBox);
            panel1.Location = new Point(327, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(461, 426);
            panel1.TabIndex = 0;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            ageLabel.Location = new Point(221, 298);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(29, 17);
            ageLabel.TabIndex = 12;
            ageLabel.Text = "Yaş";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            nameLabel.Location = new Point(217, 155);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(33, 17);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "İsim";
            // 
            // passwordAgainLabel
            // 
            passwordAgainLabel.AutoSize = true;
            passwordAgainLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            passwordAgainLabel.Location = new Point(186, 298);
            passwordAgainLabel.Name = "passwordAgainLabel";
            passwordAgainLabel.Size = new Size(103, 18);
            passwordAgainLabel.TabIndex = 7;
            passwordAgainLabel.Text = "Şifre ( Tekrar )";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            passwordLabel.Location = new Point(221, 224);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(38, 18);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Şifre";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            usernameLabel.Location = new Point(190, 154);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(90, 18);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.IndianRed;
            label4.Location = new Point(106, 9);
            label4.Name = "label4";
            label4.Size = new Size(268, 33);
            label4.TabIndex = 1;
            label4.Text = "Giriş/Kayıt Sistemi";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(kytRdBtn);
            panel3.Controls.Add(grsRdBtn);
            panel3.Location = new Point(-1, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(461, 73);
            panel3.TabIndex = 0;
            // 
            // kytRdBtn
            // 
            kytRdBtn.AutoSize = true;
            kytRdBtn.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kytRdBtn.Location = new Point(263, 25);
            kytRdBtn.Name = "kytRdBtn";
            kytRdBtn.Size = new Size(111, 27);
            kytRdBtn.TabIndex = 1;
            kytRdBtn.TabStop = true;
            kytRdBtn.Text = "Kayıt Ol";
            kytRdBtn.UseVisualStyleBackColor = true;
            kytRdBtn.CheckedChanged += kytRdBtn_CheckedChanged;
            // 
            // grsRdBtn
            // 
            grsRdBtn.AutoSize = true;
            grsRdBtn.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            grsRdBtn.Location = new Point(75, 25);
            grsRdBtn.Name = "grsRdBtn";
            grsRdBtn.Size = new Size(119, 27);
            grsRdBtn.TabIndex = 0;
            grsRdBtn.TabStop = true;
            grsRdBtn.Text = "Giriş Yap";
            grsRdBtn.UseVisualStyleBackColor = true;
            grsRdBtn.CheckedChanged += grsRdBtn_CheckedChanged;
            // 
            // grsBtn
            // 
            grsBtn.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            grsBtn.ForeColor = Color.IndianRed;
            grsBtn.Location = new Point(186, 373);
            grsBtn.Name = "grsBtn";
            grsBtn.Size = new Size(94, 29);
            grsBtn.TabIndex = 9;
            grsBtn.Text = "Giriş Yap";
            grsBtn.UseVisualStyleBackColor = true;
            grsBtn.Click += grsBtn_Click;
            // 
            // lastnameLabel
            // 
            lastnameLabel.AutoSize = true;
            lastnameLabel.Font = new Font("Times New Roman", 9F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lastnameLabel.Location = new Point(212, 224);
            lastnameLabel.Name = "lastnameLabel";
            lastnameLabel.Size = new Size(55, 17);
            lastnameLabel.TabIndex = 11;
            lastnameLabel.Text = "Soyisim";
            // 
            // lastnameBox
            // 
            lastnameBox.BorderStyle = BorderStyle.FixedSingle;
            lastnameBox.Location = new Point(148, 244);
            lastnameBox.Name = "lastnameBox";
            lastnameBox.Size = new Size(174, 27);
            lastnameBox.TabIndex = 14;
            lastnameBox.TextChanged += lastnameBox_TextChanged;
            lastnameBox.KeyPress += lastnameBox_KeyPress;
            // 
            // continueBtn
            // 
            continueBtn.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            continueBtn.ForeColor = Color.IndianRed;
            continueBtn.Location = new Point(186, 373);
            continueBtn.Name = "continueBtn";
            continueBtn.Size = new Size(94, 29);
            continueBtn.TabIndex = 16;
            continueBtn.Text = "Devam Et";
            continueBtn.UseVisualStyleBackColor = true;
            continueBtn.Click += continueBtn_Click;
            // 
            // kytBtn
            // 
            kytBtn.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kytBtn.ForeColor = Color.IndianRed;
            kytBtn.Location = new Point(186, 373);
            kytBtn.Name = "kytBtn";
            kytBtn.Size = new Size(94, 29);
            kytBtn.TabIndex = 8;
            kytBtn.Text = "Kayıt Ol";
            kytBtn.UseVisualStyleBackColor = true;
            kytBtn.Click += kytBtn_Click;
            // 
            // nameBox
            // 
            nameBox.BorderStyle = BorderStyle.FixedSingle;
            nameBox.Location = new Point(148, 175);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(174, 27);
            nameBox.TabIndex = 13;
            nameBox.TextChanged += nameBox_TextChanged;
            nameBox.KeyPress += nameBox_KeyPress;
            // 
            // passwordBox
            // 
            passwordBox.BorderStyle = BorderStyle.FixedSingle;
            passwordBox.Location = new Point(148, 244);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(174, 27);
            passwordBox.TabIndex = 3;
            passwordBox.TextChanged += passwordBox_TextChanged;
            // 
            // passwordAgainBox
            // 
            passwordAgainBox.BorderStyle = BorderStyle.FixedSingle;
            passwordAgainBox.Location = new Point(148, 318);
            passwordAgainBox.Name = "passwordAgainBox";
            passwordAgainBox.Size = new Size(174, 27);
            passwordAgainBox.TabIndex = 4;
            passwordAgainBox.TextChanged += passwordAgainBox_TextChanged;
            // 
            // ageBox
            // 
            ageBox.BorderStyle = BorderStyle.FixedSingle;
            ageBox.Location = new Point(148, 318);
            ageBox.Name = "ageBox";
            ageBox.Size = new Size(174, 27);
            ageBox.TabIndex = 15;
            ageBox.KeyPress += ageBox_KeyPress;
            // 
            // usernameBox
            // 
            usernameBox.BorderStyle = BorderStyle.FixedSingle;
            usernameBox.Location = new Point(148, 175);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(174, 27);
            usernameBox.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = Color.PeachPuff;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(8, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 257);
            panel2.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.ForeColor = Color.IndianRed;
            label8.Location = new Point(8, 146);
            label8.Name = "label8";
            label8.Size = new Size(279, 36);
            label8.TabIndex = 3;
            label8.Text = "Eğer yeni bir kullanıcı iseniz öncelikle\r\nsisteme kayıt olunuz!\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 200);
            label3.Name = "label3";
            label3.Size = new Size(265, 18);
            label3.TabIndex = 2;
            label3.Text = "Her alanın doldurulması zorunludur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(8, 56);
            label2.Name = "label2";
            label2.Size = new Size(289, 90);
            label2.TabIndex = 1;
            label2.Text = "Randevu verebilmeniz için sisteme giriş\r\nyapmanız gerekmektedir. Yandaki\r\npencerede belirtilen alanlara gerekli\r\nbilgileri yazarak giriş yapabilirsiniz.\r\n\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(26, 12);
            label1.Name = "label1";
            label1.Size = new Size(265, 23);
            label1.TabIndex = 0;
            label1.Text = "Randevu sistemine hoşgeldiniz";
            // 
            // GirisFormu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GirisFormu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş/Kayıt";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel3;
        private RadioButton kytRdBtn;
        private RadioButton grsRdBtn;
        private Button kytBtn;
        private Label passwordAgainLabel;
        private Label passwordLabel;
        private Label usernameLabel;
        private TextBox passwordAgainBox;
        private TextBox passwordBox;
        private TextBox usernameBox;
        private Button grsBtn;
        private Label label8;
        private TextBox ageBox;
        private TextBox lastnameBox;
        private TextBox nameBox;
        private Label ageLabel;
        private Label lastnameLabel;
        private Label nameLabel;
        private Button continueBtn;
    }
}
