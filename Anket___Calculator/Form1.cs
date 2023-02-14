using System.Text.Json;
using System;
using System.Text.RegularExpressions;

namespace Anket___Calculator
{
    public partial class Form1_Anket : Form
    {
        public Form1_Anket()
        {
            InitializeComponent();
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new("^[a-z]{3,20}$");

            if (regex.IsMatch(tb_name.Text))
            {
                tb_name.ForeColor = Color.Green;
            }
            else
            {
                tb_name.ForeColor = Color.Red;
            }
        }

        private void tb_surname_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new("^[a-z]{3,20}$");

            if (regex.IsMatch(tb_surname.Text))
            {
                tb_surname.ForeColor = Color.Green;
            }
            else
            {
                tb_surname.ForeColor = Color.Red;
            }
        }

        private void tb_fatherName_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new("^[a-z]{3,20}$");

            if (regex.IsMatch(tb_fatherName.Text))
            {
                tb_fatherName.ForeColor = Color.Green;
            }
            else
            {
                tb_fatherName.ForeColor = Color.Red;
            }
        }

        private void tb_country_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new("^[a-z]{3,20}$");

            if (regex.IsMatch(tb_country.Text))
            {
                tb_country.ForeColor = Color.Green;
            }
            else
            {
                tb_country.ForeColor = Color.Red;
            }
        }

        private void tb_city_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new("^[a-z]{3,20}$");

            if (regex.IsMatch(tb_city.Text))
            {
                tb_city.ForeColor = Color.Green;
            }
            else
            {
                tb_city.ForeColor = Color.Red;
            }
        }

        private void tb_phone_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$");
            if (regex.IsMatch(tb_phone.Text))
            {
                tb_phone.ForeColor = Color.Green;
            }
            else
            {
                tb_phone.ForeColor = Color.Red;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (tb_name.Text.Length > 3 && tb_surname.Text.Length > 3 && tb_fatherName.Text.Length > 3 && tb_country.Text.Length > 3 && tb_city.Text.Length > 3 && tb_phone.Text.Length > 9)
            {
                btn_save.Enabled = true;
                Person person = new()
                {
                    Name = tb_name.Text,
                    Surname = tb_surname.Text,
                    FatherName = tb_fatherName.Text,
                    Country = tb_country.Text,
                    City = tb_city.Text,
                    Phone = tb_phone.Text,
                    Date = dateTimePicker1.Value,
                    Gender = rb_male.Checked ? rb_male.Text : rb_female.Text,
                };

                var json = JsonSerializer.Serialize(person);
                File.WriteAllText($"{person.Name}.json", json);
                this.Controls.Clear();
                this.InitializeComponent();
            }
            else
            {
                MessageBox.Show("Anket bosh buraxila bilmez", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            try
            {
                var json = File.ReadAllText($"{tb_search.Text}.json");
                var obj = JsonSerializer.Deserialize<Person>(json);
                tb_name.Text = obj?.Name;
                tb_surname.Text = obj?.Surname;
                tb_fatherName.Text = obj?.FatherName;
                tb_country.Text = obj?.Country;
                tb_city.Text = obj?.City;
                tb_phone.Text = obj?.Phone;
                if (obj?.Gender == "Male")
                    rb_male.Select();
                else if (obj?.Gender == "Female")
                    rb_female.Select();


            }
            catch (Exception)
            {

                MessageBox.Show("File movcud deyil ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}