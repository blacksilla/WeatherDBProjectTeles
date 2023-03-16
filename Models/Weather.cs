namespace WeatherDBProject.Models
{
    public class Weather
    {
        public string id;
        public string location;
        public string description;
        public double tempMax;
        public double tempMin;

        public string ID { get => id; set => id = value; }
        public string Location { get => location; set => location = value; }
        public string Description { get => description; set => description = value; }
        public double TempMax { get => tempMax; set => tempMax = value; }
        public double TempMin { get => tempMin; set => tempMin = value; }



    }
}
