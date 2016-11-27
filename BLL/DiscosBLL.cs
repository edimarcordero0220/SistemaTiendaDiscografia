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
        public static List<Discos> GetListaNombre(string tmp)
        {
            List<Discos> lista = new List<Discos>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.disco.Where(p => p.NombreDisco == tmp).ToList();
            return lista;
        }
        public static List<Discos> GetArtista(string tmp)
        {
            List<Discos> lista = new List<Discos>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.disco.Where(p => p.Artista == tmp).ToList();
            return lista;
        }
        public static List<Discos> GetLista()
        {
            List<Discos> lista = new List<Discos>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.disco.ToList();
            return lista;
        }
        public static List<Discos> GetLista(int IdDisco)
        {
            List<Discos> lista = new List<Discos>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.disco.Where(p => p.IdDisco == IdDisco).ToList();
            return lista;

        }
    }
}
