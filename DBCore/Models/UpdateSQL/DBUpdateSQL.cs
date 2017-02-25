using DBCore.Models.BaseSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace DBCore.Models.UpdateSQL
{
    public class DBUpdateSQL<T>
    {
        /// <summary>
        /// Method can update on o more records
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public ModelResult UpdateRecord(string sql, params object[] parameters)
        {
            try
            {
                using (var context = new DBContext())
                {
                    context.Database.ExecuteSqlCommand(sql, parameters);
                    return new ModelResult()
                    {
                        IsSuccess = true
                    };
                }
            }
            catch (Exception e)
            {
                return new ModelResult()
                {
                    IsSuccess = false,
                    Message = e.ToString()
                };
            }
        }

        /// <summary>
        /// update single record after select this record
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public ModelResult<T> UpdateSelectSingleRecord(string sql, params object[] parameters)
        {
            try
            {
                var record  = ExecuteSQL(ref sql, parameters).FirstOrDefault();
                return new ModelResult<T>()
                {
                    Result = record,
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ModelResult<T>()
                {
                    IsSuccess = false,
                    Message = e.ToString()
                };
            }
        }
        /// <summary>
        /// Update single record after that select it as Json
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public ModelResult<string> UpdateSelectSingleRecordAsJson(string sql, params object[] parameters)
        {
            try
            {
                var record = new JavaScriptSerializer().Serialize(ExecuteSQL(ref sql, parameters).FirstOrDefault());
                return new ModelResult<string>()
                {
                    Result = record,
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ModelResult<string>()
                {
                    IsSuccess = false,
                    Message = e.ToString()
                };
            }
        }

        /// <summary>
        /// update multiple record after select this record
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public ModelResult<List<T>> UpdateSelectRecords(string sql, params object[] parameters)
        {
            try
            {
                var record = ExecuteSQL(ref sql, parameters).ToList();
                return new ModelResult<List<T>>()
                {
                    Result = record,
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ModelResult<List<T>>()
                {
                    IsSuccess = false,
                    Message = e.ToString()
                };
            }
        }
        /// <summary>
        /// Update multiple record after that select it as Json
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public ModelResult<string> UpdateSelectRecordsAsJson(string sql, params object[] parameters)
        {
            try
            {
                var record = new JavaScriptSerializer().Serialize(ExecuteSQL(ref sql, parameters).ToList());
                return new ModelResult<string>()
                {
                    Result = record,
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ModelResult<string>()
                {
                    IsSuccess = false,
                    Message = e.ToString()
                };
            }
        }


        private List<T> ExecuteSQL(ref string sql, params object[] parameters)
        {
            using (var context = new DBContext())
            {
                return context.Database.SqlQuery<T>(sql, parameters).ToList<T>();
            }
        }
    }
}
