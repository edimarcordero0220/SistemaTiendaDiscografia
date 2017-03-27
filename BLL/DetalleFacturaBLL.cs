using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
using System.Data.Entity;

namespace BLL
{
    public class DetalleFacturaBLL
    {
        Factura factura = new Factura();
        public static void Guardar(Factura f)
        {
            try
            {
                SistemaDiscograficoDb db = new SistemaDiscograficoDb();
                db.DetallesFacturas.Add(f);
                var df = db.DetallesFacturas.Add(f);
                foreach (var produ in df.Discos)
                {
                    db.Entry(produ).State = EntityState.Unchanged;
                }
                db.DetallesFacturas.Add(f);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static void Eliminar(Factura f)
        {
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            Factura fa = db.DetallesFacturas.Find(f);
            db.DetallesFacturas.Remove(fa);
            db.SaveChanges();

        }
        public static void Eliminar(int v)
        {
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            Factura fa = db.DetallesFacturas.Find(v);


            db.DetallesFacturas.Remove(fa);
            db.SaveChanges();
        }
        public static Factura Buscar(int Id)
        {
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            return db.DetallesFacturas.Find(Id);
        }
    }
}
