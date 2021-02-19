using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoExtensions.Extensions
{
    public static class DateTimeExtension
    {
        public static String GetFechaPersonalizadaString(this DateTime dateTime)
        {
            String fecha = dateTime.Year + "/" + dateTime.Month +
                "/" + dateTime.Day + " - " + dateTime.DayOfWeek;
            return fecha;
        }
    }
}
