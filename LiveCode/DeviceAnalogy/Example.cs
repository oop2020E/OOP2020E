using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using LiveCode.DeviceAnalogy;

namespace LiveCode.DeviceAnalogy
{
    class Example
    {
        void Run()
        {
            #region Take1
            Take1.LogitechMouse lm = new Take1.LogitechMouse();
            Take1.Computer c = new Take1.Computer();
            c.PluginLogitechMouse(lm);
            #endregion

            #region Take2
            Take2.Computer c2 = new Take2.Computer();
            Take2.Mouse m = new Take2.LogitechMouse();
            #endregion


            Take3.Computer c3 = new Take3.Computer();
        }
    }
}
