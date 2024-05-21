namespace NdpProje
{
    partial class Personeller
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
            listBox1 = new ListBox();
            panel1 = new Panel();
            personelNameBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            undoBtn = new Button();
            label4 = new Label();
            panel2 = new Panel();
            personelSilBtn = new Button();
            personelBulBtn = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            listBox1.TabIndex = 23;
            // 
            // panel1
            // 
            panel1.BackColor = Color.PeachPuff;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(personelBulBtn);
            panel1.Controls.Add(personelNameBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 575);
            panel1.TabIndex = 22;
            // 
            // personelNameBox
            // 
            personelNameBox.Location = new Point(37, 78);
            personelNameBox.Name = "personelNameBox";
            personelNameBox.Size = new Size(201, 27);
            personelNameBox.TabIndex = 10;
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
            label2.Size = new Size(205, 40);
            label2.TabIndex = 4;
            label2.Text = "Personel Bilgileri";
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
            panel4.TabIndex = 21;
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
            label4.Size = new Size(217, 60);
            label4.TabIndex = 0;
            label4.Text = "Personeller";
            // 
            // panel2
            // 
            panel2.BackColor = Color.PeachPuff;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(personelSilBtn);
            panel2.Location = new Point(323, 603);
            panel2.Name = "panel2";
            panel2.Size = new Size(671, 106);
            panel2.TabIndex = 24;
            // 
            // personelSilBtn
            // 
            personelSilBtn.Font = new Font("League Spartan", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            personelSilBtn.ForeColor = Color.OrangeRed;
            personelSilBtn.Location = new Point(224, 25);
            personelSilBtn.Name = "personelSilBtn";
            personelSilBtn.Size = new Size(219, 59);
            personelSilBtn.TabIndex = 18;
            personelSilBtn.Text = "Personel Kaydını Sil";
            personelSilBtn.UseVisualStyleBackColor = true;
            personelSilBtn.Click += personelSilBtn_Click;
            // 
            // personelBulBtn
            // 
            personelBulBtn.Font = new Font("League Spartan SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            personelBulBtn.Location = new Point(37, 126);
            personelBulBtn.Name = "personelBulBtn";
            personelBulBtn.Size = new Size(124, 40);
            personelBulBtn.TabIndex = 11;
            personelBulBtn.Text = "Personel Ara";
            personelBulBtn.UseVisualStyleBackColor = true;
            personelBulBtn.Click += personelBulBtn_Click;
            // 
            // Personeller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(panel2);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Name = "Personeller";
            Text = "Personeller";
            Load += PersonelForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox1;
        private Panel panel1;
        private TextBox personelNameBox;
        private Label label3;
        private Label label2;
        private Panel panel4;
        private Button undoBtn;
        private Label label4;
        private Panel panel2;
        private Button personelSilBtn;
        private Button personelBulBtn;
    }
}