using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infragistics.Win.UltraWinEditors;
using System.ComponentModel;

namespace SmileBase.DerivedControls
{
    public class DatePicker : UltraDateTimeEditor
    {
        [Browsable(true)]
        [Category("Input")]
        public bool IsMandatory { get; set; }
    }
}
