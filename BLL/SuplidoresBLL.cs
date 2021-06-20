using Pedidos_Registro.DAL;
using Pedidos_Registro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pedidos_Registro.BLL
{
    public class SuplidoresBLL
    {
        public static List<Suplidores> GetList(Expression<Func<Suplidores, bool>> suplidores)
        {
            Contexto db = new Contexto();
            List<Suplidores> Lista = new List<Suplidores>();

            try
            {
                Lista = db.Suplidores.Where(suplidores).ToList();
            }
            catch
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }

            return Lista;
        }
    }
}
