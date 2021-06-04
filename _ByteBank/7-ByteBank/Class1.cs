﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ByteBank
{
    public class Cliente
    {

        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public string Profissao { get; set; }

        public Cliente(string nome, string cpf, int idade, string profissao)
        {
            Nome = nome;
            CPF = cpf;
            Idade = idade;
            Profissao = profissao;
        }
    }
}
