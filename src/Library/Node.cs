using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node <T> 
    {
       
        private List<T> children = new List<T>();
        private T thing {get;set;} 

      

        public ReadOnlyCollection<T> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(T t)
        {
            
            this.thing= t;
        }

        public void AddChildren(T n)
        {
            this.children.Add(n);
        }
        
    }
}
