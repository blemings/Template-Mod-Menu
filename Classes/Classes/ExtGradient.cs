using System;
using UnityEngine;

namespace Template.Classes
{
    public class ExtGradient
    {
        public GradientColorKey[] colors = new GradientColorKey[]
        {
            new GradientColorKey(new Color32(37, 58, 28, 255), 0f),

        };

        public bool isRainbow = false;
        public bool copyRigColors = false;
    }
}
