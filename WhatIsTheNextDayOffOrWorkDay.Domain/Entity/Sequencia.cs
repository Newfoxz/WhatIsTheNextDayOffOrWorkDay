using System;

namespace WhatIsTheNextDayOffOrWorkDay.Domain.Entity
{
    public class Sequencia
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public int Indicador { get; set; }
        public int EscalaId { get; set; }
        public virtual Escala Escala { get; set; }

        public string IndicadorToString()
        {
            if (Indicador == 0)
                return "DayOff";
            else if (Indicador == 1)
                return "WorkDay";
            else
                return string.Empty;
        }
    }
}
