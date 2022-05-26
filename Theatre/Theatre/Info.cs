using System.Windows.Forms;

namespace Theatre
{
	public partial class Info : Form
	{
		public Info() => InitializeComponent();
		protected override bool ProcessCmdKey(ref Message message, Keys keys) => (DialogResult = DialogResult.OK) == DialogResult.OK;
	}
}
