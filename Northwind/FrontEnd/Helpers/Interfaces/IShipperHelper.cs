using FrontEnd.Models;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IShipperHelper
    {
        List<ShipperViewModel> GetShippers();

        ShipperViewModel GetShipper(int id);
    }
}
