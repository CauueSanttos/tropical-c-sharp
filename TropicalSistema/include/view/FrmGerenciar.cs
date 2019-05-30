using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TropicalSistema.include.view {

    public partial class FrmGerenciar : Form {

        public FrmGerenciar(string iCodigoCliente) {
            InitializeComponent();
            this.loadDadosCliente(iCodigoCliente);
        }

        private void loadDadosCliente(string iCodigoCliente) {

        }
    }
}
