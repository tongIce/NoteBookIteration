using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Note
    {
        private int _id;
        private int _classifyId;
        private string _notes;
        private DateTime _time;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public int ClassifyId
        {
            get { return _classifyId; }
            set { _classifyId = value; }
        }
        public string Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }
        public DateTime Time
        {
            get { return _time; }
            set { _time = value; }
        }
    }
}
