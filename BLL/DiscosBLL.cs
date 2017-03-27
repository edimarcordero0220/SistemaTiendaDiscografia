using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BLL
{
    public class DiscosBLL
    {
        

        public static void Insertar(DetalleFactura d)
        {
            try
            {
                SistemaDiscograficoDb db = new SistemaDiscograficoDb();
                db.disco.Add(d);
                db.SaveChanges();
                db.Dispose();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void Eliminar(DetalleFactura d)
        {
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            DetalleFactura disc = new DetalleFactura();
            db.disco.Remove(disc);
            db.SaveChanges();
        }
        public static DetalleFactura Buscar(int Id)
        {
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            return db.disco.Find(Id);
        }
        public static void Eliminar(int v)
        {
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            DetalleFactura dis = db.disco.Find(v);
            try
            {
                db.disco.Remove(dis);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<DetalleFactura> GetLista()
        {
            List<DetalleFactura> lista = new List<DetalleFactura>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.disco.ToList();
            return lista;

        }
        public static List<DetalleFactura> GetListaId(int discoId)
        {
            List<DetalleFactura> lista = new List<DetalleFactura>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.disco.Where(p => p.IdDisco == discoId).ToList();
            return lista;
        }
        public static List<DetalleFactura> GetListaNombre(string nombre)
        {
            List<DetalleFactura> lista = new List<DetalleFactura>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.disco.Where(p => p.NombreDisco == nombre).ToList();
            return lista;
        }
        public static List<DetalleFactura> GetArtista(string artista)
        {
            List<DetalleFactura> lista = new List<DetalleFactura>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.disco.Where(p => p.Artista == artista).ToList();
            return lista;
        }
        public static List<DetalleFactura> GetProductor(string productor)
        {
            List<DetalleFactura> lista = new List<DetalleFactura>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.disco.Where(p => p.Productor == productor).ToList();
            return lista;
        }
        public static List<DetalleFactura> GetSello(string sello)
        {
            List<DetalleFactura> lista = new List<DetalleFactura>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.disco.Where(p => p.SelloDiscografico == sello).ToList();
            return lista;
        }
        public static List<DetalleFactura> GetFecha( DateTime Desde, DateTime Hasta)
        {
            List<DetalleFactura> lista = new List<DetalleFactura>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.disco.Where(p => p.FechaDeLanzamiento >= Desde && p.FechaDeLanzamiento<=Hasta).ToList();
            return lista;
        }
    }
}
