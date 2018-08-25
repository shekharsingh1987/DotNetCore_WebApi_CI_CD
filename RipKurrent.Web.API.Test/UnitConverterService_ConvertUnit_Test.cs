using RipKurrent.Web.API.Services;
using Xunit;

namespace RipKurrent.Web.API.Test
{
    public class UnitConverterService_ConvertUnit_Test
    {
        private readonly UnitConverterService _unitConverterService;
        public UnitConverterService_ConvertUnit_Test()
        {
            _unitConverterService = new UnitConverterService();
        }
        [Fact]
        public void ConvertCentimeterToMilliimeterMustGive_10()
        {
            double val = _unitConverterService.ConvertUnit(1, "length", "cm", "mm");
            Assert.Equal<double>(10, val);
        }

        [Fact]
        public void ConvertMilliimeterToCentimeterMustGive_0_1()
        {
            double val = _unitConverterService.ConvertUnit(1, "length", "mm", "cm");
            Assert.Equal<double>(0.1, val);
        }
    }
}
