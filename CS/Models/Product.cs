using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

public class Product {
    public int ProductID { get; set; }
    [Required(ErrorMessage = "Product Name is required")]
    public string ProductName { get; set; }
    [Required(ErrorMessage = "Unit Price is required")]
    public decimal? UnitPrice { get; set; }
    [Required(ErrorMessage = "Units On Order are required")]
    public short? UnitsOnOrder { get; set; }
}