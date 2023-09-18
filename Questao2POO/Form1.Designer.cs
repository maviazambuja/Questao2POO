namespace Questao2POO
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.rbtOnibus = new System.Windows.Forms.RadioButton();
            this.rbtCaminhao = new System.Windows.Forms.RadioButton();
            this.lvIgual = new System.Windows.Forms.ListView();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.lbQtdAssentos = new System.Windows.Forms.Label();
            this.mkdtbPlaca = new System.Windows.Forms.MaskedTextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.tbQtdAssentos = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(278, 221);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(408, 221);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 23);
            this.btLimpar.TabIndex = 1;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // rbtOnibus
            // 
            this.rbtOnibus.AutoSize = true;
            this.rbtOnibus.Location = new System.Drawing.Point(143, 12);
            this.rbtOnibus.Name = "rbtOnibus";
            this.rbtOnibus.Size = new System.Drawing.Size(70, 20);
            this.rbtOnibus.TabIndex = 2;
            this.rbtOnibus.TabStop = true;
            this.rbtOnibus.Text = "Ônibus";
            this.rbtOnibus.UseVisualStyleBackColor = true;
            // 
            // rbtCaminhao
            // 
            this.rbtCaminhao.AutoSize = true;
            this.rbtCaminhao.Location = new System.Drawing.Point(278, 12);
            this.rbtCaminhao.Name = "rbtCaminhao";
            this.rbtCaminhao.Size = new System.Drawing.Size(89, 20);
            this.rbtCaminhao.TabIndex = 3;
            this.rbtCaminhao.TabStop = true;
            this.rbtCaminhao.Text = "Caminhão";
            this.rbtCaminhao.UseVisualStyleBackColor = true;
            // 
            // lvIgual
            // 
            this.lvIgual.HideSelection = false;
            this.lvIgual.Location = new System.Drawing.Point(45, 318);
            this.lvIgual.Name = "lvIgual";
            this.lvIgual.Size = new System.Drawing.Size(689, 97);
            this.lvIgual.TabIndex = 4;
            this.lvIgual.UseCompatibleStateImageBehavior = false;
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Location = new System.Drawing.Point(28, 86);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(42, 16);
            this.lbPlaca.TabIndex = 5;
            this.lbPlaca.Text = "Placa";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(28, 122);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(31, 16);
            this.lbAno.TabIndex = 6;
            this.lbAno.Text = "Ano";
            // 
            // lbQtdAssentos
            // 
            this.lbQtdAssentos.AutoSize = true;
            this.lbQtdAssentos.Location = new System.Drawing.Point(28, 159);
            this.lbQtdAssentos.Name = "lbQtdAssentos";
            this.lbQtdAssentos.Size = new System.Drawing.Size(87, 16);
            this.lbQtdAssentos.TabIndex = 7;
            this.lbQtdAssentos.Text = "Qtd Assentos";
            // 
            // mkdtbPlaca
            // 
            this.mkdtbPlaca.Location = new System.Drawing.Point(113, 80);
            this.mkdtbPlaca.Name = "mkdtbPlaca";
            this.mkdtbPlaca.Size = new System.Drawing.Size(100, 22);
            this.mkdtbPlaca.TabIndex = 8;
            this.mkdtbPlaca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mkdtbPlaca_MaskInputRejected);
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(113, 116);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(100, 22);
            this.tbAno.TabIndex = 9;
            // 
            // tbQtdAssentos
            // 
            this.tbQtdAssentos.Location = new System.Drawing.Point(121, 153);
            this.tbQtdAssentos.Name = "tbQtdAssentos";
            this.tbQtdAssentos.Size = new System.Drawing.Size(100, 22);
            this.tbQtdAssentos.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(318, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbQtdAssentos);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.mkdtbPlaca);
            this.Controls.Add(this.lbQtdAssentos);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.lvIgual);
            this.Controls.Add(this.rbtCaminhao);
            this.Controls.Add(this.rbtOnibus);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Name = "Form1";
            this.Text = "veículos tipo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.RadioButton rbtOnibus;
        private System.Windows.Forms.RadioButton rbtCaminhao;
        private System.Windows.Forms.ListView lvIgual;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.Label lbQtdAssentos;
        private System.Windows.Forms.MaskedTextBox mkdtbPlaca;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.TextBox tbQtdAssentos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

