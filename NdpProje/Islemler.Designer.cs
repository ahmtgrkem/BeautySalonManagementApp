namespace NdpProje
{
    partial class Islemler
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
            panel2 = new Panel();
            serviceUpdtBtn = new Button();
            serviceDltBtn = new Button();
            serviceAddBtn = new Button();
            listBox1 = new ListBox();
            panel1 = new Panel();
            label1 = new Label();
            serviceFeeBox = new TextBox();
            serviceNameBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            undoBtn = new Button();
            label4 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(serviceUpdtBtn);
            panel2.Controls.Add(serviceDltBtn);
            panel2.Controls.Add(serviceAddBtn);
            panel2.Location = new Point(323, 603);
            panel2.Name = "panel2";
            panel2.Size = new Size(671, 106);
            panel2.TabIndex = 28;
            // 
            // serviceUpdtBtn
            // 
            serviceUpdtBtn.Font = new Font("League Spartan", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            serviceUpdtBtn.ForeColor = Color.Black;
            serviceUpdtBtn.Location = new Point(445, 23);
            serviceUpdtBtn.Name = "serviceUpdtBtn";
            serviceUpdtBtn.Size = new Size(219, 59);
            serviceUpdtBtn.TabIndex = 20;
            serviceUpdtBtn.Text = "İşlem Güncelle";
            serviceUpdtBtn.UseVisualStyleBackColor = true;
            serviceUpdtBtn.Click += serviceUpdtBtn_Click;
            // 
            // serviceDltBtn
            // 
            serviceDltBtn.Font = new Font("League Spartan", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            serviceDltBtn.ForeColor = Color.Black;
            serviceDltBtn.Location = new Point(228, 23);
            serviceDltBtn.Name = "serviceDltBtn";
            serviceDltBtn.Size = new Size(211, 59);
            serviceDltBtn.TabIndex = 19;
            serviceDltBtn.Text = "İşlem Sil";
            serviceDltBtn.UseVisualStyleBackColor = true;
            serviceDltBtn.Click += serviceDltBtn_Click;
            // 
            // serviceAddBtn
            // 
            serviceAddBtn.Font = new Font("League Spartan", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            serviceAddBtn.ForeColor = Color.Black;
            serviceAddBtn.Location = new Point(3, 23);
            serviceAddBtn.Name = "serviceAddBtn";
            serviceAddBtn.Size = new Size(219, 59);
            serviceAddBtn.TabIndex = 18;
            serviceAddBtn.Text = "İşlem Ekle";
            serviceAddBtn.UseVisualStyleBackColor = true;
            serviceAddBtn.Click += serviceAddBtn_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.PeachPuff;
            listBox1.Font = new Font("League Spartan Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 27;
            listBox1.Location = new Point(323, 134);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(671, 463);
            listBox1.TabIndex = 27;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(serviceFeeBox);
            panel1.Controls.Add(serviceNameBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 575);
            panel1.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("League Spartan Medium", 10.1999989F, FontStyle.Bold);
            label1.Location = new Point(37, 127);
            label1.Name = "label1";
            label1.Size = new Size(50, 26);
            label1.TabIndex = 12;
            label1.Text = "Ücret";
            // 
            // serviceFeeBox
            // 
            serviceFeeBox.Location = new Point(37, 156);
            serviceFeeBox.Name = "serviceFeeBox";
            serviceFeeBox.Size = new Size(201, 27);
            serviceFeeBox.TabIndex = 11;
            // 
            // serviceNameBox
            // 
            serviceNameBox.Location = new Point(37, 78);
            serviceNameBox.Name = "serviceNameBox";
            serviceNameBox.Size = new Size(201, 27);
            serviceNameBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("League Spartan Medium", 10.1999989F, FontStyle.Bold);
            label3.Location = new Point(37, 49);
            label3.Name = "label3";
            label3.Size = new Size(32, 26);
            label3.TabIndex = 5;
            label3.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("League Spartan SemiBold", 16.1999989F, FontStyle.Bold);
            label2.Location = new Point(8, 9);
            label2.Name = "label2";
            label2.Size = new Size(168, 40);
            label2.TabIndex = 4;
            label2.Text = "İşlem Bilgileri";
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
            panel4.TabIndex = 25;
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
            label4.Location = new Point(423, 24);
            label4.Name = "label4";
            label4.Size = new Size(161, 60);
            label4.TabIndex = 0;
            label4.Text = "İşlemler";
            // 
            // Islemler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(panel2);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Name = "Islemler";
            Text = "Islemler";
            Load += Islemler_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button serviceAddBtn;
        private ListBox listBox1;
        private Panel panel1;
        private TextBox serviceNameBox;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private Button undoBtn;
        private Label label4;
        private Label label1;
        private TextBox serviceFeeBox;
        private Button serviceDltBtn;
        private Button serviceUpdtBtn;
    }
}