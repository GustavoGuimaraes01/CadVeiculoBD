namespace CadVeiculo_turmaB
{
    partial class frmPrincipal
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
            grpVeiculo = new GroupBox();
            txtPlaca = new MaskedTextBox();
            txtModelo = new TextBox();
            lblModelo = new Label();
            lblPlaca = new Label();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnListar = new Button();
            btnExcluir = new Button();
            lstVeiculos = new ListView();
            colPlaca = new ColumnHeader();
            colModelo = new ColumnHeader();
            bntSair = new Button();
            grpVeiculo.SuspendLayout();
            SuspendLayout();
            // 
            // grpVeiculo
            // 
            grpVeiculo.Controls.Add(txtPlaca);
            grpVeiculo.Controls.Add(txtModelo);
            grpVeiculo.Controls.Add(lblModelo);
            grpVeiculo.Controls.Add(lblPlaca);
            grpVeiculo.Location = new Point(27, 12);
            grpVeiculo.Name = "grpVeiculo";
            grpVeiculo.Size = new Size(615, 141);
            grpVeiculo.TabIndex = 0;
            grpVeiculo.TabStop = false;
            grpVeiculo.Text = "Dados do Veiculo";
            // 
            // txtPlaca
            // 
            txtPlaca.Enabled = false;
            txtPlaca.Location = new Point(93, 35);
            txtPlaca.Mask = "LLL-0&00";
            txtPlaca.Name = "txtPlaca";
            txtPlaca.Size = new Size(121, 23);
            txtPlaca.TabIndex = 0;
            // 
            // txtModelo
            // 
            txtModelo.Enabled = false;
            txtModelo.Location = new Point(93, 77);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(406, 23);
            txtModelo.TabIndex = 1;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(16, 80);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(59, 15);
            lblModelo.TabIndex = 1;
            lblModelo.Text = "MODELO:";
            // 
            // lblPlaca
            // 
            lblPlaca.AutoSize = true;
            lblPlaca.Location = new Point(28, 38);
            lblPlaca.Name = "lblPlaca";
            lblPlaca.Size = new Size(47, 15);
            lblPlaca.TabIndex = 0;
            lblPlaca.Text = "PLACA:";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(27, 169);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(75, 23);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "NOVO";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Enabled = false;
            btnSalvar.Location = new Point(27, 208);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(27, 247);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 3;
            btnListar.Text = "LISTAR";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(27, 287);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lstVeiculos
            // 
            lstVeiculos.Columns.AddRange(new ColumnHeader[] { colPlaca, colModelo });
            lstVeiculos.FullRowSelect = true;
            lstVeiculos.Location = new Point(120, 169);
            lstVeiculos.Name = "lstVeiculos";
            lstVeiculos.Size = new Size(522, 176);
            lstVeiculos.TabIndex = 5;
            lstVeiculos.UseCompatibleStateImageBehavior = false;
            lstVeiculos.View = View.Details;
            // 
            // colPlaca
            // 
            colPlaca.Text = "Placa";
            colPlaca.Width = 100;
            // 
            // colModelo
            // 
            colModelo.Text = "Modelo";
            colModelo.Width = 400;
            // 
            // bntSair
            // 
            bntSair.BackColor = Color.Red;
            bntSair.ForeColor = Color.White;
            bntSair.Location = new Point(27, 322);
            bntSair.Name = "bntSair";
            bntSair.Size = new Size(75, 23);
            bntSair.TabIndex = 6;
            bntSair.Text = "SAIR";
            bntSair.UseVisualStyleBackColor = false;
            bntSair.Click += bntSair_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 377);
            Controls.Add(bntSair);
            Controls.Add(lstVeiculos);
            Controls.Add(btnExcluir);
            Controls.Add(btnListar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(grpVeiculo);
            Name = "frmPrincipal";
            Text = "Cadastro de Veiculos";
            grpVeiculo.ResumeLayout(false);
            grpVeiculo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpVeiculo;
        private TextBox txtModelo;
        private Label lblModelo;
        private Label lblPlaca;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnListar;
        private Button btnExcluir;
        private ListView lstVeiculos;
        private MaskedTextBox txtPlaca;
        private ColumnHeader colPlaca;
        private ColumnHeader colModelo;
        private Button bntSair;
    }
}
