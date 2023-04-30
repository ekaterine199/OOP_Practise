namespace OOP_Practise.Task_1
{
    public class Subject
    {
        private readonly string _name;
        private readonly List<string> _prerequisits;
        private readonly int _credits;
        private readonly int _maxStudents;

        public Subject()
        {
            _name = "";
            _credits = 0;
            _maxStudents = 0;
        }

        public Subject(string name)
        {
            _name = name;
        }
        public Subject(int credits)
        {
            _credits = credits;
        }
        public Subject(string name, List<string> prerequisits, int credits, int maxStudents)
        {
            _name = name;
            _prerequisits = prerequisits;
            _credits = credits;
            _maxStudents = maxStudents;
        }
        public string getName()
        {
            return _name;
        }

        public int getCredits()
        {
            return _credits;
        }

        public override string ToString()
        {
            string allPrerequisits = string.Join(", ", _prerequisits);
            return $"name:{_name} \n" +
                $"prerequisits:{ allPrerequisits} \n credits:{_credits}";
        }

    }
}
