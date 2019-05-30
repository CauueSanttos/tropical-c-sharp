using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TropicalSistema.include.controller;
using TropicalSistema.include.model;

namespace TropicalSistema.include.view {

    public partial class FrmBuscaUsuario : Form {

        public FrmBuscaUsuario() {
            InitializeComponent();
        }

        private void buttonBusca_Click(object sender, EventArgs e) {
            this.buscaCliente();
        }

        private void buscaCliente() {
            string sNomeCliente = inputBusca.Text;

            ControllerCliente oController = new ControllerCliente();
            List<Cliente> aUsuarios = oController.buscaCliente(sNomeCliente);

            gridUsuarios.AutoGenerateColumns = false;
            gridUsuarios.DataSource = aUsuarios;

            gridUsuarios.Visible = true;
        }

        private void inputBusca_KeyPress(object sender, KeyPressEventArgs e) {
            if ((Keys)e.KeyChar == Keys.Enter) {
                this.buscaCliente();
            }
        }

        private void gridUsuarios_RowEnter(object sender, DataGridViewCellEventArgs e) {
            this.btnGerenciar.Enabled = true;
        }

        private void btnGerenciar_Click(object sender, EventArgs e) {
            this.criaTelaGerenciar();
        }

        private void criaTelaGerenciar() {
            var oCell = this.gridUsuarios.CurrentRow;

            ControllerCliente oControllerCliente = new ControllerCliente();
            oControllerCliente.criaTelaGerenciar(oCell.Cells["codigo"].Value.ToString());
        }

        private void btnInserir_Click(object sender, EventArgs e) {
            this.criaTelaInclusao();
        }

        private void criaTelaInclusao() {
            ControllerCliente oControllerCliente = new ControllerCliente();
            oControllerCliente.criaTelaIncluir();
        }
    }
}
