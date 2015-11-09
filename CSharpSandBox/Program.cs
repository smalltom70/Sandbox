using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CSharpSandBox.Classes;
using Newtonsoft.Json;

namespace CSharpSandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new WebClient();

            var emailData = c.DownloadString("..\\..\\Data\\MassEmail.json");
            var d = new Dictionary<string,EmailData.RootObject>();

            d.Add("MassEmailCatalogue", JsonConvert.DeserializeObject<EmailData.RootObject>(emailData));
           
          



        }
    }
}
