using System;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Theatre
{
    public partial class Events : Form
    {

        const string FILE_EVENTS = "Events.json";
        const string FILE_ACTORS = "ACTORS.json";
        int number = 0;
        int n_event = 0;
        public Events()
        {
            Task.Run(() => File.Open(FILE_EVENTS, FileMode.OpenOrCreate).Close());

            Task.Run(() => File.Open(FILE_ACTORS, FileMode.OpenOrCreate).Close());

            InitializeComponent();
        }

        //запись в файл json
        async Task WriteToFile<T>(List<T> data, string FILE_NAME)
        {
            using (var streamWriter = new StreamWriter(FILE_NAME, false))
            {
                await streamWriter.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(data)));
            }
        }

        //чтение из файла json
        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () => JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync()) ?? new List<T>());
            }
        }

        void Control_Click(object sender, EventArgs e) => (sender as Control).BackColor = Color.White;

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        async void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_EVENTS))
            {

                var table_of_events = await ReadFromFile<InfoEvents>(FILE_EVENTS);

                n_event = table_of_events.Count;
                count_of_events.Text = Convert.ToString(n_event);

                if (table_of_events != null)

                    foreach (var events in table_of_events)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[number].Cells[0].Value = events.NameEvent;
                        dataGridView1.Rows[number].Cells[1].Value = events.TypeEvent;
                        dataGridView1.Rows[number].Cells[2].Value = events.CountActors;
                        dataGridView1.Rows[number].Cells[3].Value = events.CountTickets;
                        dataGridView1.Rows[number].Cells[4].Value = events.Price;
                        dataGridView1.Rows[number].Cells[5].Value = events.Rating;
                        number++;
                    }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        async void button_add_Click(object sender, EventArgs e)
        {
            Add_event FormAdd = new Add_event();
            FormAdd.ShowDialog();

            string nameEventForm = Add_event.NameEventForm;
            string typeEventForm = Add_event.TypeEventForm;
            uint countActorsForm = Add_event.CountActorsForm;
            uint countTicketsForm = Add_event.CountTicketsForm;
            uint priceForm = Add_event.PriceForm;
            string ratingForm = Add_event.RatingForm;

            var actors = await ReadFromFile<InfoActors>(FILE_ACTORS);

            InfoEvents newEvent = new InfoEvents(nameEventForm, typeEventForm, countActorsForm, countTicketsForm, priceForm, ratingForm);

            if (!string.IsNullOrEmpty(nameEventForm) && !string.IsNullOrEmpty(typeEventForm) && (countActorsForm > 0) && (countTicketsForm > 0)
            && (priceForm>0) && !string.IsNullOrEmpty(ratingForm))
            {
                
                var events = await ReadFromFile<InfoEvents>(FILE_EVENTS);
                
                if (countActorsForm > actors.Count)
                {
                    MessageBox.Show($"Мероприятие  <{nameEventForm}>  не может быть добавлено, " +
                        $"так как в базе театра только {actors.Count} актёров, а для вашего мероприятия их требуется" +
                        $" {countActorsForm}. " +
                        $"                                                                         " +
                        $"Совет: На вкладке <Учёт актёров> добавьте ещё необходимое количество людей!"
                                , "Добавление записи", 0, MessageBoxIcon.Information);
                }
                else if (!events.Contains(newEvent))
                {
                    foreach (var eve in events)
                    {
                        if (eve.NameEvent == nameEventForm)
                        {
                            MessageBox.Show($"Мероприятие с таким названием  <{eve.NameEvent}>  уже есть в базе Театра. " 
                                , "Добавление записи", 0, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    events.Add(newEvent);

                    n_event = events.Count;
                    count_of_events.Text = Convert.ToString(n_event);

                    await WriteToFile(events, FILE_EVENTS);

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[number].Cells[0].Value = nameEventForm;
                    dataGridView1.Rows[number].Cells[1].Value = typeEventForm;
                    dataGridView1.Rows[number].Cells[2].Value = countActorsForm;
                    dataGridView1.Rows[number].Cells[3].Value = countTicketsForm;
                    dataGridView1.Rows[number].Cells[4].Value = priceForm;
                    dataGridView1.Rows[number].Cells[5].Value = ratingForm;
                    number++;
                }
                else
                {
                    MessageBox.Show($"Данное мероприятие было занесено в базу театра ранее", "Добавление мероприятие", 0, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        async void button_delete_Click(object sender, EventArgs e)
        {
            Int32 selectCount =
                        dataGridView1.GetCellCount(DataGridViewElementStates.Selected);

            if (selectCount > 0)
            {

                var events = await ReadFromFile<InfoEvents>(FILE_EVENTS);
                
                string name_event = dataGridView1.SelectedCells[0].Value.ToString();
                string type_event = dataGridView1.SelectedCells[1].Value.ToString();
                uint count_actors = Convert.ToUInt32(dataGridView1.SelectedCells[2].Value.ToString());
                uint count_tickets = Convert.ToUInt32(dataGridView1.SelectedCells[3].Value.ToString());
                uint price = Convert.ToUInt32(dataGridView1.SelectedCells[4].Value.ToString());
                string rating = dataGridView1.SelectedCells[5].Value.ToString();
                foreach (var eve in events)
                {
                    if (name_event == eve.NameEvent && type_event == eve.TypeEvent && count_actors == eve.CountActors
                        && count_tickets == eve.CountTickets && price == eve.Price && rating == eve.Rating)
                    {
                        events.Remove(eve);
                        n_event = events.Count;
                        count_of_events.Text = Convert.ToString(n_event);
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                        number--;
                        MessageBox.Show($"Мероприятие  <{eve.NameEvent}>  удалено!", "Удаление одного мероприятия", 0, MessageBoxIcon.Information);
                        break;
                    }
                }

                 await WriteToFile(events, FILE_EVENTS);
            }
            else
            {
                MessageBox.Show("Нет ни одного мероприятия!", "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }

        async void button_filtr_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(textFiltr.Text))
            {
                MessageBox.Show("Заполните поле!", "Фильтрация", 0, MessageBoxIcon.Information);
                textFiltr.BackColor = Color.MistyRose;
            }
            else
            {
                string filtr = textFiltr.Text;

                dataGridView1.Rows.Clear();
                number = 0;

                bool flag = false;

                var events = await ReadFromFile<InfoEvents>(FILE_EVENTS);

                foreach (var eve in events)
                {
                    if (eve.Rating == Convert.ToString(filtr))
                    {
                        flag = true;
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[number].Cells[0].Value = eve.NameEvent;
                        dataGridView1.Rows[number].Cells[1].Value = eve.TypeEvent;
                        dataGridView1.Rows[number].Cells[2].Value = eve.CountActors;
                        dataGridView1.Rows[number].Cells[3].Value = eve.CountTickets;
                        dataGridView1.Rows[number].Cells[4].Value = eve.Price;
                        dataGridView1.Rows[number].Cells[5].Value = eve.Rating;
                        number++;
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show($"Мероприятия с таким рейтингом {filtr} не найдены!", "Фильтрация", 0, MessageBoxIcon.Information);
                }
            }
        }

        async void button_no_filtr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textFiltr.Text))
            {
                MessageBox.Show($"Вы не применяли фильтрацию ранее!", "Фильтрация", 0, MessageBoxIcon.Information);
                return;
            }
            textFiltr.Text = "";
            dataGridView1.Rows.Clear();
            number = 0;

            var events = await ReadFromFile<InfoEvents>(FILE_EVENTS);

            foreach (var eve in events)
            {
              
                dataGridView1.Rows.Add();
                dataGridView1.Rows[number].Cells[0].Value = eve.NameEvent;
                dataGridView1.Rows[number].Cells[1].Value = eve.TypeEvent;
                dataGridView1.Rows[number].Cells[2].Value = eve.CountActors;
                dataGridView1.Rows[number].Cells[3].Value = eve.CountTickets;
                dataGridView1.Rows[number].Cells[4].Value = eve.Price;
                dataGridView1.Rows[number].Cells[5].Value = eve.Rating;
                number++;
            }
        }

        async void button_delete_all_Click(object sender, EventArgs e)
        {
            var events = await ReadFromFile<InfoEvents>(FILE_EVENTS);

            if (dataGridView1.Rows.Count != 0)
            {
                events.Clear();
                n_event = events.Count;
                count_of_events.Text = Convert.ToString(n_event);
                dataGridView1.Rows.Clear();
                number = 0;
                MessageBox.Show("Данные удалены!", "Удалить все мероприятия", 0, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Нет ни одного мероприятия!", "Удалить все мероприятия", 0, MessageBoxIcon.Information);
            }

            await WriteToFile(events, FILE_EVENTS);
        }

        private void textFiltr_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
