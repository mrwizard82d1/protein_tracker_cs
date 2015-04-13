using fit;

namespace ProteinTrackerDotNetFit
{
    public class HelloWorld : ColumnFixture
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
