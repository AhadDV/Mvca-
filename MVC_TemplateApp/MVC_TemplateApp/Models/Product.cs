namespace MVC_TemplateApp.Models;

public class Product
{


    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal StartPrice { get; set; }
    public decimal Price { get; set; }
    public double Rate { get; set; }
    public virtual ICollection<ProductPhoto> ProductPhotos { get; set; }
}

 
 