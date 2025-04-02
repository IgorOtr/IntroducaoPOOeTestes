using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro.Model
{
    public class Conta
    {
        private long _numeroConta;
        private decimal _saldoConta;

        public Conta(long numero, decimal saldo)
        {
            _numeroConta = numero;
            _saldoConta = saldo;
        }

        public Conta(long numero)
        {
            _numeroConta = numero;
            _saldoConta = 0;
        }

        public decimal Saldo 
        { 
            get
            {
                return _saldoConta;
            }
            private set
            {
                _saldoConta = value;
            }
        }

        public long Numero
        {
            get
            {
                return _numeroConta;
            }
            private set
            {
                _numeroConta = value;
            }
        }

        public void Depositar(decimal valor)
        {
            _saldoConta += valor;
        }


    }
}
