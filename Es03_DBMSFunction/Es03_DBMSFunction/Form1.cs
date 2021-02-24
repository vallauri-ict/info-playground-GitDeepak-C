using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Es03_DBMSFunction
{
    public partial class Form1 : Form
    {
        public static readonly string workingDirectory = Environment.CurrentDirectory;
        public static readonly string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        public static readonly string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + projectDirectory + @"\DriverDB.mdf;Integrated Security=True;Connect Timeout=30";

        private BindingSource bsDriver = new BindingSource();
        private DataTable dtDriver;
        private SqlDataAdapter daDriver;

        public Form1()
        {
            InitializeComponent();
        }

        private void Query(string selectCommand, out SqlDataAdapter da)
        {
            da = null;
            try
            {
                // Crea un nuovo data adapter basato su selectCommand
                da = new SqlDataAdapter(selectCommand, CONNECTION_STRING);

                // Creo un command builder per generare un comando SQL update, insert, delete
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDgv(0);
        }

        private void PopulateDgv(int tables)
        {
            switch (tables)
            {
                case 0:
                    dgvDriver.DataSource = bsDriver;
                    Query("SELECT * FROM Driver", out daDriver);
                    if (daDriver != null)
                    {
                        dtDriver = new DataTable();
                        daDriver.Fill(dtDriver);
                        bsDriver.DataSource = dtDriver;
                    }
                    dgvDriver.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;
                case 1:
                    dgvDriver.DataSource = bsDriver;
                    Query("SELECT * FROM Driver", out daDriver);
                    if (daDriver != null)
                    {
                        dtDriver = new DataTable();
                        daDriver.Fill(dtDriver);
                        bsDriver.DataSource = dtDriver;
                    }
                    dgvDriver.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    break;
            }
        }

        private void btnCercaNazionalita_Click(object sender, EventArgs e)
        {
            if(cmbCountries.Text != "")
            {
                DataTable dt = new DataTable();
                SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING);
                string sql = "SELECT * FROM F1('" + cmbCountries.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                sqlConnection.Close();
                da.Dispose();
                dgvDriver.DataSource = dt;
            }
            else
                MessageBox.Show("Selezionare una nazionalità!!");
        }

        private void btnContaDriver_Click(object sender, EventArgs e)
        {
            if (nudPodiums.Value >= 0)
            {
                SqlConnection sqlConnection = new SqlConnection(CONNECTION_STRING);
                string sql = "SELECT * FROM F2('" + Convert.ToInt32(nudPodiums.Value) + "')";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                sqlConnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show("Numero piloti: " + reader.GetInt32(0).ToString());
                }
                sqlConnection.Close();
            }
            else
                MessageBox.Show("Inserire un numero corretto!!");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            PopulateDgv(0);
        }
    }
}
