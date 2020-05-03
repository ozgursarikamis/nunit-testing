using System;

namespace Calculator.Tests
{
    public enum SpecialDates
    {
        NewMillenium
    }

    public class SpecialDateStore
    { 
        public DateTime DateOf(SpecialDates specialDate)
        {
            switch (specialDate)
            {
                case SpecialDates.NewMillenium:
                    return new DateTime(2000, 1, 1, 0, 0, 0, 0);
                default:
                    throw new ArgumentOutOfRangeException(nameof(specialDate));
            }
        }
    }
}