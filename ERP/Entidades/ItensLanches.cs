﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.Dominio.Entidades
{
    public class ItensLanches
    {
        public int id { get; set; }
        public int lancheId { get; set; }
        public virtual Lanches lanches { get; set; }
        public virtual Ingredientes Ingredientes { get; set; }
        public int IngredienteId { get; set; }

    }
}
