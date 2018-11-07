namespace DesignPatternsCSharp.Prototype
{
    using System;

    public abstract  class Item: ICloneable
    {
        public string title { get; set; }
        public double price { get; set; }
        public string url { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
