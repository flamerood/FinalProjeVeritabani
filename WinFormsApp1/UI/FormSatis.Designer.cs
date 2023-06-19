namespace WinFormsApp1.UI
{
    partial class FormSatis
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
            txtsatis = new TextBox();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            txtsfiyat = new TextBox();
            button2 = new Button();
            button1 = new Button();
            txtmusteriad = new TextBox();
            label5 = new Label();
            txtfilmad = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btniptal
            // 
            btniptal.Location = new Point(75, 182);
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
            btnkaydet.Location = new Point(216, 182);
            btnkaydet.Margin = new Padding(3, 2, 3, 2);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(82, 22);
            btnkaydet.TabIndex = 17;
            btnkaydet.Text = "Kaydet";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // txtsatis
            // 
            txtsatis.Location = new Point(97, 23);
            txtsatis.Margin = new Padding(3, 2, 3, 2);
            txtsatis.Name = "txtsatis";
            txtsatis.ReadOnly = true;
            txtsatis.Size = new Size(174, 23);
            txtsatis.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 116);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 19;
            label2.Text = "Satış Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 28);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 20;
            label1.Text = "SatışID";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtsfiyat
            // 
            txtsfiyat.Location = new Point(97, 119);
            txtsfiyat.Margin = new Padding(3, 2, 3, 2);
            txtsfiyat.Name = "txtsfiyat";
            txtsfiyat.Size = new Size(174, 23);
            txtsfiyat.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(288, 87);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(82, 22);
            button2.TabIndex = 33;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(288, 55);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 32;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtmusteriad
            // 
            txtmusteriad.Location = new Point(97, 84);
            txtmusteriad.Margin = new Padding(3, 2, 3, 2);
            txtmusteriad.Name = "txtmusteriad";
            txtmusteriad.ReadOnly = true;
            txtmusteriad.Size = new Size(174, 23);
            txtmusteriad.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 87);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 31;
            label5.Text = "Müşteri ID";
            // 
            // txtfilmad
            // 
            txtfilmad.Location = new Point(97, 57);
            txtfilmad.Margin = new Padding(3, 2, 3, 2);
            txtfilmad.Name = "txtfilmad";
            txtfilmad.ReadOnly = true;
            txtfilmad.Size = new Size(174, 23);
            txtfilmad.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 55);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 29;
            label3.Text = "Film ID";
            // 
            // FormSatis
            // 
            AcceptButton = btnkaydet;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btniptal;
            ClientSize = new Size(383, 240);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtmusteriad);
            Controls.Add(label5);
            Controls.Add(txtfilmad);
            Controls.Add(label3);
            Controls.Add(btniptal);
            Controls.Add(btnkaydet);
            Controls.Add(txtsfiyat);
            Controls.Add(txtsatis);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormSatis";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form Satış";
            Load += Formulasım_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btniptal;
        private Button btnkaydet;
        private TextBox txtsatis;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProvider1;
        private TextBox txtsfiyat;
        private Button button2;
        private Button button1;
        private TextBox txtmusteriad;
        private Label label5;
        private TextBox txtfilmad;
        private Label label3;
    }
}