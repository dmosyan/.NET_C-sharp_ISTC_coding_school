using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class Student : Person
    {
        public enum GradeLevels { Freshman, Sophomore, Junior, Senior }
        public GradeLevels GradeLevel { get; set; }

        public override float ComputeGradeAverage()
        {
            return 4.0f;
        }

        public override string SendMessage(string message)
        {
            String original = base.SendMessage(message);
            StringBuilder sb = new StringBuilder(original);
            sb.AppendLine("This message is confidential.");
            return sb.ToString();
        }
    }
}
