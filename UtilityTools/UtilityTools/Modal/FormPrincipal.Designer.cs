namespace UtilityTools.Modal
{
    partial class FormPrincipal
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCarregarCarro = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutCarro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnArquivoUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnderecoCarro = new System.Windows.Forms.TextBox();
            this.rbtnLink = new System.Windows.Forms.RadioButton();
            this.rbtnLocal = new System.Windows.Forms.RadioButton();
            this.pbCarroOut = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpImgColor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnderecoImagemColor = new System.Windows.Forms.TextBox();
            this.rbtnLinkColor = new System.Windows.Forms.RadioButton();
            this.rbtnUpImgColor = new System.Windows.Forms.RadioButton();
            this.pboxImagemColor = new System.Windows.Forms.PictureBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnGoImageColor = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarroOut)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagemColor)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 617);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 591);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnCarregarCarro);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtOutCarro);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.pbCarroOut);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 591);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reconhecimento de Carros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(280, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "O Processo Pode Demorar Um Pouco";
            // 
            // btnCarregarCarro
            // 
            this.btnCarregarCarro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCarregarCarro.Enabled = false;
            this.btnCarregarCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarregarCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarCarro.ForeColor = System.Drawing.Color.White;
            this.btnCarregarCarro.Location = new System.Drawing.Point(359, 197);
            this.btnCarregarCarro.Name = "btnCarregarCarro";
            this.btnCarregarCarro.Size = new System.Drawing.Size(109, 44);
            this.btnCarregarCarro.TabIndex = 3;
            this.btnCarregarCarro.Text = "Go!";
            this.btnCarregarCarro.UseVisualStyleBackColor = false;
            this.btnCarregarCarro.Click += new System.EventHandler(this.btnCarregarCarro_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dados (Output): ";
            // 
            // txtOutCarro
            // 
            this.txtOutCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutCarro.Location = new System.Drawing.Point(8, 291);
            this.txtOutCarro.Multiline = true;
            this.txtOutCarro.Name = "txtOutCarro";
            this.txtOutCarro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutCarro.Size = new System.Drawing.Size(389, 294);
            this.txtOutCarro.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnArquivoUp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEnderecoCarro);
            this.groupBox1.Controls.Add(this.rbtnLink);
            this.groupBox1.Controls.Add(this.rbtnLocal);
            this.groupBox1.Location = new System.Drawing.Point(190, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 124);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnArquivoUp
            // 
            this.btnArquivoUp.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnArquivoUp.Enabled = false;
            this.btnArquivoUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArquivoUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArquivoUp.ForeColor = System.Drawing.Color.White;
            this.btnArquivoUp.Location = new System.Drawing.Point(401, 36);
            this.btnArquivoUp.Name = "btnArquivoUp";
            this.btnArquivoUp.Size = new System.Drawing.Size(40, 35);
            this.btnArquivoUp.TabIndex = 2;
            this.btnArquivoUp.Text = "/\\";
            this.btnArquivoUp.UseVisualStyleBackColor = false;
            this.btnArquivoUp.Click += new System.EventHandler(this.btnArquivoUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(147, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Endereço da Imagem:";
            // 
            // txtEnderecoCarro
            // 
            this.txtEnderecoCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoCarro.Location = new System.Drawing.Point(6, 40);
            this.txtEnderecoCarro.Name = "txtEnderecoCarro";
            this.txtEnderecoCarro.Size = new System.Drawing.Size(389, 24);
            this.txtEnderecoCarro.TabIndex = 1;
            // 
            // rbtnLink
            // 
            this.rbtnLink.AutoSize = true;
            this.rbtnLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLink.ForeColor = System.Drawing.Color.White;
            this.rbtnLink.Location = new System.Drawing.Point(74, 83);
            this.rbtnLink.Name = "rbtnLink";
            this.rbtnLink.Size = new System.Drawing.Size(103, 19);
            this.rbtnLink.TabIndex = 0;
            this.rbtnLink.TabStop = true;
            this.rbtnLink.Text = "Link (Website)";
            this.rbtnLink.UseVisualStyleBackColor = true;
            this.rbtnLink.CheckedChanged += new System.EventHandler(this.rbtnLink_CheckedChanged);
            // 
            // rbtnLocal
            // 
            this.rbtnLocal.AutoSize = true;
            this.rbtnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLocal.ForeColor = System.Drawing.Color.White;
            this.rbtnLocal.Location = new System.Drawing.Point(240, 83);
            this.rbtnLocal.Name = "rbtnLocal";
            this.rbtnLocal.Size = new System.Drawing.Size(131, 19);
            this.rbtnLocal.TabIndex = 0;
            this.rbtnLocal.TabStop = true;
            this.rbtnLocal.Text = "Upload de Imagem";
            this.rbtnLocal.UseVisualStyleBackColor = true;
            this.rbtnLocal.CheckedChanged += new System.EventHandler(this.rbtnLocal_CheckedChanged);
            // 
            // pbCarroOut
            // 
            this.pbCarroOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCarroOut.Location = new System.Drawing.Point(411, 291);
            this.pbCarroOut.Name = "pbCarroOut";
            this.pbCarroOut.Size = new System.Drawing.Size(377, 294);
            this.pbCarroOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCarroOut.TabIndex = 0;
            this.pbCarroOut.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(796, 591);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reconhecimento de Objetos";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabPage4.Controls.Add(this.btnGoImageColor);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.groupBox2);
            this.tabPage4.Controls.Add(this.pboxImagemColor);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(796, 591);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Colarizador de Imagens";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(258, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "O Processo Pode Demorar Um Pouco";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpImgColor);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtEnderecoImagemColor);
            this.groupBox2.Controls.Add(this.rbtnLinkColor);
            this.groupBox2.Controls.Add(this.rbtnUpImgColor);
            this.groupBox2.Location = new System.Drawing.Point(168, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 124);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btnUpImgColor
            // 
            this.btnUpImgColor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpImgColor.Enabled = false;
            this.btnUpImgColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpImgColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpImgColor.ForeColor = System.Drawing.Color.White;
            this.btnUpImgColor.Location = new System.Drawing.Point(401, 36);
            this.btnUpImgColor.Name = "btnUpImgColor";
            this.btnUpImgColor.Size = new System.Drawing.Size(40, 35);
            this.btnUpImgColor.TabIndex = 2;
            this.btnUpImgColor.Text = "/\\";
            this.btnUpImgColor.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(147, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Endereço da Imagem:";
            // 
            // txtEnderecoImagemColor
            // 
            this.txtEnderecoImagemColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoImagemColor.Location = new System.Drawing.Point(6, 40);
            this.txtEnderecoImagemColor.Name = "txtEnderecoImagemColor";
            this.txtEnderecoImagemColor.Size = new System.Drawing.Size(389, 24);
            this.txtEnderecoImagemColor.TabIndex = 1;
            // 
            // rbtnLinkColor
            // 
            this.rbtnLinkColor.AutoSize = true;
            this.rbtnLinkColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnLinkColor.ForeColor = System.Drawing.Color.White;
            this.rbtnLinkColor.Location = new System.Drawing.Point(74, 83);
            this.rbtnLinkColor.Name = "rbtnLinkColor";
            this.rbtnLinkColor.Size = new System.Drawing.Size(103, 19);
            this.rbtnLinkColor.TabIndex = 0;
            this.rbtnLinkColor.TabStop = true;
            this.rbtnLinkColor.Text = "Link (Website)";
            this.rbtnLinkColor.UseVisualStyleBackColor = true;
            this.rbtnLinkColor.CheckedChanged += new System.EventHandler(this.rbtnLinkColor_CheckedChanged);
            // 
            // rbtnUpImgColor
            // 
            this.rbtnUpImgColor.AutoSize = true;
            this.rbtnUpImgColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnUpImgColor.ForeColor = System.Drawing.Color.White;
            this.rbtnUpImgColor.Location = new System.Drawing.Point(240, 83);
            this.rbtnUpImgColor.Name = "rbtnUpImgColor";
            this.rbtnUpImgColor.Size = new System.Drawing.Size(131, 19);
            this.rbtnUpImgColor.TabIndex = 0;
            this.rbtnUpImgColor.TabStop = true;
            this.rbtnUpImgColor.Text = "Upload de Imagem";
            this.rbtnUpImgColor.UseVisualStyleBackColor = true;
            // 
            // pboxImagemColor
            // 
            this.pboxImagemColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxImagemColor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pboxImagemColor.Location = new System.Drawing.Point(0, 222);
            this.pboxImagemColor.Name = "pboxImagemColor";
            this.pboxImagemColor.Size = new System.Drawing.Size(796, 369);
            this.pboxImagemColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxImagemColor.TabIndex = 4;
            this.pboxImagemColor.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(796, 591);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Extra2";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnGoImageColor
            // 
            this.btnGoImageColor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGoImageColor.Enabled = false;
            this.btnGoImageColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoImageColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoImageColor.ForeColor = System.Drawing.Color.White;
            this.btnGoImageColor.Location = new System.Drawing.Point(337, 167);
            this.btnGoImageColor.Name = "btnGoImageColor";
            this.btnGoImageColor.Size = new System.Drawing.Size(109, 44);
            this.btnGoImageColor.TabIndex = 7;
            this.btnGoImageColor.Text = "Go!";
            this.btnGoImageColor.UseVisualStyleBackColor = false;
            this.btnGoImageColor.Click += new System.EventHandler(this.btnGoImageColor_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 617);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCarroOut)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagemColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.PictureBox pbCarroOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnLocal;
        private System.Windows.Forms.TextBox txtEnderecoCarro;
        private System.Windows.Forms.RadioButton rbtnLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnArquivoUp;
        private System.Windows.Forms.TextBox txtOutCarro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCarregarCarro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpImgColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnderecoImagemColor;
        private System.Windows.Forms.RadioButton rbtnLinkColor;
        private System.Windows.Forms.RadioButton rbtnUpImgColor;
        private System.Windows.Forms.PictureBox pboxImagemColor;
        private System.Windows.Forms.Button btnGoImageColor;
    }
}