using csharp_programming;
using static System.Net.Mime.MediaTypeNames;

namespace cshar_programming
{
    [Comment(Text = "Person Class")]
    internal class Person
    {
        [Comment(Text = "person Name")]
        public string Name { get; set; }

        [Comment(Text = "person age")]
        public int Age { get; set; }

        [Comment(Text = "Person Marital Status")]
        public bool Married { get; set; }

        [Comment(Text = "Is person graduate or undergraduate")]
        public bool IsGraduate { get; set; }

        public override string ToString()
        {
            return string.Format("name={0} , Age={1}, Married={2} , Graduated={3} ", Name, Age, Married, IsGraduate);
        }
    }
}