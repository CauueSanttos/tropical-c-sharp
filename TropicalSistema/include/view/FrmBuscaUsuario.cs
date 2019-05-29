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
            this.gridUsuarios.Rows.Clear();
            string sNomeCliente = inputBusca.Text;

            ControllerCliente oController = new ControllerCliente();
            List<Cliente> aUsuarios = oController.buscaCliente(sNomeCliente);

            foreach (var oCliente in aUsuarios) {
                string sTipoCliente = (oCliente.getTipo() == 0 ? "Normal" : "Mensalista");
                gridUsuarios.Rows.Add(oCliente.getCodigo(), oCliente.getNome(), oCliente.getTelefone(), oCliente.getEmpresa(), sTipoCliente);
            }

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
            this.loadDadosCliente();
        }

        private void loadDadosCliente() {
            var oCell = this.gridUsuarios.CurrentRow;
            ControllerGerenciar oControllerGerenciar = new ControllerGerenciar();
            oControllerGerenciar.openForm(oCell.Cells["codigo"].Value.ToString());
        }
    }
}
