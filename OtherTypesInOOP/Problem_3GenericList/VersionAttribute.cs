using System;


namespace Problem_3GenericList
{

    [AttributeUsage(
            AttributeTargets.Struct |
            AttributeTargets.Class |
            AttributeTargets.Interface |
            AttributeTargets.Method |
            AttributeTargets.Enum)]
    public class VersionAttribute : System.Attribute
    {

        public string Version { get; private set; }

        public VersionAttribute(int major, int minor)
        {
            this.Version = string.Format("{0}.{1}", major, minor);
        }

        public override string ToString()
        {
            return Version;
        }
    }
}
