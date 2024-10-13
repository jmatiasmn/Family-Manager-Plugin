using System;

namespace cbb.core
{
    /// <summary>
    /// The helper functions for converting length units in desired type.
    /// </summary>
    public static class LengthUnitConverter
    {
        #region public methods

        public static double ConvertToMetric(double value, LengthUnitType type, int decimals)
        {
            switch (type)
            {
                case LengthUnitType.milimiter:
                    return Math.Round(value * 304.8, decimals);
                case LengthUnitType.centimeter:
                    return Math.Round(value * 30.48, decimals);
                case LengthUnitType.decimeter:
                    return Math.Round(value * 3.048, decimals);
                case LengthUnitType.meter:
                    return Math.Round(value* 0.3048, decimals);
                case LengthUnitType.kilometer:
                    return Math.Round(value * 0.0003048, decimals);
                default:
                    return value;
            }
        }

        #endregion


    }
}
