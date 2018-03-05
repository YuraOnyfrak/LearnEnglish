using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows;

namespace EnglishStudy.DB.Abstract.Implement
{
    public class EnglishStudyDB
    {
        static private readonly string connectionString = @"Server=tcp:englishstudydb.database.windows.net,1433;Initial Catalog=EnglishStudyDB;Persist Security Info=False;User ID={user};Password={azure2018};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        
        public static DataTable GetTable()
        {
            DataTable table = GetTable("SELECT  * FROM Dictionary;");

            return table;
        }

        private static DataTable GetTable(string commandString)
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand(commandString, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(table);

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }

            return table;
        }

        public static DataTable GetTableToDictionary()
        {  
            DataTable table = GetTable("SELECT  top 6 * FROM Dictionary WHERE EXISTS(SELECT * FROM IsLearnedWord  where Dictionary.id = IsLearnedWord.idWord  and IsLearnedWord.learned = 0)");
             
            return table;
        }

        public static void UpdateStatus()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("UPDATE IsLearnedWord SET  learned = 1 WHERE idWord in (SELECT top 6  idWord FROM IsLearnedWord where IsLearnedWord.learned = 0)", connection);

                    command.ExecuteNonQuery();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        public void AddWords()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string commandString = "INSERT Orders VALUES( @CustomerNo, '11-12-2011', @Goods)";
                int orderid = 2;
                int customerNo = 2;
                //  DateTime orderDate = new DateTime(11,12,2011);
                string goods = "m";

                SqlCommand command = new SqlCommand(commandString, connection);
                command.Parameters.Add("OrderId", orderid);
                command.Parameters.Add("CustomerNo", customerNo);
                command.Parameters.Add("Goods", goods);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTableMapping mapping = adapter.TableMappings.Add("Table", "Покупець");

                var columnMapping = new DataColumnMapping[]
                {
                    new DataColumnMapping("CustomerNo","Покупець")
                };

                mapping.ColumnMappings.AddRange(columnMapping);

                try
                {
                    connection.Open();
                    command.Transaction = connection.BeginTransaction();
                    command.ExecuteNonQuery();
                    command.Transaction.Commit();



                }
                catch (Exception)
                {
                    command.Transaction.Rollback();
                    throw;
                }

            }
        }
    }
}
