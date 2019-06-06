using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TropicalSistema.include.model {

    class HistoricoCliente {

        public int codigo {get; set;}
        public int tipoHistorico {get; set;}
        public double saldoAnterior {get; set;}
        public double saldoAtual {get; set;}
        public double saldoHistorico {get; set;}
        public string dataHoraHistorico {get; set;}

    }
}
