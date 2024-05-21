namespace NdpProje
{
    partial class Randevular
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            comboBox1 = new ComboBox();
            label8 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            numericUpDown1 = new NumericUpDown();
            customerLastnameBox = new TextBox();
            customerNameBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            randevuVerBtn = new Button();
            panel4 = new Panel();
            undoBtn = new Button();
            label4 = new Label();
            panel2 = new Panel();
            randevuSilBtn = new Button();
            randevuGnclBtn = new Button();
            customerBindingSource = new BindingSource(components);
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(maskedTextBox2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(customerLastnameBox);
            panel1.Controls.Add(customerNameBox);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new Point(12, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 575);
            panel1.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Şekillendirme", "Fön", "Çıt çıt fön", "Star kırık fön", "Model saç kesim", "Çocuk kesim", "Kesim", "Dip Boya", "İnoa boya", "Ombre balyaj kısa saç", "Bölgesel balyaj", "Röfle kısa saç", "Silme İşlemi kısa saç", "Dip açma", "Topuz", "Maşa", "Çıt çıt maşa", "Keratin bakım", "Saç bakım", "Botox", "Saç örgü", "Manikür", "Pedikür", "Törpü oje", "El – ayak tırnak kesimi", "Komple ağda", "Kaş", "Bıyık", "Porselen makyaj", "Kirpik (adet)", "Kirpik(adet-haftalık)", "Kalıcı oje", "Gelin sepeti (saç,makyaj,dekolte,kirpik,manikür,pedikür,kaş,bıyık,prova)", "Kına – nişan (saç,makyaj,kirpik)" });
            comboBox1.Location = new Point(32, 476);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("League Spartan SemiBold", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(8, 433);
            label8.Name = "label8";
            label8.Size = new Size(75, 40);
            label8.TabIndex = 11;
            label8.Text = "İşlem";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(37, 382);
            maskedTextBox2.Mask = "(999) 000-0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(201, 27);
            maskedTextBox2.TabIndex = 15;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(37, 310);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(201, 27);
            numericUpDown1.TabIndex = 14;
            // 
            // customerLastnameBox
            // 
            customerLastnameBox.Location = new Point(37, 238);
            customerLastnameBox.Name = "customerLastnameBox";
            customerLastnameBox.Size = new Size(201, 27);
            customerLastnameBox.TabIndex = 11;
            customerLastnameBox.KeyPress += customerLastnameBox_KeyPress;
            // 
            // customerNameBox
            // 
            customerNameBox.Location = new Point(37, 166);
            customerNameBox.Name = "customerNameBox";
            customerNameBox.Size = new Size(201, 27);
            customerNameBox.TabIndex = 10;
            customerNameBox.KeyPress += customerNameBox_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("League Spartan Medium", 10.1999989F, FontStyle.Bold);
            label7.Location = new Point(37, 353);
            label7.Name = "label7";
            label7.Size = new Size(134, 26);
            label7.TabIndex = 9;
            label7.Text = "İletişim Numarası";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("League Spartan Medium", 10.1999989F, FontStyle.Bold);
            label6.Location = new Point(37, 281);
            label6.Name = "label6";
            label6.Size = new Size(37, 26);
            label6.TabIndex = 8;
            label6.Text = "Yaş";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("League Spartan Medium", 10.1999989F, FontStyle.Bold);
            label5.Location = new Point(37, 209);
            label5.Name = "label5";
            label5.Size = new Size(56, 26);
            label5.TabIndex = 7;
            label5.Text = "Soyad";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(239, 45);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(59, 27);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("League Spartan Medium", 10.1999989F, FontStyle.Bold);
            label3.Location = new Point(37, 137);
            label3.Name = "label3";
            label3.Size = new Size(32, 26);
            label3.TabIndex = 5;
            label3.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("League Spartan SemiBold", 16.1999989F, FontStyle.Bold);
            label2.Location = new Point(8, 97);
            label2.Name = "label2";
            label2.Size = new Size(195, 40);
            label2.TabIndex = 4;
            label2.Text = "Müşteri Bilgileri";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("League Spartan SemiBold", 16.1999989F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 40);
            label1.TabIndex = 3;
            label1.Text = "Tarih - Saat";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(8, 43);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(225, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // randevuVerBtn
            // 
            randevuVerBtn.Font = new Font("League Spartan", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            randevuVerBtn.Location = new Point(3, 25);
            randevuVerBtn.Name = "randevuVerBtn";
            randevuVerBtn.Size = new Size(219, 59);
            randevuVerBtn.TabIndex = 17;
            randevuVerBtn.Text = "Randevu Ver";
            randevuVerBtn.UseVisualStyleBackColor = true;
            randevuVerBtn.Click += randevuVerBtn_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.PeachPuff;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(undoBtn);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(12, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(982, 116);
            panel4.TabIndex = 10;
            // 
            // undoBtn
            // 
            undoBtn.Font = new Font("League Spartan", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            undoBtn.Location = new Point(22, 25);
            undoBtn.Name = "undoBtn";
            undoBtn.Size = new Size(79, 59);
            undoBtn.TabIndex = 18;
            undoBtn.Text = "Geri";
            undoBtn.UseVisualStyleBackColor = true;
            undoBtn.Click += undoBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("League Spartan", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(394, 25);
            label4.Name = "label4";
            label4.Size = new Size(229, 60);
            label4.TabIndex = 0;
            label4.Text = "Randevular";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(randevuSilBtn);
            panel2.Controls.Add(randevuGnclBtn);
            panel2.Controls.Add(randevuVerBtn);
            panel2.Location = new Point(323, 603);
            panel2.Name = "panel2";
            panel2.Size = new Size(671, 106);
            panel2.TabIndex = 20;
            // 
            // randevuSilBtn
            // 
            randevuSilBtn.Font = new Font("League Spartan", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            randevuSilBtn.Location = new Point(445, 25);
            randevuSilBtn.Name = "randevuSilBtn";
            randevuSilBtn.Size = new Size(219, 59);
            randevuSilBtn.TabIndex = 19;
            randevuSilBtn.Text = "Randevu Sil";
            randevuSilBtn.UseVisualStyleBackColor = true;
            randevuSilBtn.Click += randevuSilBtn_Click;
            // 
            // randevuGnclBtn
            // 
            randevuGnclBtn.Font = new Font("League Spartan", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            randevuGnclBtn.Location = new Point(224, 25);
            randevuGnclBtn.Name = "randevuGnclBtn";
            randevuGnclBtn.Size = new Size(219, 59);
            randevuGnclBtn.TabIndex = 18;
            randevuGnclBtn.Text = "Randevu Güncelle";
            randevuGnclBtn.UseVisualStyleBackColor = true;
            randevuGnclBtn.Click += randevuGnclBtn_Click;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Customer);
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.PeachPuff;
            listBox1.Font = new Font("League Spartan SemiBold", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 26;
            listBox1.Location = new Point(323, 134);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(671, 446);
            listBox1.TabIndex = 21;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Randevular
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(listBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Randevular";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Randevular";
            Load += Randevular_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button randevuVerBtn;
        private ComboBox comboBox1;
        private Label label8;
        private MaskedTextBox maskedTextBox2;
        private NumericUpDown numericUpDown1;
        private TextBox customerLastnameBox;
        private TextBox customerNameBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private MaskedTextBox maskedTextBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Panel panel4;
        private Button undoBtn;
        private Label label4;
        private Panel panel2;
        private Button randevuSilBtn;
        private Button randevuGnclBtn;
        private BindingSource customerBindingSource;
        private ListBox listBox1;
    }
}