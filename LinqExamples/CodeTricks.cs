namespace LinqExamples
{
    public class CodeTricks
    {
        public void Test()
        {
            Person person1 = new Person();

            bool hasName;

            if (person1.Name != null)
                hasName = true;
            else
                hasName = false;


            // Ternary if statement
            hasName = person1.Name != null ? true : false;

            // Null Propagation
            Person person2 = null;

            if (person2 != null && person2.Name != null)
                hasName = true;
            else
                hasName = false;

            // Null propagation
            hasName = (person2?.Name != null) ? true : false;

            // Null coalescing
            string name = "";

            if (person2 != null && person2.Name != null)
                name = person2.Name;
            else
                name = "Unknown";


            // Null coalescing
            name = person2?.Name ?? "Unknown";


            // Inline variable declaration
            string myAge = "30";
            int age;
            int selectedAge;

            if (int.TryParse(myAge, out selectedAge))
                age = selectedAge;


            // Inline variable declaration
            if (int.TryParse(myAge, out int selectedAge2))
                age = selectedAge2;

            if (!int.TryParse(myAge, out _)) return;



            // Pattern matching
            object person3 = new Person();
            if (person3 != null && person3 is Person)
            {
                Person tempPerson = (Person)person3;

                tempPerson.Name = "Martin";
            }


            // Pattern matching
            if (person2 is Person person4)
                person4.Name = "Martin";

            string name1 = "Name";

            switch (name1)
            {
                case string p when p.Length > 0:
                    break;

                case "Martin":
                    break;
            }
        }
    }
}
