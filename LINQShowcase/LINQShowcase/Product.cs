using System;
using System.Collections.Generic;
using System.Text;

namespace LINQShowcase
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateOnly AddToStockDate { get; set; }

        public string Category { get; set; }

        public bool IsActive { get; set; }

        public override string ToString()
        {
            return $"{Id}.....{Name}.....{Price}.....{Description}.....{AddToStockDate}.....{Category}.....{IsActive}";
        }
    }

    public class  ProductService
    {
        public List<Product> GetProducts() => new()
        {
            new(){ Id=1, Name="Dell XPS 15", Price=150000, Description="64 GB Ram 2 TB SSD ", IsActive = true, AddToStockDate= new DateOnly(2025,5,20), CreatedDate=DateTime.Now, Category="Bilgisayar"},
            new(){ Id=2, Name="Samsung Galaxy S25", Price=74990, Description="256 GB Depolama 12 GB RAM", IsActive = true, AddToStockDate= new DateOnly(2025,4,10), CreatedDate=DateTime.Now, Category="Elektronik"},
            new(){ Id=3, Name="Apple AirPods Pro 2", Price=12999, Description="Aktif Gürültü Engelleme USB-C", IsActive = true, AddToStockDate= new DateOnly(2025,3,15), CreatedDate=DateTime.Now, Category="Elektronik"},
            new(){ Id=4, Name="Sony WH-1000XM5", Price=14500, Description="Kablosuz Bluetooth Kulaklık", IsActive = true, AddToStockDate= new DateOnly(2025,6,1), CreatedDate=DateTime.Now, Category="Elektronik"},
            new(){ Id=5, Name="Logitech MX Master 3S", Price=4799, Description="Ergonomik Kablosuz Mouse", IsActive = false, AddToStockDate= new DateOnly(2025,2,20), CreatedDate=DateTime.Now, Category="Elektronik"},
            new(){ Id=6, Name="iPad Air M2", Price=44999, Description="11 inç Liquid Retina 256 GB", IsActive = true, AddToStockDate= new DateOnly(2025,5,5), CreatedDate=DateTime.Now, Category="Elektronik"},
            new(){ Id=7, Name="Slim Fit Erkek Gömlek", Price=1299, Description="Pamuklu Uzun Kollu Mavi", IsActive = true, AddToStockDate= new DateOnly(2025,4,25), CreatedDate=DateTime.Now, Category="Giyim"},
            new(){ Id=8, Name="Kadın Trençkot", Price=3750, Description="Bej Renk Kuşaklı Orta Boy", IsActive = true, AddToStockDate= new DateOnly(2025,3,10), CreatedDate=DateTime.Now, Category="Giyim"},
            new(){ Id=9, Name="Erkek Deri Ceket", Price=8500, Description="Siyah Hakiki Deri Slim Fit", IsActive = false, AddToStockDate= new DateOnly(2025,1,18), CreatedDate=DateTime.Now, Category="Giyim"},
            new(){ Id=10, Name="Kadın Yüksek Bel Jean", Price=1899, Description="Koyu Mavi Skinny Fit", IsActive = true, AddToStockDate= new DateOnly(2025,5,30), CreatedDate=DateTime.Now, Category="Giyim"},
            new(){ Id=11, Name="Unisex Oversize Sweatshirt", Price=999, Description="Siyah Kapüşonlu Pamuklu", IsActive = true, AddToStockDate= new DateOnly(2025,6,12), CreatedDate=DateTime.Now, Category="Giyim"},
            new(){ Id=12, Name="Ray-Ban Wayfarer Güneş Gözlüğü", Price=5250, Description="Polarize Cam Siyah Çerçeve", IsActive = true, AddToStockDate= new DateOnly(2025,5,1), CreatedDate=DateTime.Now, Category="Aksesuar"},
            new(){ Id=13, Name="Daniel Wellington Saat", Price=4200, Description="Classic 40mm Deri Kayış", IsActive = true, AddToStockDate= new DateOnly(2025,2,14), CreatedDate=DateTime.Now, Category="Aksesuar"},
            new(){ Id=14, Name="Erkek Deri Kemer", Price=850, Description="Siyah Otomatik Tokalı Hakiki Deri", IsActive = false, AddToStockDate= new DateOnly(2025,4,5), CreatedDate=DateTime.Now, Category="Aksesuar"},
            new(){ Id=15, Name="Kadın Deri El Çantası", Price=6990, Description="Bordo Gerçek Deri Omuz Askılı", IsActive = true, AddToStockDate= new DateOnly(2025,3,22), CreatedDate=DateTime.Now, Category="Aksesuar"},
            new(){ Id=16, Name="Şapka Bucket Hat", Price=450, Description="Bej Pamuklu Unisex Yazlık", IsActive = true, AddToStockDate= new DateOnly(2025,6,8), CreatedDate=DateTime.Now, Category="Aksesuar"},
             new(){ Id=16, Name="Şapka Bucket Hat", Price=450, Description="Bej Pamuklu Unisex Yazlık", IsActive = true, AddToStockDate= new DateOnly(2025,6,8), CreatedDate=DateTime.Now, Category="Aksesuar"}
        };
    }
}
