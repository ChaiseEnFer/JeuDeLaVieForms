using System;
using System.Windows.Forms;
using System.Drawing;
namespace GraphiqueFromCode.Controls
{
    public class MainPanel : PictureBox
    {
        public MainPanel(int n)
        {
            Name = "pnl_main";
            BackColor = Color.Black;
            Anchor = AnchorStyles.None;
            Size = new Size(n*5, n*5);
            Dock = DockStyle.None;
        }
    }


}