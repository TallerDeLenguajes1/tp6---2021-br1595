﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio01
{
    public class Calculadora
    {
        private float numero1;
        private float numero2;

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }

        public float Suma()
        {
            return numero1 + numero2;
        }

        public float Resta()
        {
            return numero1 - numero2;
        }

        public float Multiplicacion()
        {
            return numero1 * numero2;
        }

        public float Division()
        {
            return numero1 / numero2;
        }
    }

}
