using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace BLL
{
    public class UsuariosBLL
    {
        public static void Insertar(Usuarios u)
        {
            try
            {
                SistemaDiscograficoDb db = new SistemaDiscograficoDb();
                db.Usuario.Add(u);
                db.SaveChanges();
                db.Dispose();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public static void Eliminar(Usuarios u)
        {
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            Usuarios usu = db.Usuario.Find(u);

            db.Usuario.Remove(usu);
            db.SaveChanges();
        }
        public static Usuarios Buscar (int Id)
        {
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            return db.Usuario.Find(Id);
        }
        public static void Eliminar(int v)
        {
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            Usuarios usu = db.Usuario.Find(v);
            try
            {
                db.Usuario.Remove(usu);
                db.SaveChanges();

            }catch(Exception ex)
            {
                throw ex;
            }
        }
        public static List<Usuarios> GetListaNombre(string tmp)
        {
            List<Usuarios> lista = new List<Usuarios>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.Usuario.Where(p => p.NombreUsuario == tmp).ToList();
            return lista;
        }
        public static List<Usuarios> GetContrasena(string tmp)
        {
            List<Usuarios> lista = new List<Usuarios>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.Usuario.Where(p => p.Contrasena == tmp).ToList();
            return lista;
        }
        public static List<Usuarios> GetLista()
        {
            List<Usuarios> lista = new List<Usuarios>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.Usuario.ToList();
            return lista;
        }
        public static List<Usuarios> GetLista(int usuarioId)
        {
            List<Usuarios> lista = new List<Usuarios>();
            SistemaDiscograficoDb db = new SistemaDiscograficoDb();
            lista = db.Usuario.Where(p =>p.UsuarioId== usuarioId).ToList();
            return lista;

        }

    }
}
