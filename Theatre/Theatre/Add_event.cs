using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Theatre
{
    public partial class Add_event : Form
    {

		public static string NameEventForm = "";
		public static string TypeEventForm = "";
		public static uint CountActorsForm = 0;
		public static uint CountTicketsForm = 0;
		public static uint PriceForm = 0;
		public static string RatingForm = "";

		public Add_event()
        {
            InitializeComponent();
        }

		bool CheckOnCorrectTextBox(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") && Regex.IsMatch(tb.Text, @"^[а-яА-Яa-zA-Z ]+$") || (tb.BackColor = Color.MistyRose) != Color.MistyRose;

		bool CheckOnCorrectComboBox(ComboBox cb) => !(cb.SelectedItem is null) || (cb.BackColor = Color.MistyRose) != Color.MistyRose;
		
		bool CheckOnCorrectNumberBox(TextBox nb) => uint.TryParse(nb.Text, out _) || (nb.BackColor = Color.MistyRose) != Color.MistyRose;

		bool FlagCorrect =>
			CheckOnCorrectTextBox(nameEvent) &
			CheckOnCorrectComboBox(typeEvent) &
			CheckOnCorrectNumberBox(actorEvent) &
			CheckOnCorrectNumberBox(numberPlaces) &
			CheckOnCorrectNumberBox(ticket) &
			CheckOnCorrectComboBox(raiting);

		void Control_Click(object sender, EventArgs e) => (sender as Control).BackColor = Color.WhiteSmoke;

		private void button_back_Click(object sender, EventArgs e)
        {
			NameEventForm = "";
			TypeEventForm = "";
			CountActorsForm = 0;
			CountTicketsForm = 0;
			PriceForm = 0;
			RatingForm = "";
			Close();
		}

        private void button_event_add_Click(object sender, EventArgs e)
        {

            if (FlagCorrect)
            {
                NameEventForm = nameEvent.Text;
                TypeEventForm = typeEvent.SelectedItem as string;
                CountActorsForm = Convert.ToUInt32(actorEvent.Text);
                CountTicketsForm = Convert.ToUInt32(numberPlaces.Text);
                PriceForm = Convert.ToUInt32(ticket.Text);
                RatingForm = raiting.SelectedItem as string;

                Close();
            }
			else
				MessageBox.Show($"Некорректные данные", "Добавление мероприятия", 0, MessageBoxIcon.Information);

		}
    }
}
