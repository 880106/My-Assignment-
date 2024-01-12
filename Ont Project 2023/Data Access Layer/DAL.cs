using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Globalization;

namespace Data_Access_Layer
{
    public class DAL
    {
        static string connString = "Data Source=APHELELE;Initial Catalog=ASSESSMENT1DB;Integrated Security=True";
        SqlConnection dbConn = new SqlConnection(connString);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;

        public int InsertUser(User user)
        {

            dbConn.Open();

            SqlCommand dbComm = new SqlCommand("sp_InsertUser", dbConn);

            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", user.Name);
            dbComm.Parameters.AddWithValue("@Surname", user.Surname);
            dbComm.Parameters.AddWithValue("@Title", user.Title);
            dbComm.Parameters.AddWithValue("@Role", user.Role);
            dbComm.Parameters.AddWithValue("@Email", user.Email);
            dbComm.Parameters.AddWithValue("@Password", user.Password);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;


        }
        public bool CheckIfEmailExits(string email)
        {
            bool emailExists = false;

            using (SqlConnection dbConn = new SqlConnection(connString))
            {
                dbConn.Open();

                using (SqlCommand dbComm = new SqlCommand("sp_CheckIfEmailExits", dbConn))
                {
                    dbComm.CommandType = CommandType.StoredProcedure;
                    dbComm.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader reader = dbComm.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int typeExists = reader.GetInt32(reader.GetOrdinal("TypeExists"));
                            emailExists = typeExists > 0;
                        }
                    }
                }

                dbConn.Close();
            }

            return emailExists;
        }



        public int UpdateUser(User user)
        {

            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_UpdateUser", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", user.Name);
            dbComm.Parameters.AddWithValue("@Surname", user.Surname);
            dbComm.Parameters.AddWithValue("@Title", user.Title);
            dbComm.Parameters.AddWithValue("@Role", user.Role);
            dbComm.Parameters.AddWithValue("@Email", user.Email);
            dbComm.Parameters.AddWithValue("@Password", user.Password);

            int rowsAffected = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return rowsAffected;

        }
        public int DeleteUser(string Email)
        {

            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_DeleteUser", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Email", Email);

            int rowsAffected = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return rowsAffected;

        }
        public DataTable GetUserData()
        {

            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_GetUserData", dbConn);
            SqlDataAdapter dbAdapter = new SqlDataAdapter(dbComm);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;

        }

        public DataTable SearchByName(string name)
        {

            dbConn.Open();
            dbComm = new SqlCommand("sp_SearchByName", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@Name", name);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);


            dbConn.Close();

            return dt;
        }
        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public int InsertModule(Module module)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_InsertModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleName", module.ModuleName);
            dbComm.Parameters.AddWithValue("@ModuleDuration", module.ModuleDuration);
            dbComm.Parameters.AddWithValue("@ModuleTypeID", module.ModuleTypeID);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int UpdateModule(Module module)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_UpdateModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleID", module.ModuleID);
            dbComm.Parameters.AddWithValue("@ModuleName", module.ModuleName);
            dbComm.Parameters.AddWithValue("@ModuleDuration", module.ModuleDuration);
            dbComm.Parameters.AddWithValue("@ModuleTypeID", module.ModuleTypeID);

            int rowsAffected = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return rowsAffected;
        }

        public int DeleteModule(int moduleIDTypeID)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_DeleteModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleTypeID", moduleIDTypeID);

            int rowsAffected = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return rowsAffected;
        }

        public DataTable GetModuleData()
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_GetModuleData", dbConn);
            SqlDataAdapter dbAdapter = new SqlDataAdapter(dbComm);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetModuleByName(string moduleName)
        {
            dbConn.Open();
            dbComm = new SqlCommand("sp_GetModuleModuleByName", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleName", moduleName);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);


            dbConn.Close();

            return dt;



        }
        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public int InsertModuleType(ModuleType moduleType)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_InsertModuleType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleTypeDescription", moduleType.ModuleTypeDescription);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int UpdateModuleType(ModuleType moduleType)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_UpdateModuleType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleTypeDescription", moduleType.ModuleTypeDescription);

            int rowsAffected = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return rowsAffected;
        }

        public int DeleteModuleType(int moduleTypeID)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_DeleteModuleType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@ModuleTypeID", moduleTypeID);

            int rowsAffected = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return rowsAffected;
        }

        public DataTable GetModuleTypeData()
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_GetModuleTypeData", dbConn);
            SqlDataAdapter dbAdapter = new SqlDataAdapter(dbComm);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable GetForComboxModuleTypeID()
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_GetForComboxModuleTypeID", dbConn);
            SqlDataAdapter dbAdapter = new SqlDataAdapter(dbComm);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public int InsertLecturerModule(LecturerModule lecturerModule)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_InsertLecturerModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@LecturerModuleID", lecturerModule.LecturerModuleID);
            dbComm.Parameters.AddWithValue("@UserID", lecturerModule.UserID);
            dbComm.Parameters.AddWithValue("@ModuleID", lecturerModule.ModuleID);
            dbComm.Parameters.AddWithValue("@Date", lecturerModule.Date);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int UpdateLecturerModule(LecturerModule lecturerModule)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_UpdateLecturerModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@LecturerModuleID", lecturerModule.LecturerModuleID);
            dbComm.Parameters.AddWithValue("@Date", lecturerModule.Date);
            int rowsAffected = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return rowsAffected;
        }

        public int DeleteLecturerModule(int lecturerModuleID)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_DeleteLecturerModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@LecturerModuleID", lecturerModuleID);

            int rowsAffected = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return rowsAffected;
        }

        public DataTable GetLecturerModuleData()
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_GetLecturerModuleData", dbConn);
            SqlDataAdapter dbAdapter = new SqlDataAdapter(dbComm);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable GetModulIdForcmbLecturer()
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_GetModulIdForcmbLecturer", dbConn);
            SqlDataAdapter dbAdapter = new SqlDataAdapter(dbComm);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetUserIDForCmbLecturerModule()
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_GetUserIDForCmbLecturerModule", dbConn);
            SqlDataAdapter dbAdapter = new SqlDataAdapter(dbComm);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public int InsertStudentModule(StudentModule studentModule)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_InsertStudentModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentModuleID", studentModule.StudentModuleID);
            dbComm.Parameters.AddWithValue("@LecturerModuleID", studentModule.LecturerModuleID);
            dbComm.Parameters.AddWithValue("@UserID", studentModule.UserID);
            dbComm.Parameters.AddWithValue("@Date", studentModule.Date);


            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int UpdateStudentModule(StudentModule studentModule)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_UpdateStudentModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentModuleID", studentModule.StudentModuleID);
            dbComm.Parameters.AddWithValue("@Date", studentModule.Date);
            int rowsAffected = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return rowsAffected;
        }

        public int DeleteStudentModule(int studentModuleID)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_DeleteStudentModule", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentModuleID", studentModuleID);

            int rowsAffected = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return rowsAffected;
        }

        public DataTable GetStudentModuleData()
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_GetStudentModuleData", dbConn);
            SqlDataAdapter dbAdapter = new SqlDataAdapter(dbComm);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetUserIDForCmbStudent()
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_GetUserIDForCmbStudent", dbConn);
            SqlDataAdapter dbAdapter = new SqlDataAdapter(dbComm);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetModIDForStud()
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_GetModIDForStud", dbConn);
            SqlDataAdapter dbAdapter = new SqlDataAdapter(dbComm);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public int InsertAssessment(Assessment assessment)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_InsertAssessment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentLecturerModuleID", assessment.StudentLecturerModuleID);
            dbComm.Parameters.AddWithValue("@DueDate", assessment.DueDate);
            dbComm.Parameters.AddWithValue("@AssessmentTypeID", assessment.AssessmentTypeID);
            dbComm.Parameters.AddWithValue("@AssessmentStatus", assessment.AssessmentStatus);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int UpdateAssessment(Assessment assessment)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_UpdateAssessment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentLecturerModuleID", assessment.StudentLecturerModuleID);
            dbComm.Parameters.AddWithValue("@DueDate", assessment.DueDate);
            dbComm.Parameters.AddWithValue("@AssessmentTypeID", assessment.AssessmentTypeID);

            int rowsAffected = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return rowsAffected;
        }

        public int DeleteAssessment(int studentLecturerModuleID)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_DeleteAssessment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@StudentLecturerModuleID", studentLecturerModuleID);

            int rowsAffected = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return rowsAffected;
        }

        public DataTable GetAssessmentData()
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_GetAssessmentData", dbConn);
            SqlDataAdapter dbAdapter = new SqlDataAdapter(dbComm);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public int InsertAssessmentType(AssessmentType assessmentType)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_InsertAssessmentType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentTypeDescription", assessmentType.AssessmentTypeDescription);

            int x = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return x;
        }

        public int UpdateAssessmentType(AssessmentType assessmentType)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_UpdateAssessmentType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentTypeDescription", assessmentType.AssessmentTypeDescription);

            int rowsAffected = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return rowsAffected;
        }

        public int DeleteAssessmentType(int assessmentTypeID)
        {
            dbConn.Open();

            SqlCommand dbComm = new SqlCommand("sp_DeleteAssessmentType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentTypeID", assessmentTypeID);

            int rowsAffected = dbComm.ExecuteNonQuery();
            dbConn.Close();

            return rowsAffected;
        }
        public int UpdateAssessmentType(string assessmentTypeDescription)
        {

            dbConn.Open();

            SqlCommand dbComm = new SqlCommand("sp_UpdateAssessmentType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentTypeDescription", assessmentTypeDescription);

            int rowsAffected = dbComm.ExecuteNonQuery();


            dbConn.Close();

            return rowsAffected;
        }
        public DataTable GetTypeIDForCmb()
        {
            dbConn.Open();
            SqlCommand cmd = new SqlCommand("sp_GetTypeIDForCmb", dbConn);
            SqlDataAdapter dbAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetAssessmentTypeData()
        {
            dbConn.Open();
            SqlCommand cmd = new SqlCommand("sp_GetAssessmentTypeData", dbConn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dbAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        public DataTable GetByAssessmentType(int assessmentTypeID)
        {

            dbConn.Open();
            SqlCommand cmd = new SqlCommand("sp_GetByAssessmentType", dbConn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@AssessmentTypeID", assessmentTypeID);

            SqlDataAdapter dbAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetDataForCmbType()
        {
            dbConn.Open();
            SqlCommand cmd = new SqlCommand("sp_GetDataForcmbType", dbConn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dbAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public bool CheckAssessmentTypeExists(string assessmentTypeDescription)
        {
            SqlConnection dbConn = new SqlConnection(connString);
            dbConn.Open();

            SqlCommand dbComm = new SqlCommand("sp_CheckAssessmentTypeExists", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentTypeDescription", assessmentTypeDescription);

            SqlDataReader reader = dbComm.ExecuteReader();

            if (reader.Read())
            {
                int typeExists = reader.GetInt32(reader.GetOrdinal("TypeExists"));
                reader.Close();
                dbConn.Close();
                return typeExists > 0;
            }

            reader.Close();
            dbConn.Close();
            return false;
        }
        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public DataTable Login(string email, string password)
        {
            dbConn.Open();
            SqlCommand cmd = new SqlCommand("sp_Login", dbConn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Password", password);
            SqlDataAdapter dbAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public int InsertManageAssessment(ManageAssessment assessment)
        {
            using (SqlConnection dbConn = new SqlConnection(connString))
            {
                dbConn.Open();

                using (SqlCommand dbComm = new SqlCommand("sp_InsertManageAssessement", dbConn))
                {
                    dbComm.CommandType = CommandType.StoredProcedure;
                    dbComm.Parameters.AddWithValue("@AssessmentTypeID", assessment.AssessmentTypeID);
                    dbComm.Parameters.AddWithValue("@MarkAssessment", assessment.MarkAssessment);
                    dbComm.Parameters.AddWithValue("@Date", assessment.Date);

                    int x = dbComm.ExecuteNonQuery();
                    dbConn.Close();
                    return x;
                }
            }
        }
        public int UpdateManageAssessment(ManageAssessment assessment)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_UpdateManageAssesssment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentTypeID", assessment.AssessmentTypeID);
            dbComm.Parameters.AddWithValue("@NewMarkAssessment", assessment.MarkAssessment);
            dbComm.Parameters.AddWithValue("@NewDate", assessment.Date);

            int rowsAffected = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return rowsAffected;
        }
        public int DeleteManageAssessment(int assessmentTypeID)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_DeleteManageAssesssment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentTypeID", assessmentTypeID);

            int rowsAffected = dbComm.ExecuteNonQuery();
            dbConn.Close();
            return rowsAffected;
        }
        public DataTable GetManageAssessmentData()
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_GetAllData", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dbAdapter = new SqlDataAdapter(dbComm);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }
        public DataTable GetManageAssessment()
        {
            dbConn.Open();
            SqlCommand sqlCommand = new SqlCommand("sp_GetManageAssessment", dbConn);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dbConn.Close();
            return dataTable;
        }
        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public DataTable GetAllDatFromTables()
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_GetAllDatFromTables", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dbAdapter = new SqlDataAdapter(dbComm);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }

        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
        public DataTable GetRepotingInformation(string assessmentName, string StartDate, string endDate)
        {
            dbConn.Open();
            SqlCommand dbComm = new SqlCommand("sp_GetRepotingInformation", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentTypeDescription", assessmentName);
            dbComm.Parameters.AddWithValue("@StartDate", StartDate);
            dbComm.Parameters.AddWithValue("@EndDate", endDate);
            SqlDataAdapter dbAdapter = new SqlDataAdapter(dbComm);
            DataTable dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();
            return dt;
        }


        public DataTable SearchAssessment(string assessment)
        {

            dbConn.Open();
            dbComm = new SqlCommand("sp_SearchAssessment", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;
            dbComm.Parameters.AddWithValue("@AssessmentTypeDescription", assessment);
            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);


            dbConn.Close();

            return dt;
        }
        /*----------------------------------------------------------------------------------------------------------------------------------------------------*/
    }
}
