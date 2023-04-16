using System;
using System.Drawing;
using System.Windows.Forms;

namespace LazyBrowser.UI
{
    internal class TabsWidget : TabControl
    {
        private Button newTabButton;
        public TabsWidget()
        {
            // Set the DrawMode property to OwnerDrawFixed to enable drawing of the tabs
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
            newTabButton = new Button();
            newTabButton.Text = "New Tab";
            newTabButton.Size = new System.Drawing.Size(75, 23);
            newTabButton.Location = new System.Drawing.Point(this.Right - newTabButton.Width - 5, this.Top + 3);
            newTabButton.Click += NewTabButton_Click;
            this.Controls.Add(newTabButton);
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
        private void NewTabButton_Click(object sender, EventArgs e)
        {
            // Add a new Tab to the TabControl when the button is clicked
            this.TabPages.Add(new TabPage("New Tab"));
            this.SelectedIndex = this.TabPages.Count - 1;
        }
    }
}
