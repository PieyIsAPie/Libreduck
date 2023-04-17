using System;
using System.Drawing;
using System.Windows.Forms;

namespace LazyBrowser.UI
{
    public class TabsWidget : TabControl
    {
        private Button newTabButton;
        

        public TabsWidget()
        {
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            // Draw the Close button on the current Tab
            Rectangle closeButtonRect = new Rectangle(e.Bounds.Right - 15, e.Bounds.Top + 4, 12, 12);
            e.Graphics.DrawString("X", new Font("Microsoft Sans Serif", 8.25f), SystemBrushes.ControlText, closeButtonRect);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            // Check if the mouse was clicked on a Close button
            for (int i = 0; i < this.TabCount; i++)
            {
                Rectangle closeButtonRect = new Rectangle(this.GetTabRect(i).Right - 15, this.GetTabRect(i).Top + 4, 12, 12);
                if (closeButtonRect.Contains(e.Location))
                {
                    this.TabPages.RemoveAt(i);
                    break;
                }
            }
        }
    }
}
