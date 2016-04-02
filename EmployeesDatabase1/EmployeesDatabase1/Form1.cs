using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeesDatabase1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DatabaseConnection objConnect;//variable to store our connection object
        string conString;//a string to hold our connection string from the Setting page we set up earlier. 
        DataSet ds;//somewhere to put the DataSet wheen we call GETCONNECTION method
        DataRow dRow;//To manipulate each row

        int MaxRows;//how many rows there are in the DataSet, which is how many rows were pulled from the database table. 
        int inc = 0;//to move from one record to another, and back again. 

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                objConnect = new DatabaseConnection();//This creates a new object for us, of type DatabaseConnection.
                conString = Properties.Settings.Default.EmployeesConnectionString;//соединяется со строкой в свойствах где прописан путь
               
                objConnect.connection_string = conString;
                objConnect.Sql = Properties.Settings.Default.SQL;//vibiraet vse stroki
               
                ds = objConnect.GetConnection;//ds-куда вставтить датабэйс
                MaxRows = ds.Tables[0].Rows.Count;//так как у нас тольуо одна таблица

                NavigateRecords();//To fill the textboxes,
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }

        }

        private void NavigateRecords()
        {

    dRow = ds.Tables[0].Rows[inc];

    txtFirstName.Text = dRow.ItemArray.GetValue(1).ToString();
    txtSurname.Text = dRow.ItemArray.GetValue(2).ToString();
    txtJobTitle.Text = dRow.ItemArray.GetValue(3).ToString();
    txtDepartment.Text = dRow.ItemArray.GetValue(4).ToString();

}

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (inc!= MaxRows-1)//если не послед.
            {
                inc++;
                NavigateRecords();//pokajet po strochkam
            }
            else 
            {
                MessageBox.Show("No more rows!");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

            if (inc>0)
            {
                inc--;
                NavigateRecords();//pokajet po strochkam
            }
            else
            {
                MessageBox.Show("First record");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (inc!=MaxRows-1)
            {
                inc = MaxRows -1;
                NavigateRecords();//pokajet po strochkam
            }
           
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (inc != 0)
            {
                inc = 0;
                NavigateRecords();//pokajet po strochkam
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtSurname.Clear();
            txtJobTitle.Clear();
            txtDepartment.Clear();

            btnAddNew.Enabled = false;//otkl  we need to disable it and enable save and cancel
            btnSave.Enabled = true;//vkl
            btnCancel.Enabled = true;//vkl
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NavigateRecords();// Показывает последнюю введенную строку(когда добавили новую строку inc увеличился,поэтому покажет ее)

            btnAddNew.Enabled = true;//vkl            
            btnSave.Enabled = false;//otkl
            btnCancel.Enabled = false;//otkl
            
        }

        private void btnSave_Click(object sender, EventArgs e)//save it to the Dataset, and save it to the underlying database. 
        {//To add a record to the Dataset
            DataRow row = ds.Tables[0].NewRow();// The DataRow object is used to add new rows to a Dataset. 
            row[1] = txtFirstName.Text;
            row[2] = txtSurname.Text;
            row[3] = txtJobTitle.Text;
            row[4] = txtDepartment.Text;

            ds.Tables[0].Rows.Add(row);//add all rows to table

            try
            {
                objConnect.UpdateDatabase(ds);//!To actually update the database!

                MaxRows ++ ;
                inc = MaxRows - 1;

                MessageBox.Show("Database updated");
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }
            btnCancel.Enabled = false;//otkl
            btnSave.Enabled = false;//otkl
            btnAddNew.Enabled = true;//vkl
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables[0].Rows[inc];//tekyshaya stroka

            row[1] = txtFirstName.Text;
            row[2] = txtSurname.Text;
            row[3] = txtJobTitle.Text;
            row[4] = txtDepartment.Text;

            

            try
            {

                objConnect.UpdateDatabase(ds);

                MessageBox.Show("Record Updated");

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try 
            {
                ds.Tables[0].Rows[inc].Delete();//from dataset
                objConnect.UpdateDatabase(ds);

                MaxRows = ds.Tables[0].Rows.Count;
                inc--;
                if (inc < 0)//так как если удалили 1 строку то надо показать новую 1 строку а не -1 строку
                {
                    inc = 0;
                    MessageBox.Show("you've deleted 1-rst row");
                    NavigateRecords();
                }
                else
                {
                    NavigateRecords();//покажет пред перед удалением
                }
                 MessageBox.Show("Record deleted");

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }

         }

        
    

        }    
}


//dataset набор тэйбл адаптеров ,адаптер-соединение