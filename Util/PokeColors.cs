namespace BlazonDex.Util
{
    public class PokeColor
    {
        public static string GetTypeColor(string type)
        {
            string color=type switch
            {
                "bug"=>"#26de81",
                "dragon"=>"#ffeaa7",
                "electric"=>"#fed330",
                "fairy"=>"#FF0069",
                "fighting"=>"#30336b",
                "flying"=>"#81ecec",
                "grass"=>"#00b894",
                "ground"=>"#EfB549",
                "ghost"=>"#a55eea",
                "ice"=>"#74b9ff",
                "normal"=>"#95afc0",
                "poison"=>"#6c5ce7",
                "psychic"=>"#a29bfe",
                "rock"=>"#2d3436",
                "water"=>"#0190FF",
                "fire"=>"#f0932b",
                _ =>"#0190FF"
            };
            return color;
        }
    }
}