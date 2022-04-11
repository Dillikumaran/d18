using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lynq
{
    class Day26Apr11task
    {
        public class Doctor
        {

            public int DoctorID { get; set; }
            public string DoctorName { get; set; }
            public int SpecializationId { get; set; }
        }
        public class Specialization
        {
            public int SpecializationId { get; set; }
            public string SpecializationName { get; set; }
        }
        class joinSpecialization
        {
            public static void Main()
            {
                IList<Doctor> DocData = new List<Doctor>()
            {
            new Doctor()  { DoctorID = 1 ,DoctorName="John",SpecializationId=4},
            new Doctor() { DoctorID = 2, DoctorName = "Dillikumaran",SpecializationId=2},
            new Doctor() { DoctorID = 3, DoctorName = "Vishal",SpecializationId=1},
            new Doctor() { DoctorID = 4, DoctorName = "Giridharan",SpecializationId=3 },
            new Doctor() { DoctorID = 5, DoctorName = "Yuvaraj",SpecializationId=2 },
            new Doctor() { DoctorID = 6, DoctorName = "Harishwar",SpecializationId=1 },
            new Doctor() { DoctorID = 7, DoctorName = "Abdul_alsudias",SpecializationId=3 },
            new Doctor() { DoctorID = 8, DoctorName = "Venkat", SpecializationId=4  },
            new Doctor() { DoctorID = 9, DoctorName = "Abdul_alsudias",SpecializationId=4 },
            new Doctor() { DoctorID = 10, DoctorName = "Abdul_alsudias",SpecializationId=1 }
            };
                IList<Specialization> Specializations = new List<Specialization>()
            {
                new Specialization(){SpecializationId= 1,SpecializationName="Dental"},
                new Specialization(){SpecializationId= 2,SpecializationName="Psychology"},
                new Specialization(){SpecializationId = 3,SpecializationName="physiology"},
                new Specialization(){SpecializationId = 4,SpecializationName="Neurology"}
            };
                var joinDocData = from dt in DocData
                                  join sp in Specializations
                                  on dt.SpecializationId equals sp.SpecializationId
                                  select new
                                  {
                                      DocName = dt.DoctorName,
                                      SpecName = sp.SpecializationName
                                  };
                foreach (var item in joinDocData)
                {
                    Console.WriteLine("Dr." + item.DocName + " is specialized in  " + item.SpecName);
                }

            }
        }
    }
}
