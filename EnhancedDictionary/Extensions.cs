using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VK
{
    public static class Extensions
    {
        public static bool Replace<T>(this IList<T> items, T oldItem, T newItem)
        {
            var oldItemIndex = items.IndexOf(oldItem);
            var result = items.Remove(oldItem);

            if (result)
            {
                items.Insert(oldItemIndex, newItem);
            }

            return result;
        }
    }
}
