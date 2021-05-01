using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tp_9
{
    public partial class Gestion_Des_Client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RemplirDpl();
                DropDownList1.AutoPostBack = true;
            }
            
        }

        protected void Add_Btn_Click(object sender, EventArgs e)
        {
            try {
                Connection.cmd.Parameters.Clear();
                Connection.cn.Open();
                Connection.cmd.CommandText = "INSERT INTO Client VALUES (@nom,@prenom,@adresse,@ville);";
                Connection.cmd.Parameters.AddWithValue("@nom", txt_nom.Text);
                Connection.cmd.Parameters.AddWithValue("@prenom", txt_prenom.Text);
                Connection.cmd.Parameters.AddWithValue("@adresse", txt_adresse.Text);
                Connection.cmd.Parameters.AddWithValue("@ville", txt_ville.Text);
                int Check = Connection.cmd.ExecuteNonQuery();
                if (Check > 0)
                {
                    lbl_error.Text = "Inserted Successfully";
                }
                else
                {
                    lbl_error.Text = "Insert Failed";
                }
            }
            catch(Exception ex) {
                Response.Write("<script>alert(" + ex.Message + ")</script>");
            }finally{
                Connection.cn.Close();
                RemplirDpl();
                Vider();
            }
        }
        public void RemplirDpl()
        {
            if(DropDownList1.Items.Count!=0)
                DropDownList1.Items.Clear();
            try
            {
                DropDownList1.Items.Insert(0, "--- Selectionner un Client ---");
                Connection.cn.Open();
                Connection.cmd.CommandText = "SELECT nom +' '+prenom AS 'client' FROM Client;";
                Connection.dr = Connection.cmd.ExecuteReader();
                while (Connection.dr.Read())
                {
                    DropDownList1.Items.Add(Connection.dr["client"].ToString());
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert(" + ex.Message + ")</script>");
            }
            finally
            {
                Connection.dr.Close();
                Connection.cn.Close();
            }

        }
        protected void Update_Btn1_Click(object sender, EventArgs e)
        {

        }

        protected void Delete_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.cmd.Parameters.Clear();
                Connection.cn.Open();
                Connection.cmd.CommandText = "DELETE FROM Client WHERE id=@id";
                Connection.cmd.Parameters.AddWithValue("@id", DropDownList1.SelectedIndex);
                int Check = Connection.cmd.ExecuteNonQuery();
                if (Check > 0)
                {
                    lbl_error.Text = "Inserted Successfully";
                }
                else
                {
                    lbl_error.Text = "Insert Failed";
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(" + ex.Message + ")</script>");
            }
            finally
            {
                Connection.cn.Close();
                RemplirDpl();
                Vider();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.Items.Count > 0)
            {
                Connection.cmd.Parameters.Clear();
                try
                {
                    Connection.cn.Open();
                    Connection.cmd.CommandText = "SELECT * FROM  Client WHERE id=@id";
                    Connection.cmd.Parameters.AddWithValue("@id", DropDownList1.SelectedIndex);
                    Connection.dr = Connection.cmd.ExecuteReader();
                    if (Connection.dr.Read())
                    {
                        lbl_error.Text = "read data in postback";
                        txt_nom.Text = Connection.dr[1].ToString();
                        txt_prenom.Text = Connection.dr[2].ToString();
                        txt_adresse.Text = Connection.dr[3].ToString();
                        txt_ville.Text = Connection.dr[4].ToString();
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert(" + ex.Message + ")</script>");
                }
                finally
                {
                    Connection.dr.Close();
                    Connection.cn.Close();
                }
            }
        }

        protected void Update_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.cmd.Parameters.Clear();
                Connection.cn.Open();
                Connection.cmd.CommandText = "UPDATE Client SET nom=@nom,prenom=@prenom,adresse=@adresse,ville=@ville WHERE id=@id";
                Connection.cmd.Parameters.AddWithValue("@id", DropDownList1.SelectedIndex);
                Connection.cmd.Parameters.AddWithValue("@nom", txt_nom.Text);
                Connection.cmd.Parameters.AddWithValue("@prenom", txt_prenom.Text);
                Connection.cmd.Parameters.AddWithValue("@adresse", txt_adresse.Text);
                Connection.cmd.Parameters.AddWithValue("@ville", txt_ville.Text);
                int Check = Connection.cmd.ExecuteNonQuery();
                if (Check > 0)
                {
                    lbl_error.Text = "Inserted Successfully";
                }
                else
                {
                    lbl_error.Text = "Insert Failed";
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert(" + ex.Message + ")</script>");
            }
            finally
            {
                Connection.cn.Close();
                RemplirDpl();
            }
        }

        protected void Clear_Btn0_Click(object sender, EventArgs e)
        {
            Vider();
        }
        public void Vider()
        {
            List<TextBox> textBoxes = new List<TextBox> { txt_nom, txt_prenom, txt_adresse, txt_ville };
            for (int i = 0; i < textBoxes.Count; i++)
                textBoxes[i].Text = string.Empty;
            txt_ville.Focus();
        }
    }
}