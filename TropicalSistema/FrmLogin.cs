using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
