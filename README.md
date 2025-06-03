# Dotnet_lab
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TaskForm.aspx.cs" Inherits="TaskManagerWebForm.TaskForm" %>


public partial class _Default : System.Web.UI.Page
{
    public class Item
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    [WebMethod]
    public static List<Item> GetMessage()
    {
        List<Item> list = new List<Item>();
        string connectionString = ConfigurationManager.ConnectionStrings["YourConnStr"].ConnectionString;

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            string query = "SELECT Id, Name FROM YourTable";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Item
                {
                    Id = reader["Id"].ToString(),
                    Name = reader["Name"].ToString()
                });
            }
        }

        return list;
    }
}



<script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>

<select id="myDropdown">
  <option value="">-- Select --</option>
</select>

<script>
  $(document).ready(function () {
    $.ajax({
      type: "POST",
      url: "Default.aspx/GetMessage",
      data: '{}',
      contentType: "application/json; charset=utf-8",
      dataType: "json",
      success: function (response) {
        var items = response.d;
        var $dropdown = $('#myDropdown');
        $.each(items, function (i, item) {
          $dropdown.append($('<option>', {
            value: item.Id,
            text: item.Name
          }));
        });
      },
      error: function (xhr) {
        if (xhr.status === 401) {
          alert("Unauthorized. Please log in.");
          window.location.href = "/Login.aspx";
        } else {
          alert("Error: " + xhr.statusText);
        }
      }
    });
  });
</script>

       


