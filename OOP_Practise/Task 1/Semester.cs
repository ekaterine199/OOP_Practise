namespace OOP_Practise.Task_1
{
    public class Semester
    {
        private readonly int _number;
        private readonly List<Subject> _subjects;

        public Semester()
        {
            _number = 1;
            _subjects = new List<Subject>();
        }

        public Semester(int number)
        {
            _number = number;
            _subjects = new List<Subject>();
        }
        public Semester(int number, List<Subject> subjects)
        {
            _number = number;
            _subjects = subjects;
        }

        public int GetSemesterNumber()
        {
            return _number;
        }

        public List<Subject> GetSubjects()
        {
            return _subjects;
        }

        public void AddSubject(Subject subject)
        {

            if (_subjects.Contains(subject))
            {
                throw new Exception("This semester already contans this subject!");
            }
            else
            {
                _subjects.Add(subject);
            }

        }

        public string printSubjects()
        {
            if (_subjects == null || _subjects.Count == 0)
            {
                return "No subjects found";
            }

            string allSubjects = "";
            for (int i = 0; i < _subjects.Count(); i++)
            {
                allSubjects += _subjects[i].getName() + ", ";
            }
            allSubjects = allSubjects.Substring(0, allSubjects.Length - 2);
            return allSubjects;
        }
    }
}
