
namespace GenericDoubleLinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ListItem<T>
    {
        internal ListItem<T> Next;
        internal ListItem<T> Previous;

        internal T Data;

        public ListItem(T data)
        {
            this.Data = data;
        }
    }
}