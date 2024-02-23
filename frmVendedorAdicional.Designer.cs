namespace ImportarVendedorAdicional
{
    partial class frmVendedorAdicional
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
            dataGridView1 = new DataGridView();
            txtPlanilha = new TextBox();
            btnSelecionarArquivo = new Button();
            escolherPlanilha = new ComboBox();
            btnEscolherPlanilha = new Button();
            btnGravar = new Button();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnSair = new Button();
            txtCodigoVen = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(423, 359);
            dataGridView1.TabIndex = 0;
            // 
            // txtPlanilha
            // 
            txtPlanilha.Location = new Point(12, 12);
            txtPlanilha.Name = "txtPlanilha";
            txtPlanilha.Size = new Size(423, 27);
            txtPlanilha.TabIndex = 1;
            // 
            // btnSelecionarArquivo
            // 
            btnSelecionarArquivo.Location = new Point(441, 10);
            btnSelecionarArquivo.Name = "btnSelecionarArquivo";
            btnSelecionarArquivo.Size = new Size(94, 29);
            btnSelecionarArquivo.TabIndex = 2;
            btnSelecionarArquivo.Text = "Selecionar";
            btnSelecionarArquivo.UseVisualStyleBackColor = true;
            btnSelecionarArquivo.Click += btnSelecionarArquivo_Click;
            // 
            // escolherPlanilha
            // 
            escolherPlanilha.FormattingEnabled = true;
            escolherPlanilha.Location = new Point(12, 45);
            escolherPlanilha.Name = "escolherPlanilha";
            escolherPlanilha.Size = new Size(423, 28);
            escolherPlanilha.TabIndex = 3;
            // 
            // btnEscolherPlanilha
            // 
            btnEscolherPlanilha.Location = new Point(441, 45);
            btnEscolherPlanilha.Name = "btnEscolherPlanilha";
            btnEscolherPlanilha.Size = new Size(94, 29);
            btnEscolherPlanilha.TabIndex = 5;
            btnEscolherPlanilha.Text = "OK";
            btnEscolherPlanilha.UseVisualStyleBackColor = true;
            btnEscolherPlanilha.Click += btnEscolherPlanilha_Click;
            // 
            // btnGravar
            // 
            btnGravar.Location = new Point(441, 304);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(94, 29);
            btnGravar.TabIndex = 6;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(441, 339);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(441, 374);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(441, 409);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(94, 29);
            btnSair.TabIndex = 9;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // txtCodigoVen
            // 
            txtCodigoVen.Location = new Point(441, 80);
            txtCodigoVen.Name = "txtCodigoVen";
            txtCodigoVen.Size = new Size(94, 27);
            txtCodigoVen.TabIndex = 10;
            // 
            // frmVendedorAdicional
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 450);
            Controls.Add(txtCodigoVen);
            Controls.Add(btnSair);
            Controls.Add(btnExcluir);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(btnEscolherPlanilha);
            Controls.Add(escolherPlanilha);
            Controls.Add(btnSelecionarArquivo);
            Controls.Add(txtPlanilha);
            Controls.Add(dataGridView1);
            Name = "frmVendedorAdicional";
            Text = "Vendedor Adicional";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtPlanilha;
        private Button btnSelecionarArquivo;
        private ComboBox escolherPlanilha;
        private Button btnEscolherPlanilha;
        private Button btnGravar;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnSair;
        private TextBox txtCodigoVen;
    }
}