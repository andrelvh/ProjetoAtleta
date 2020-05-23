namespace ProjetoAtleta
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
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_imctotal = new System.Windows.Forms.TextBox();
            this.txt_altura = new System.Windows.Forms.TextBox();
            this.lbl_altura = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_peso = new System.Windows.Forms.TextBox();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_peso = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_calcimc = new System.Windows.Forms.Label();
            this.btn_imc = new System.Windows.Forms.Button();
            this.btn_dados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_imctotal
            // 
            this.txt_imctotal.Enabled = false;
            this.txt_imctotal.Location = new System.Drawing.Point(141, 354);
            this.txt_imctotal.Name = "txt_imctotal";
            this.txt_imctotal.Size = new System.Drawing.Size(100, 20);
            this.txt_imctotal.TabIndex = 39;
            this.txt_imctotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_altura
            // 
            this.txt_altura.Location = new System.Drawing.Point(170, 163);
            this.txt_altura.Name = "txt_altura";
            this.txt_altura.Size = new System.Drawing.Size(109, 20);
            this.txt_altura.TabIndex = 3;
            // 
            // lbl_altura
            // 
            this.lbl_altura.AutoSize = true;
            this.lbl_altura.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_altura.ForeColor = System.Drawing.Color.SeaShell;
            this.lbl_altura.Location = new System.Drawing.Point(101, 165);
            this.lbl_altura.Name = "lbl_altura";
            this.lbl_altura.Size = new System.Drawing.Size(45, 15);
            this.lbl_altura.TabIndex = 37;
            this.lbl_altura.Text = "Altura:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_titulo.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.SeaShell;
            this.lbl_titulo.Location = new System.Drawing.Point(120, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(140, 24);
            this.lbl_titulo.TabIndex = 36;
            this.lbl_titulo.Text = "Cálculo IMC";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_peso
            // 
            this.txt_peso.Location = new System.Drawing.Point(170, 126);
            this.txt_peso.Name = "txt_peso";
            this.txt_peso.Size = new System.Drawing.Size(109, 20);
            this.txt_peso.TabIndex = 2;
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(170, 89);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(109, 20);
            this.txt_idade.TabIndex = 1;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(170, 52);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(109, 20);
            this.txt_nome.TabIndex = 0;
            // 
            // lbl_peso
            // 
            this.lbl_peso.AutoSize = true;
            this.lbl_peso.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_peso.ForeColor = System.Drawing.Color.SeaShell;
            this.lbl_peso.Location = new System.Drawing.Point(101, 128);
            this.lbl_peso.Name = "lbl_peso";
            this.lbl_peso.Size = new System.Drawing.Size(37, 15);
            this.lbl_peso.TabIndex = 32;
            this.lbl_peso.Text = "Peso:";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idade.ForeColor = System.Drawing.Color.SeaShell;
            this.lbl_idade.Location = new System.Drawing.Point(101, 91);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(41, 15);
            this.lbl_idade.TabIndex = 31;
            this.lbl_idade.Text = "Idade:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.SeaShell;
            this.lbl_nome.Location = new System.Drawing.Point(101, 54);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(42, 15);
            this.lbl_nome.TabIndex = 30;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_calcimc
            // 
            this.lbl_calcimc.AutoSize = true;
            this.lbl_calcimc.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calcimc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_calcimc.Location = new System.Drawing.Point(163, 334);
            this.lbl_calcimc.Name = "lbl_calcimc";
            this.lbl_calcimc.Size = new System.Drawing.Size(56, 15);
            this.lbl_calcimc.TabIndex = 29;
            this.lbl_calcimc.Text = "O IMC é:";
            // 
            // btn_imc
            // 
            this.btn_imc.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_imc.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imc.ForeColor = System.Drawing.Color.Black;
            this.btn_imc.Location = new System.Drawing.Point(104, 275);
            this.btn_imc.Name = "btn_imc";
            this.btn_imc.Size = new System.Drawing.Size(175, 49);
            this.btn_imc.TabIndex = 5;
            this.btn_imc.Text = "Calcular IMC";
            this.btn_imc.UseVisualStyleBackColor = false;
            this.btn_imc.Click += new System.EventHandler(this.btn_imc_Click);
            // 
            // btn_dados
            // 
            this.btn_dados.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_dados.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dados.ForeColor = System.Drawing.Color.Black;
            this.btn_dados.Location = new System.Drawing.Point(104, 205);
            this.btn_dados.Name = "btn_dados";
            this.btn_dados.Size = new System.Drawing.Size(175, 49);
            this.btn_dados.TabIndex = 4;
            this.btn_dados.Text = "Enviar dados";
            this.btn_dados.UseVisualStyleBackColor = false;
            this.btn_dados.Click += new System.EventHandler(this.btn_dados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(380, 393);
            this.Controls.Add(this.txt_imctotal);
            this.Controls.Add(this.txt_altura);
            this.Controls.Add(this.lbl_altura);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.txt_peso);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lbl_peso);
            this.Controls.Add(this.lbl_idade);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_calcimc);
            this.Controls.Add(this.btn_imc);
            this.Controls.Add(this.btn_dados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atleta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_imctotal;
        private System.Windows.Forms.TextBox txt_altura;
        private System.Windows.Forms.Label lbl_altura;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.TextBox txt_peso;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_peso;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_calcimc;
        private System.Windows.Forms.Button btn_imc;
        private System.Windows.Forms.Button btn_dados;
    }
}