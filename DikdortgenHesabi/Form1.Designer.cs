namespace DikdortgenHesabi
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
            txtUzun = new TextBox();
            txtKisa = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            lblSonuc = new Label();
            lblHata = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // txtUzun
            // 
            txtUzun.Location = new Point(504, 66);
            txtUzun.Margin = new Padding(5);
            txtUzun.Name = "txtUzun";
            txtUzun.Size = new Size(336, 61);
            txtUzun.TabIndex = 0;
            // 
            // txtKisa
            // 
            txtKisa.Location = new Point(504, 184);
            txtKisa.Margin = new Padding(5);
            txtKisa.Name = "txtKisa";
            txtKisa.Size = new Size(336, 61);
            txtKisa.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 73);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(264, 54);
            label1.TabIndex = 2;
            label1.Text = "UZUN KENAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 191);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(238, 54);
            label2.TabIndex = 3;
            label2.Text = "KISA KENAR";
            // 
            // button1
            // 
            button1.Location = new Point(564, 297);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(254, 78);
            button1.TabIndex = 4;
            button1.Text = "GOSTER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Location = new Point(621, 469);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(156, 54);
            lblSonuc.TabIndex = 5;
            lblSonuc.Text = "SONUC";
            // 
            // lblHata
            // 
            lblHata.AutoSize = true;
            lblHata.ForeColor = SystemColors.MenuHighlight;
            lblHata.Location = new Point(621, 594);
            lblHata.Name = "lblHata";
            lblHata.Size = new Size(0, 54);
            lblHata.TabIndex = 6;
            lblHata.Click += lblHata_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.ForeColor = SystemColors.HighlightText;
            panel1.Location = new Point(1156, 221);
            panel1.Name = "panel1";
            panel1.Size = new Size(227, 126);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(22F, 54F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1580, 827);
            Controls.Add(panel1);
            Controls.Add(lblHata);
            Controls.Add(lblSonuc);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtKisa);
            Controls.Add(txtUzun);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUzun;
        private TextBox txtKisa;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label lblSonuc;
        private Label lblHata;
        private Panel panel1;
    }
}
