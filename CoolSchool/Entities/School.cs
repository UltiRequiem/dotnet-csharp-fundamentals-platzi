namespace CoreSchool.Entities
{
    class School
    {
        public string name;
        public SchoolTypes type;

        public School(string schoolName, SchoolTypes schoolTypes = SchoolTypes.HighSchool) => (name, type) = (schoolName, schoolTypes);

        public override string ToString() => $"{name} - {type}";
    }

}
