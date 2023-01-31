using PuppeteerSharp;
using PuppeteerSharp.Media;
using System;
using System.Windows.Forms;

namespace WebPageToPdfV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var options = new LaunchOptions { Headless = true, IgnoreHTTPSErrors = true, Timeout = 10000 };

            using (var browserFetcher = new BrowserFetcher())
            {
                await browserFetcher.DownloadAsync();

                using (var browser = await Puppeteer.LaunchAsync(options))
                using (var page = await browser.NewPageAsync())
                {
                    await page.GoToAsync(edUrl.Text);
                    await page.WaitForSelectorAsync(edPath.Text);

                    var sd = new SaveFileDialog();
                    sd.DefaultExt = "pdf";
                    sd.Filter = "Pdf doc (.pdf)|*.pdf";
                    if (sd.ShowDialog() == DialogResult.OK)
                    {
                        var po = new PdfOptions()
                        {
                            Scale = 0.9M,
                            PreferCSSPageSize = true,
                            DisplayHeaderFooter = true,
                            MarginOptions = new MarginOptions() { Bottom = "20", Top = "20", Left = "50", Right = "50" }
                        };

                        await page.PdfAsync(sd.FileName, po);
                        System.Diagnostics.Process.Start(sd.FileName);
                    }
                }
            }
        }
    }
}
