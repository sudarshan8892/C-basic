using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using ASP.NET_MVC.Data;

namespace ASP.NET_MVC.Data
{
    public  class APPDBContext:BaseDataAccess
    {
      
        public DataTable GetCompanyConnectionByUsername(string userName)
        {
            string sqlQuery = @"select UO.CompanyId
                                ,O.ConnectionString 
                                ,O.MasterPassword
                                ,O.CompanyName
                                from UserOrganization UO 
                                left join Organization O
                                on O.CompanyId = UO.CompanyId
                                where UO.UserName ='{0}'
                                and UO.IsActive =1
                                ";
            sqlQuery = string.Format(sqlQuery, userName);

            try
            {
                using (SqlCommand cmd = GetSQLCommand(sqlQuery))
                {
                    DataSet dsResult = GetDataSet(cmd);
                    return dsResult.Tables[0];
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}