using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
         
         /*
         TIPO DE CLASES
         * public (se puede ver desde cualquier lado)
         * private (Solo para clases anidadas)
         * protected  (Solo accesibles clases hijas)
         * internal (concepto de ensamblado, restringe el objeto a el proyecto que esta definido)
         * internal protected (que sea del mismo proyecto o que sea clase hija)
         * private protected (solamente lo pueden acceder los que estan en el mismo proyecto y en la misma clase)
         */

    class Calculadora
    {

        private int numero1;

        public int Numero1
        {
            get
            {
                return numero1;
            }
            set
            {
                numero1 = value;
            }
        }

    }


}
