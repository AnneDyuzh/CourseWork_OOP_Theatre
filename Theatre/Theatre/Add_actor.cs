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
    public partial class Add_actor : Form
    {

        public static string ActorForm = "";
        public static uint AgeForm = 0;
        public static uint WorkForm = 0;
        public static string RatingForm = "";

        public Add_actor()
        {
            InitializeComponent();
        }

        bool CheckOnCorrectTextBox(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
            Regex.IsMatch(tb.Text, @"^[А-ЯЁ]+[а-яё]+ ([А-ЯЁ]+[а-яё]* [А-ЯЁ]+[а-яё]*$|[А-ЯЁ][.] [А-ЯЁ][.]$|[А-ЯЁ][.][А-ЯЁ][.])") || (tb.BackColor = Color.MistyRose) != Color.MistyRose
            || (label5.Text = "Примеры ввода: Мишин Н К, Мишин Н.К.") != "Примеры ввода: Мишин Н К, Мишин Н.К.";

        bool CheckOnCorrectComboBox(ComboBox cb) => !(cb.SelectedItem is null) || (cb.BackColor = Color.MistyRose) != Color.MistyRose;

        bool CheckOnCorrectNumberBox(TextBox nb) => uint.TryParse(nb.Text, out _) || (nb.BackColor = Color.MistyRose) != Color.MistyRose
             /*|| (label7.Text = "Недопустимые символы") != "Недопустимые символы"*/;

        bool CheckOnCorrectNumberBox2(TextBox nb) => uint.TryParse(nb.Text, out _) || (nb.BackColor = Color.MistyRose) != Color.MistyRose
          /* || (label8.Text = "Недопустимые символы") != "Недопустимые символы"*/;

        bool FlagCorrect =>
            CheckOnCorrectTextBox(actor) &
            CheckOnCorrectNumberBox(age) &
            CheckOnCorrectNumberBox2(work) &
            CheckOnCorrectComboBox(raiting);

        void Control_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            label7.Text = "";
            label8.Text = "";
            (sender as Control).BackColor = Color.WhiteSmoke;

        }

        private void button_event_change_Click(object sender, EventArgs e)
        {
            if (FlagCorrect)
            {
                ActorForm = actor.Text;         
                AgeForm = Convert.ToUInt32(age.Text);
                WorkForm = Convert.ToUInt32(work.Text);
                RatingForm = raiting.SelectedItem as string;
                
                Close();

            }
            else
                MessageBox.Show($"Некорректные данные", "Добавление актёра", 0, MessageBoxIcon.Information);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            ActorForm = "";
            AgeForm = 0;
            WorkForm = 0;
            RatingForm = "";
            Close();
        }
    }
}
