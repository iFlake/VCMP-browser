using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCMP_browser
{
    public partial class Dashboard : Form
    {
        int DragOffsetX = 0;
        int DragOffsetY = 0;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LabelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            DragOffsetX = Cursor.Position.X - Location.X;
            DragOffsetY = Cursor.Position.Y - Location.Y;

            DragTimer.Enabled = true;
        }

        private void LabelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            DragTimer.Enabled = false;
        }

        private void DragTimer_Tick(object sender, EventArgs e)
        {
            Location = new Point(Cursor.Position.X - DragOffsetX, Cursor.Position.Y - DragOffsetY);
        }
    }
}
