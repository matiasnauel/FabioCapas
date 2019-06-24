﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocios
{
    public abstract class IContrato
    {
        public abstract bool agragar(object ob);
        public abstract bool eliminar(int id);
        public abstract List<Object> traerTodos(object ob);
        public abstract bool MOdificar(int id);
        public abstract int OptenerId(string Text);

    }
}
