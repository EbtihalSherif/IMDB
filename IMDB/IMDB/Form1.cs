using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Oracle.Database.Extensions;

namespace IMDB
{
    public partial class Form1 : Form
    {
        OracleCommandBuilder builder;
        OracleDataAdapter adapter;
        Recommend rec = new Recommend();
        public static int userID = 0;
        public static string userName = "";

        public static   OracleConnection con;
       public static string  ordb = "data source = orcl; user id =scott; password=tiger;";

        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (userID != 0)
            {
                panel1.Controls.Clear();
                AddMovie add = new AddMovie();
                add.Visible = true;
                add.Location = new Point(200, 0);
                panel1.Controls.Add(add);
                add.BringToFront();
            }
            else
                MessageBox.Show("Please login first!!");
        }

        public void Form1_Load(object sender, EventArgs e)
        {
          /*  if(userID==0)
            {
                btn_Manage.Hide();
                btn_profile.Hide();

            }*/
            rec.Visible = true;
            rec.Location = new Point(80, 120);
            panel1.Controls.Add(rec);
            rec.BringToFront();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void joinLbl_Click(object sender, EventArgs e)
        {
           
                login login = new login();
            login.Visible = true;
            login.Location = new Point(400, 95);
            this.Controls.Add(login);
            login.BringToFront();
           
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (userID != 0)
            {
                panel1.Controls.Clear();
            DeleteMovie delete = new DeleteMovie();
            delete.Visible = true;
            delete.Location = new Point(200, 0);
            panel1.Controls.Add(delete);
            delete.BringToFront();
        }
            else
                MessageBox.Show("please Login First !");
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (userID != 0)
            {
                panel1.Controls.Clear();
                UpdateMovie update = new UpdateMovie();
                update.Visible = true;
                update.Location = new Point(200, 0);
                panel1.Controls.Add(update);
                update.BringToFront();
            }
            else
                MessageBox.Show("please Login First !");
        }

        private void searchTool_Click(object sender, EventArgs e)
        {

            if (searchType.selectedValue.ToString() == "Director")
            {
                try
                {
                    con = new OracleConnection(ordb);
                    con.Open();
                    panel1.Controls.Clear();
                    con = new OracleConnection(ordb);

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;
                    cmd.CommandText = " select movie.movie_name,movie.date_of_puplish , moviecategory.categoryname,movie.avg_rate,director.dir_name   from  movie inner join director on movie.director_id = director.dir_id inner join moviecategory ON moviecategory.categoryid = movie.category_id where director.dir_name= :name";
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add("name", searchbox.Text.ToString());
                    con.Open();
                    OracleDataReader reader = cmd.ExecuteReader();
                    for (int i = 0; reader.Read(); i++)
                    {
                        string name = reader[0].ToString();
                        string year = reader[1].ToString();
                        string category = reader[2].ToString();
                        string rate = reader[3].ToString();
                        string director = reader[4].ToString();
                        rate = get_avg_Rate(name);

                        if (rate == "null")
                            rate = "0";

                        update_rate(name, rate);

                        search s = new search(name, category, director, rate, year);
                        s.Visible = true;
                        s.Location = new Point(70, 490 * i + 5);
                        panel1.Controls.Add(s);
                        s.BringToFront();





                    }
                    reader.Close();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (searchType.selectedValue.ToString() == "Actor")
            {
                try
                {
                    panel1.Controls.Clear();
                    string cmdStr = "select movie.movie_name,movie.date_of_puplish , moviecategory.categoryname,movie.avg_rate,director.dir_name from  movie INNER JOIN movie_actor on movie_actor.movie_name=movie.movie_name INNER JOIN actor on movie_actor.actor_id=actor.actor_id inner join director on movie.director_id = director.dir_id  inner join moviecategory ON moviecategory.categoryid = movie.category_id where Actor.Actor_name=:actor_name";
                    adapter = new OracleDataAdapter(cmdStr, ordb);
                    adapter.SelectCommand.Parameters.Add("actor_name", searchbox.Text.ToString());
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {

                        string name = ds.Tables[0].Rows[i]["MOVIE_NAME"].ToString();
                        string year = ds.Tables[0].Rows[i]["DATE_OF_PUPLISH"].ToString();
                        string category = ds.Tables[0].Rows[i]["categoryname"].ToString();
                        string rate = ds.Tables[0].Rows[i]["AVG_RATE"].ToString();
                        string director = ds.Tables[0].Rows[i]["dir_name"].ToString();
                        if (rate == "")
                            rate = "0";

                        search s = new search(name, category, director, rate, year);
                        s.Visible = true;
                        s.Location = new Point(70, 490 * i + 5);
                        panel1.Controls.Add(s);
                        s.BringToFront();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }



            else if (searchType.selectedValue.ToString() == "Title")
            {

                try
                {
                    OracleConnection conn;
                    string ordb = "data source = orcl; user id =scott; password=tiger;";
                    con = new OracleConnection(ordb);
                    con.Open();
                    panel1.Controls.Clear();
                    con = new OracleConnection(ordb);

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;
                    cmd.CommandText = " select movie.movie_name,movie.date_of_puplish , moviecategory.categoryname,movie.avg_rate,director.dir_name   from  movie inner join director on movie.director_id = director.dir_id inner join moviecategory ON moviecategory.categoryid = movie.category_id where movie.movie_name= :name";
                    cmd.CommandType = CommandType.Text;

                    cmd.Parameters.Add("name", searchbox.Text.ToString());
                    con.Open();
                    OracleDataReader reader = cmd.ExecuteReader();
                    for (int i = 0; reader.Read(); i++)
                    {
                        string name = reader[0].ToString();
                        string year = reader[1].ToString();
                        string category = reader[2].ToString();
                        string rate = reader[3].ToString();
                        string director = reader[4].ToString();
                        rate = get_avg_Rate(name);

                        if (rate == "null")
                            rate = "0";

                        update_rate(name, rate);

                        search s = new search(name, category, director, rate, year);
                        s.Visible = true;
                        s.Location = new Point(70, 490 * i + 5);
                        panel1.Controls.Add(s);
                        s.BringToFront();





                    }
                    reader.Close();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }

            else if (searchType.selectedValue.ToString() == "Category")
            {

                try
                {
                    
                    con = new OracleConnection(ordb);
                    con.Open();
                    panel1.Controls.Clear();
                    con = new OracleConnection(ordb);

                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "SEARCH_CATEGORY";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("cname", searchbox.Text.ToString());
                    cmd.Parameters.Add("c", OracleDbType.RefCursor, ParameterDirection.Output);
                    con.Open();
                    OracleDataReader reader = cmd.ExecuteReader();
                    for (int i = 0; reader.Read(); i++)
                    {
                        string name = reader[0].ToString();
                        string year = reader[1].ToString();
                        string category = reader[2].ToString();
                        string rate = reader[3].ToString();
                        string director = reader[4].ToString();
                        rate = get_avg_Rate(name);

                        if (rate == "null")
                            rate = "0";

                        update_rate(name, rate);

                        search s = new search(name, category, director, rate, year);
                        s.Visible = true;
                        s.Location = new Point(70, 490 * i + 5);
                        panel1.Controls.Add(s);
                        s.BringToFront();





                    }
                    reader.Close();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            int y = 40, x = 0;



            con = new OracleConnection(ordb);
            con.Open();

         
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "view_AllMovies";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("cursor", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader reader = cmd.ExecuteReader();

            string name = "",rate="";
           while (reader.Read())
            {
                 name = reader["MOVIE_NAME"].ToString();
                string year = reader["DATE_OF_PUPLISH"].ToString();
                string category = reader["CATEGORYNAME"].ToString();
                 rate = reader["AVG_RATE"].ToString();
                string director = reader["DIR_NAME"].ToString();
                OracleCommand c = new OracleCommand();

               

                rate = get_avg_Rate(name);

                if (rate == "null")
                    rate= "0";

                update_rate(name, rate);


                search s = new search(name, category, director, rate, year);
                s.Visible = true;
                s.Location = new Point(70, x);
                panel1.Controls.Add(s);
                s.BringToFront();

                x += 495;

            }
            reader.Close();

            con.Close();


           
        }

        public static string get_avg_Rate(string name)
        {

            OracleCommand c = new OracleCommand();

            c.Connection = con;
            c.CommandText = "GETAVGRATE";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("movie_name", name);

            c.Parameters.Add("rate", OracleDbType.Int32, ParameterDirection.Output);
            c.ExecuteNonQuery();

          string  rate = c.Parameters["rate"].Value.ToString();
            return rate;

        }
        public static void update_rate(string movie ,string rate)
        {
               try
            {
                int rateno = Convert.ToInt32(rate);

                OracleCommand command = new OracleCommand();
                command.Connection = con;
                 command.CommandText = "UPDATE_AVG_RATE";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("r", rateno);

                command.Parameters.Add("n", movie);
                command.ExecuteNonQuery();
           }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchbox_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void searchType_onItemSelected(object sender, EventArgs e)
        {
               //rate above
             if (searchType.selectedValue.ToString() == "Rate above")
            {


                con = new OracleConnection(ordb);
                con.Open();
                panel1.Controls.Clear();
                con = new OracleConnection(ordb);
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM MOVIE ORDER BY AVG_RATE DESC";
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                for (int i = 0; reader.Read(); i++)
                {
                    string name = reader[0].ToString();
                    string year = reader[1].ToString();
                    string rate = reader[5].ToString();


                    rate = get_avg_Rate(name);

                    if (rate == "null")
                        rate = "0";

                    update_rate(name, rate);


                    RATE s = new RATE(name, rate, year);
                    s.Visible = true;
                    s.Location = new Point(70, 490 * i + 5);
                    panel1.Controls.Add(s);
                    s.BringToFront();


                }
                reader.Close();
                con.Close();


            }
            else if (searchType.selectedValue.ToString() == "Rate below")
            {


                con = new OracleConnection(ordb);
                con.Open();
                panel1.Controls.Clear();
                con = new OracleConnection(ordb);
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM MOVIE ORDER BY AVG_RATE";
                cmd.CommandType = CommandType.Text;
                OracleDataReader reader = cmd.ExecuteReader();
                for (int i = 0; reader.Read(); i++)
                {
                    string name = reader[0].ToString();
                    string year = reader[1].ToString();
                    string rate = reader[5].ToString();


                    rate = get_avg_Rate(name);

                    if (rate == "null")
                        rate = "0";

                    update_rate(name, rate);

                    RATE s = new RATE(name, rate, year);
                    s.Visible = true;
                    s.Location = new Point(70, 490 * i + 5);
                    panel1.Controls.Add(s);
                    s.BringToFront();


                }
                reader.Close();
                con.Close();


            }

        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            if (userID != 0)
            {
                Reports report = new Reports();
                report.Visible = true;
                report.Location = new Point(100, 95);
                report.BringToFront();
            }
            else
                MessageBox.Show("please Login First !");
        }

        private void btn_Manage_Click(object sender, EventArgs e)
        {
            if (userID != 0)
            {
                manage manage = new manage();
            manage.Visible = true;
            manage.Location = new Point(100, 95);
            manage.BringToFront();
        }
            else
                MessageBox.Show("please Login First !");
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            if (userID != 0)
            {
                panel1.Controls.Clear();
                user_profile user = new user_profile();
                user.Visible = true;
                user.Location = new Point(200, 0);
                panel1.Controls.Add(user);
                user.BringToFront();
            }
            else
                MessageBox.Show("please Login First !");
            
        }
    }
}
