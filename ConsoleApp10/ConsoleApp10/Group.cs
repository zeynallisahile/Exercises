using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Group
    {
        private static int _programming_count;
        private static int _design_count;
        private static int _system_count;

        private string _no;
        private Student[] students = new Student[0];
        public string No { get => _no; private set { } }
        public Type Type { get; set; }

        public Group(Type type)
        {
            if (Type == Type.Programing)
            {
                _programming_count++;
                int programing_NumberNo = 60 + _programming_count;

                No = "EL" + programing_NumberNo;
            }

            if (Type == Type.Design)
            {
                _design_count++;
                int desigin_NumberNo = 60 + _design_count;

                No = "  CL" + desigin_NumberNo;

            }

            if (Type == Type.System)
            {
                _system_count++;
                int system_NumberNo = 60 + _system_count;

                No = " KL" + system_NumberNo;

            }


        }
    }
}
