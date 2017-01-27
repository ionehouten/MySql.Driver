using System;

namespace MySql.Driver
{

    [Serializable]
    public class Entity
    {
        public Entity()
        {
            OPERATION = Operation.Create;
            NO = 0;
        }
        
        [Reference]
        public Int32 NO { get; set; }
        [Reference]
        public Object DATA { get; set; }
        [Reference]
        public Operation OPERATION { get; set; }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }

    [AttributeUsageAttribute(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = true)]
    public sealed class ReferenceAttribute : Attribute
    {
        public ReferenceAttribute() { }
    }
    [AttributeUsageAttribute(AttributeTargets.Class)]
    public sealed class EntityAttribute : Attribute
    {
        public EntityAttribute(Type type)
        {
            this.Type = type;
        }
        public Type Type{ get; }
    }
    public sealed class ViewAttribute : Attribute
    {
        public ViewAttribute(string name)
        {
            this.Name = name;
        }
        public string Name { get; }
        public string Schema { get; set; }
    }
    public sealed class FieldsAttribute : Attribute
    {
        public FieldsAttribute(string[] fields)
        {
            this.Fields = fields;
        }
        public string[] Fields { get; }
    }

    public enum Operation : int
    {
        ReadOnly = -1,
        Read = 0,
        Create = 1,
        Update = 2,
        Delete = 3,
        Detail = 4,
        Disable = 5,
        Cancel = 6,
        Revision = 7,
    }
}
