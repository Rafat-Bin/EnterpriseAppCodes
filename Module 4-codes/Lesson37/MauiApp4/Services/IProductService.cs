using MauiApp4.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp4.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product? GetProductById(int id);
    }
}
