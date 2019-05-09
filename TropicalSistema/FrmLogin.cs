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
using TropicalSistema.include.model;

namespace TropicalSistema {

    public partial class FrmLogin : Form {

        public FrmLogin() {            
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            inputUsuario.Clear();
            inputSenha.Clear();
            MessageBox.Show("Os campos foram limpos!");
        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            this.validaLoginUsuario();
        }

        private void validaLoginUsuario() {
            string sUsuario = inputUsuario.Text;
            string sSenha = inputSenha.Text;

            ControllerGerencia oController = new ControllerGerencia();
            if (oController.validaLoginGerencia(sUsuario, sSenha)) {
                MessageBox.Show("Deu boa");
            }
        }
    }
}
