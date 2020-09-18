using System;
using System.Collections.Generic;
using System.Text;

namespace LiveCode.DeviceAnalogy.Take3
{

//TODO omskriv med interfaces


    class UsbDevice
    {

    }

    class ThunderboltDevice
    {

    

    class ExternalDrive : UsbDevice
    {

    }

    class Mouse : UsbDevice
    {

    }
    class Computer
    {
        public void PluginUsbDevice(UsbDevice dev)
        {

        }
    }

    class Ex
    {
        void foo()
        {
            Computer c = new Computer();
            c.PluginUsbDevice(new Mouse());
            c.PluginUsbDevice(new ExternalDrive());
        }
    }
}
