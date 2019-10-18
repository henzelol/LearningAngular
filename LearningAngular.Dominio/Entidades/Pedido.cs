﻿using System;
using System.Collections.Generic;

namespace LearningAngular.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }


        public ICollection<ItemPedido> ItensPedido { get; set; }
    }

}
