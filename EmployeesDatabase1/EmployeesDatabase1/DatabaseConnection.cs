using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeesDatabase1
{
    class DatabaseConnection
    {
        private string sql_string;//The sql_string field variable will hold a SQL string like "SELECT * FROM table"
        private string strCon;//hold a location of the database
        System.Data.SqlClient.SqlDataAdapter da_1;// A DataAdapter is used to open up a table in a database.

        public string Sql//write-only property
        {

            set { sql_string = value; }//nikto ne mojet prochitat eto pole tak kak net get
        }
        public string connection_string
        {

            set { strCon = value; }

        }
        public System.Data.DataSet GetConnection//grid that holds the data from our table.you load table data into a DataSet,
        {
            get { return MyDataSet(); }//The method connects to the database and fills a Dataset. 


        }
        private System.Data.DataSet MyDataSet()
        {
            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(strCon);
            // SqlConnection will use our connection string in strCon to connect to the database.
            con.Open();//we open a connection to the database.
            da_1 = new System.Data.SqlClient.SqlDataAdapter(sql_string, con);//which records and which database
            System.Data.DataSet dat_set = new System.Data.DataSet();//l hold all the records from the table.
            da_1.Fill(dat_set, "Table_Data_1");

            con.Close( );
           
     return dat_set;
        }
        //To actually update the database
        public void UpdateDatabase(System.Data.DataSet ds)
        {
            System.Data.SqlClient.SqlCommandBuilder cb = new System.Data.SqlClient.SqlCommandBuilder(da_1);//In order to do an automatic update
            cb.DataAdapter.Update(ds.Tables[0]);//dataadapter-property.its method -update.

        }
        
    }
}
//da_1 просто указывает что взять и откуда и потом заполняет в дат_сет