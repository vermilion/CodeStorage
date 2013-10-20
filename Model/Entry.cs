using System;

namespace Model
{
    public class Entry : ICloneable
    {
        public string Category;
        public string Code;
        public DateTime DateChanged;
        public string Description;
        public string Name;
        public string Lang;

        public Entry()
        {
            Lang = "Other";
            Code = string.Empty;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}