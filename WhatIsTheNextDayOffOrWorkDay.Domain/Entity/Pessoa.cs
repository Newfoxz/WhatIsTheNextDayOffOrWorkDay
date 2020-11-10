using System;

namespace WhatIsTheNextDayOffOrWorkDay.Domain.Entity
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string Apelido { get; set; }
        public string NumeroCPF { get; set; }
        public string DataNascimento { get; set; }
    }
}
