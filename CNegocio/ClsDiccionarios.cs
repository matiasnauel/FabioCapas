﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Dynamic;
using System.Linq.Expressions;

namespace CNegocio
{
    public class ClsDiccionarios 
    {
        public List<DICCIONARIO_FAB> TraerDicFab(int cab)
        {
            using (bulonera2Entities22 db = new bulonera2Entities22())
            {
                var DicFab = (from x in db.DICCIONARIO_FAB where x.dic_cab == cab select x).ToList();
                return DicFab;
            }
        }
        /// <summary>
        /// Diccionario tecnico ODFM
        /// </summary>
        /// <param name="cab"></param>
        /// <returns></returns>
        public List<Diccionario_odfm> TraerDiccionario_ODFM(int cab)
        {
            using (bulonera2Entities22 db = new bulonera2Entities22())
            {
                var DicFab = (from x in db.Diccionario_odfm where x.dic_cab == cab select x).ToList();
                return DicFab;
            }
        }
        public List<Diccionario_odfm> TraerTodos_ODFM()
        {
            using (bulonera2Entities22 db = new bulonera2Entities22())
            {
                var DicFab = (from x in db.Diccionario_odfm select x).ToList();
                return DicFab;
            }
        }
        public bool CargarNuevoTermino_ODFM(string des, string abr)
        {
            
                using (bulonera2Entities22 db = new bulonera2Entities22())
                {
                    using (var Transaction = db.Database.BeginTransaction())
                    {
                    try
                    {
                        int _Cod;
                        Diccionario_odfm New_term = new Diccionario_odfm();
                        New_term.dic_cab = 0;
                        if((from x in db.Diccionario_odfm where x.dic_cab == 0 select x.dic_cod).Any())
                        {
                            _Cod = (from x in db.Diccionario_odfm where x.dic_cab == 0 select x.dic_cod).Max();
                            _Cod++;
                            New_term.dic_cod = _Cod;
                        }
                        else
                        {
                            New_term.dic_cod = 0;
                        }
                        


                        New_term.dic_abr = abr;
                        New_term.dic_des = des;
                        db.Diccionario_odfm.Add(New_term);
                        db.SaveChanges();
                        Transaction.Commit();
                        Transaction.Dispose();
                        return true;
                    }
                    catch (Exception er)
                    {
                        string error = er.ToString();
                        Transaction.Rollback();
                        return false;
                    }

                    }

                }
               
            }

        public List<Diccionario_odfm> OptnerDatosDeCabecera(string abr, string des)
        {
            using (bulonera2Entities22 db = new bulonera2Entities22())
            {
                List<Diccionario_odfm> Dic = (from x in db.Diccionario_odfm where x.dic_abr == abr & x.dic_des == des select x).ToList();
                return Dic;
            }
        }
    }


    }

