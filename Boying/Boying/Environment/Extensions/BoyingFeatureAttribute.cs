using System;

namespace Boying.Environment.Extensions
{
    [AttributeUsage(AttributeTargets.Class)]
    public class BoyingFeatureAttribute : Attribute
    {
        public BoyingFeatureAttribute(string text)
        {
            FeatureName = text;
        }

        public string FeatureName { get; set; }
    }
}