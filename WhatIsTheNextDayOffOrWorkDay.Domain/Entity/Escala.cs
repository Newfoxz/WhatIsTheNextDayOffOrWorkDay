using System;
using System.Collections.Generic;
using System.Linq;

namespace WhatIsTheNextDayOffOrWorkDay.Domain.Entity
{
    public class Escala
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime VigenciaInicial { get; set; }
        public virtual ICollection<Sequencia> Sequencias { get; set; }
    }
}
