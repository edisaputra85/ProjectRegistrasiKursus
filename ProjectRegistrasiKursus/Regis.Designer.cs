namespace ProjectRegistrasiKursus
{
    partial class Regis
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxBahasaPemrograman = new ComboBox();
            richTextBoxHasil = new RichTextBox();
            buttonDaftar = new Button();
            radioButtonHari1 = new RadioButton();
            radioButtonHari2 = new RadioButton();
            radioButtonHari3 = new RadioButton();
            groupBoxPilihanHari = new GroupBox();
            checkBoxWeb = new CheckBox();
            checkBoxMobile = new CheckBox();
            checkBoxDesktop = new CheckBox();
            label5 = new Label();
            textBoxNama = new TextBox();
            groupBoxPilihanHari.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 116);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(301, 31);
            label1.TabIndex = 0;
            label1.Text = "Pilih Bahasa Pemrograman";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 191);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(193, 31);
            label2.TabIndex = 1;
            label2.Text = "Pilih Hari Kursus";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 348);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(273, 31);
            label3.TabIndex = 2;
            label3.Text = "Pilih Skill Pemrograman";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 486);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(190, 31);
            label4.TabIndex = 3;
            label4.Text = "Pilih Jam Kursus";
            // 
            // comboBoxBahasaPemrograman
            // 
            comboBoxBahasaPemrograman.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBahasaPemrograman.FormattingEnabled = true;
            comboBoxBahasaPemrograman.Items.AddRange(new object[] { "C#", "Java", "Python", "PHP", "JavaScript", "Kotlin" });
            comboBoxBahasaPemrograman.Location = new Point(377, 116);
            comboBoxBahasaPemrograman.Name = "comboBoxBahasaPemrograman";
            comboBoxBahasaPemrograman.Size = new Size(322, 39);
            comboBoxBahasaPemrograman.TabIndex = 4;
            comboBoxBahasaPemrograman.SelectedValueChanged += comboBoxBahasaPemrograman_SelectedValueChanged;
            // 
            // richTextBoxHasil
            // 
            richTextBoxHasil.Location = new Point(748, 85);
            richTextBoxHasil.Name = "richTextBoxHasil";
            richTextBoxHasil.Size = new Size(820, 485);
            richTextBoxHasil.TabIndex = 5;
            richTextBoxHasil.Text = "";
            // 
            // buttonDaftar
            // 
            buttonDaftar.Location = new Point(341, 541);
            buttonDaftar.Name = "buttonDaftar";
            buttonDaftar.Size = new Size(164, 57);
            buttonDaftar.TabIndex = 6;
            buttonDaftar.Text = "Daftar";
            buttonDaftar.UseVisualStyleBackColor = true;
            buttonDaftar.Click += buttonDaftar_Click;
            // 
            // radioButtonHari1
            // 
            radioButtonHari1.AutoSize = true;
            radioButtonHari1.Location = new Point(25, 19);
            radioButtonHari1.Name = "radioButtonHari1";
            radioButtonHari1.Size = new Size(171, 35);
            radioButtonHari1.TabIndex = 7;
            radioButtonHari1.TabStop = true;
            radioButtonHari1.Text = "Senin - Rabu";
            radioButtonHari1.UseVisualStyleBackColor = true;
            radioButtonHari1.Click += radioButtonHari1_Click;
            // 
            // radioButtonHari2
            // 
            radioButtonHari2.AutoSize = true;
            radioButtonHari2.Location = new Point(25, 60);
            radioButtonHari2.Name = "radioButtonHari2";
            radioButtonHari2.Size = new Size(187, 35);
            radioButtonHari2.TabIndex = 8;
            radioButtonHari2.TabStop = true;
            radioButtonHari2.Text = "Selasa - Kamis";
            radioButtonHari2.UseVisualStyleBackColor = true;
            radioButtonHari2.CheckedChanged += radioButtonHari2_CheckedChanged;
            // 
            // radioButtonHari3
            // 
            radioButtonHari3.AutoSize = true;
            radioButtonHari3.Location = new Point(25, 101);
            radioButtonHari3.Name = "radioButtonHari3";
            radioButtonHari3.Size = new Size(203, 35);
            radioButtonHari3.TabIndex = 9;
            radioButtonHari3.TabStop = true;
            radioButtonHari3.Text = "Sabtu - Minggu";
            radioButtonHari3.UseVisualStyleBackColor = true;
            radioButtonHari3.CheckedChanged += radioButtonHari3_CheckedChanged;
            // 
            // groupBoxPilihanHari
            // 
            groupBoxPilihanHari.Controls.Add(radioButtonHari1);
            groupBoxPilihanHari.Controls.Add(radioButtonHari3);
            groupBoxPilihanHari.Controls.Add(radioButtonHari2);
            groupBoxPilihanHari.Location = new Point(377, 175);
            groupBoxPilihanHari.Name = "groupBoxPilihanHari";
            groupBoxPilihanHari.Size = new Size(322, 148);
            groupBoxPilihanHari.TabIndex = 10;
            groupBoxPilihanHari.TabStop = false;
            // 
            // checkBoxWeb
            // 
            checkBoxWeb.AutoSize = true;
            checkBoxWeb.Location = new Point(398, 344);
            checkBoxWeb.Name = "checkBoxWeb";
            checkBoxWeb.Size = new Size(241, 35);
            checkBoxWeb.TabIndex = 11;
            checkBoxWeb.Text = "Pemrograman Web";
            checkBoxWeb.UseVisualStyleBackColor = true;
            checkBoxWeb.CheckedChanged += checkBoxWeb_CheckedChanged;
            // 
            // checkBoxMobile
            // 
            checkBoxMobile.AutoSize = true;
            checkBoxMobile.Location = new Point(397, 387);
            checkBoxMobile.Name = "checkBoxMobile";
            checkBoxMobile.Size = new Size(269, 35);
            checkBoxMobile.TabIndex = 12;
            checkBoxMobile.Text = "Pemrograman Mobile";
            checkBoxMobile.UseVisualStyleBackColor = true;
            checkBoxMobile.CheckedChanged += checkBoxMobile_CheckedChanged;
            // 
            // checkBoxDesktop
            // 
            checkBoxDesktop.AutoSize = true;
            checkBoxDesktop.Location = new Point(397, 433);
            checkBoxDesktop.Name = "checkBoxDesktop";
            checkBoxDesktop.Size = new Size(282, 35);
            checkBoxDesktop.TabIndex = 13;
            checkBoxDesktop.Text = "Pemrograman Desktop";
            checkBoxDesktop.UseVisualStyleBackColor = true;
            checkBoxDesktop.CheckedChanged += checkBoxDesktop_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 54);
            label5.Margin = new Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new Size(77, 31);
            label5.TabIndex = 14;
            label5.Text = "Nama";
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(377, 54);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(322, 38);
            textBoxNama.TabIndex = 15;
            // 
            // Regis
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1596, 610);
            Controls.Add(textBoxNama);
            Controls.Add(label5);
            Controls.Add(checkBoxDesktop);
            Controls.Add(checkBoxMobile);
            Controls.Add(checkBoxWeb);
            Controls.Add(groupBoxPilihanHari);
            Controls.Add(buttonDaftar);
            Controls.Add(richTextBoxHasil);
            Controls.Add(comboBoxBahasaPemrograman);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Regis";
            Text = "Regis";
            groupBoxPilihanHari.ResumeLayout(false);
            groupBoxPilihanHari.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxBahasaPemrograman;
        private RichTextBox richTextBoxHasil;
        private Button buttonDaftar;
        private RadioButton radioButtonHari1;
        private RadioButton radioButtonHari2;
        private RadioButton radioButtonHari3;
        private GroupBox groupBoxPilihanHari;
        private CheckBox checkBoxWeb;
        private CheckBox checkBoxMobile;
        private CheckBox checkBoxDesktop;
        private Label label5;
        private TextBox textBoxNama;
    }
}