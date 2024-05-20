using System.Net;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {   
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return true;
                };

            var client = new HttpClient(handler);

            var cities = textBox3.Text.Split(',');

            textBox2.Clear();

            var tasks = new List<Task<string>>();

            foreach ( var city in cities ) 
            {
                var task = client.GetStringAsync(textBox1.Text);
                tasks.Add(task);
            }

            var timeoutTask = Task.Delay(2500);
            var allCompleted = Task.WhenAll(tasks);

            await Task.WhenAny(timeoutTask, allCompleted);

            if (timeoutTask.IsCompleted)
            {
                textBox2.Text = "Sorry, the server didn't respond in timely manner";
                return;
            }

            foreach (var task in tasks)
            {
                textBox2.Text += task.Result;
            }

        }
    }
}