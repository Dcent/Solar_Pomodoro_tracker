using System;
using System.Collections.Generic;
using LuxaforSharp;

namespace Solar_Pomodoro.Core.Models
{
    public class PreloadedColors
    {

        public Dictionary<string, Color> ColorsMap { get; }

        public PreloadedColors()
        {
            ColorsMap = new Dictionary<string, Color>();
            ColorsMap.Add("Red", new Color(255, 0, 0));
            ColorsMap.Add("Green", new Color(0, 255,0));
            ColorsMap.Add("Blue", new Color(0, 0, 255));
        }
    }
}
