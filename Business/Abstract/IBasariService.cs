using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBasariService
    {
        public Basari OgrencininBasarisi(int ogrenciID, int dersID);
        public void BasariEkle(Basari basari);
        public void BasariGuncelle(Basari basari);
    }
}
