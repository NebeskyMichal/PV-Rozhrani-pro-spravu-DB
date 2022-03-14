using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace SkolniKurzy
{
    public partial class Form1 : Form
    {
        private string actionName;
        private SqlConnection connection = null;


        /// <summary>
        /// Získá název akce, kterou uživatel chce použivat (Vytvorit,Upravit,Smazat)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private string ActionSelect(object sender, EventArgs e)
        {
            menuBox.Visible = false;
            createBox.Visible = true;
            return (sender as Button).Text;
        }

        /// <summary>
        /// Na základě vybrané funkce a datech zadaných v text boxech provede daný SQL příkaz, pro tabulku ucitel.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="datum_narozeni"></param>
        private void UcitelAction(string action, string jmeno, string prijmeni, string datum_narozeni)
        {
            try
            {
                if (action.Equals("Vytvorit"))
                {
                    string insert = "insert into ucitel values('" + jmeno + "','" + prijmeni + "','" + datum_narozeni + "')";
                    SqlCommand command = new SqlCommand(insert, connection);
                    command.ExecuteNonQuery();
                }
                else if (action.Equals("Upravit"))
                {
                    string update = "update ucitel set prijmeni='" + prijmeni + "'where jmeno='" + jmeno + "' and datum_narozeni='" + datum_narozeni + "'";
                    SqlCommand command = new SqlCommand(update, connection);
                    command.ExecuteNonQuery();
                }
                else if (action.Equals("Smazat"))
                {
                    string delete = "delete from ucitel where jmeno='" + jmeno + "' and prijmeni='" + prijmeni + "' and datum_narozeni='" + datum_narozeni + "'";
                    SqlCommand command = new SqlCommand(delete, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Toto nelze, opravte vaše udaje!");
            }
        }
        /// <summary>
        ///Na základě vybrané funkce a datech zadaných v text boxech provede daný SQL příkaz, pro tabulku kurz.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="ucitel_id"></param>
        /// <param name="nazev"></param>
        private void KurzAction(string action, string ucitel_id, string nazev)
        {
            try
            {
                if (action.Equals("Vytvorit"))
                {
                    string insert = "insert into kurz values(" + ucitel_id + ",'" + nazev + "')";
                    SqlCommand command = new SqlCommand(insert, connection);
                    command.ExecuteNonQuery();
                }
                else if (action.Equals("Upravit"))
                {
                    string update = "update kurz set ucitel_id=" + ucitel_id + "where nazev='" + nazev + "'";
                    SqlCommand command = new SqlCommand(update, connection);
                    command.ExecuteNonQuery();
                }
                else if (action.Equals("Smazat"))
                {
                    string delete = "delete from kurz where ucitel_id=" + ucitel_id + " and nazev='" + nazev + "'";
                    SqlCommand command = new SqlCommand(delete, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Toto nelze, opravte vaše udaje!");
            }
        }
        /// <summary>        
        ///Na základě vybrané funkce a datech zadaných v text boxech provede daný SQL příkaz, pro tabulku student.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        private void StudentAction(string action, string jmeno, string prijmeni)
        {
            try
            {
                if (action.Equals("Vytvorit"))
                {
                    string insert = "insert into student values('" + jmeno + "','" + prijmeni + "')";
                    SqlCommand command = new SqlCommand(insert, connection);
                    command.ExecuteNonQuery();
                }
                else if (action.Equals("Upravit"))
                {
                    string update = "update student set prijmeni='" + prijmeni + "'where jmeno='" + jmeno + "'";
                    SqlCommand command = new SqlCommand(update, connection);
                    command.ExecuteNonQuery();
                }
                else if (action.Equals("Smazat"))
                {
                    string delete = "delete from student where jmeno='" + jmeno + "' and prijmeni='" + prijmeni + "'";
                    SqlCommand command = new SqlCommand(delete, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Toto nelze, opravte vaše udaje!");
            }
        }
        /// <summary>
        /// Na základě vybrané funkce a datech zadaných v text boxech provede daný SQL příkaz, pro tabulku zapis_kurzu.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="kurz_id"></param>
        /// <param name="student_id"></param>
        /// <param name="datum_konani"></param>
        /// <param name="cena_kurzu"></param>
        private void ZapisAction(string action, string kurz_id, string student_id, string datum_konani, string cena_kurzu)
        {
            try
            {
                if (action.Equals("Vytvorit"))
                {
                    string insert = "insert into zapis_kurzu values(" + kurz_id + "," + student_id + ",'" + datum_konani + "'," + cena_kurzu + ")";
                    SqlCommand command = new SqlCommand(insert, connection);
                    command.ExecuteNonQuery();
                }
                else if (action.Equals("Upravit"))
                {
                    string update = "update zapis_kurzu set datum_konani='" + datum_konani + "', cena_kurzu=" + cena_kurzu + "where kurz_id=" + kurz_id + "";
                    SqlCommand command = new SqlCommand(update, connection);
                    command.ExecuteNonQuery();
                }
                else if (action.Equals("Smazat"))
                {
                    string delete = "delete from zapis_kurzu where kurz_id=" + kurz_id + " and student_id=" + student_id + " and datum_konani='" + datum_konani + "' and cena_kurzu=" + cena_kurzu;
                    SqlCommand command = new SqlCommand(delete, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Toto nelze, opravte vaše udaje!");
            }
        }
        /// <summary>
        /// Základní metoda Form1 Inicializuje komponenty WindowsForms a poté se připojí do databáze pomocí udájů z souboru App.config, taktéž volá metody, které naplní GridView pro všechny tabulky.
        /// </summary>
        public Form1()
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
            InitializeComponent();
            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    connection = new SqlConnection(cs.ConnectionString);
                }
                try
                {
                    connection.Open();
                    Debug.Write("Connection succesfull!");
                }
                catch (Exception e)
                {
                    Debug.Write("Connection failed!");
                }
            }
            UcitelGrid();
            KurzGrid();
            StudentGrid();
            ZapisGrid();
        }

        /// <summary>
        /// Při načtení aplikace, metoda schová všechny zatím nepotřebné GroupBoxy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            createBox.Visible = false;
            kurzBox.Visible = false;
            studentBox.Visible = false;
            zapisBox.Visible = false;
            ucitelBox.Visible = false;
        }

        /// <summary>
        /// Po kliknutí na toto tlacitko se objevi GroupBox pro kurz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            kurzBox.Visible = true;
            createBox.Visible = false;
        }
        /// <summary>
        /// Po kliknutí na toto tlacitko se objevi GroupBox pro ucitel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            ucitelBox.Visible = true;
            createBox.Visible = false;
        }
        /// <summary>
        /// Po kliknutí na toto tlacitko se objevi GroupBox pro student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void student_Click(object sender, EventArgs e)
        {
            studentBox.Visible = true;
            createBox.Visible = false;

        }
        /// <summary>
        /// Po kliknutí na toto tlacitko se objevi GroupBox pro zapis_kurzu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zapis_Click(object sender, EventArgs e)
        {
            zapisBox.Visible = true;
            createBox.Visible = false;
        }

        /// <summary>
        /// Jedno z tlacitek hlavni meny, která udavá vybranou akci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            actionName = ActionSelect(sender, e);
        }
             /// <summary>
        /// Jedno z tlacitek hlavni meny, která udavá vybranou akci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            actionName = ActionSelect(sender, e);
        }
        /// <summary>
        /// Jedno z tlacitek hlavni meny, která udavá vybranou akci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuDrop_Click(object sender, EventArgs e)
        {
            actionName = ActionSelect(sender, e);
        }
        /// <summary>
        /// Metoda, ktera vyexportuje udaje z tabulky zapis_kurzu do souboru zapis.csv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuSave_Click(object sender, EventArgs e)
        {
            zapisGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            zapisGridView.SelectAll();
            DataObject dataObject = zapisGridView.GetClipboardContent();
            File.WriteAllText("zapis.csv", dataObject.GetText(TextDataFormat.CommaSeparatedValue));
            MessageBox.Show("Soubor zapis.csv je uložen v adresaři projektu ./SkolniKurzy/bin/debug/zapis.csv");
        }
        /// <summary>
        /// Tlacitko si veme udaje z TextBoxu a na zakladě předchozi akce zavola SQL přikaz z metody UcitelAction();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            string jmeno = ucBox1.Text;
            string prijmeni = ucBox2.Text;
            string datum_narozeni = ucBox3.Text;
            UcitelAction(actionName, jmeno, prijmeni, datum_narozeni);
        }
        /// <summary>
        /// Tlacitko si veme udaje z TextBoxu a na zakladě předchozi akce zavola SQL přikaz z metody KurzAction();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_2(object sender, EventArgs e)
        {
            string ucitel_id = kurzBox1.Text;
            string nazev = kurzBox2.Text;
            KurzAction(actionName,ucitel_id, nazev);
        }/// <summary>
         /// Tlacitko si veme udaje z TextBoxu a na zakladě předchozi akce zavola SQL přikaz z metody StudentAction();
         /// </summary>
         /// <param name="sender"></param>
         /// <param name="e"></param>

        private void studButton_Click(object sender, EventArgs e)
        {
            string jmeno = studBox1.Text;
            string prijmeni = studBox2.Text;
            StudentAction(actionName, jmeno, prijmeni);
        }
        /// <summary>
        /// Tlacitko si veme udaje z TextBoxu a na zakladě předchozi akce zavola SQL přikaz z metody ZapisAction();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zapButton_Click(object sender, EventArgs e)
        {
            string kurz_id = zapBox1.Text;
            string student_id = zapBox2.Text;
            string datum_konani = zapBox3.Text;
            string cena_kurzu = zapBox4.Text;
            ZapisAction(actionName, kurz_id, student_id, datum_konani, cena_kurzu);
        }

        /// <summary>
        /// Jedno z tlačitek, které funguje jako zpětné tlačítko, tudíž vráti uživatele na GroupBox předtím
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createBack_Click(object sender, EventArgs e)
        {
            createBox.Visible = false;
            menuBox.Visible = true;
        }
        /// <summary>
        /// Jedno z tlačitek, které funguje jako zpětné tlačítko, tudíž vráti uživatele na GroupBox předtím
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zapisBack_Click(object sender, EventArgs e)
        {
            zapisBox.Visible = false;
            createBox.Visible = true;
        }
        /// <summary>
        /// Jedno z tlačitek, které funguje jako zpětné tlačítko, tudíž vráti uživatele na GroupBox předtím
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void studBack_Click(object sender, EventArgs e)
        {
            studentBox.Visible = false;
            createBox.Visible = true;
        }
        /// <summary>
        /// Jedno z tlačitek, které funguje jako zpětné tlačítko, tudíž vráti uživatele na GroupBox předtím
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void kurzBack_Click(object sender, EventArgs e)
        {
            kurzBox.Visible = false;
            createBox.Visible = true;
        }
        /// <summary>
        /// Jedno z tlačitek, které funguje jako zpětné tlačítko, tudíž vráti uživatele na GroupBox předtím
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucitelBack_Click(object sender, EventArgs e)
        {
            ucitelBox.Visible = false;
            createBox.Visible = true;
        }
        /// <summary>
        /// Tlačítko ukončí program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Metoda naplní GridView pro tabulku ucitel daty z databáze
        /// </summary>
        private void UcitelGrid()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM ucitel", connection))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
        /// <summary>
        /// Metoda naplní GridView pro tabulku kurz daty z databáze
        /// </summary>
        private void KurzGrid()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM kurz inner join ucitel on ucitel.id = kurz.ucitel_id", connection))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        kurzGridView.DataSource = dt;
                    }
                }
            }
        }
        /// <summary>
        /// Metoda naplní GridView pro tabulku student daty z databáze
        /// </summary>
        private void StudentGrid()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM student", connection))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        studentGridView.DataSource = dt;
                    }
                }
            }
        }
        /// <summary>
        /// Metoda naplní GridView pro tabulku zapis_kurzu daty z databáze
        /// </summary>
        private void ZapisGrid()
        {
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM zapis_kurzu inner join kurz on kurz.id = zapis_kurzu.kurz_id inner join student on student.id = zapis_kurzu.student_id", connection))
            {
                cmd.CommandType = CommandType.Text;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        zapisGridView.DataSource = dt;
                    }
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void kurzBox_Enter(object sender, EventArgs e)
        {

        }

        private void studentBox_Enter(object sender, EventArgs e)
        {

        }

        private void zapisBox_Enter(object sender, EventArgs e)
        {

        }

        private void createBox_Enter(object sender, EventArgs e)
        {

        }

        private void viewButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
