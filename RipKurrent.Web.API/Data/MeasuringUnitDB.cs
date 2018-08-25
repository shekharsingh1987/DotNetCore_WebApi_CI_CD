using RipKurrent.Web.API.Model;
using System.Collections.Generic;
using System.Linq;

namespace RipKurrent.Web.API.Data
{
    public class MeasuringUnitDB
    {
        private readonly IEnumerable<MeasuringUnit> _measuringUnits;
        public MeasuringUnitDB()
        {
            _measuringUnits = new List<MeasuringUnit>()
            {
                new MeasuringUnit
                {
                    Id=1,
                    Name="millimeter",
                    ShortForm="mm",
                    BaseUnit="meter",
                    BaseUnitShortForm="m",
                    Type="length",
                    Factor=0.001
                },
                new MeasuringUnit
                {
                    Id=2,
                    Name="centimeter",
                    ShortForm="cm",
                    BaseUnit="meter",
                    BaseUnitShortForm="m",
                    Type="length",
                    Factor=0.01
                },
                new MeasuringUnit
                {
                    Id=3,
                    Name="decimeter",
                    ShortForm="dm",
                    BaseUnit="meter",
                    BaseUnitShortForm="m",
                    Type="length",
                    Factor=0.1
                },
                new MeasuringUnit
                {
                    Id=4,
                    Name="foot",
                    ShortForm="ft",
                    BaseUnit="meter",
                    BaseUnitShortForm="m",
                    Type="length",
                    Factor=0.3048
                }
            };

        }


        public IEnumerable<MeasuringUnit> GetAll()
        {
            return _measuringUnits;
        }

        public MeasuringUnit FindMeasuringUnit(string name, string type)
        {
            return _measuringUnits.First<MeasuringUnit>(x => (x.Name == name.ToLower() || x.ShortForm == name.ToLower()) && x.Type == type.ToLower());
        }

    }
}
