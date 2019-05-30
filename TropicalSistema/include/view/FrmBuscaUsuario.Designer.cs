namespace TropicalSistema.include.view {
    partial class FrmBuscaUsuario {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscaUsuario));
            this.inputBusca = new System.Windows.Forms.TextBox();
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.buttonBusca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBusca
            // 
            this.inputBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBusca.Location = new System.Drawing.Point(34, 29);
            this.inputBusca.Name = "inputBusca";
            this.inputBusca.Size = new System.Drawing.Size(435, 20);
            this.inputBusca.TabIndex = 0;
            this.inputBusca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputBusca_KeyPress);
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.AllowUserToAddRows = false;
            this.gridUsuarios.AllowUserToResizeRows = false;
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.telefone,
            this.empresa,
            this.tipo});
            this.gridUsuarios.Location = new System.Drawing.Point(34, 107);
            this.gridUsuarios.MultiSelect = false;
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.ReadOnly = true;
            this.gridUsuarios.RowHeadersVisible = false;
            this.gridUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsuarios.Size = new System.Drawing.Size(493, 106);
            this.gridUsuarios.TabIndex = 2;
            this.gridUsuarios.Visible = false;
            this.gridUsuarios.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUsuarios_RowEnter);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 170;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 120;
            // 
            // empresa
            // 
            this.empresa.DataPropertyName = "empresa";
            this.empresa.HeaderText = "Empresa";
            this.empresa.Name = "empresa";
            this.empresa.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(34, 66);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(92, 23);
            this.btnInserir.TabIndex = 3;
            this.btnInserir.Text = "Inserir Cliente";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.Enabled = false;
            this.btnGerenciar.Location = new System.Drawing.Point(132, 66);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(75, 23);
            this.btnGerenciar.TabIndex = 4;
            this.btnGerenciar.Text = "Gerenciar";
            this.btnGerenciar.UseVisualStyleBackColor = true;
            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // buttonBusca
            // 
            this.buttonBusca.BackgroundImage = global::TropicalSistema.Properties.Resources.search;
            this.buttonBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBusca.Location = new System.Drawing.Point(484, 16);
            this.buttonBusca.Name = "buttonBusca";
            this.buttonBusca.Size = new System.Drawing.Size(43, 43);
            this.buttonBusca.TabIndex = 1;
            this.buttonBusca.Text = " ";
            this.buttonBusca.UseVisualStyleBackColor = true;
            this.buttonBusca.Click += new System.EventHandler(this.buttonBusca_Click);
            // 
            // FrmBuscaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 225);
            this.Controls.Add(this.btnGerenciar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.gridUsuarios);
            this.Controls.Add(this.buttonBusca);
            this.Controls.Add(this.inputBusca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBuscaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBusca;
        private System.Windows.Forms.Button buttonBusca;
        private System.Windows.Forms.DataGridView gridUsuarios;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnGerenciar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
    }
}