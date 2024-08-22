using Microsoft.Data.SqlClient;
using System.Data.SqlClient;
namespace Student_Record_Store
{
    public partial class Form1 : Form
    {
        //int irollno;
        string iname, idiv, iemail;
        Int128 imobno;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //irollno = int.Parse(rollno.Text);
            iname = name.Text;
            idiv = div.Text;
            iemail = email.Text;
            imobno = int.Parse(mobno.Text);

            string conString = "Data Source=.\\sqlexpress;Initial Catalog=student_record;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(conString);

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand($"insert into student (iname, idiv, iemail, imobono) values ('{iname}', '{idiv}', '{iemail}', {imobno})", con);

                int affect = cmd.ExecuteNonQuery();

                if (affect > 0)
                {
                    con.Close();
                    MessageBox.Show("Data Inserted ..");
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Data NOT stored..");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
