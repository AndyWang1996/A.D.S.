using System;
namespace Trees.Model
{
    public class data
    {
        int ID = 0;
        Object o = null;

        public data (int ID, Object o)
        {
            this.ID = ID;
            this.o = o;
        }

        public int getID()
        {
            return this.ID;
        }

        public object getdata()
        {
            return this.o;
        }

    }
}