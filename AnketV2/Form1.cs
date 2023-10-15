using System.Text.Json;

namespace AnketV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Worker> Workers = new List<Worker>() { };

        private void add_button_Click(object sender, EventArgs e)
        {
            if (name_txtbox.Text == "" || name_txtbox.Text == " ")
                MessageBox.Show("Name Can Not Be NULL or WhiteSpace ");
            else if (surname_txtbox.Text == "" || surname_txtbox.Text == " ")
                MessageBox.Show("Surname Can Not Be NULL or WhiteSpace ");
            else if (mail_txtbox.Text == "" || mail_txtbox.Text == " ")
                MessageBox.Show("Mail Can Not Be NULL or WhiteSpace ");
            else if (phone_txtbox.Text == "" || phone_txtbox.Text == " ")
                MessageBox.Show("Phone Can Not Be NULL or WhiteSpace ");

            foreach (Worker w in workers_listbox.Items)
            {
                if (w.Mail == mail_txtbox.Text)
                {
                    MessageBox.Show("This Mail Already Excists !");
                    return;
                }
            }


            Worker worker = new Worker(name_txtbox.Text, surname_txtbox.Text, mail_txtbox.Text, phone_txtbox.Text, dateTimePicker1.Value);
            Workers.Add(worker);

            if (workers_listbox.DataSource != null)
                workers_listbox.DataSource = null;

            workers_listbox.DataSource = Workers;

            name_txtbox.Text = "";
            surname_txtbox.Text = "";
            mail_txtbox.Text = "";
            phone_txtbox.Text = "";

        }

        private void filename_txtbox_Click(object sender, EventArgs e)
        {
            filename_txtbox.Text = "";
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (!filename_txtbox.Text.EndsWith(".json") || filename_txtbox.Text.Length <= 5)
            {
                MessageBox.Show("Your File Must Be a JSON file ! And Must Has Minimum 6 characthers inside !");
                return;
            }

            else
            {
                string jsonFormat = JsonSerializer.Serialize(Workers);
                File.WriteAllText(filename_txtbox.Text, jsonFormat);
                MessageBox.Show($"Data Was Saved To : {filename_txtbox.Text} - path", filename_txtbox.Text);
            }
        }

        private void load_button_Click(object sender, EventArgs e)
        {
            if (!filename_txtbox.Text.EndsWith(".json") || filename_txtbox.Text.Length <= 5)
            {
                MessageBox.Show("Your File Must Be a JSON file ! And Must Has Minimum 6 characthers inside !");
                return;
            }

            else
            {
                string dataFromJson = File.ReadAllText(filename_txtbox.Text);
                Workers = JsonSerializer.Deserialize<List<Worker>>(dataFromJson)!;

                if (workers_listbox.DataSource != null)
                    workers_listbox.DataSource = null;
                workers_listbox.DataSource = Workers;
            }
        }

        private void change_button_Click(object sender, EventArgs e)
        {
            if (name_txtbox.Text == "" || name_txtbox.Text == " ") {
                MessageBox.Show("Name Can Not Be NULL or WhiteSpace "); return;
            }
            else if (surname_txtbox.Text == "" || surname_txtbox.Text == " ") {
                MessageBox.Show("Surname Can Not Be NULL or WhiteSpace "); return; }

            else if (mail_txtbox.Text == "" || mail_txtbox.Text == " ") {
                MessageBox.Show("Mail Can Not Be NULL or WhiteSpace "); return; }

            else if (phone_txtbox.Text == "" || phone_txtbox.Text == " ") {
                MessageBox.Show("Phone Can Not Be NULL or WhiteSpace "); return;
            }



            foreach (Worker worker in Workers)
            {
                if(worker.Mail == mail_txtbox.Text)
                {
                    worker.Name = name_txtbox.Text;
                    worker.Surname = surname_txtbox.Text;
                    worker.Phone = phone_txtbox.Text;
                    worker.Date = dateTimePicker1.Value;

                    if (workers_listbox.DataSource != null) workers_listbox.DataSource = null;
                    workers_listbox.DataSource = Workers;

                    MessageBox.Show("Updated in List Box! Do not forget save this to file ! ");
                }
            }
          

        }
    }
}