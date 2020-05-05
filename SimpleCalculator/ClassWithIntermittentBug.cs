using System;

namespace Calculator
{
    public class ClassWithIntermittentBug
    {
        public void DoWork()
        {
            if (DateTime.Now.Ticks % 2 == 0)
            {
                throw new ApplicationException("Simulated Bug");
            }
        }
    }
}