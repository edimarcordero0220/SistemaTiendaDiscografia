using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;
namespace BLL
{
    public class ClientesBLL
    {
        public static void Insertar(Clientes c)
        {
            try
            {
                SistemaDiscograficoDb db = new SistemaDiscograficoDb();
                db.Clientes.Add(c);
                db.SaveChanges();
                db.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void Eliminar(Clientes c)
        {
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            Clientes cl = db.Clientes.Find(c);

            db.Clientes.Remove(cl);
            db.SaveChanges();
        }
        public static Clientes Buscar(int Id)
        {
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            return db.Clientes.Find(Id);
        }
        public static void Eliminar(int v)
        {
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            Clientes cl = db.Clientes.Find(v);
            try
            {
                db.Clientes.Remove(cl);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Clientes> GetListaNombre(string tmp)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.Clientes.Where(p => p.NombreCliente == tmp).ToList();
            return lista;
        }
        public static List<Clientes> GetLista()
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.Clientes.ToList();
            return lista;
        }
        public static List<Clientes> GetLista(int clienteId)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.Clientes.Where(p => p.IdCliente == clienteId).ToList();
            return lista;

        }

    }
}
