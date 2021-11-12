using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_02
{
    class Calculo
    {
        #region atributos
        private int num1;
        private int resultado;
        #endregion

        #region construtores
        public Calculo()
        {
            this.num1 = 0;
        }

        public Calculo(int num1)
        {
            this.num1 = num1;
        }
        #endregion

        #region métodos de interface (Setter's & Getter's)
        public void setNum1(int num1)
        {
            this.num1 = num1;
        }

        public int getNum1()
        {
            return this.num1;
        }

        public int getResultado()
        {
            return this.resultado;
        }
        #endregion

        #region métodos funcionais
        public void calcular()
        {
            this.resultado = this.num1 * this.num1;
        }
        #endregion
    }
}