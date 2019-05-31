using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TropicalSistema.include.controller;

namespace TropicalSistema.include.view {

    public partial class FrmIncluir : Form {

        public FrmIncluir() {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            this.limparFormulario();
        }

        private void limparFormulario() {
            this.inputNome.Clear();
            this.inputTelefone.Clear();
            this.inputEmpresa.Clear();

            this.selectTipo.SelectedItem = null;

            MessageBox.Show("Os campos foram limpos!", "ALERTA");
        }

        private void btnIncluir_Click(object sender, EventArgs e) {
            this.validaDadosFormulario();
            this.processaDadosUsuario();
        }

        private void processaDadosUsuario() {
            ControllerCliente oControllerCliente = new ControllerCliente();
            oControllerCliente.processaDadosInclusao(this.inputNome.Text, this.inputEmpresa.Text, this.inputTelefone.Text, this.selectTipo.SelectedIndex);
        }

        private void validaDadosFormulario() {
            List<String> aCampos = new List<String>();

            if (this.inputNome.Text == "") {
                aCampos.Add("Nome");
            }

            if (this.inputTelefone.Text == "") {
                aCampos.Add("Telefone");
            }

            if (this.inputEmpresa.Text == "") {
                aCampos.Add("Empresa");
            }

            if (this.selectTipo.SelectedIndex == -1) {
                aCampos.Add("Tipo");
            }

            if (aCampos.Count() > 0) {
                MessageBox.Show("Preencha o(s) campo(s): [" + String.Join(", ", aCampos) +  "]", "OBRIGATÓRIO");
            }
        }
    }
}
