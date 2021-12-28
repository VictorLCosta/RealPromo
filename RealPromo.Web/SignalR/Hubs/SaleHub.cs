using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using RealPromo.Web.Models.Entities;

namespace RealPromo.Web.SignalR.Hubs
{
    public class SaleHub : Hub
    {
        public async Task CreatePromo(Sale sale)
        {
            
        }
    }
}