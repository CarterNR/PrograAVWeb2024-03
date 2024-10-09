using BackEnd.DTO;
using BackEnd.Services.Interfaces;
using DAL.Interfaces;
using Entities.Entities;

namespace BackEnd.Services.Implementations
{
    public class ShipperService : IShipperService
    {
        IUnidadDeTrabajo Unidad;
        public ShipperService(IUnidadDeTrabajo unidadDeTrabajo)
        {
            this.Unidad = unidadDeTrabajo;
        }

        #region
        Shipper Convertir (ShipperDTO shipper)
        {
            return new Shipper
            {
                ShipperId = shipper.ShipperId,
                CompanyName = shipper.CompanyName
            };
        }

        ShipperDTO Convertir(Shipper shipper)
        {
            return new ShipperDTO
            {
                ShipperId = shipper.ShipperId,
                CompanyName = shipper.CompanyName
            };
        }
        #endregion

        public bool Agregar(ShipperDTO shipper)
        {
            Shipper entity = Convertir (shipper);
            Unidad.ShipperDAL.Add(entity);
            return Unidad.Complete();
        }

        public bool Editar(ShipperDTO shipper)
        {
            var entity = Convertir (shipper);
            Unidad.ShipperDAL.Update(entity);
            return Unidad.Complete();
        }

        public bool Eliminar(ShipperDTO shipper)
        {
            var entity = Convertir(shipper);
            Unidad.ShipperDAL.Remove(entity);
            return Unidad.Complete();
        }

        public ShipperDTO Obtener(int id)
        {
            return Convertir(Unidad.ShipperDAL.Get(id));
        }

        public List<ShipperDTO> Obtener()
        {
            List<ShipperDTO> list = new List<ShipperDTO>();
            var shippers = Unidad.ShipperDAL.GetAll().ToList();

            foreach (var item in shippers)
            {
                list.Add(Convertir(item));
            }
            return list;
        }
    }
}
