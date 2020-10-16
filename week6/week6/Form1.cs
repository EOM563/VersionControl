using System.Windows.Forms;
using week6.MnbServiceReference;
using week6.Entities;
using System.ComponentModel;

namespace week6
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Rates;
            harmadik();
        }
                
        private void harmadik()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response = mnbService.GetExchangeRates(request);


            var result = response.GetExchangeRatesResult;
        }

        

    }
}
