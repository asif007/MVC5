using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MVC5.ViewModel;
namespace MVC5.WebForm
{
    public partial class MyForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Book> books = Book.GetBooks();
            var bookdetails = from r in books
                              select new
                              {
                                  r.ID,
                                  r.Title,
                                  r.Price,
                                  r.DateOfRelease
                              };
            foreach (var items in bookdetails) {
                prouctid.Text += string.Format("{0} <br/>",items);
            }

            IEnumerable<Book> Ebook = Book.GetBooks();
            IEnumerable<sales> sale = sales.GetDetails();
            var joining=from r in Ebook join t in sale
                                      on r.ID equals t.ID
                                      select  new{
                                        Name=r.Title,pages=t.pages
                                      };
            foreach (var item in joining) {
                Label1.Text += string.Format("{0} <br/>",item);
            }
        }

        protected void button_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textbox1.Text);
            int b = Convert.ToInt32(textbox2.Text);
            int sum = a + b;
            int diff = a - b;
            int div = a / b;
            m1.Text = string.Format("sum= {0}",sum);
            m2.Text = string.Format("diff= {0}", diff);
            m3.Text = string.Format("div= {0}", div);
            
            
        }
    }
}