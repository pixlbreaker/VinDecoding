using Newtonsoft.Json;
using System;
using System.Collections;
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
            Console.WriteLine("Local Information:");
            LocalJSONRead();

            Console.WriteLine("\nRemote Information:");
            RemoteJSONRead();
        }

        /// <summary>
        /// Reads from a Remote Location
        /// </summary>
        public static void RemoteJSONRead() {
            // Try Catch
            try {
                
                // Uses the WebClient
                using (WebClient webClient = new System.Net.WebClient()) {

                    // Gets the JSON string
                    WebClient n = new WebClient();
                    var json = n.DownloadString(@"https://jsonplaceholder.typicode.com/comments");
                    var list = json.ToList();

                    // Creates a list of objects
                    var c = JsonConvert.DeserializeObject<List<RootObject>>(json);

                    Console.WriteLine("The JSON file is vaild\n");

                    // Prints the Information
                    Console.WriteLine("The First Name is {0}", c.First().name);
                    Console.WriteLine("The First Email is {0}", c.First().email);
                    Console.WriteLine("The First Body is {0}", c.First().body);
                }

            } catch (Exception ex) {

                // Error Information
                Console.WriteLine("An error occured with the JSON file.");
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    
        /// <summary>
        /// Reads from a Local Location
        /// </summary>
        public static void LocalJSONRead() {
            // Try Catch
            try {
                // Parses the file
                string json = File.ReadAllText(@"../../testVehicle.json");

                // Creates a new Vehicle
                RootObjectCar v = JsonConvert.DeserializeObject<RootObjectCar>(json);

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
    