namespace NordicMagaza.Models
{
    public class Store
    {

        public string Title { get; set; } // başlık
        public string Summary { get; set; } // özet
        public string Content { get; set; } // içerik
        public string ImgUrl { get; set; } // ürün resmi
        public string Slug { get; set; } //kullanıcı dostu açıklama
    }
}
