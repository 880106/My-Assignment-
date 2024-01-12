using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;

namespace BusinessLogicLayer
{
    public class BLL
    {
        readonly DAL dataAccess = new DAL();

        public int InsertUser(User user)
        {


            return dataAccess.InsertUser(user);
        }
            public bool CheckIfEmailExits(string email)
            {
                return dataAccess.CheckIfEmailExits(email);
            }

        public int UpdateUser(User user)
        {
            
            return dataAccess.UpdateUser(user);
        }

        public int DeleteUser(string Email)
        {
          
            return dataAccess.DeleteUser(Email);
        }

        public DataTable GetUserData()
        {

            return dataAccess.GetUserData();
        }

        public DataTable SearchByName(string name)
        {
            return dataAccess.SearchByName(name);
        }

        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public int InsertModule(Module module)
        {
            return dataAccess.InsertModule(module);
        }

        public int UpdateModule(Module module)
        {
            return dataAccess.UpdateModule(module);
        }

        public int DeleteModule(int moduleIDTypeID)
        {
            return dataAccess.DeleteModule(moduleIDTypeID);
        }

        public DataTable GetModuleData()
        {
            return dataAccess.GetModuleData();
        }
        public DataTable GetModuleByName(string moduleName)
        {
            return dataAccess.GetModuleByName(moduleName);
        }
        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public int InsertModuleType(ModuleType moduleType)
        {
            return dataAccess.InsertModuleType(moduleType);
        }

        public int UpdateModuleType(ModuleType moduleType)
        {
            return dataAccess.UpdateModuleType(moduleType);
        }

        public int DeleteModuleType(int moduleTypeID)
        {
            return dataAccess.DeleteModuleType(moduleTypeID);
        }

        public DataTable GetModuleTypeData()
        {
            return dataAccess.GetModuleTypeData();
        }
        public DataTable GetForComboxModuleTypeID()
        {
            return dataAccess.GetForComboxModuleTypeID();
        }
        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public int InsertLecturerModule(LecturerModule lecturerModule)
        {
            return dataAccess.InsertLecturerModule(lecturerModule);
        }

        public int UpdateLecturerModule(LecturerModule lecturerModule)
        {
            return dataAccess.UpdateLecturerModule(lecturerModule);
        }

        public int DeleteLecturerModule(int lecturerModuleID)
        {
            return dataAccess.DeleteLecturerModule(lecturerModuleID);
        }

        public DataTable GetLecturerModuleData()
        {
            return dataAccess.GetLecturerModuleData();
        }
        public DataTable GetModulIdForcmbLecturer()
        {
            return dataAccess.GetModulIdForcmbLecturer();
        }
        public DataTable GetUserIDForCmbLecturerModule()
        {
            return dataAccess.GetUserIDForCmbLecturerModule();
        }

        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public int InsertStudentModule(StudentModule studentModule)
        {
            return dataAccess.InsertStudentModule(studentModule);
        }

        public int UpdateStudentModule(StudentModule studentModule)
        {
            return dataAccess.UpdateStudentModule(studentModule);
        }

        public int DeleteStudentModule(int studentModuleID)
        {
            return dataAccess.DeleteStudentModule(studentModuleID);
        }

        public DataTable GetStudentModuleData()
        {
            return dataAccess.GetStudentModuleData();
        }
        public DataTable GetUserIDForCmbStudent()
        {
            return dataAccess.GetUserIDForCmbStudent();
        }
        public DataTable GetModIDForStud()
        {
            return dataAccess.GetModIDForStud();
        }
        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public int InsertAssessment(Assessment assessment)
        {
            return dataAccess.InsertAssessment(assessment);
        }

        public int UpdateAssessment(Assessment assessment)
        {
            return dataAccess.UpdateAssessment(assessment);
        }

        public int DeleteAssessment(int assessmentID)
        {
            return dataAccess.DeleteAssessment(assessmentID);
        }

        public DataTable GetAssessmentData()
        {
            return dataAccess.GetAssessmentData();
        }



        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public int InsertAssessmentType(AssessmentType assessmentType)
        {
            return dataAccess.InsertAssessmentType(assessmentType);
        }

        public int UpdateAssessmentType(AssessmentType assessmentType)
        {
            return dataAccess.UpdateAssessmentType(assessmentType);
        }

        public int DeleteAssessmentType(int StudentLecturerModuleID)
        {
            return dataAccess.DeleteAssessmentType(StudentLecturerModuleID);
        }

        public DataTable GetAssessmentTypeData()
        {
            return dataAccess.GetAssessmentTypeData();
        }

        public DataTable GetByAssessmentType(int assessmentTypeID)
        {
            return dataAccess.GetByAssessmentType(assessmentTypeID);
        }
        public DataTable GetTypeIDForCmb()
        {
            return dataAccess.GetTypeIDForCmb();
        }
        public DataTable GetDataForCmbType()
        {
            return dataAccess.GetDataForCmbType();
        }
        public bool CheckAssessmentTypeExists(string assessmentTypeDescription)
        {
     
            return dataAccess.CheckAssessmentTypeExists(assessmentTypeDescription);
        }
        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public DataTable Login(string email, string password)
        {
            return dataAccess.Login(email, password);
        }
        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/


        public int InsertManageAssessment(ManageAssessment manageAssessment)
        {
            return dataAccess.InsertManageAssessment(manageAssessment);
        }

        public int UpdateManageAssessment(ManageAssessment manageAssessment)
        {
            return dataAccess.UpdateManageAssessment(manageAssessment);
        }

        public int DeleteManageAssessment(int assessmentTypeID)
        {
            return dataAccess.DeleteManageAssessment(assessmentTypeID);
        }
        public DataTable GetManageAssessmentData()
        {
            return dataAccess.GetManageAssessmentData();
        }
        public DataTable GetManageAssessment()
        {
            return dataAccess.GetManageAssessment();
        }

        public DataTable GetAllDatFromTables()
        {
            return dataAccess.GetAllDatFromTables();
        }
        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public DataTable GetRepotingInformation(string assessmentName, string startDate, string endDate)
        {
            return dataAccess.GetRepotingInformation(assessmentName, startDate, endDate);
        }
        public DataTable SearchAssessment(string name)
        {
            return dataAccess.SearchAssessment(name);
        }
    }
}
