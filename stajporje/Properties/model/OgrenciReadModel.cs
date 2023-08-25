using System.ComponentModel.DataAnnotations;

namespace stajproje.Properties.model
{
    public class OgrenciReadModel
    {
        [Key]
        public int ogrenciNo { get; set; }
        public string ogrenciAdi { get; set; }
        public string ogrenciSoyadi { get; set; }
        public int ogrenciYasi { get; set; }
        public DateTime DogumTarihi { get; set; }
    }
}
