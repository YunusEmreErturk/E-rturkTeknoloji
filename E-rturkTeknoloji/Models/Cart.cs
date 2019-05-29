using E_rturkTeknoloji.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_rturkTeknoloji.Models
{
    //    public class Cart
    //    {
    //        private List<CartLine> _cartLines;
    //        public List<CartLine> CartLines
    //        {
    //            get
    //            {
    //                return _cartLines;
    //            }
    //        }
    //        public void AddProduct(Product product, int quantity)

    //        {
    //            var line = _cartLines.Where(i => i.Product.Id == product.Id).FirstOrDefault();
    //            if (line==null)
    //            {
    //                _cartLines.Add(new CartLine() { Product = product, Quantity = quantity });
    //            }
    //            else
    //            {
    //                line.Quantity += quantity;
    //            }
    //        }

    //        public void DeleteProduct(Product product)
    //        {
    //            _cartLines.RemoveAll(i => i.Product.Id == product.Id);
    //        }

    //        public double Total()
    //        {
    //            return _cartLines.Sum(i => i.Product.Price * i.Quantity);
    //        }
    //        public void Clear()
    //        {
    //            _cartLines.Clear();
    //        }
    //    }
    //    public class CartLine
    //    {
    //        public Product Product { get; set; }
    //        public int Quantity { get; set; }
    //    }
    //}
    public class Cart
    {
        private List<CartLine> _cardLines = new List<CartLine>();

        public List<CartLine> CartLines
        {
            get { return _cardLines; }
        }

        public void AddProduct(Product product, int quantity)
        {
            var line = _cardLines.FirstOrDefault(i => i.Product.Id == product.Id);
            if (line == null)
            {
                _cardLines.Add(new CartLine() { Product = product, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void DeleteProduct(Product product)
        {
            _cardLines.RemoveAll(i => i.Product.Id == product.Id);
        }

        public double Total()
        {
            return _cardLines.Sum(i => i.Product.Price * i.Quantity);
        }

        public void Clear()
        {
            _cardLines.Clear();
        }
    }

    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}