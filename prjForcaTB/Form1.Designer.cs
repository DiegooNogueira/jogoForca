namespace prjForcaTB
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbLetra = new System.Windows.Forms.GroupBox();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.gbPalavra = new System.Windows.Forms.GroupBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.lblLetraDigitada = new System.Windows.Forms.Label();
            this.lblDicas = new System.Windows.Forms.Label();
            this.pbForca = new System.Windows.Forms.PictureBox();
            this.pbEnforcado = new System.Windows.Forms.PictureBox();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.btnSairJogo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbLetra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnforcado)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLetra
            // 
            this.gbLetra.Controls.Add(this.txtLetra);
            this.gbLetra.Location = new System.Drawing.Point(21, 12);
            this.gbLetra.Name = "gbLetra";
            this.gbLetra.Size = new System.Drawing.Size(213, 68);
            this.gbLetra.TabIndex = 0;
            this.gbLetra.TabStop = false;
            this.gbLetra.Text = "Letra:";
            // 
            // txtLetra
            // 
            this.txtLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLetra.Font = new System.Drawing.Font("Andy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLetra.Location = new System.Drawing.Point(21, 23);
            this.txtLetra.MaxLength = 1;
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(173, 31);
            this.txtLetra.TabIndex = 1;
            this.txtLetra.Text = "A";
            this.txtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLetra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLetra_KeyDown);
            // 
            // gbPalavra
            // 
            this.gbPalavra.Location = new System.Drawing.Point(279, 12);
            this.gbPalavra.Name = "gbPalavra";
            this.gbPalavra.Size = new System.Drawing.Size(322, 91);
            this.gbPalavra.TabIndex = 1;
            this.gbPalavra.TabStop = false;
            this.gbPalavra.Text = "Palavra:";
            // 
            // btnJogar
            // 
            this.btnJogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJogar.Font = new System.Drawing.Font("Andy", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJogar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJogar.Image = ((System.Drawing.Image)(resources.GetObject("btnJogar.Image")));
            this.btnJogar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJogar.Location = new System.Drawing.Point(31, 86);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(194, 50);
            this.btnJogar.TabIndex = 2;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnJogar.UseCompatibleTextRendering = true;
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lblLetraDigitada
            // 
            this.lblLetraDigitada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLetraDigitada.Font = new System.Drawing.Font("Andy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetraDigitada.ForeColor = System.Drawing.Color.Red;
            this.lblLetraDigitada.Location = new System.Drawing.Point(18, 233);
            this.lblLetraDigitada.Name = "lblLetraDigitada";
            this.lblLetraDigitada.Size = new System.Drawing.Size(583, 79);
            this.lblLetraDigitada.TabIndex = 3;
            this.lblLetraDigitada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDicas
            // 
            this.lblDicas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDicas.Location = new System.Drawing.Point(280, 116);
            this.lblDicas.Name = "lblDicas";
            this.lblDicas.Size = new System.Drawing.Size(321, 76);
            this.lblDicas.TabIndex = 4;
            // 
            // pbForca
            // 
            this.pbForca.Image = ((System.Drawing.Image)(resources.GetObject("pbForca.Image")));
            this.pbForca.Location = new System.Drawing.Point(18, 329);
            this.pbForca.Name = "pbForca";
            this.pbForca.Size = new System.Drawing.Size(252, 426);
            this.pbForca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbForca.TabIndex = 5;
            this.pbForca.TabStop = false;
            // 
            // pbEnforcado
            // 
            this.pbEnforcado.Location = new System.Drawing.Point(96, 419);
            this.pbEnforcado.Name = "pbEnforcado";
            this.pbEnforcado.Size = new System.Drawing.Size(138, 335);
            this.pbEnforcado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEnforcado.TabIndex = 6;
            this.pbEnforcado.TabStop = false;
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNovoJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoJogo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNovoJogo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoJogo.Image")));
            this.btnNovoJogo.Location = new System.Drawing.Point(31, 142);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(194, 43);
            this.btnNovoJogo.TabIndex = 7;
            this.btnNovoJogo.UseVisualStyleBackColor = false;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // lblCronometro
            // 
            this.lblCronometro.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronometro.ForeColor = System.Drawing.Color.Azure;
            this.lblCronometro.Image = ((System.Drawing.Image)(resources.GetObject("lblCronometro.Image")));
            this.lblCronometro.Location = new System.Drawing.Point(285, 329);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(315, 395);
            this.lblCronometro.TabIndex = 8;
            this.lblCronometro.Text = "120 seg";
            this.lblCronometro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSairJogo
            // 
            this.btnSairJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairJogo.Font = new System.Drawing.Font("Andy", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSairJogo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSairJogo.Location = new System.Drawing.Point(31, 191);
            this.btnSairJogo.Name = "btnSairJogo";
            this.btnSairJogo.Size = new System.Drawing.Size(194, 39);
            this.btnSairJogo.TabIndex = 9;
            this.btnSairJogo.Text = "Sair";
            this.btnSairJogo.UseVisualStyleBackColor = true;
            this.btnSairJogo.Click += new System.EventHandler(this.btnSairJogo_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(639, 733);
            this.Controls.Add(this.btnSairJogo);
            this.Controls.Add(this.lblCronometro);
            this.Controls.Add(this.btnNovoJogo);
            this.Controls.Add(this.pbEnforcado);
            this.Controls.Add(this.pbForca);
            this.Controls.Add(this.lblDicas);
            this.Controls.Add(this.lblLetraDigitada);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.gbPalavra);
            this.Controls.Add(this.gbLetra);
            this.Font = new System.Drawing.Font("Andy", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Forca";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbLetra.ResumeLayout(false);
            this.gbLetra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbForca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnforcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLetra;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.GroupBox gbPalavra;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lblLetraDigitada;
        private System.Windows.Forms.Label lblDicas;
        private System.Windows.Forms.PictureBox pbForca;
        private System.Windows.Forms.PictureBox pbEnforcado;
        private System.Windows.Forms.Button btnNovoJogo;
        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.Button btnSairJogo;
        private System.Windows.Forms.Timer timer1;
    }
}

