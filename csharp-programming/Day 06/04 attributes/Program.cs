using cshar_programming;
using System.Reflection;

namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Type personType = typeof(Person);
            PropertyInfo[] propertiesInfo = personType.GetProperties();
            foreach (var propertyInfo in propertiesInfo)
            {
                Attribute? commentAttribute = propertyInfo.GetCustomAttribute(typeof(CommentAttribute));
                if (commentAttribute != null)
                {
                    Console.WriteLine("{0} : {1}", propertyInfo.Name, ((CommentAttribute)commentAttribute).Text);
                }
            }
        }
    }
}

/*
 * What is reflection?
 * - Reflection provides objects (of type Type) that describe assemblies, modules, and types.
 * Use Type.GetMethods() to obtain MenthodInfo[] of all methods.
 * User Type.GetFields() to obtain FieldInfo[] of all fields.
 */