using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BLL
{
    public class FacturaBLL
    {
        public static void Insertar(Factura f)
        {
            try
            {
                SistemaDiscograficoDb db = new SistemaDiscograficoDb();
                db.DetallesFacturas.Add(f);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Eliminar(Factura f)
        {
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            Factura cl = db.DetallesFacturas.Find(f);

            db.DetallesFacturas.Remove(cl);
            db.SaveChanges();
        }
        public static Factura Buscar(int Id)
        {
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            return db.DetallesFacturas.Find(Id);
        }
        public static void Eliminar(int v)
        {
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            Factura cl = db.DetallesFacturas.Find(v);
            try
            {
                db.DetallesFacturas.Remove(cl);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
