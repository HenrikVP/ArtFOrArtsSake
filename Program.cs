using Art.Model;

namespace Art
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Abstract classes cannot be instantiated.
            //ArtModel am = new ArtModel();

            //Instantiate, then add values to properties
            VisualArts va = new VisualArts();
            va.Artist = "Johannes Vermeer";
            va.Title = "Girl with a Pearl Earring";
            va.WeightInGrams = 1665;
            //Instantiate with values
            Dance d = new Dance()
            {
                Artist = "Tchaikovski",
                Title = "Swan Lake",
                DanceStyle = "Ballet",
                Venue = "The Royal Theatre"
            };
            //Empty constructor
            Music m = new Music();
            //Constructor with 2 parameters (instrument and artist)

            string t;
            t = "Her er endnu en string";

            string s = "Her er en string";
            List<string> list = new List<string>() { "Her er en tredje string", "Og en fjerde" };
            list.Add(s);
            list.Add(t);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Music m2 = new Music(list, "Genghis Khan");
            Console.WriteLine(m2.Artist);
            Console.WriteLine(m2.ToString());
            
        }
    }
}