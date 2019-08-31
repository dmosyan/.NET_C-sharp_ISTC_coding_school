using System;
using System.Collections.Generic;
using System.Windows;
using System.Diagnostics;
using System.Net;
using System.Threading.Tasks;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void execute_Sync_Click(object sender, RoutedEventArgs eventArgs)
        {
            Stopwatch watch = Stopwatch.StartNew();
            RunDownloadSync();
            watch.Stop();
            long elapsedMS = watch.ElapsedMilliseconds;

            resultsWindow.Text = $"Total execution time: {elapsedMS}";
        }

        private async void execute_Async_Click(object sender, RoutedEventArgs eventArgs)
        {
            Stopwatch watch = Stopwatch.StartNew();
            await RunDownloadAsync();
            watch.Stop();
            long elapsedMS = watch.ElapsedMilliseconds;

            resultsWindow.Text = $"Total execution time: {elapsedMS}";
        }

        private List<string> PrepData()
        {
            List<string> output = new List<string>();
            resultsWindow.Text = "";

            output.Add("https://www.yahoo.com");
            output.Add("https://www.google.com");
            output.Add("https://www.microsoft.com");
            output.Add("https://www.cnn.com");
            output.Add("https://www.stackoverflow.com");

            return output;
        }

        private async Task RunDownloadAsync()
        {
            List<string> webistes = PrepData();
            foreach (string item in webistes)
            {
                WebsiteDataModel results = await Task.Run(() => DownloadWebsite(item));
                ReportWebsiteInfo(results);
            }
        }

        private void RunDownloadSync()
        {
            List<string> webistes = PrepData();
            foreach (string item in webistes)
            {
                WebsiteDataModel results = DownloadWebsite(item);
                ReportWebsiteInfo(results);
            }
        }

        private WebsiteDataModel DownloadWebsite(string websiteURL)
        {
            WebsiteDataModel output = new WebsiteDataModel();
            WebClient client = new WebClient();

            output.WebsiteURL = websiteURL;
            output.WebsiteData = client.DownloadString(websiteURL); //donwloading index page

            return output;
        }

        private void ReportWebsiteInfo(WebsiteDataModel data)
        {
            resultsWindow.Text += $"{data.WebsiteURL} downloaded: {data.WebsiteData.Length} characters long {Environment.NewLine}";
        }
    }
}
