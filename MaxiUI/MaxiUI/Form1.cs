using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using MaxiUI.Mappers;
using Newtonsoft.Json;

namespace MaxiUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var request = new Employee
            {
                Name = Name.Text,
                LastName = LastName.Text,
                DateOfBirth = DateTime.Parse(DateOfBirth.Value.ToShortDateString()),
                EmployeeNumber = Int32.Parse(EmployeeNumber.Text),
                Curp = Curp.Text,
                Ssn = Int32.Parse(Ssn.Text),
                Phone = Phone.Text,
                Nationality = Nationality.Text
            };

            var requestJson = JsonConvert.SerializeObject(request);

            var httpContent = new StringContent(requestJson, Encoding.UTF8, "application/json");

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7196/api/Employee/");

            var consumeApi = client.PostAsync("add", httpContent);
            consumeApi.Wait();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var request = new Employee
            {
                Name = Name.Text,
                LastName = LastName.Text,
                DateOfBirth = DateTime.Parse(DateOfBirth.Value.ToShortDateString()),
                EmployeeNumber = Int32.Parse(EmployeeNumber.Text),
                Curp = Curp.Text,
                Ssn = Int32.Parse(Ssn.Text),
                Phone = Phone.Text,
                Nationality = Nationality.Text
            };

            var requestJson = JsonConvert.SerializeObject(request);

            var httpContent = new StringContent(requestJson, Encoding.UTF8, "application/json");

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7196/api/Employee/");

            var consumeApi = client.PutAsync("update", httpContent);
            consumeApi.Wait();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var request = new Beneficiary
            {
                Name = Name.Text,
                LastName = LastName.Text,
                DateOfBirth = DateTime.Parse(DateOfBirth.Value.ToShortDateString()),
                Curp = Curp.Text,
                Ssn = Int32.Parse(Ssn.Text),
                Phone = Phone.Text,
                Nationality = Nationality.Text,
                ParticipationPercentage = Int32.Parse(ParticipationPercentage.Text)
            };

            var requestJson = JsonConvert.SerializeObject(request);

            var httpContent = new StringContent(requestJson, Encoding.UTF8, "application/json");

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7196/api/Beneficiary/");

            var consumeApi = client.PostAsync("add", httpContent);
            consumeApi.Wait();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var request = new Beneficiary
            {
                Name = Name.Text,
                LastName = LastName.Text,
                DateOfBirth = DateTime.Parse(DateOfBirth.Value.ToShortDateString()),
                Curp = Curp.Text,
                Ssn = Int32.Parse(Ssn.Text),
                Phone = Phone.Text,
                Nationality = Nationality.Text,
                ParticipationPercentage = Int32.Parse(ParticipationPercentage.Text)
            };

            var requestJson = JsonConvert.SerializeObject(request);

            var httpContent = new StringContent(requestJson, Encoding.UTF8, "application/json");

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7196/api/Beneficiary/");

            var consumeApi = client.PostAsync("update", httpContent);
            consumeApi.Wait();

        }
    }
}
