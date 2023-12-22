using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace School
{
    public partial class Form1 : Form
    {
        private string apiKey = "e447f1cf5b8f4e40ac1182855231912";
        private string location = "";
        private string apiUrl;

        public Form1()
        {
            InitializeComponent();
            apiUrl = $"http://api.weatherapi.com/v1/current.json?key={apiKey}&q={location}&aqi=no";

            // Hide the labels initially
            labelCityName.Visible = false;
            labelTemperature.Visible = false;
            labelCondition.Visible = false;
        }

        private void UpdateApiUrl()
        {
            location = textBox1.Text;
            apiUrl = $"http://api.weatherapi.com/v1/current.json?key={apiKey}&q={location}&aqi=no";
        }

        private async void pictureBox1_Click(object sender, EventArgs e)
        {
            await FetchAndDisplayWeatherInfo();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await FetchAndDisplayWeatherInfo();
        }

        private async Task FetchAndDisplayWeatherInfo()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        JObject weatherData = JObject.Parse(jsonResponse);

                        // Extract relevant information
                        string cityName = weatherData["location"]["name"].ToString();
                        string temperature = weatherData["current"]["temp_c"].ToString();
                        string condition = weatherData["current"]["condition"]["text"].ToString();
                        string iconUrl = weatherData["current"]["condition"]["icon"].ToString();

                        // Display weather information in labels
                        labelCityName.Text = $"City: {cityName}";
                        labelTemperature.Text = $"Temperature: {temperature}°C";
                        labelCondition.Text = $"Condition: {condition}";

                        // Show the labels
                        labelCityName.Visible = true;
                        labelTemperature.Visible = true;
                        labelCondition.Visible = true;

                        // Load the weather condition icon into pictureBox1
                        pictureBox1.ImageLocation = "http:" + iconUrl;
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateApiUrl();
        }
    }
}
