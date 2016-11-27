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
        public static List<Clientes> GetLista()
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.Clientes.ToList();
            return lista;

        }
       
        
        public static List<Clientes> GetListaId(int clienteId)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.Clientes.Where(p => p.IdCliente == clienteId).ToList();
            return lista;
        }
        public static List<Clientes> GetListaCedula(string cedula)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.Clientes.Where(p => p.CedulaCliente == cedula).ToList();
            return lista;
        }
        public static List<Clientes> GetListaDireccion(string direccion)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.Clientes.Where(p => p.DireccionCliente == direccion).ToList();
            return lista;
        }
        public static List<Clientes> GetListaFecha(DateTime Desde, DateTime Hasta)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.Clientes.Where(p => p.FechaCreacion >= Desde && p.FechaCreacion <= Hasta).ToList();
            return lista;
        }
        public static List<Clientes> GetListaNombre(string NombreCliente)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.Clientes.Where(p => p.NombreCliente == NombreCliente).ToList();
            return lista;
        }
        public static List<Clientes> GetListaApellido(string Apellido)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.Clientes.Where(p => p.ApellidoCliente == Apellido).ToList();
            return lista;
        }
       

    }
}
