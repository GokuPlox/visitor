using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node <T> 
    {
       
        private List<Node<T>> children = new List<Node<T>>();
        private T thing {get;set;} 

      

        public ReadOnlyCollection<Node<T>> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(T t)
        {
            
            this.thing= t;
        }

        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }
        
    }
}
