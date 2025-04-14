namespace NDP_Ödev_1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            yiyecekComboBox = new ComboBox();
            listBox1 = new ListBox();
            ekleButton = new Button();
            adText = new TextBox();
            cinsText = new TextBox();
            fiyatText = new TextBox();
            kdvText = new TextBox();
            kaloriText = new TextBox();
            yazdirButton = new Button();
            silButton = new Button();
            paraText = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label1.Location = new Point(49, 80);
            label1.Name = "label1";
            label1.Size = new Size(155, 29);
            label1.TabIndex = 0;
            label1.Text = "Yiyecek Seçiniz";
            // 
            // label2
            // 
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label2.Location = new Point(49, 181);
            label2.Name = "label2";
            label2.Size = new Size(155, 29);
            label2.TabIndex = 1;
            label2.Text = "Adı";
            // 
            // label3
            // 
            label3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label3.Location = new Point(49, 236);
            label3.Name = "label3";
            label3.Size = new Size(155, 29);
            label3.TabIndex = 2;
            label3.Text = "Cinsi";
            // 
            // label4
            // 
            label4.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label4.Location = new Point(49, 290);
            label4.Name = "label4";
            label4.Size = new Size(155, 29);
            label4.TabIndex = 3;
            label4.Text = "Fiyatı";
            // 
            // label5
            // 
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label5.Location = new Point(49, 342);
            label5.Name = "label5";
            label5.Size = new Size(155, 29);
            label5.TabIndex = 4;
            label5.Text = "KDV Oranı";
            // 
            // label6
            // 
            label6.Font = new Font("Tahoma", 10.8F, FontStyle.Bold);
            label6.Location = new Point(49, 398);
            label6.Name = "label6";
            label6.Size = new Size(155, 29);
            label6.TabIndex = 5;
            label6.Text = "Kalori";
            // 
            // label7
            // 
            label7.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(538, 47);
            label7.Name = "label7";
            label7.Size = new Size(205, 29);
            label7.TabIndex = 6;
            label7.Text = "Sipariş Listesi";
            // 
            // yiyecekComboBox
            // 
            yiyecekComboBox.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            yiyecekComboBox.FormattingEnabled = true;
            yiyecekComboBox.Items.AddRange(new object[] { "Meyve", "Tatlı", "Salata", "İçecek" });
            yiyecekComboBox.Location = new Point(199, 75);
            yiyecekComboBox.Margin = new Padding(3, 2, 3, 2);
            yiyecekComboBox.Name = "yiyecekComboBox";
            yiyecekComboBox.Size = new Size(270, 30);
            yiyecekComboBox.TabIndex = 12;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Tahoma", 11F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(538, 81);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(608, 290);
            listBox1.TabIndex = 13;
            // 
            // ekleButton
            // 
            ekleButton.BackColor = Color.Peru;
            ekleButton.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ekleButton.ForeColor = SystemColors.ButtonHighlight;
            ekleButton.Location = new Point(362, 439);
            ekleButton.Margin = new Padding(3, 2, 3, 2);
            ekleButton.Name = "ekleButton";
            ekleButton.Size = new Size(107, 31);
            ekleButton.TabIndex = 14;
            ekleButton.Text = "Ekle";
            ekleButton.UseVisualStyleBackColor = false;
            ekleButton.Click += ekleButton_Click;
            // 
            // adText
            // 
            adText.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            adText.Location = new Point(199, 178);
            adText.Margin = new Padding(3, 2, 3, 2);
            adText.Name = "adText";
            adText.Size = new Size(270, 29);
            adText.TabIndex = 15;
            // 
            // cinsText
            // 
            cinsText.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cinsText.Location = new Point(199, 233);
            cinsText.Margin = new Padding(3, 2, 3, 2);
            cinsText.Name = "cinsText";
            cinsText.Size = new Size(270, 29);
            cinsText.TabIndex = 16;
            // 
            // fiyatText
            // 
            fiyatText.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            fiyatText.Location = new Point(199, 287);
            fiyatText.Margin = new Padding(3, 2, 3, 2);
            fiyatText.Name = "fiyatText";
            fiyatText.Size = new Size(270, 29);
            fiyatText.TabIndex = 17;
            // 
            // kdvText
            // 
            kdvText.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kdvText.Location = new Point(199, 339);
            kdvText.Margin = new Padding(3, 2, 3, 2);
            kdvText.Name = "kdvText";
            kdvText.Size = new Size(270, 29);
            kdvText.TabIndex = 18;
            // 
            // kaloriText
            // 
            kaloriText.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            kaloriText.Location = new Point(199, 395);
            kaloriText.Margin = new Padding(3, 2, 3, 2);
            kaloriText.Name = "kaloriText";
            kaloriText.Size = new Size(270, 29);
            kaloriText.TabIndex = 19;
            // 
            // yazdirButton
            // 
            yazdirButton.BackColor = Color.Peru;
            yazdirButton.Font = new Font("Tahoma", 10.8F);
            yazdirButton.ForeColor = SystemColors.ButtonHighlight;
            yazdirButton.Location = new Point(926, 439);
            yazdirButton.Margin = new Padding(3, 2, 3, 2);
            yazdirButton.Name = "yazdirButton";
            yazdirButton.Size = new Size(107, 31);
            yazdirButton.TabIndex = 20;
            yazdirButton.Text = "Yazdır";
            yazdirButton.UseVisualStyleBackColor = false;
            yazdirButton.Click += yazdirButton_Click;
            // 
            // silButton
            // 
            silButton.BackColor = Color.Peru;
            silButton.Font = new Font("Tahoma", 10.8F);
            silButton.ForeColor = SystemColors.ButtonHighlight;
            silButton.Location = new Point(1039, 439);
            silButton.Margin = new Padding(3, 2, 3, 2);
            silButton.Name = "silButton";
            silButton.Size = new Size(107, 31);
            silButton.TabIndex = 21;
            silButton.Text = "Sil";
            silButton.UseVisualStyleBackColor = false;
            silButton.Click += silButton_Click;
            // 
            // paraText
            // 
            paraText.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            paraText.Location = new Point(538, 395);
            paraText.Margin = new Padding(3, 2, 3, 2);
            paraText.Name = "paraText";
            paraText.ReadOnly = true;
            paraText.Size = new Size(608, 29);
            paraText.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1203, 566);
            Controls.Add(paraText);
            Controls.Add(silButton);
            Controls.Add(yazdirButton);
            Controls.Add(kaloriText);
            Controls.Add(kdvText);
            Controls.Add(fiyatText);
            Controls.Add(cinsText);
            Controls.Add(adText);
            Controls.Add(ekleButton);
            Controls.Add(listBox1);
            Controls.Add(yiyecekComboBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yemek Sipariş Menüsü";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox yiyecekComboBox;
        private ListBox listBox1;
        private Button ekleButton;
        private TextBox adText;
        private TextBox cinsText;
        private TextBox fiyatText;
        private TextBox kdvText;
        private TextBox kaloriText;
        private Button yazdirButton;
        private Button silButton;
        private TextBox paraText;
    }
}
