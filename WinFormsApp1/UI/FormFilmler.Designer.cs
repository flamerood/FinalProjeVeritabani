namespace WinFormsApp1.UI
{
    partial class FormFilmler
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
            btniptal = new Button();
            btnkaydet = new Button();
            txtyer = new TextBox();
            txtyonetmen = new TextBox();
            txticerik = new TextBox();
            txtad = new TextBox();
            txtKod = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            txtyil = new TextBox();
            txttur = new TextBox();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btniptal
            // 
            btniptal.Location = new Point(100, 241);
            btniptal.Margin = new Padding(3, 2, 3, 2);
            btniptal.Name = "btniptal";
            btniptal.Size = new Size(82, 22);
            btniptal.TabIndex = 5;
            btniptal.Text = "İptal";
            btniptal.UseVisualStyleBackColor = true;
            btniptal.Click += btniptal_Click;
            // 
            // btnkaydet
            // 
            btnkaydet.Location = new Point(299, 241);
            btnkaydet.Margin = new Padding(3, 2, 3, 2);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(82, 22);
            btnkaydet.TabIndex = 6;
            btnkaydet.Text = "Kaydet";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // txtyer
            // 
            txtyer.Location = new Point(100, 122);
            txtyer.Margin = new Padding(3, 2, 3, 2);
            txtyer.Name = "txtyer";
            txtyer.Size = new Size(282, 23);
            txtyer.TabIndex = 4;
            // 
            // txtyonetmen
            // 
            txtyonetmen.Location = new Point(100, 94);
            txtyonetmen.Margin = new Padding(3, 2, 3, 2);
            txtyonetmen.Name = "txtyonetmen";
            txtyonetmen.Size = new Size(281, 23);
            txtyonetmen.TabIndex = 3;
            // 
            // txticerik
            // 
            txticerik.Location = new Point(100, 64);
            txticerik.Margin = new Padding(3, 2, 3, 2);
            txticerik.Name = "txticerik";
            txticerik.Size = new Size(282, 23);
            txticerik.TabIndex = 2;
            // 
            // txtad
            // 
            txtad.Location = new Point(100, 39);
            txtad.Margin = new Padding(3, 2, 3, 2);
            txtad.Name = "txtad";
            txtad.Size = new Size(282, 23);
            txtad.TabIndex = 1;
            // 
            // txtKod
            // 
            txtKod.Location = new Point(100, 14);
            txtKod.Margin = new Padding(3, 2, 3, 2);
            txtKod.Name = "txtKod";
            txtKod.ReadOnly = true;
            txtKod.Size = new Size(281, 23);
            txtKod.TabIndex = 0;
            txtKod.TextChanged += txtKod_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 125);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 4;
            label5.Text = "Oyuncular";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 98);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 5;
            label4.Text = "Yönetmen";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 73);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 6;
            label3.Text = "İçerik";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 42);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 7;
            label2.Text = "Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 17);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 8;
            label1.Text = "FilmID";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtyil
            // 
            txtyil.Location = new Point(100, 177);
            txtyil.Margin = new Padding(3, 2, 3, 2);
            txtyil.Name = "txtyil";
            txtyil.Size = new Size(282, 23);
            txtyil.TabIndex = 10;
            // 
            // txttur
            // 
            txttur.Location = new Point(100, 149);
            txttur.Margin = new Padding(3, 2, 3, 2);
            txttur.Name = "txttur";
            txttur.Size = new Size(281, 23);
            txttur.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 181);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 11;
            label6.Text = "Çıkış Yılı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 153);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 12;
            label7.Text = "Tür";
            // 
            // FormFilmler
            // 
            AcceptButton = btnkaydet;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btniptal;
            ClientSize = new Size(434, 308);
            Controls.Add(txtyil);
            Controls.Add(txttur);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(btniptal);
            Controls.Add(btnkaydet);
            Controls.Add(txtyer);
            Controls.Add(txtyonetmen);
            Controls.Add(txticerik);
            Controls.Add(txtad);
            Controls.Add(txtKod);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormFilmler";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormFilmler";
            Load += FormFilmler_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btniptal;
        private Button btnkaydet;
        private TextBox txtyer;
        private TextBox txtyonetmen;
        private TextBox txticerik;
        private TextBox txtad;
        private TextBox txtKod;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProvider1;
        private TextBox txtyil;
        private TextBox txttur;
        private Label label6;
        private Label label7;
    }
}