namespace WinFormsApp1.UI
{
    partial class FormOdeme
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
            txtacik = new TextBox();
            txtodeme = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtpoz = new Label();
            errorProvider1 = new ErrorProvider(components);
            txtodmtur = new MaskedTextBox();
            txttutar = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            txtmusteriad = new TextBox();
            txtfilmad = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btniptal
            // 
            btniptal.Location = new Point(72, 217);
            btniptal.Margin = new Padding(3, 2, 3, 2);
            btniptal.Name = "btniptal";
            btniptal.Size = new Size(82, 22);
            btniptal.TabIndex = 15;
            btniptal.Text = "İptal";
            btniptal.UseVisualStyleBackColor = true;
            btniptal.Click += btniptal_Click;
            // 
            // btnkaydet
            // 
            btnkaydet.Location = new Point(235, 217);
            btnkaydet.Margin = new Padding(3, 2, 3, 2);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(82, 22);
            btnkaydet.TabIndex = 17;
            btnkaydet.Text = "Kaydet";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // txtacik
            // 
            txtacik.Location = new Point(100, 139);
            txtacik.Margin = new Padding(3, 2, 3, 2);
            txtacik.Name = "txtacik";
            txtacik.Size = new Size(217, 23);
            txtacik.TabIndex = 11;
            txtacik.TextChanged += txticerik_TextChanged;
            // 
            // txtodeme
            // 
            txtodeme.Location = new Point(100, 4);
            txtodeme.Margin = new Padding(3, 2, 3, 2);
            txtodeme.Name = "txtodeme";
            txtodeme.ReadOnly = true;
            txtodeme.Size = new Size(144, 23);
            txtodeme.TabIndex = 9;
            txtodeme.TextChanged += txtKod_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 169);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 16;
            label4.Text = "Ödeme Türü";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 139);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 18;
            label3.Text = "Açıklama";
            label3.Click += label3_Click;
            // 
            // txtpoz
            // 
            txtpoz.AutoSize = true;
            txtpoz.Location = new Point(37, 7);
            txtpoz.Name = "txtpoz";
            txtpoz.Size = new Size(57, 15);
            txtpoz.TabIndex = 20;
            txtpoz.Text = "OdemeID";
            txtpoz.Click += label1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtodmtur
            // 
            txtodmtur.Location = new Point(100, 166);
            txtodmtur.Margin = new Padding(3, 2, 3, 2);
            txtodmtur.Name = "txtodmtur";
            txtodmtur.Size = new Size(144, 23);
            txtodmtur.TabIndex = 21;
            // 
            // txttutar
            // 
            txttutar.Location = new Point(100, 107);
            txttutar.Margin = new Padding(3, 2, 3, 2);
            txttutar.Name = "txttutar";
            txttutar.Size = new Size(217, 23);
            txttutar.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 110);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 24;
            label1.Text = "Tutar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 44);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 19;
            label2.Text = "Film ID";
            label2.Click += label2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 81);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 25;
            label5.Text = "Müşteri ID";
            // 
            // txtmusteriad
            // 
            txtmusteriad.Location = new Point(100, 78);
            txtmusteriad.Margin = new Padding(3, 2, 3, 2);
            txtmusteriad.Name = "txtmusteriad";
            txtmusteriad.ReadOnly = true;
            txtmusteriad.Size = new Size(144, 23);
            txtmusteriad.TabIndex = 22;
            // 
            // txtfilmad
            // 
            txtfilmad.Location = new Point(100, 41);
            txtfilmad.Margin = new Padding(3, 2, 3, 2);
            txtfilmad.Name = "txtfilmad";
            txtfilmad.ReadOnly = true;
            txtfilmad.Size = new Size(144, 23);
            txtfilmad.TabIndex = 10;
            txtfilmad.TextChanged += txtad_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(250, 41);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 26;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // button2
            // 
            button2.Location = new Point(250, 77);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 27;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormOdeme
            // 
            AcceptButton = btnkaydet;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btniptal;
            ClientSize = new Size(388, 270);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txttutar);
            Controls.Add(txtmusteriad);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(txtodmtur);
            Controls.Add(btniptal);
            Controls.Add(btnkaydet);
            Controls.Add(txtacik);
            Controls.Add(txtfilmad);
            Controls.Add(txtodeme);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtpoz);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormOdeme";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormOdeme";
            Load += FormOdeme_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btniptal;
        private Button btnkaydet;
        private TextBox txtacik;
        private TextBox txtodeme;
        private Label label4;
        private Label label3;
        private Label txtpoz;
        private ErrorProvider errorProvider1;
        private MaskedTextBox txtodmtur;
        private TextBox txttutar;
        private Label label1;
        private TextBox txtmusteriad;
        private Label label5;
        private TextBox txtfilmad;
        private Label label2;
        private Button button2;
        private Button button1;
    }
}