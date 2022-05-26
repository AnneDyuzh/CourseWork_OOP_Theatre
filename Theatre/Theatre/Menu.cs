using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Theatre
{
    public partial class Menu : Form
    {

		public Menu()
		{

			using (var info = new Info())
			{
				info.ShowDialog();
			}

			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
            Events Event = new Events();
            Event.ShowDialog();
        }

        private void btn_actors_show_Click(object sender, EventArgs e)
        {
            Actors Actor = new Actors();
            Actor.ShowDialog();
        }
    }
}
