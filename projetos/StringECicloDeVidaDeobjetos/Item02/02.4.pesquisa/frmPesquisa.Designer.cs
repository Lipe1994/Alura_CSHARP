namespace _02._4.pesquisa
{
    partial class frmPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisa));
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtTrecho2 = new System.Windows.Forms.TextBox();
            this.txtSubstituir2 = new System.Windows.Forms.TextBox();
            this.txtSubstituir1 = new System.Windows.Forms.TextBox();
            this.txtTrecho1 = new System.Windows.Forms.TextBox();
            this.txtIndiceDe = new System.Windows.Forms.TextBox();
            this.txtTerminaCom = new System.Windows.Forms.TextBox();
            this.txtComecaCom = new System.Windows.Forms.TextBox();
            this.txtContem = new System.Windows.Forms.TextBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.btnExecutar);
            this.pnlBotoes.Controls.Add(this.radioButton6);
            this.pnlBotoes.Controls.Add(this.radioButton3);
            this.pnlBotoes.Controls.Add(this.radioButton2);
            this.pnlBotoes.Controls.Add(this.radioButton1);
            this.pnlBotoes.Controls.Add(this.txtTrecho2);
            this.pnlBotoes.Controls.Add(this.txtSubstituir2);
            this.pnlBotoes.Controls.Add(this.txtSubstituir1);
            this.pnlBotoes.Controls.Add(this.txtTrecho1);
            this.pnlBotoes.Controls.Add(this.txtIndiceDe);
            this.pnlBotoes.Controls.Add(this.txtTerminaCom);
            this.pnlBotoes.Controls.Add(this.txtComecaCom);
            this.pnlBotoes.Controls.Add(this.txtContem);
            this.pnlBotoes.Controls.Add(this.radioButton4);
            this.pnlBotoes.Controls.Add(this.radioButton5);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBotoes.Location = new System.Drawing.Point(0, 0);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(684, 185);
            this.pnlBotoes.TabIndex = 0;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Enabled = false;
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.Location = new System.Drawing.Point(536, 134);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(136, 38);
            this.btnExecutar.TabIndex = 22;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton6.Location = new System.Drawing.Point(319, 12);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(92, 24);
            this.radioButton6.TabIndex = 19;
            this.radioButton6.TabStop = true;
            this.radioButton6.Tag = "IndiceDe";
            this.radioButton6.Text = "Índice de";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(9, 84);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(118, 24);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "TerminaCom";
            this.radioButton3.Text = "Termina com";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(9, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(120, 24);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "ComecaCom";
            this.radioButton2.Text = "Começa com";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(9, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 24);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "Contem";
            this.radioButton1.Text = "Contém";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
            // 
            // txtTrecho2
            // 
            this.txtTrecho2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrecho2.Location = new System.Drawing.Point(505, 48);
            this.txtTrecho2.Name = "txtTrecho2";
            this.txtTrecho2.Size = new System.Drawing.Size(26, 26);
            this.txtTrecho2.TabIndex = 15;
            this.txtTrecho2.Tag = "Trecho";
            this.txtTrecho2.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtSubstituir2
            // 
            this.txtSubstituir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubstituir2.Location = new System.Drawing.Point(566, 86);
            this.txtSubstituir2.Name = "txtSubstituir2";
            this.txtSubstituir2.Size = new System.Drawing.Size(103, 26);
            this.txtSubstituir2.TabIndex = 14;
            this.txtSubstituir2.Tag = "Substituir";
            this.txtSubstituir2.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtSubstituir1
            // 
            this.txtSubstituir1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubstituir1.Location = new System.Drawing.Point(414, 86);
            this.txtSubstituir1.Name = "txtSubstituir1";
            this.txtSubstituir1.Size = new System.Drawing.Size(103, 26);
            this.txtSubstituir1.TabIndex = 13;
            this.txtSubstituir1.Tag = "Substituir";
            this.txtSubstituir1.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtTrecho1
            // 
            this.txtTrecho1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrecho1.Location = new System.Drawing.Point(416, 48);
            this.txtTrecho1.Name = "txtTrecho1";
            this.txtTrecho1.Size = new System.Drawing.Size(46, 26);
            this.txtTrecho1.TabIndex = 12;
            this.txtTrecho1.Tag = "Trecho";
            this.txtTrecho1.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtIndiceDe
            // 
            this.txtIndiceDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndiceDe.Location = new System.Drawing.Point(414, 10);
            this.txtIndiceDe.Name = "txtIndiceDe";
            this.txtIndiceDe.Size = new System.Drawing.Size(110, 26);
            this.txtIndiceDe.TabIndex = 11;
            this.txtIndiceDe.Tag = "IndiceDe";
            this.txtIndiceDe.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtTerminaCom
            // 
            this.txtTerminaCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerminaCom.Location = new System.Drawing.Point(131, 86);
            this.txtTerminaCom.Name = "txtTerminaCom";
            this.txtTerminaCom.Size = new System.Drawing.Size(110, 26);
            this.txtTerminaCom.TabIndex = 9;
            this.txtTerminaCom.Tag = "TerminaCom";
            this.txtTerminaCom.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtComecaCom
            // 
            this.txtComecaCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComecaCom.Location = new System.Drawing.Point(131, 48);
            this.txtComecaCom.Name = "txtComecaCom";
            this.txtComecaCom.Size = new System.Drawing.Size(110, 26);
            this.txtComecaCom.TabIndex = 8;
            this.txtComecaCom.Tag = "ComecaCom";
            this.txtComecaCom.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // txtContem
            // 
            this.txtContem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContem.Location = new System.Drawing.Point(131, 10);
            this.txtContem.Name = "txtContem";
            this.txtContem.Size = new System.Drawing.Size(110, 26);
            this.txtContem.TabIndex = 7;
            this.txtContem.Tag = "Contem";
            this.txtContem.Enter += new System.EventHandler(this.txt_Enter);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.Location = new System.Drawing.Point(319, 84);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(237, 24);
            this.radioButton4.TabIndex = 21;
            this.radioButton4.TabStop = true;
            this.radioButton4.Tag = "Substituir";
            this.radioButton4.Text = "Substituir                              por";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton5.Location = new System.Drawing.Point(319, 48);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(303, 24);
            this.radioButton5.TabIndex = 20;
            this.radioButton5.TabStop = true;
            this.radioButton5.Tag = "Trecho";
            this.radioButton5.Text = "Trecho de               com          caracteres";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.rbt_CheckedChanged);
            // 
            // lblDocumento
            // 
            this.lblDocumento.BackColor = System.Drawing.Color.White;
            this.lblDocumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDocumento.Font = new System.Drawing.Font("Consolas", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(0, 185);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(684, 226);
            this.lblDocumento.TabIndex = 2;
            this.lblDocumento.Text = resources.GetString("lblDocumento.Text");
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.pnlBotoes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "frmPesquisa";
            this.Text = "Pesquisa de strings";
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotoes;
        private System.Windows.Forms.TextBox txtSubstituir1;
        private System.Windows.Forms.TextBox txtTrecho1;
        private System.Windows.Forms.TextBox txtIndiceDe;
        private System.Windows.Forms.TextBox txtTerminaCom;
        private System.Windows.Forms.TextBox txtComecaCom;
        private System.Windows.Forms.TextBox txtContem;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtTrecho2;
        private System.Windows.Forms.TextBox txtSubstituir2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Label lblDocumento;
    }
}

