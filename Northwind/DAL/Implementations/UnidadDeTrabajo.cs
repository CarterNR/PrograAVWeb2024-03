using DAL.Interfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        public IShipperDAL ShipperDAL { get; set; }
        public ISupplierDAL SupplierDAL { get; set; }
       
        private NorthwndContext _northWindContext;

        public UnidadDeTrabajo(NorthwndContext northWindContext,
                         IShipperDAL shipperDAL

             )
        {
            this._northWindContext = northWindContext;
            this.ShipperDAL = shipperDAL;

        }


        public bool Complete()
        {
            try
            {
                _northWindContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public void Dispose()
        {
            this._northWindContext.Dispose();
        }
    }
}
