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

namespace TropicalSistema.include.view {

    public partial class FrmGerenciar : Form {

        public FrmGerenciar(string iCodigoCliente) {
            InitializeComponent();
            this.loadDadosCliente(iCodigoCliente);
        }

        private void loadDadosCliente(string iCodigoCliente) {
            Cliente oModelCliente = new Cliente();
            oModelCliente.setCodigo(Convert.ToInt32(iCodigoCliente));
            oModelCliente.getClienteGerenciar();

            inputNome.Text = oModelCliente.getNome();
            inputCodigo.Text = Convert.ToString(oModelCliente.getCodigo());
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            decimal sValorCampo = Convert.ToDecimal(inputNovoSaldo.Text);
            decimal sValorAtual = Convert.ToDecimal((inputSaldoAtual.Text == "" ? "0" : inputSaldoAtual.Text));

            decimal dValorTotal = sValorCampo + sValorAtual;

            inputSaldoAtual.Text = Convert.ToString(dValorTotal);
            inputNovoSaldo.Clear();
        }

        private void btnRemover_Click(object sender, EventArgs e) {
            decimal sValorCampo = Convert.ToDecimal((inputNovoSaldo.Text == "" ? "0" : inputNovoSaldo.Text));
            decimal sValorAtual = Convert.ToDecimal((inputSaldoAtual.Text == "" ? "0" : inputSaldoAtual.Text));

            decimal dValorTotal = sValorAtual - sValorCampo;

            inputSaldoAtual.Text = Convert.ToString(dValorTotal);
            inputNovoSaldo.Clear();
        }

        private void btnConfirmar_Click(object sender, EventArgs e) {
            MessageBox.Show(inputCodigo.Text);
        }
    }
}
