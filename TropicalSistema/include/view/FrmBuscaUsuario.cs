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
            oController.buscaCliente(sNomeCliente);
        }
    }
}
