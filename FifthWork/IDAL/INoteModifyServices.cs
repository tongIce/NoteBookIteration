using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IDAL
{
    public interface INoteModifyServices
    {
        void setFontSize(RichTextBox textBox);
        void setFontColor(RichTextBox textbox);
        void insertPicture(RichTextBox textbox);
        void saveNote(RichTextBox textbox);
        void openNote(RichTextBox textBox);
    }
}
