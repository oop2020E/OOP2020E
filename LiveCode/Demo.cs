using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace LiveCode
{
    //interface 

    interface ICommand
    {
        void Execute();
    }

    class Controllable
    {
        private void Refresh()
        {
            Console.Clear();

            Console.SetCursorPosition(10, pos);
            Console.WriteLine("X");
        }
        public ICommand MoveUpCommand => new MoveUpCommandImpl(this);
        public ICommand MoveDownCommand => new MoveDownCommandImpl(this);

        int pos = 0;

        private class MoveUpCommandImpl : ICommand
        {
            private Controllable controllable;

            public MoveUpCommandImpl(Controllable controllable)
            {
                this.controllable = controllable;
            }

            public void Execute()
            {
                controllable.pos++;
            }
        }

        private class MoveDownCommandImpl : ICommand
        {
            private Controllable controllable;

            public MoveDownCommandImpl(Controllable controllable)
            {
                this.controllable = controllable;
            }

            public void Execute()
            {
                controllable.pos--;
            }
        }
    }

    class App
    {

    }


    public class Demo
    {
        public void Run()
        {
        }
    }
}