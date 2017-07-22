using Newtonsoft.Json;


namespace Directory_Codejam
{
    public class Serilizable
    {
        public static string serializeobject(StudentInfo information)
        {
            return JsonConvert.SerializeObject(information);
        }
    }


}