using Infragistics.Win.UltraWinEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmileBase.DerivedControls
{
    public class TextBox : UltraTextEditor
    {
        [Browsable(true)]
        [Category("Input")]
        public bool IsMandatory { get; set; }


    }
}
