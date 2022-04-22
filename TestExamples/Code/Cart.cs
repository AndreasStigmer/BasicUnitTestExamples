using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExamples.Code
{
    public class Cart : ICart
    {
        private List<CartItem> _list;

        public Cart()
        {
            _list = new List<CartItem>();
        }

        /// <summary>
        /// Returns a copy of all CartItems in the Cart
        /// </summary>
        /// <returns></returns>
        public List<CartItem> GetAllItems()
        {
            var list = new List<CartItem>();
            foreach (var item in _list)
            {
                list.Add(new CartItem { Item = new Product { Id = item.Item.Id, Name = item.Item.Name }, Qty = item.Qty });
            }
            return list;
        }

        /// <summary>
        /// Adds a product or increase number of a specified product in the cart
        /// </summary>
        /// <param name="product">The product object</param>
        public void AddProduct(Product product)
        {
            var item = FindItemById(product.Id);
            if (item == null)
            {
                _list.Add(new CartItem { Item = product, Qty = 1 });
                return;
            }
            item.Qty++;
        }

        /// <summary>
        /// Retrieves the CartItem containing the product with requested ProductID
        /// </summary>
        /// <param name="Id">The productid</param>
        /// <returns>CartItem with the specified productid or null if not found</returns>
        public CartItem FindItemById(Guid Id)
        {
            return _list.FirstOrDefault(x => x.Item.Id == Id);
        }

        /// <summary>
        /// Removes a CartItem containing the product with specified productid from the cart
        /// </summary>
        /// <param name="productId">ID of the product to be removed</param>
        public void RemoveProduct(Guid productId)
        {
            var item = FindItemById(productId);
            if (item == null)
            {
                _list.Remove(item);
            }
        }
    }

    /// <summary>
    /// Cartitem contains product and qty
    /// </summary>
    public class CartItem
    {
        public Product Item { get; set; }
        public int Qty { get; set; }
    }


    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        
    }
}
