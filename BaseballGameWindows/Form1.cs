using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseballGameWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 새창NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseGame bg = new BaseGame();
            bg.MdiParent = this; // this는 Form1를 뜻하고 bg에게 bg의 부모는 Form1를 알려주는 것을 뜻함
            bg.Show();
        }

        private void 종료XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close(); //== this.Close();
            //Application.Exit(); - 강제종료와 비슷해서 별로 안좋음
        }

        private void 계단식정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade); // 배치(레이아웃) Cascade==계단
        }

        private void 가로정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void 세로정렬ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);

        }

    }
}
