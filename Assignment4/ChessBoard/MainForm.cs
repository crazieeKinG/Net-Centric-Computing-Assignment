using System.Drawing;
using System.Windows.Forms;

namespace ChessBoard
{
    public partial class MainForm : Form
    {
        private ChessBox cbox = new ChessBox();
        private Graphics g;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {
            
            g = e.Graphics;
            cbox.Width = panel.Width / 8;
            cbox.Height = panel.Height / 8;
            DrawBoard(g);
        }

        private  void DrawBoard(Graphics g)
        {
            float posx = 0, posy = 0;
            for (int i = 0; i < 8; i++)
            {
                posy = i * cbox.Height;
                for (int j = 0; j < 8; j++)
                {
                    posx = j * cbox.Width;
                    if ((i + j) % 2 != 0)
                        cbox.Draw(g, posx, posy, Brushes.White);
                    else
                        cbox.Draw(g, posx, posy, Brushes.Black);
                }
            }
        }

        private void Panel_Resize(object sender, System.EventArgs e)
        {
            panel.Invalidate();
        }
    }
}
