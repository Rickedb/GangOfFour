using System;

namespace GangOfFour.Prototype
{
    public class ProtoCloner
    {
        protected virtual ProtoCloner clone()
        {
            return (ProtoCloner)this.MemberwiseClone();
        }

        public static T clone<T>(T obj)
        {
            var instance = Activator.CreateInstance<T>();
            var properties = obj.GetType().GetProperties();

            foreach(var prop in properties)
                prop.SetValue(instance, prop.GetValue(obj));

            return instance;
        }
    }
}
