using FrontEnd.ApiModels;
using FrontEnd.Helpers.Interfaces;
using FrontEnd.Models;
using Newtonsoft.Json;

namespace FrontEnd.Helpers.Implementations
{
    public class ShipperHelper : IShipperHelper
    {
        IServiceRepository _IServiceRepository;

        public ShipperHelper(IServiceRepository serviceRepository)
        {
            _IServiceRepository = serviceRepository;
        }

        public List<ShipperViewModel> GetShippers()
        {
            HttpResponseMessage responseMessage = _IServiceRepository.GetResponse("api/Shipper");
            List<Shipper> shippers = new List<Shipper>();
            if(responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                shippers = JsonConvert.DeserializeObject<List<Shipper>>(content);
            }

            List<ShipperViewModel> resultado = new List<ShipperViewModel>();
            foreach (var item in shippers)
            {
                resultado.Add(
                    new ShipperViewModel
                    {
                        ShipperId = item.ShipperId,
                        CompanyName = item.CompanyName
                    }
                    );
            }
            return resultado;
        }

        public ShipperViewModel GetShipper(int id)
        {
            HttpResponseMessage responseMessage = _IServiceRepository.GetResponse("api/Shipper/" + id.ToString());
            Shipper shipper = new Shipper();
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                shipper = JsonConvert.DeserializeObject<Shipper>(content);
            }

            ShipperViewModel resultado = new ShipperViewModel
            {
                ShipperId = shipper.ShipperId,
                CompanyName = shipper.CompanyName

            };
        
            return resultado;
        }
    }
}
