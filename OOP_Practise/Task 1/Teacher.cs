namespace OOP_Practise.Task_1
{
    public class Teacher
    {
        private readonly string _name;
        private readonly string _surname;
        private readonly List<Subject> _subjects;


        public Teacher()
        {
            _name = "";
            _surname = "";
            _subjects = new List<Subject>();
        }
        public Teacher(string name, string surname)
        {
            _name = name;
            _surname = surname;
            _subjects = new List<Subject>();
        }
        public Teacher(string name, string surname, List<Subject> subjects)
        {
            _name = name;
            _surname = surname;
            if (subjects.Count() <= 3)
            {
                _subjects = subjects;
            }
            else
            {
                throw new Exception("Teacher should not be teaching more " +
                    "than 3 subjects!");
            }
        }

        public bool isCount3()
        {
            try
            {
                return _subjects.Count <= 3;
            }
            catch (Exception)
            {
                throw new Exception("Teacher should not be teaching more " +
                    "than 3 subjects!");
            }
        }


        public void AddSubject(Subject newSubject)
        {
            if (_subjects.Count < 3)
            {
                if (_subjects.Contains(newSubject))
                {
                    throw new Exception("This Teacher already teaches this subject!");
                }
                else
                {
                    _subjects.Add(newSubject);
                }
            }
            else
            {
                throw new Exception("Teacher should not be teaching more " +
                    "than 3 subjects!");
            }
        }

        public void ModifySubject(string oldSubject, Subject newSubject)
        {
            foreach (var subj in _subjects)
            {
                if (subj.getName() == oldSubject)
                {
                    _subjects.Remove(subj);
                    _subjects.Add(newSubject);
                    break;
                }
            }

            //if (_subjects.Contains(oldSubject))
            //{
            //    _subjects.Remove(oldSubject);
            //    _subjects.Add(newSubject);
            //}
            //else
            //{
            //    throw new Exception("This Subject Does Not Exist!");
            //}
        }

        public override string ToString()
        {
            string allSubjects = string.Join(", ", _subjects);
            return $"{base.ToString()}\nname:{_name} \n surname:{_surname} \n subjects:{allSubjects}";
        }
    }
}
