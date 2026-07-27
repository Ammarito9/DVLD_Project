using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.DAL.DTO
{
    public class TestDTO
    {
        public int ID { get; set; }
        public int TestAppointmentID { get; set; }
        public int CreatedByUserID { get; set; }
        public char TestResultCharacter { get; set; }
        public string? Note { get; set; }
        public TestDTO() { }
        public TestDTO(int testAppointmentID, int createdByUserID, char testResultCharacter, string? note)
        {
            TestAppointmentID = testAppointmentID;
            CreatedByUserID = createdByUserID;
            TestResultCharacter = testResultCharacter;
            Note = note;
        }
    }
}
