﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CNegocio
{
    public class ClsUsuario

    {
        /// <summary>
        /// Variables globales del la propiedad
        /// </summary>
        public static USUARIOS UsuarioActual = null;
        public static bool ExisteSecion;
        
        /// <summary>
        /// Definicion de contructor
        /// </summary>
        /// <param name="Usuario"></param>
        /// <param name="Contraceña"></param>
        /// <returns></returns>

        public static bool loggin(string Usuario, string Contraceña)
        {
            try
            {
                using (CapaDatos.bulonera2Entities1 db = new CapaDatos.bulonera2Entities1())
                {
                    UsuarioActual = (from x in db.USUARIOS where x.nombre_usuario == Usuario && x.contraseña == Contraceña select x).FirstOrDefault();
                    if (UsuarioActual != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }


    }
    public class ClsPermisosUsuario : IContrato2
    {
        public override bool agragar(object ob)
        {
            throw new NotImplementedException();
        }

        public override bool eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public override object GetObjet(int id)
        {
            throw new NotImplementedException();
        }

        public override bool MOdificar(object id)
        {
            throw new NotImplementedException();
        }

        public override int OptenerId(string Text)
        {
            throw new NotImplementedException();
        }

        public override List<object> TraerTodos(string Text)
        {
            throw new NotImplementedException();
        }

        public override DataSet TraerTodos()
        {
            throw new NotImplementedException();
        }
    }
}

