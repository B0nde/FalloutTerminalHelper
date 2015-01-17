using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FalloutTerminalHelper.Gui
{
    public partial class FalloutTerminalHelperGui : Form
    {
        private Helper helper;

        public FalloutTerminalHelperGui()
        {
            InitializeComponent();
            helper = new Helper(pbScreen.CreateGraphics());
        }

        private void btAddEntry_Click(object sender, EventArgs e)
        {
            try
            {
                var matches = Convert.ToInt32(tbMatches.Text);
                helper.AddEntry(new Entry(tbWord.Text, matches));
                helper.Draw();
            }
            catch (FormatException)
            {
            }
        }

        private void btCheck_Click(object sender, EventArgs e)
        {
            if (helper.Fits(tbCheckWord.Text))
                lMatches.Text = "It matches!";
            else
                lMatches.Text = "It does not match!";

            helper.Draw();
        }
    }
}
