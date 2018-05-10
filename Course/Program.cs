using System;
using Course.Entities;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    string s = sr.ReadToEnd();
                    List<Post> list = JsonConvert.DeserializeObject<List<Post>>(s);
                    foreach (Post post in list) {
                        Console.WriteLine(post);
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            catch (JsonSerializationException e) {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
