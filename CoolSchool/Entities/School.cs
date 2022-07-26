namespace CoreSchool.Entities
{

    class School
    {
        string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value.ToUpper();
            }
        }


        School(string schoolName)
        {
            name = schoolName;
        }

    }

}
