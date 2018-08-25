using RipKurrent.Web.API.Data;

namespace RipKurrent.Web.API.Services
{
    public class UnitConverterService
    {
        private readonly MeasuringUnitDB _measuringUnitDB;

        public UnitConverterService()
        {
            _measuringUnitDB = new MeasuringUnitDB();
        }

        public double ConvertUnit(double value, string type, string fromUnit, string toUnit)
        {
            var fromUnitFactor = _measuringUnitDB.FindMeasuringUnit(fromUnit, type).Factor;
            var toUnitFactor = _measuringUnitDB.FindMeasuringUnit(toUnit, type).Factor;
            return value * (fromUnitFactor / toUnitFactor);
        }
    }
}
