using System;


namespace Items
{
    public abstract class Item
    {
        public string Name { get; private set; }
        public int Cost { get; private set; }
        public int Weight { get; private set; }
        // Attributes
        // Notes
        public string Description { get; private set; }
    }
}