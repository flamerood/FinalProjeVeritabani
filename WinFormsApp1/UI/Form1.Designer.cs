namespace WinFormsApp1
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
            tab = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnekle = new ToolStripButton();
            btnurunbul = new ToolStripButton();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            tabPage2 = new TabPage();
            toolStrip2 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripTextBox6 = new ToolStripTextBox();
            toolStripLabel6 = new ToolStripLabel();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            toolStrip3 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton4 = new ToolStripButton();
            toolStripTextBox2 = new ToolStripTextBox();
            toolStripLabel2 = new ToolStripLabel();
            dataGridView3 = new DataGridView();
            tabPage4 = new TabPage();
            toolStrip4 = new ToolStrip();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            txtbox = new ToolStripTextBox();
            toolStripLabel3 = new ToolStripLabel();
            dataGridView4 = new DataGridView();
            tab.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            tabPage2.SuspendLayout();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            toolStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // tab
            // 
            tab.Controls.Add(tabPage1);
            tab.Controls.Add(tabPage2);
            tab.Controls.Add(tabPage3);
            tab.Controls.Add(tabPage4);
            tab.Dock = DockStyle.Fill;
            tab.Location = new Point(0, 0);
            tab.Margin = new Padding(3, 2, 3, 2);
            tab.Name = "tab";
            tab.SelectedIndex = 0;
            tab.Size = new Size(653, 338);
            tab.TabIndex = 0;
            tab.SelectedIndexChanged += tab_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(toolStrip1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(645, 310);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Filmler";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(3, 29);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(639, 279);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnekle, btnurunbul, toolStripTextBox1, toolStripLabel1 });
            toolStrip1.Location = new Point(3, 2);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(639, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // btnekle
            // 
            btnekle.BackgroundImage = (Image)resources.GetObject("btnekle.BackgroundImage");
            btnekle.Image = (Image)resources.GetObject("btnekle.Image");
            btnekle.ImageTransparentColor = Color.Magenta;
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(52, 24);
            btnekle.Text = "Ekle";
            btnekle.Click += btnekle_Click;
            // 
            // btnurunbul
            // 
            btnurunbul.Alignment = ToolStripItemAlignment.Right;
            btnurunbul.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnurunbul.Image = (Image)resources.GetObject("btnurunbul.Image");
            btnurunbul.ImageTransparentColor = Color.Magenta;
            btnurunbul.Name = "btnurunbul";
            btnurunbul.Size = new Size(24, 24);
            btnurunbul.Text = "Bul";
            btnurunbul.Click += btnurunbul_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Alignment = ToolStripItemAlignment.Right;
            toolStripTextBox1.BackColor = SystemColors.GradientActiveCaption;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(176, 27);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(25, 24);
            toolStripLabel1.Text = "Ara";
            toolStripLabel1.Click += toolStripLabel1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(toolStrip2);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(645, 310);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Müşteri";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripButton3, toolStripTextBox6, toolStripLabel6 });
            toolStrip2.Location = new Point(3, 2);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(639, 27);
            toolStrip2.TabIndex = 3;
            toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton2
            // 
            toolStripButton2.BackgroundImage = (Image)resources.GetObject("toolStripButton2.BackgroundImage");
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(52, 24);
            toolStripButton2.Text = "Ekle";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Alignment = ToolStripItemAlignment.Right;
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(24, 24);
            toolStripButton3.Text = "Bul";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripTextBox6
            // 
            toolStripTextBox6.Alignment = ToolStripItemAlignment.Right;
            toolStripTextBox6.BackColor = SystemColors.GradientActiveCaption;
            toolStripTextBox6.Name = "toolStripTextBox6";
            toolStripTextBox6.Size = new Size(176, 27);
            toolStripTextBox6.Click += toolStripTextBox6_Click;
            // 
            // toolStripLabel6
            // 
            toolStripLabel6.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel6.Name = "toolStripLabel6";
            toolStripLabel6.Size = new Size(25, 24);
            toolStripLabel6.Text = "Ara";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 2);
            dataGridView2.Margin = new Padding(3, 2, 3, 2);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(639, 306);
            dataGridView2.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(toolStrip3);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 2, 3, 2);
            tabPage3.Size = new Size(645, 310);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Ödeme";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // toolStrip3
            // 
            toolStrip3.ImageScalingSize = new Size(20, 20);
            toolStrip3.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton4, toolStripTextBox2, toolStripLabel2 });
            toolStrip3.Location = new Point(3, 2);
            toolStrip3.Name = "toolStrip3";
            toolStrip3.Size = new Size(639, 27);
            toolStrip3.TabIndex = 3;
            toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton1
            // 
            toolStripButton1.BackgroundImage = (Image)resources.GetObject("toolStripButton1.BackgroundImage");
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(52, 24);
            toolStripButton1.Text = "Ekle";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton4
            // 
            toolStripButton4.Alignment = ToolStripItemAlignment.Right;
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(24, 24);
            toolStripButton4.Text = "Bul";
            toolStripButton4.Click += toolStripButton4_Click;
            // 
            // toolStripTextBox2
            // 
            toolStripTextBox2.Alignment = ToolStripItemAlignment.Right;
            toolStripTextBox2.BackColor = SystemColors.GradientActiveCaption;
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(176, 27);
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(25, 24);
            toolStripLabel2.Text = "Ara";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(3, 2);
            dataGridView3.Margin = new Padding(3, 2, 3, 2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.RowTemplate.Height = 29;
            dataGridView3.Size = new Size(639, 306);
            dataGridView3.TabIndex = 2;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(toolStrip4);
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 2, 3, 2);
            tabPage4.Size = new Size(645, 310);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Satış";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // toolStrip4
            // 
            toolStrip4.ImageScalingSize = new Size(20, 20);
            toolStrip4.Items.AddRange(new ToolStripItem[] { toolStripButton5, toolStripButton6, txtbox, toolStripLabel3 });
            toolStrip4.Location = new Point(3, 2);
            toolStrip4.Name = "toolStrip4";
            toolStrip4.Size = new Size(639, 27);
            toolStrip4.TabIndex = 3;
            toolStrip4.Text = "toolStrip4";
            // 
            // toolStripButton5
            // 
            toolStripButton5.BackgroundImage = (Image)resources.GetObject("toolStripButton5.BackgroundImage");
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(52, 24);
            toolStripButton5.Text = "Ekle";
            toolStripButton5.Click += toolStripButton5_Click;
            // 
            // toolStripButton6
            // 
            toolStripButton6.Alignment = ToolStripItemAlignment.Right;
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(24, 24);
            toolStripButton6.Text = "Bul";
            toolStripButton6.Click += toolStripButton6_Click;
            // 
            // txtbox
            // 
            txtbox.Alignment = ToolStripItemAlignment.Right;
            txtbox.BackColor = SystemColors.GradientActiveCaption;
            txtbox.Name = "txtbox";
            txtbox.Size = new Size(176, 27);
            // 
            // toolStripLabel3
            // 
            toolStripLabel3.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel3.Name = "toolStripLabel3";
            toolStripLabel3.Size = new Size(25, 24);
            toolStripLabel3.Text = "Ara";
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Dock = DockStyle.Fill;
            dataGridView4.Location = new Point(3, 2);
            dataGridView4.Margin = new Padding(3, 2, 3, 2);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 51;
            dataGridView4.RowTemplate.Height = 29;
            dataGridView4.Size = new Size(639, 306);
            dataGridView4.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 338);
            Controls.Add(tab);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            toolStrip3.ResumeLayout(false);
            toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            toolStrip4.ResumeLayout(false);
            toolStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tab;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ToolStrip toolStrip1;
        private ToolStripButton btnekle;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripButton btnurunbul;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private ToolStrip toolStrip2;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripTextBox toolStripTextBox6;
        private ToolStripLabel toolStripLabel6;
        private ToolStrip toolStrip3;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton4;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripTextBox txtbox;
        private ToolStripLabel toolStripLabel2;
        private ToolStrip toolStrip4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripLabel toolStripLabel3;
        private DataGridView dataGridView1;
    }
}