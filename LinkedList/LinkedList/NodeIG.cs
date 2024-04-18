using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class NodeIG
    { 
        public IGPost value;
        public NodeIG next;
        public NodeIG(IGPost iGPost) 
        { 
            this.value = iGPost;
            this.next = null;
        
        }

    }
}
