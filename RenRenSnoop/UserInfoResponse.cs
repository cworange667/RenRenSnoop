using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RenRenSnoop
{
    public class UserInfoResponse
    {
        public UserInfo response;
    }
    public class UserInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public Avatar[] avatar { get; set; }
        public string star { get; set; }
        public BasicInformation basicInformation { get; set; }
        public Education[] education { get; set; }
        public Work[] work { get; set; }
        public string emotionalState { get; set; }
    }

    public class Avatar
    {
        public string size { get; set; }
        public string url { get; set; }
    }
    public class BasicInformation
    {
        public string sex { get; set; }
        public string birthday { get; set; }
        public HomeTown homeTown { get; set; }
    }
    public class HomeTown
    {
        public string province { get; set; }
        public string city { get; set; }
    }
    public class Education
    {
        public string name { get; set; }
        public string year { get; set; }
        public string educationBackground { get; set; }
        public string department { get; set; }
    }
    public class Work
    {
        public string name { get; set; }
        public string time { get; set; }
    }
    public enum EducationBackground
    {
        DOCTOR, COLLEGE, GVY, PRIMARY, OTHER, TEACHER, MASTER, HIGHSCHOOL, TECHNICAL, JUNIOR, SECRET
    }
}
