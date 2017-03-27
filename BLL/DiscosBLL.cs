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
        

        public static void Insertar(Discos d)
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
        public static void Eliminar(Discos d)
        {
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            Discos disc = new Discos();
            db.disco.Remove(disc);
            db.SaveChanges();
        }
        public static Discos Buscar(int Id)
        {
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            return db.disco.Find(Id);
        }
        public static void Eliminar(int v)
        {
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            Discos dis = db.disco.Find(v);
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
        public static List<Discos> GetLista()
        {
            List<Discos> lista = new List<Discos>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.disco.ToList();
            return lista;

        }
        public static List<Discos> GetListaId(int discoId)
        {
            List<Discos> lista = new List<Discos>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.disco.Where(p => p.IdDisco == discoId).ToList();
            return lista;
        }
        public static List<Discos> GetListaNombre(string nombre)
        {
            List<Discos> lista = new List<Discos>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.disco.Where(p => p.NombreDisco == nombre).ToList();
            return lista;
        }
        public static List<Discos> GetArtista(string artista)
        {
            List<Discos> lista = new List<Discos>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.disco.Where(p => p.Artista == artista).ToList();
            return lista;
        }
        public static List<Discos> GetProductor(string productor)
        {
            List<Discos> lista = new List<Discos>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.disco.Where(p => p.Productor == productor).ToList();
            return lista;
        }
        public static List<Discos> GetSello(string sello)
        {
            List<Discos> lista = new List<Discos>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.disco.Where(p => p.SelloDiscografico == sello).ToList();
            return lista;
        }
        public static List<Discos> GetFecha( DateTime Desde, DateTime Hasta)
        {
            List<Discos> lista = new List<Discos>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.disco.Where(p => p.FechaDeLanzamiento >= Desde && p.FechaDeLanzamiento<=Hasta).ToList();
            return lista;
        }
    }
}
