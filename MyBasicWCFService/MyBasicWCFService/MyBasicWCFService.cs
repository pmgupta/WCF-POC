﻿

namespace MyBasicWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MyBasicWCFService : IMyBasicWCFService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
    }
}
