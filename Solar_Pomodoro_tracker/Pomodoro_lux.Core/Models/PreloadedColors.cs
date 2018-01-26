using System;
using System.Collections.Generic;
using LuxaforSharp;

namespace Pomodoro_lux.Core.Models
{
    public class PreloadedColors
    {

        public Dictionary<string, Color> ColorsMap { get; }

        public PreloadedColors()
        {
            ColorsMap.Add("Red", new Color(255, 0, 0));
            ColorsMap.Add("Red", new Color(255, 0, 0));
            ColorsMap.Add("Red", new Color(255, 0, 0));
        }
    }
}
