using Microsoft.AspNetCore.Components.Forms;

namespace TravelApp.Client
{


    public class Travel
    {
       
       public List<Day> days = new List<Day>();
    }

    public class Day
    {
        private static int counter;
        public string name;
        public List<Destination> Destinations { get; set; } = new List<Destination>();

        public Day() {
            counter++;
            var x = counter.ToString();
            name = "day " + x; 
        }
    }

    public class Destination
    {
        public string name { get; set; } = "none";
        public string location { get; set; } = "none";
        public string description { get; set; } = "none";
        public List<MyImage> Images= new();
    }

    public class MyImage
    {
        public string name;
        public string data;
        public MyImage(IBrowserFile file)
        {
            name = file.Name;
            var buffer = new byte[file.Size];
            file.OpenReadStream().ReadAsync(buffer);
            var mimeType = file.ContentType;
            data = $"data:{mimeType};base64,{Convert.ToBase64String(buffer)}";
        }
    }

}
