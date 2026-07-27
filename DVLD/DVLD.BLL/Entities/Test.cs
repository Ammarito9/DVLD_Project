using DVLD.DAL.Data;
using DVLD.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DVLD.BLL.Entities.Test;

namespace DVLD.BLL.Entities
{
    public class Test
    {
        public enum TestType
        {
            Visual = 1,
            Written,
            Street
        }
        enum Mode
        {
            Update,
            AddNew
        }
        public enum TestResult
        {
            Pass = 'P',
            Failed = 'F',
        }
        Mode mode;
        public int ID { get; set; }
        public int TestAppointmentID { get; set; }
        public int CreatedByUserID { get; set; }
        public char TestResultCharacter { get; set; }
        public TestResult testResult { get; set; }
        public string? Note { get; set; }
        public Test() { mode = Mode.AddNew; }
        public Test(int iD, int testAppointmentID, int createdByUserID, char testResultCharacter, string? note)
        {
            mode = Mode.Update;
            ID = iD;
            TestAppointmentID = testAppointmentID;
            CreatedByUserID = createdByUserID;
            TestResultCharacter = testResultCharacter;
            Note = note;
        }
        public static Test Find(int ID)
        {
            DataRow dr = TestData.GetByID(ID);

            if (dr is not null)
            {
                return new Test(
                    ID,
                    (int)dr["TestAppointmentID"],
                    (int)dr["CreatedByUserID"],
                    (char)dr["TestResultCharacter"],
                    (string)dr["Note"]
                    );
            }
            else
                return null;

        }
        public static DataTable GetAll() => TestData.GetAll();
        private bool Add()
        {
            TestDTO newTest = new TestDTO();

            newTest.TestAppointmentID = TestAppointmentID;
            newTest.CreatedByUserID = CreatedByUserID;
            newTest.TestResultCharacter = TestResultCharacter;
            newTest.Note = Note;
            ID = TestData.Add(newTest);

            return ID != 0;
        }
        private bool Update()
        {
            if (!TestData.IsExist(ID))
                return false;

            TestDTO newTest = new TestDTO();

            newTest.ID = ID;
            newTest.TestAppointmentID = TestAppointmentID;
            newTest.CreatedByUserID = CreatedByUserID;
            newTest.TestResultCharacter = TestResultCharacter;
            newTest.Note = Note;

            return (TestData.Update(newTest) > 0);
        }
        public static bool Delete(int ID) => (TestData.Delete(ID) > 0);
        public static bool IsExist(int ID) => TestData.IsExist(ID);
        public bool Save()
        {
            switch (mode)
            {
                case Mode.AddNew:
                    if (Add())
                    {
                        mode = Mode.Update;
                        return true;
                    }
                    return false;
                case Mode.Update:
                    return Update();

                default:
                    return false;
            }
        }

    }
}
