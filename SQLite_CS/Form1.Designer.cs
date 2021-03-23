
namespace SQLite_CS
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_busca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(62, 371);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(214, 23);
            this.txt_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 465);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Idade:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(62, 402);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(214, 23);
            this.txt_email.TabIndex = 5;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(62, 433);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(113, 23);
            this.txt_telefone.TabIndex = 6;
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(62, 462);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(113, 23);
            this.txt_idade.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(586, 328);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(330, 390);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 9;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(472, 390);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(330, 457);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 11;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(472, 457);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(75, 23);
            this.btn_apagar.TabIndex = 12;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(181, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID Pesquisa:\r\n";
            // 
            // txt_busca
            // 
            this.txt_busca.Location = new System.Drawing.Point(248, 457);
            this.txt_busca.Name = "txt_busca";
            this.txt_busca.Size = new System.Drawing.Size(76, 23);
            this.txt_busca.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 502);
            this.Controls.Add(this.txt_busca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_idade);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_busca;
    }
}

