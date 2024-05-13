using MySql.Data.MySqlClient;
using SmartContact.SmartContactClasses;
using System.Data;
namespace SmartContact
{
    public partial class SmartContact : Form
    {
        public SmartContact()
        {
            InitializeComponent();

        }
        ContactClass c = new ContactClass();
       
        public void loaddata()
        {
            //LOAD DATA ON DATA GRIDVIEW
            DataTable dt = c.SelectData();
            dataGridView1.DataSource = dt;
           
        }
        private void SmartContact_Load(object sender, EventArgs e)
        {
            loaddata();

        }
        public void imageload()
        {
            String image = textBoxImage.Text;

            try
            {
                pictureBox1.Load(image);
            }
            catch (Exception ex)
            {
                //image can't be loaded
            }
        }

        public void clear()
        {
            textBoxContactID.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxContactNo.Text = "";
            comboBoxGender.Text = "";
            textBoxImage.Text = "";
        }
        //to get the data form the selected row in the grid to the labels
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //identifying the selected row index 
            int rowIndex = e.RowIndex;
            //inserting data from grid view row to textboxes
            textBoxContactID.Text = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxContactNo.Text = dataGridView1.Rows[rowIndex].Cells[4].Value.ToString();
            comboBoxGender.Text = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxImage.Text = dataGridView1.Rows[rowIndex].Cells[5].Value.ToString();
            imageload();
        }

        //add
        private void button1_Click(object sender, EventArgs e)
        {
            //get the value from the input fields 
            c.FirstName = textBoxFirstName.Text;
            c.LastName = textBoxLastName.Text;
            c.ContactNo = textBoxContactNo.Text;
            c.Gender = comboBoxGender.Text;
            c.Image = textBoxImage.Text;

            // Inserting data into the database using the method we created in previous class
            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("New Contact Inserted!");
            }
            else
            {
                //failed
                MessageBox.Show("Contact Not Inserted!");
            }
            //LOAD DATA ON DATA GRIDVIEW
            loaddata();
            clear();
        }
        //delete
        private void button2_Click(object sender, EventArgs e)
        {
            //get the value from the input fields 
            c.ContactID = Convert.ToInt32(textBoxContactID.Text);
            // deleting data into the database using the method we created in previous class
            bool success = c.Delete(c);
            if (success == true)
            {
                MessageBox.Show("Contact Deleted!");
            }
            else
            {
                //failed
                MessageBox.Show("Contact Not Deleted!");
            }
            //LOAD DATA ON DATA GRIDVIEW
            loaddata();
            clear();
        }
        //update
        private void button3_Click(object sender, EventArgs e)
        {
            //get the value from the input fields 
            try
            {
                c.ContactID = Convert.ToInt32(textBoxContactID.Text);
                c.FirstName = textBoxFirstName.Text;
                c.LastName = textBoxLastName.Text;
                c.ContactNo = textBoxContactNo.Text;
                c.Gender = comboBoxGender.Text;
                c.Image = textBoxImage.Text;

                // update data into the database using the method we created in previous class
                bool success = c.update(c);
                if (success == true)
                {
                    MessageBox.Show("Contact updated!");
                }
                else
                {
                    //failed
                    MessageBox.Show("Contact Not updated!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //LOAD DATA ON DATA GRIDVIEW
            loaddata();
            clear();
        }
        //search
        private void Searchbuttionpic_Click(object sender, EventArgs e)
        {
            c.FirstName = textBoxSearch.Text;
            //LOAD DATA ON DATA GRIDVIEW
            DataTable dt = c.search(c);
            dataGridView1.DataSource = dt;

        }
        //load data
        private void buttonloaddata_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            imageload();
        }

    }
}
