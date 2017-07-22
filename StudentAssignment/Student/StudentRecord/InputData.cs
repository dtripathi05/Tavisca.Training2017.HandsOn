using System;


namespace Directory_Codejam
{
    public class InputData
    {
        StudentInfo studentInformation;
        public InputData()
        {
            studentInformation = new StudentInfo();
        }
        
        Validation validation = new Validation();
        public void PhoneNumber()
        {
            while (true)
            {
                Console.WriteLine("Enter Your Phone Number");
                string phoneNumber = Console.ReadLine();
                if (validation.ValidatePhoneNumber(phoneNumber))
                {
                    studentInformation.phone_number = phoneNumber;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        public void FullName()
        {
            while (true)
            {
                Console.WriteLine("Enter Your First name");
                string firstName = Console.ReadLine();
                if (validation.ValidateName(firstName))
                {
                    studentInformation.first_name = firstName;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            while (true)
            {
                Console.WriteLine("Enter Your Last name");
                string lastName = Console.ReadLine();
                if (validation.ValidateName(lastName))
                {
                    studentInformation.last_name = lastName;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        public void Email()
        {
            while (true)
            {
                Console.WriteLine("Enter your Email ID");
                string emailId = Console.ReadLine();
                if (validation.ValidateEmail(emailId))
                {
                    studentInformation.emailAddress = emailId;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

            }
        }
        public void Address()
        {
            while (true)
            {
                Console.WriteLine("Enter Your Address");
                string inputAddress = Console.ReadLine();
                if (validation.ValidateAddress(inputAddress))
                {
                    studentInformation.address = inputAddress;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        public void DOB()
        {
            while (true)
            {
                Console.WriteLine(" Enter your Date of Birth");
                string inputDOB = Console.ReadLine();
                if (validation.ValidateDateOfBirth(inputDOB))
                {
                    //studentInformation.DOB = DateTime.Parse(inputDOB);
                    studentInformation.DOB = DateTime.ParseExact(inputDOB, "ddMMyyyy", System.Globalization.CultureInfo.InvariantCulture);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        public void MentorName()
        {
            while (true)
            {
                Console.WriteLine("Enter Mentor's Name");
                string mentorName = Console.ReadLine();
                if (validation.ValidateName(mentorName))
                {
                    studentInformation.mentor_name = mentorName;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
        public void EmergencyNumber()
        {
            while (true)
            {
                Console.WriteLine("Enter Your Phone Number");
                string emergencyNumber = Console.ReadLine();
                if (validation.ValidatePhoneNumber(emergencyNumber))
                {
                    studentInformation.emergency_number = emergencyNumber;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }

        public StudentInfo GetStudentInfoContext()
        {
            return studentInformation;
        }

       
    }


}