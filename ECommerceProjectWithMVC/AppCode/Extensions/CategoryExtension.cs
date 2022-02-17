using ECommerceProjectWithMVC.Models.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceProjectWithMVC.AppCode.Extensions
{
    static public partial class Extension
    {
        static public IEnumerable<Category> GetChildCategories(this Category parent)
        {
            if (parent.ParentId != null)
                yield return parent;

            foreach (var child in parent.Children.SelectMany(c => c.GetChildCategories()))
            {
                yield return child;
            }
        }
    }
}
