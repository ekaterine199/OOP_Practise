namespace OOP_Practise.Task_1
{
    public class Student
    {
        private readonly string _name;
        private readonly string _surname;
        private readonly string _personalNumber;
        private readonly List<Subject> _currentSubjects;
        private readonly List<Semester> _semesters;


        public Student()
        {
            _name = "";
            _surname = "";
        }
        public Student(string name)
        {
            _name = name;
        }

        public Student(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }

        public Student(string name, string surname, List<Subject> currentSubjects)
        {
            _name = name;
            _surname = surname;
            _currentSubjects = currentSubjects;
        }

        public Student(string name, string surname, string personalNumber, List<Subject> currentSubjects)
        {
            _name = name;
            _surname = surname;
            if (personalNumber.ToString().Length == 11)
            {
                _personalNumber = personalNumber;
            }
            else
            {
                throw new Exception("Personal number must contain 11 digits!");
            }
            if (calculateCredits(currentSubjects) <= 35)
            {
                _currentSubjects = currentSubjects;
            }
            else
            {
                throw new Exception("Credists must be less than 35!");
            }
            _semesters = new List<Semester>();
        }


        public string PrintFullName(string name, string surname)
        {
            string fullName = name + " " + surname;
            return fullName;
        }
        public int calculateCredits(List<Subject> currentSubjects)
        {
            int sumOfCredits = 0;
            foreach (var subj in currentSubjects)
            {
                sumOfCredits += subj.getCredits();
            }
            return sumOfCredits;
        }

        public void AddSemester(Semester newSemester)
        {

            if (_semesters.Contains(newSemester))
            {
                throw new Exception("This semester already exists!");
            }
            else
            {
                _semesters.Add(newSemester);
            }

        }

        public void AddSubjectInSpecificSemester(int semester, Subject subject)
        {
            int semesterCount = _semesters.Count();
            if (semesterCount > semester)
            {
                _semesters[semester].AddSubject(subject);
            }
            else
            {
                //In case we want to add new semester and add subject there
                //List<Subject> subjects = new List<Subject>();
                //subjects.Add(subject);
                //Semester newSemester = new Semester(semester, subjects);
                //_semesters.Add(newSemester);

                throw new Exception("This semester does not exist!");
            }
        }

        public string SemesterInfo()
        {
            string allSemesters = "";
            for (int i = 0; i < _semesters.Count(); i++)
            {
                allSemesters += $"{_semesters[i].GetSemesterNumber()}: {string.Join(", ", _semesters[i].printSubjects())}\n";
            }
            return allSemesters;
        }

        public override string ToString()
        {
            string allSubjects = string.Join(", ", _currentSubjects);
            string allSemester = string.Join(", ", _semesters);
            return $"{base.ToString()}\nname:{_name} \n surname:{_surname}" +
                $"\n personal number:{_personalNumber}" +
                $"\n subjects:{allSubjects}" +
                $"\n semesters:{allSemester}";
        }

    }
}
