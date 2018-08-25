namespace RipKurrent.Web.API.Model
{
    public class MeasuringUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortForm { get; set; }
        public string  Type { get; set; }
        public string BaseUnit { get; set; }
        public string BaseUnitShortForm { get; set; }
        public double Factor { get; set; }

    }
}
