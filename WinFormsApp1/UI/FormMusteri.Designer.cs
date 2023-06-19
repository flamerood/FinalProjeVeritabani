namespace WinFormsApp1.UI
{
    partial class FormMusteri
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
            txtmsoy = new TextBox();
            txtadr = new TextBox();
            txtmad = new TextBox();
            txtmusteri = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txttelno = new MaskedTextBox();
            errorProvider1 = new ErrorProvider(components);
            txtmail = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btniptal
            // 
            btniptal.Location = new Point(100, 229);
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
            btnkaydet.Location = new Point(297, 229);
            btnkaydet.Margin = new Padding(3, 2, 3, 2);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(82, 22);
            btnkaydet.TabIndex = 17;
            btnkaydet.Text = "Kaydet";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // txtmsoy
            // 
            txtmsoy.Location = new Point(118, 71);
            txtmsoy.Margin = new Padding(3, 2, 3, 2);
            txtmsoy.Name = "txtmsoy";
            txtmsoy.Size = new Size(261, 23);
            txtmsoy.TabIndex = 12;
            // 
            // txtadr
            // 
            txtadr.Location = new Point(116, 102);
            txtadr.Margin = new Padding(3, 2, 3, 2);
            txtadr.Multiline = true;
            txtadr.Name = "txtadr";
            txtadr.Size = new Size(263, 51);
            txtadr.TabIndex = 11;
            // 
            // txtmad
            // 
            txtmad.Location = new Point(118, 44);
            txtmad.Margin = new Padding(3, 2, 3, 2);
            txtmad.Name = "txtmad";
            txtmad.Size = new Size(261, 23);
            txtmad.TabIndex = 10;
            // 
            // txtmusteri
            // 
            txtmusteri.Location = new Point(118, 11);
            txtmusteri.Margin = new Padding(3, 2, 3, 2);
            txtmusteri.Name = "txtmusteri";
            txtmusteri.ReadOnly = true;
            txtmusteri.Size = new Size(261, 23);
            txtmusteri.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 165);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 14;
            label5.Text = "Telefon Numarası";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 71);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 16;
            label4.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 102);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 18;
            label3.Text = "Adres";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 47);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 19;
            label2.Text = "Ad";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 14);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 20;
            label1.Text = "MüşteriID";
            // 
            // txttelno
            // 
            txttelno.Location = new Point(118, 157);
            txttelno.Margin = new Padding(3, 2, 3, 2);
            txttelno.Mask = "\\0(599) 000-0000";
            txttelno.Name = "txttelno";
            txttelno.Size = new Size(127, 23);
            txttelno.TabIndex = 21;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtmail
            // 
            txtmail.Location = new Point(118, 184);
            txtmail.Margin = new Padding(3, 2, 3, 2);
            txtmail.Name = "txtmail";
            txtmail.Size = new Size(261, 23);
            txtmail.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(82, 187);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 23;
            label6.Text = "Mail";
            // 
            // FormMusteri
            // 
            AcceptButton = btnkaydet;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btniptal;
            ClientSize = new Size(441, 280);
            Controls.Add(txtmail);
            Controls.Add(label6);
            Controls.Add(txttelno);
            Controls.Add(btniptal);
            Controls.Add(btnkaydet);
            Controls.Add(txtmsoy);
            Controls.Add(txtadr);
            Controls.Add(txtmad);
            Controls.Add(txtmusteri);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMusteri";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormMusteri";
            Load += FormMusteri_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btniptal;
        private Button btnkaydet;
        private TextBox txtmsoy;
        private TextBox txtadr;
        private TextBox txtmad;
        private TextBox txtmusteri;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MaskedTextBox txttelno;
        private ErrorProvider errorProvider1;
        private TextBox txtmail;
        private Label label6;
    }
}