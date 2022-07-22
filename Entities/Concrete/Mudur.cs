using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Mudur:IEntity
    {
        public int MudurID { get; set; }        
        public string MudurAd { get; set; }        
        public string MudurSoyad { get; set; }        
        public string MudurTcNo { get; set; }
        public string MudurSifre { get; set; }
    }
}
