namespace LinqExamples
{
    public class Person
    {
        public int Age { get; internal set; }
        public object Gender { get; internal set; }
        public string Name { get; internal set; }

        
    }

    internal class Gender
    {
        private Gender _gender;

        public static object Female { get; internal set; }
        public static object Male { get; internal set; }
        public static object Other { get; internal set; }

        public Gender gender 
        {
            get { return _gender; }
            set { _gender = value; }
        }

    }
}