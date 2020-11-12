using System;

namespace WhatIsTheNextDayOffOrWorkDay.Domain.Entity
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Apelido { get; set; }  
        public string Email { get; set; }
        public int EscalaId { get; set; }
        public virtual Escala Escala { get; set; }
    }
}
