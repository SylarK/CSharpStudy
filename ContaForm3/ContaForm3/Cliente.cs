﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaForm3
{
    public class Cliente
    {
        public string Nome { get; set; }

        public Cliente() { }

        public Cliente(string nome) {
            this.Nome = nome;
        }
    }
}
