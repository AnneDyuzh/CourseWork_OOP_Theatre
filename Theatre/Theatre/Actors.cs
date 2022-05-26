using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json;


namespace Theatre
{
    public partial class Actors : Form
    {
        const string FILE_EVENTS = "Events.json";
        const string FILE_ACTORS = "ACTORS.json";

        int n = 0;
        int numbers = 0;

        public Actors()
        {
            Task.Run(() => File.Open(FILE_ACTORS, FileMode.OpenOrCreate).Close());

            Task.Run(() => File.Open(FILE_EVENTS, FileMode.OpenOrCreate).Close());

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

        private void button_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        async void button_add_actor_Click(object sender, EventArgs e)
        {
            Add_actor FormAddActor = new Add_actor();
            FormAddActor.ShowDialog();

            string actorForm = Add_actor.ActorForm;
            uint ageForm = Add_actor.AgeForm;
            uint workForm = Add_actor.WorkForm;
            string ratingForm = Add_actor.RatingForm;

            InfoActors newActor = new InfoActors(actorForm, ageForm, workForm, ratingForm);

            if (!string.IsNullOrEmpty(actorForm) && (workForm > 0) && (ageForm > 0) && !string.IsNullOrEmpty(ratingForm))
            {
                var actors = await ReadFromFile<InfoActors>(FILE_ACTORS);

                if (!actors.Contains(newActor))
                {
                    foreach (var act in actors)
                    {
                        if (act.Actor == actorForm)
                        {
                            MessageBox.Show($"Актёр {act.Actor} уже занесён в базу театра. "
                                , "Добавление актёра", 0, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    actors.Add(newActor);

                    n = actors.Count;
                    count_of_actors.Text = Convert.ToString(n);

                    await WriteToFile(actors, FILE_ACTORS);

                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[numbers].Cells[0].Value = actorForm;
                    dataGridView2.Rows[numbers].Cells[1].Value = ageForm;
                    dataGridView2.Rows[numbers].Cells[2].Value = workForm;
                    dataGridView2.Rows[numbers].Cells[3].Value = ratingForm;
                    numbers++;
                }
                else
                {
                    MessageBox.Show($"Этот актёр был занесён в базу театра ранее", "Добавление актёра", 0, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        async void Form2_Load(object sender, EventArgs e)
        {
            if (File.Exists(FILE_ACTORS))
            {

                var table_of_actors = await ReadFromFile<InfoActors>(FILE_ACTORS);

                n = table_of_actors.Count;
                count_of_actors.Text = Convert.ToString(n);

                if (table_of_actors != null)

                    foreach (var actor in table_of_actors)
                    {
                        dataGridView2.Rows.Add();
                        dataGridView2.Rows[numbers].Cells[0].Value = actor.Actor;
                        dataGridView2.Rows[numbers].Cells[1].Value = actor.Age;
                        dataGridView2.Rows[numbers].Cells[2].Value = actor.Work;
                        dataGridView2.Rows[numbers].Cells[3].Value = actor.Rating;
                        numbers++;
                    }
            }
        }

        async void button_delete_actor_Click(object sender, EventArgs e)
        {
            Int32 selectCount =
                        dataGridView2.GetCellCount(DataGridViewElementStates.Selected);

            if (selectCount > 0)
            {

                var actors = await ReadFromFile<InfoActors>(FILE_ACTORS);
                var count = actors.Count;
                var events = await ReadFromFile<InfoEvents>(FILE_EVENTS);
                var flag = true;

                foreach (var eve in events)
                {
                    if (eve.CountActors > count-1)
                    {
                        flag = false;
                        MessageBox.Show($"Вы не можете удалить актёра, так как" +
                            $" мероприятию  <{eve.NameEvent}> требуется {eve.CountActors} " +
                            $"актёров!", "Удаление одного актёра", 0, MessageBoxIcon.Information);
                        break;
                    }
                }

                string actor = dataGridView2.SelectedCells[0].Value.ToString();
                uint age = Convert.ToUInt32(dataGridView2.SelectedCells[1].Value.ToString());
                uint work = Convert.ToUInt32(dataGridView2.SelectedCells[2].Value.ToString());
                string rating = dataGridView2.SelectedCells[3].Value.ToString();

                if (flag)
                {
                    foreach (var act in actors)
                    {
                        if (actor == act.Actor && age == act.Age && work == act.Work && rating == act.Rating)
                        {
                            actors.Remove(act);
                            n = actors.Count;
                            count_of_actors.Text = Convert.ToString(n);
                            dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
                            numbers--;
                            MessageBox.Show($"Актёр  {act.Actor}  удалён!", "Удаление одного актёра", 0, MessageBoxIcon.Information);
                            break;
                        }
                    }

                    await WriteToFile(actors, FILE_ACTORS);
                }
            }
            else
            {
                MessageBox.Show("Нет ни одного актёра!", "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }

        async void button_delete_all_actor_Click(object sender, EventArgs e)
        {
            var actors = await ReadFromFile<InfoActors>(FILE_ACTORS);

            var events = await ReadFromFile<InfoEvents>(FILE_EVENTS);


            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("Нет ни одного актёра!", "Удалить всех актёров", 0, MessageBoxIcon.Information);
            }
            else if (events.Count > 0)
            {
                MessageBox.Show("Вы не можете удалить всех актёров, так как в базе театра есть мероприятия!",
                    "Удалить всех актёров", 0, MessageBoxIcon.Information);
            }
            else
            {
                actors.Clear();
                n = actors.Count;
                count_of_actors.Text = Convert.ToString(n);
                dataGridView2.Rows.Clear();
                numbers = 0;
                MessageBox.Show("Данные всех актёров удалены!", "Удалить всех актёров", 0, MessageBoxIcon.Information);
                
            }

            await WriteToFile(actors, FILE_ACTORS);
        }

        private void count_of_actors_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
