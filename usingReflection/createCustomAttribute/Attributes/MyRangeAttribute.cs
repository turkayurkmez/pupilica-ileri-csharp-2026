namespace createCustomAttribute.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MyRangeAttribute : Attribute
    {
        public double Min { get; set; }
        public double Max { get; set; }
        public string Message { get; set; }

        public MyRangeAttribute(double min, double max, string message ="")
        {
            Min = min;
            Max = max;
            Message = string.IsNullOrEmpty(message) ? $"Bu alan {min} ile {max} arasında olmalıdır" : message;
        }

    }
}
