using System;

namespace Trees.Model
{

    public class Node
    {
        Node parent=null;
        Node left=null;
        Node right=null;
        data data = null;
        Boolean root = true;

        public Node(Node parent, Node left, Node right, data d)
        {
            this.parent = parent;
            this.left = left;
            this.right = right;
            this.data = d;
            if(parent != null){this.root = false;}
        }

        public Node(Node parent, Node left, Node right, int ID, Object o)
        {
            this.parent = parent;
            this.left = left;
            this.right = right;
            this.data = new data(ID, o);
            if(parent != null){this.root = false;}
        }

        public Node(Node parent, data d)
        {
            this.parent = parent;
            this.left = null;
            this.right = null;
            this.data = d;
            if(parent != null){this.root = false;}
        }

        public Node(Node parent, int ID, Object o)
        {
            this.parent = parent;
            this.left = null;
            this.right = null;
            this.data = new data(ID, o);
            if(parent != null){this.root = false;}
        }
        public Node(int ID, Object o)
        {
            this.parent = null;
            this.left = null;
            this.right = null;
            this.data = new data(ID, o);
            this.root = true;
        }

        public Node(data d)
        {
            this.parent = null;
            this.left = null;
            this.right = null;
            this.data = d;
            this.root = true;
        }

        public void setParent(Node n)
        {
            this.parent = n;
        }

        public void setleft(Node n)
        {
            this.left = n;
        }

        public void setright(Node n)
        {
            this.right = n;
        }
        
    }
    
}