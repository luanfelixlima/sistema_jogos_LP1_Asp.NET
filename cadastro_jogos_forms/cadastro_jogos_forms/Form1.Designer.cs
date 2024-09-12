namespace cadastro_jogos_forms
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
            btn_inserir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btn_alterar = new Button();
            btn_excluir = new Button();
            id = new TextBox();
            categoria = new TextBox();
            valor = new TextBox();
            data = new TextBox();
            descricao = new TextBox();
            SuspendLayout();
            // 
            // btn_inserir
            // 
            btn_inserir.Location = new Point(25, 138);
            btn_inserir.Name = "btn_inserir";
            btn_inserir.Size = new Size(90, 30);
            btn_inserir.TabIndex = 0;
            btn_inserir.Text = "Inserir";
            btn_inserir.UseVisualStyleBackColor = true;
            btn_inserir.Click += btn_inserir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 38);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 5;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(214, 38);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 6;
            label2.Text = "Data de Aquisição";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 38);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 38);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 8;
            label4.Text = "Valor";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 38);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 9;
            label5.Text = "Categoria";
            // 
            // btn_alterar
            // 
            btn_alterar.Location = new Point(140, 138);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(90, 30);
            btn_alterar.TabIndex = 10;
            btn_alterar.Text = "Alterar";
            btn_alterar.UseVisualStyleBackColor = true;
            btn_alterar.Click += btn_alterar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(255, 138);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(90, 30);
            btn_excluir.TabIndex = 11;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // id
            // 
            id.Location = new Point(34, 56);
            id.Name = "id";
            id.Size = new Size(43, 23);
            id.TabIndex = 12;
            // 
            // categoria
            // 
            categoria.Location = new Point(416, 56);
            categoria.Name = "categoria";
            categoria.Size = new Size(58, 23);
            categoria.TabIndex = 13;
            // 
            // valor
            // 
            valor.Location = new Point(335, 56);
            valor.Name = "valor";
            valor.Size = new Size(61, 23);
            valor.TabIndex = 14;
            // 
            // data
            // 
            data.Location = new Point(214, 56);
            data.Name = "data";
            data.Size = new Size(102, 23);
            data.TabIndex = 15;
            // 
            // descricao
            // 
            descricao.Location = new Point(98, 56);
            descricao.Name = "descricao";
            descricao.Size = new Size(100, 23);
            descricao.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 183);
            Controls.Add(descricao);
            Controls.Add(data);
            Controls.Add(valor);
            Controls.Add(categoria);
            Controls.Add(id);
            Controls.Add(btn_excluir);
            Controls.Add(btn_alterar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_inserir);
            Name = "Form1";
            Text = "Sistema de Jogos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_inserir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_alterar;
        private Button btn_excluir;
        private TextBox id;
        private TextBox categoria;
        private TextBox valor;
        private TextBox data;
        private TextBox descricao;
    }
}