using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational_Patterns.Singleton
{
    public class Singleton
    {
        private int counter = 0;
        private static readonly Singleton _instance;

        private static object obj;
        public static Singleton Instance {
            get
            {
                if (_instance == null)
                    return new Singleton();

                return _instance;
            }
        }

        static Singleton()
        {
            if(_instance == null)
            {
                lock(obj){
                    if (_instance == null)
                        _instance = new Singleton();
                }
            }
        }

        public int GetCounter()
        {
            return counter++;
        }
    }
}
