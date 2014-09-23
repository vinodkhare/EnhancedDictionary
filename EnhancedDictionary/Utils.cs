using System;

namespace VK
{
    public static class Utils
    {
        public static T Create<T>()
        {
            var constructor = (typeof (T)).GetConstructor(Type.EmptyTypes);

            if (ReferenceEquals(constructor, null))
            {
                //there is no default constructor
                return default(T);
            }
            //there is a default constructor
            //you can invoke it like so:
            return (T) constructor.Invoke(new object[0]);
            //return constructor.Invoke(new object[0]) as T; //If T is class
        }
    }
}