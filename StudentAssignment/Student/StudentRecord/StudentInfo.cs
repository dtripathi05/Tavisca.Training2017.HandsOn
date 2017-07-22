using System;


namespace Directory_Codejam
{
    public class StudentInfo
    {
        public string phone_number { get; set; }
        public string emergency_number { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string emailAddress { get; set; }
        public DateTime DOB { get; set; }
        public string mentor_name { get; set; }
        public Guid Id()
        {
            return System.Guid.NewGuid();

        }

    }


}