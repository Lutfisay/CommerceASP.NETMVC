using CommerceData.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace CommerceWeb.Controllers
{
    public class CategoryController : Controller
    {
        string connectionString = "Server=DESKTOP-TKJ8MV6\\SQLEXPRESS;Database=CommerceLCS;Trusted_Connection=True;";
// GET: Category
        public ActionResult CategoryList()
        {
            var model = new List<Category>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var sql = "Select * from Category";
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, connection))
                {
                    var table = new DataTable();
                    adapter.Fill(table);
                    
                    foreach (DataRow row in table.Rows)
                    {
                        var category = new Category();
                        //Id, ParentId, Name,Description, PictureId, DisplayOrder, IsActive
                        category.Id = Int32.Parse(row["Id"].ToString());
                        category.ParentId = Int32.Parse(row["ParentId"].ToString());
                        category.Name = (row["Name"].ToString());
                        category.Description = (row["Description"].ToString());
                        category.PictureId = Int32.Parse(row["PictureId"].ToString());
                        category.DisplayOrder = Int32.Parse(row["DisplayOrder"].ToString());
                        category.IsActive = Boolean.Parse(row["IsActive"].ToString());
                        model.Add(category);

                    }
                }
            }
                return View(model);
        }
    }
}