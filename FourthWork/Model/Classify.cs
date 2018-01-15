using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Classify
    {
        private int _id;
        private int _userId;
        private string _className;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        public string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }
    }
}
