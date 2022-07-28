namespace projeto02
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
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.cmbsexo = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnPesoideal = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.Nome = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.sexo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(39, 133);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(75, 23);
            this.txtAltura.TabIndex = 0;
            // 
            // cmbsexo
            // 
            this.cmbsexo.FormattingEnabled = true;
            this.cmbsexo.Items.AddRange(new object[] {
            "Feminino",
            "Mascolino"});
            this.cmbsexo.Location = new System.Drawing.Point(120, 133);
            this.cmbsexo.Name = "cmbsexo";
            this.cmbsexo.Size = new System.Drawing.Size(117, 23);
            this.cmbsexo.TabIndex = 1;
            this.cmbsexo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(39, 61);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(197, 23);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.textnome_TextChanged);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnsair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnsair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnsair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsair.Location = new System.Drawing.Point(39, 292);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(120, 30);
            this.btnsair.TabIndex = 3;
            this.btnsair.Text = "&Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnPesoideal
            // 
            this.btnPesoideal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesoideal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPesoideal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPesoideal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnPesoideal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesoideal.Location = new System.Drawing.Point(39, 197);
            this.btnPesoideal.Name = "btnPesoideal";
            this.btnPesoideal.Size = new System.Drawing.Size(120, 30);
            this.btnPesoideal.TabIndex = 4;
            this.btnPesoideal.Text = "Peso &Ideal";
            this.btnPesoideal.UseVisualStyleBackColor = false;
            this.btnPesoideal.Click += new System.EventHandler(this.btnPesoideal_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(39, 242);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 30);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Nome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nome.Location = new System.Drawing.Point(39, 32);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(41, 15);
            this.Nome.TabIndex = 6;
            this.Nome.Text = "Nome";
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.altura.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.altura.Location = new System.Drawing.Point(39, 104);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(41, 15);
            this.altura.TabIndex = 7;
            this.altura.Text = "Altura";
            this.altura.Click += new System.EventHandler(this.label2_Click);
            // 
            // sexo
            // 
            this.sexo.AutoSize = true;
            this.sexo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sexo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sexo.Location = new System.Drawing.Point(120, 104);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(35, 15);
            this.sexo.TabIndex = 8;
            this.sexo.Text = "Sexo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 457);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnPesoideal);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.cmbsexo);
            this.Controls.Add(this.txtAltura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtAltura;
        private ComboBox cmbsexo;
        private TextBox txtNome;
        private Button btnsair;
        private Button btnPesoideal;
        private Button btnLimpar;
        private Label Nome;
        private Label altura;
        private Label sexo;
    }
}