using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TestVinDecoder {
    public static class Program {

        public static void Main(string[] args) {

            HttpClient client = new HttpClient();

            // Try Catch
            try {
                // Parses the file
                string json = File.ReadAllText(@"../../testVehicle.json");

                // Creates a new Vehicle
                RootObject v = JsonConvert.DeserializeObject<RootObject>(json);

                Console.WriteLine("The JSON file is vaild\n");
                // Prints the Car information
                Console.WriteLine("The Vehicle Make {0}", v.make.name);
                Console.WriteLine("The Vehicle Model {0}", v.model.name);
                Console.WriteLine("The Vehicle Year {0}", v.years.First().year);
                Console.WriteLine("The Vehicle VIN {0}", v.vin);
                Console.WriteLine("The Vehicle Trim {0}", v.years.First().styles.First().trim);

            } catch (Exception ex) {
                
                Console.WriteLine("An error occured with the JSON file.");
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
        
    }
}
    