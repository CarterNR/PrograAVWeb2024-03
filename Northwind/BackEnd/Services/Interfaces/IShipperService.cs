using BackEnd.DTO;

namespace BackEnd.Services.Interfaces
{
    public interface IShipperService
    {
        bool Agregar(ShipperDTO shipper);
        bool Editar(ShipperDTO shipper);
        bool Eliminar(ShipperDTO shipper);
        /// <summary>
        /// Obtiene Category por Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ShipperDTO Obtener(int id);

        /// <summary>
        /// Obtiene todas la categories
        /// </summary>
        /// <returns></returns>
        List<ShipperDTO> Obtener();
    }
}
