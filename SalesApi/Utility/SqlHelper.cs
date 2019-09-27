using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace SalesApi.Utility
{
    public static class SqlHelper
    {
        public static string ExecuteProcedureReturnString(string connString, string procName, params SqlParameter[] paramters)
        {
            string result = "";
            using (var sqlConnection = new SqlConnection(connString))
            {
                using (var command = sqlConnection.CreateCommand())
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = procName;
                    if (paramters != null)
                    {
                        command.Parameters.AddRange(paramters);
                    }
                    sqlConnection.Open();
                    var ret = command.ExecuteScalar();
                    if (ret != null)
                        result = Convert.ToString(ret);
                }
            }
            return result;
        }


        public static TData ExecuteQueryReturnData<TData>(string connString, string query, Func<SqlDataReader, TData> translator)
        {
            using (var sqlConnection = new SqlConnection(connString))
            {
                using (var sqlcommand = sqlConnection.CreateCommand())
                {
                    sqlcommand.CommandType = System.Data.CommandType.Text;
                    sqlcommand.CommandText = query;

                    sqlConnection.Open();
                    using (var reader = sqlcommand.ExecuteReader())
                    {
                        TData elements;
                        try
                        {
                            elements = translator(reader);
                        }
                        finally
                        {
                            while (reader.NextResult())
                            { }
                        }
                        return elements;

                    }
                }

            }
        }

        public static TData ExtecuteProcedureReturnData<TData>(string connString, string procName, Func<SqlDataReader, TData> translator, params SqlParameter[] parameters)
        {
            using (var sqlConnection = new SqlConnection(connString))
            {
                using (var sqlCommand = sqlConnection.CreateCommand())
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.CommandText = procName;
                    if (parameters != null)
                    {
                        sqlCommand.Parameters.AddRange(parameters);
                    }
                    sqlConnection.Open();
                    using (var reader = sqlCommand.ExecuteReader())
                    {
                        TData elements;
                        try
                        {
                            elements = translator(reader);
                        }
                        finally
                        {
                            while (reader.NextResult())
                            { }
                        }
                        return elements;
                    }
                }
            }
        }


        public static bool ExecuteProcedureReturnDataSet(string connString, string spSQL, ref DataTable dt , params SqlParameter[] parameters)
        {
            // ---------------------------------------------------------
            // Purpose: Returns a Data Set based on a SQLCommand Object
            // Input: Command (sqlcommand object)
            // Input: The Dataset to be Returned
            // Returns: True or False based on Success
            // ---------------------------------------------------------
            // Assume Failure
            bool blnResult = false;
            SqlCommand Command = new SqlCommand();



            SqlDataAdapter daData = new SqlDataAdapter();
            DataSet dsData = new DataSet();
            // Set the Connection of the COmmand
            Command.Connection = new SqlConnection(connString);
            Command.CommandTimeout = 3000;
            // Set the Type
            // Command.CommandType = CommandType.StoredProcedure
            Command.CommandType = CommandType.StoredProcedure;
            Command.CommandText = spSQL;
            if (parameters != null)
            {
                Command.Parameters.AddRange(parameters);
            }

            try
            {
                daData.SelectCommand = Command;
                daData.Fill(dsData);
                // Indicate Success - Return True
                dt = dsData.Tables[0];
                blnResult = true;
            }
            catch (Exception ex)
            {
                //MsgBox(ex.Message);
                throw (ex);
            }
            finally
            {
                if (!(daData.SelectCommand == null))
                {
                    if (!(daData.SelectCommand.Connection == null))
                    {
                        daData.SelectCommand.Connection.Dispose();
                    }

                    daData.SelectCommand.Dispose();
                }

                daData.Dispose();
            }


            return blnResult;
        }

        public static bool ExecuteQueryDataSet(string connString, SqlCommand Command, ref DataTable dt)
        {
            // ---------------------------------------------------------
            // Purpose: Returns a Data Set based on a SQLCommand Object
            // Input: Command (sqlcommand object)
            // Input: The Dataset to be Returned
            // Returns: True or False based on Success
            // ---------------------------------------------------------
            // Assume Failure
            bool blnResult  = false;
           

            SqlDataAdapter daData = new SqlDataAdapter();
            DataSet dsData = new DataSet();
            // Set the Connection of the COmmand
            Command.Connection = new SqlConnection(connString);
            Command.CommandTimeout = 3000;
            // Set the Type
            // Command.CommandType = CommandType.StoredProcedure
            Command.CommandType = CommandType.Text;
            try
            {
                daData.SelectCommand = Command;
                daData.Fill(dsData);
                // Indicate Success - Return True
                dt = dsData.Tables[0];
                blnResult = true;
            }
            catch (Exception ex)
            {
                //MsgBox(ex.Message);
                throw (ex);
            }
            finally
            {
                if (!(daData.SelectCommand == null))
                {
                    if (!(daData.SelectCommand.Connection == null))
                    {
                        daData.SelectCommand.Connection.Dispose();
                    }

                    daData.SelectCommand.Dispose();
                }

                daData.Dispose();
            }


            return blnResult;
        }


        ///Methods to get values of 
        ///individual columns from sql data reader
        #region Get Values from Sql Data Reader

        public static Int64 GetNullableBigInt(SqlDataReader reader, string colName)
        {
            try { return reader.IsDBNull(reader.GetOrdinal(colName)) ? 0 : Convert.ToInt64(reader[colName]); }
            catch (Exception ex){ throw ex; }
        }

        public static decimal GetNullableDecimal(SqlDataReader reader, string colName)
        {
            try
            { return reader.IsDBNull(reader.GetOrdinal(colName)) ? 0 : Convert.ToDecimal(reader[colName]); }
            catch (Exception ex){ throw ex; }
        }

        public static double GetNullableFloat(SqlDataReader reader, string colName)
        {
            try { return reader.IsDBNull(reader.GetOrdinal(colName)) ? 0 : Convert.ToDouble(reader[colName]); }
            catch (Exception ex){ throw ex; }
        }

        public static Int32 GetNullableInt(SqlDataReader reader, string colName)
        {
            try { return reader.IsDBNull(reader.GetOrdinal(colName)) ? 0 : Convert.ToInt32(reader[colName]); }
            catch (Exception ex){ throw ex; }
        }

        public static decimal GetNullableMoney(SqlDataReader reader, string colName)
        {
            try { return reader.IsDBNull(reader.GetOrdinal(colName)) ? 0 : Convert.ToDecimal(reader[colName]); }
            catch (Exception ex){ throw ex; }
        }

        public static decimal GetNullableNumeric(SqlDataReader reader, string colName)
        {
            try { return reader.IsDBNull(reader.GetOrdinal(colName)) ? 0 : Convert.ToDecimal(reader[colName]); }
            catch (Exception ex){ throw ex; }

        }


        public static decimal GetNullableSmallInt(SqlDataReader reader, string colName)
        {
            try { return reader.IsDBNull(reader.GetOrdinal(colName)) ? 0 : Convert.ToInt16(reader[colName]); }
              catch (Exception ex){ throw ex; }
        }

        public static string GetNullableString(SqlDataReader reader, string colName)
        {
            try { return reader.IsDBNull(reader.GetOrdinal(colName)) ? null : Convert.ToString(reader[colName]); }
            catch (Exception ex){ throw ex; }
        }

       
        public static Nullable<DateTime> GetNullableDatetime(SqlDataReader reader, string colName)
        {
            try
            {
                if (reader.IsDBNull(reader.GetOrdinal(colName)))
                {
                    return null;
                }
                else
                {
                    if (Convert.ToString(reader.GetOrdinal(colName)) == "")
                    {
                        return null;
                    }
                    return Convert.ToDateTime(reader[colName]);
                }

            }
            catch (Exception ex){ throw ex; }

       
            //return reader.IsDBNull(reader.GetOrdinal(colName)) ? null : Convert.ToDateTime(reader[colName]);
        }



        public static bool GetBoolean(SqlDataReader reader, string colName)
        {
            try { return reader.IsDBNull(reader.GetOrdinal(colName)) ? default(bool) : Convert.ToBoolean(reader[colName]); }
            catch (Exception ex){ throw ex; }
        }

        //this method is to check wheater column exists or not in data reader
        public static bool IsColumnExists(this System.Data.IDataRecord dr, string colName)
        {
            try
            {
                return (dr.GetOrdinal(colName) >= 0);
            }
            catch (Exception)
            {
                return false;
            }
        }
        #endregion

    }
}
