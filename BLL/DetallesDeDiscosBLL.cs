using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Data.Entity;
using System.Windows.Forms;

namespace BLL
{
    public class DetallesDeDiscosBLL
    {
        
        public static void Insertar(DetallesDeDiscos d)
        {
            try
            {
                SistemaDiscograficoDb db = new SistemaDiscograficoDb();
              
                db.DetalleDeDiscos.Add(d);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool Eliminar(DetallesDeDiscos c)
        {
            try
            {
                SistemaDiscograficoDb db = new SistemaDiscograficoDb();
                DetallesDeDiscos cl = db.DetalleDeDiscos.Find(c);
                {
                    db.DetalleDeDiscos.Remove(c);
                    db.SaveChanges();
                    return false;
                }
            }
            catch (Exception)
            {
                return true;
                throw;
            }

        }
        public static bool Eliminar(int v)
        {
            try
            {
                SistemaDiscograficoDb db = new SistemaDiscograficoDb();
                DetallesDeDiscos c = db.DetalleDeDiscos.Find(v);
                {
                    db.DetalleDeDiscos.Remove(c);
                    db.SaveChanges();
                    return false;
                }
            }
            catch (Exception)
            {
                return true;
                throw;
            }


        }
    }
}
