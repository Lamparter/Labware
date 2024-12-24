using System;
using System.Globalization;

namespace Riverside.Labware
{
    [AttributeUsage(AttributeTargets.Assembly)]
    internal class BuildDateAttribute(string value) : Attribute
    {
        public DateTime DateTime { get; } = DateTime.ParseExact(value, "yyyyMMddHHmmss", CultureInfo.InvariantCulture, DateTimeStyles.None);
    }
}
