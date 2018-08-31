using System;
using System.Collections.Generic;
using System.Text;

namespace _08StrategyPattern
{
    /// <summary>
    /// The "face" of all operations
    /// must be implemented for each (strategy) class the operation end function in this form.
    /// </summary>
    interface IStrategy
    {
        int Process(int[] dat);
    }
}
