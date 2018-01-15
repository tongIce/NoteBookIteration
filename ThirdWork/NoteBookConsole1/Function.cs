using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoteBookConsole1
{
    class Function
    {
        public delegate void NoteEventHandler(Object sender, EventArgs e);//声明委托
        public event NoteEventHandler NoteEvent;//声明事件
        public void Functioning()
        {
            //建立NoteEventArgs对象
            EventArgs e = new EventArgs();
            if (NoteEvent != null)
            {
                //如果有对象注册
                NoteEvent(this, e);//调用所有注册对象的方法 }
            }
        }

    }
}
