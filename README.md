# Dotnet_lab
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaskForm.aspx.cs" Inherits="TaskManagerWebForm.TaskForm" %>

<!DOCTYPE html>
<html>
<head><title>Task Form</title></head>
<body>
    <form id="form1" runat="server">
        <h2>Add/Edit Task</h2>
        <asp:HiddenField ID="hfTaskId" runat="server" />

        <asp:Label Text="Title:" runat="server" /><br />
        <asp:TextBox ID="txtTitle" runat="server" /><br />

        <asp:Label Text="Description:" runat="server" /><br />
        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Rows="4" /><br />

        <asp:Label Text="Status:" runat="server" /><br />
        <asp:DropDownList ID="ddlStatus" runat="server">
            <asp:ListItem Text="Pending" Value="Pending" />
            <asp:ListItem Text="Completed" Value="Completed" />
        </asp:DropDownList><br /><br />

        <asp:Button ID="btnSave" Text="Save" runat="server" OnClick="btnSave_Click" />
        <asp:Label ID="lblMessage" runat="server" ForeColor="Green" />
    </form>
</body>
</html>


using System;
using System.Configuration;
using System.Data.SqlClient;

namespace TaskManagerWebForm
{
    public partial class TaskForm : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["TaskDbConnection"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    int taskId = Convert.ToInt32(Request.QueryString["id"]);
                    LoadTask(taskId);
                }
            }
        }

        protected void LoadTask(int taskId)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Tasks WHERE TaskId = @TaskId", con);
                cmd.Parameters.AddWithValue("@TaskId", taskId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    hfTaskId.Value = reader["TaskId"].ToString();
                    txtTitle.Text = reader["Title"].ToString();
                    txtDescription.Text = reader["Description"].ToString();
                    ddlStatus.SelectedValue = reader["Status"].ToString();
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd;

                if (string.IsNullOrEmpty(hfTaskId.Value)) // Insert
                {
                    cmd = new SqlCommand("INSERT INTO Tasks (Title, Description, Status) VALUES (@Title, @Description, @Status)", con);
                }
                else // Update
                {
                    cmd = new SqlCommand("UPDATE Tasks SET Title=@Title, Description=@Description, Status=@Status WHERE TaskId=@TaskId", con);
                    cmd.Parameters.AddWithValue("@TaskId", Convert.ToInt32(hfTaskId.Value));
                }

                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Parameters.AddWithValue("@Status", ddlStatus.SelectedValue);

                cmd.ExecuteNonQuery();

                lblMessage.Text = "Task saved successfully!";
            }
        }
    }
}
