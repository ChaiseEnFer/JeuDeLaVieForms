using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace JDLVF.Controls
{
    internal class Labrlll : Label
    {
        public Labrlll()
        {
            this.Text = " ";
            this.Font = new Font("Arial", 12, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.BackColor = Color.Black;
            this.AutoSize = true;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Height = 23;
            this.Width = 100;
        }
    }
}
