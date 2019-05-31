namespace TropicalSistema.include.view {
    partial class FrmIncluir {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIncluir));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNome = new System.Windows.Forms.TextBox();
            this.inputEmpresa = new System.Windows.Forms.TextBox();
            this.inputTelefone = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.selectTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Empresa*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefone*:";
            // 
            // inputNome
            // 
            this.inputNome.Location = new System.Drawing.Point(87, 25);
            this.inputNome.Name = "inputNome";
            this.inputNome.Size = new System.Drawing.Size(333, 20);
            this.inputNome.TabIndex = 3;
            // 
            // inputEmpresa
            // 
            this.inputEmpresa.Location = new System.Drawing.Point(87, 51);
            this.inputEmpresa.Name = "inputEmpresa";
            this.inputEmpresa.Size = new System.Drawing.Size(333, 20);
            this.inputEmpresa.TabIndex = 4;
            // 
            // inputTelefone
            // 
            this.inputTelefone.Location = new System.Drawing.Point(87, 78);
            this.inputTelefone.Name = "inputTelefone";
            this.inputTelefone.Size = new System.Drawing.Size(127, 20);
            this.inputTelefone.TabIndex = 5;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(139, 120);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 6;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(220, 120);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // selectTipo
            // 
            this.selectTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectTipo.FormattingEnabled = true;
            this.selectTipo.Items.AddRange(new object[] {
            "Normal",
            "Mensalista"});
            this.selectTipo.Location = new System.Drawing.Point(301, 78);
            this.selectTipo.Name = "selectTipo";
            this.selectTipo.Size = new System.Drawing.Size(119, 21);
            this.selectTipo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo*:";
            // 
            // FrmIncluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 155);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.selectTipo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.inputTelefone);
            this.Controls.Add(this.inputEmpresa);
            this.Controls.Add(this.inputNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIncluir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incluir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputNome;
        private System.Windows.Forms.TextBox inputEmpresa;
        private System.Windows.Forms.TextBox inputTelefone;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox selectTipo;
        private System.Windows.Forms.Label label4;
    }
}