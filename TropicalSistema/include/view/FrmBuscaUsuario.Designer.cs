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
            this.buttonBusca = new System.Windows.Forms.Button();
            this.gridUsuarios = new System.Windows.Forms.DataGridView();
            this.clicodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clitelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliempresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clitipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBusca
            // 
            this.inputBusca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBusca.Location = new System.Drawing.Point(34, 56);
            this.inputBusca.Name = "inputBusca";
            this.inputBusca.Size = new System.Drawing.Size(435, 20);
            this.inputBusca.TabIndex = 0;
            // 
            // buttonBusca
            // 
            this.buttonBusca.BackgroundImage = global::TropicalSistema.Properties.Resources.search;
            this.buttonBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBusca.Location = new System.Drawing.Point(475, 44);
            this.buttonBusca.Name = "buttonBusca";
            this.buttonBusca.Size = new System.Drawing.Size(43, 43);
            this.buttonBusca.TabIndex = 1;
            this.buttonBusca.Text = " ";
            this.buttonBusca.UseVisualStyleBackColor = true;
            this.buttonBusca.Click += new System.EventHandler(this.buttonBusca_Click);
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clicodigo,
            this.clinome,
            this.clitelefone,
            this.cliempresa,
            this.clitipo});
            this.gridUsuarios.Location = new System.Drawing.Point(34, 107);
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.Size = new System.Drawing.Size(435, 106);
            this.gridUsuarios.TabIndex = 2;
            this.gridUsuarios.Visible = false;
            // 
            // clicodigo
            // 
            this.clicodigo.DataPropertyName = "clicodigo";
            this.clicodigo.HeaderText = "Código";
            this.clicodigo.Name = "clicodigo";
            this.clicodigo.Visible = false;
            // 
            // clinome
            // 
            this.clinome.DataPropertyName = "clinome";
            this.clinome.HeaderText = "Nome";
            this.clinome.Name = "clinome";
            // 
            // clitelefone
            // 
            this.clitelefone.DataPropertyName = "clitelefone";
            this.clitelefone.HeaderText = "Telefone";
            this.clitelefone.Name = "clitelefone";
            // 
            // cliempresa
            // 
            this.cliempresa.DataPropertyName = "cliempresa";
            this.cliempresa.HeaderText = "Empresa";
            this.cliempresa.Name = "cliempresa";
            // 
            // clitipo
            // 
            this.clitipo.DataPropertyName = "clitipo";
            this.clitipo.HeaderText = "Tipo";
            this.clitipo.Name = "clitipo";
            // 
            // FrmBuscaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 225);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clicodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clitelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliempresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clitipo;
    }
}