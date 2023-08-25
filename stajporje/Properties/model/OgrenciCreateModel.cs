using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using stajproje.model;


namespace stajproje.Properties.model
{
    
        public class OgrenciCreateModel
        {
            [Key]
            public int ogrenciNo { get; set; }
            public string ogrenciAdi { get; set; }
            public string ogrenciSoyadi { get; set; }
            public int ogrenciYasi { get; set; }
            public DateTime DogumTarihi { get; set; }
        }


  
}
