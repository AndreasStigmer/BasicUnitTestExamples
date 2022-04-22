using System;
using System.Collections.Generic;

namespace TestExamples.Code
{
    public interface ICart
    {
        void AddProduct(Product product);
        CartItem FindItemById(Guid Id);
        List<CartItem> GetAllItems();
        void RemoveProduct(Guid productId);
    }
}