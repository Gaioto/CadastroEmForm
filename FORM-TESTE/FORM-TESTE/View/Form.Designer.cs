
namespace FORM_TESTE
{
    partial class Form
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
            this.cadastrar = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.TextBox();
            this.codigo = new System.Windows.Forms.NumericUpDown();
            this.preco = new System.Windows.Forms.NumericUpDown();
            this.estoque = new System.Windows.Forms.NumericUpDown();
            this.atualizarLista = new System.Windows.Forms.Button();
            this.listaProdutos = new System.Windows.Forms.ListView();
            this.headCodigo = new System.Windows.Forms.ColumnHeader();
            this.headProduto = new System.Windows.Forms.ColumnHeader();
            this.headEstoque = new System.Windows.Forms.ColumnHeader();
            this.headPreco = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deletarProduto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.novoEstoque = new System.Windows.Forms.NumericUpDown();
            this.novoPreco = new System.Windows.Forms.NumericUpDown();
            this.novoCodigo = new System.Windows.Forms.Label();
            this.novoNome = new System.Windows.Forms.Label();
            this.atualizaProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.codigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.preco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoque)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.novoEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.novoPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // cadastrar
            // 
            this.cadastrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.cadastrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cadastrar.Location = new System.Drawing.Point(59, 163);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(85, 32);
            this.cadastrar.TabIndex = 0;
            this.cadastrar.Text = "Cadastrar";
            this.cadastrar.UseVisualStyleBackColor = false;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // nome
            // 
            this.nome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nome.Location = new System.Drawing.Point(80, 62);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(120, 25);
            this.nome.TabIndex = 3;
            // 
            // codigo
            // 
            this.codigo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.codigo.Location = new System.Drawing.Point(80, 29);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(120, 25);
            this.codigo.TabIndex = 5;
            // 
            // preco
            // 
            this.preco.DecimalPlaces = 1;
            this.preco.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.preco.Location = new System.Drawing.Point(80, 127);
            this.preco.Name = "preco";
            this.preco.Size = new System.Drawing.Size(120, 25);
            this.preco.TabIndex = 6;
            // 
            // estoque
            // 
            this.estoque.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.estoque.Location = new System.Drawing.Point(80, 94);
            this.estoque.Name = "estoque";
            this.estoque.Size = new System.Drawing.Size(120, 25);
            this.estoque.TabIndex = 7;
            // 
            // atualizarLista
            // 
            this.atualizarLista.BackColor = System.Drawing.Color.LawnGreen;
            this.atualizarLista.Location = new System.Drawing.Point(589, 359);
            this.atualizarLista.Name = "atualizarLista";
            this.atualizarLista.Size = new System.Drawing.Size(90, 26);
            this.atualizarLista.TabIndex = 8;
            this.atualizarLista.Text = "Atualizar Lista";
            this.atualizarLista.UseVisualStyleBackColor = false;
            this.atualizarLista.Click += new System.EventHandler(this.atualizarLista_Click);
            // 
            // listaProdutos
            // 
            this.listaProdutos.BackColor = System.Drawing.SystemColors.Info;
            this.listaProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headCodigo,
            this.headProduto,
            this.headEstoque,
            this.headPreco});
            this.listaProdutos.HideSelection = false;
            this.listaProdutos.Location = new System.Drawing.Point(485, 35);
            this.listaProdutos.Name = "listaProdutos";
            this.listaProdutos.Size = new System.Drawing.Size(303, 318);
            this.listaProdutos.TabIndex = 9;
            this.listaProdutos.UseCompatibleStateImageBehavior = false;
            this.listaProdutos.View = System.Windows.Forms.View.Details;
            this.listaProdutos.SelectedIndexChanged += new System.EventHandler(this.listaProdutos_SelectedIndexChanged);
            // 
            // headCodigo
            // 
            this.headCodigo.Text = "Código";
            // 
            // headProduto
            // 
            this.headProduto.Text = "Produto";
            this.headProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // headEstoque
            // 
            this.headEstoque.Text = "Estoque";
            this.headEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // headPreco
            // 
            this.headPreco.Text = "Preço";
            this.headPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cadastrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.estoque);
            this.groupBox1.Controls.Add(this.nome);
            this.groupBox1.Controls.Add(this.codigo);
            this.groupBox1.Controls.Add(this.preco);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 200);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(8, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Estoque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.atualizaProduto);
            this.groupBox2.Controls.Add(this.novoNome);
            this.groupBox2.Controls.Add(this.novoCodigo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.deletarProduto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.novoEstoque);
            this.groupBox2.Controls.Add(this.novoPreco);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(249, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 200);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edita Produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Preço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Estoque";
            // 
            // deletarProduto
            // 
            this.deletarProduto.BackColor = System.Drawing.Color.Red;
            this.deletarProduto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletarProduto.Location = new System.Drawing.Point(128, 163);
            this.deletarProduto.Name = "deletarProduto";
            this.deletarProduto.Size = new System.Drawing.Size(85, 32);
            this.deletarProduto.TabIndex = 0;
            this.deletarProduto.Text = "Deletar";
            this.deletarProduto.UseVisualStyleBackColor = false;
            this.deletarProduto.Click += new System.EventHandler(this.deletarProduto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(8, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nome";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(8, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Código";
            // 
            // novoEstoque
            // 
            this.novoEstoque.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.novoEstoque.Location = new System.Drawing.Point(80, 94);
            this.novoEstoque.Name = "novoEstoque";
            this.novoEstoque.Size = new System.Drawing.Size(120, 25);
            this.novoEstoque.TabIndex = 7;
            // 
            // novoPreco
            // 
            this.novoPreco.DecimalPlaces = 1;
            this.novoPreco.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.novoPreco.Location = new System.Drawing.Point(80, 127);
            this.novoPreco.Name = "novoPreco";
            this.novoPreco.Size = new System.Drawing.Size(120, 25);
            this.novoPreco.TabIndex = 6;
            // 
            // novoCodigo
            // 
            this.novoCodigo.AutoSize = true;
            this.novoCodigo.Location = new System.Drawing.Point(79, 32);
            this.novoCodigo.Name = "novoCodigo";
            this.novoCodigo.Size = new System.Drawing.Size(0, 19);
            this.novoCodigo.TabIndex = 12;
            // 
            // novoNome
            // 
            this.novoNome.AutoSize = true;
            this.novoNome.Location = new System.Drawing.Point(79, 64);
            this.novoNome.Name = "novoNome";
            this.novoNome.Size = new System.Drawing.Size(0, 19);
            this.novoNome.TabIndex = 13;
            // 
            // atualizaProduto
            // 
            this.atualizaProduto.BackColor = System.Drawing.Color.LimeGreen;
            this.atualizaProduto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.atualizaProduto.Location = new System.Drawing.Point(8, 162);
            this.atualizaProduto.Name = "atualizaProduto";
            this.atualizaProduto.Size = new System.Drawing.Size(85, 32);
            this.atualizaProduto.TabIndex = 14;
            this.atualizaProduto.Text = "Atualizar";
            this.atualizaProduto.UseVisualStyleBackColor = false;
            this.atualizaProduto.Click += new System.EventHandler(this.atualizaProduto_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listaProdutos);
            this.Controls.Add(this.atualizarLista);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form";
            this.Text = "Controle de Produtos";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.codigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.preco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estoque)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.novoEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.novoPreco)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.NumericUpDown codigo;
        private System.Windows.Forms.NumericUpDown preco;
        private System.Windows.Forms.NumericUpDown estoque;
        private System.Windows.Forms.Button atualizarLista;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader headCodigo;
        private System.Windows.Forms.ColumnHeader Produto;
        private System.Windows.Forms.ColumnHeader headProduto;
        private System.Windows.Forms.ColumnHeader headEstoque;
        private System.Windows.Forms.ColumnHeader headPreco;
        private System.Windows.Forms.ListView listaProdutos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button atualizaProduto;
        private System.Windows.Forms.Label novoNome;
        private System.Windows.Forms.Label novoCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button deletarProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown novoEstoque;
        private System.Windows.Forms.NumericUpDown novoPreco;
    }
}

