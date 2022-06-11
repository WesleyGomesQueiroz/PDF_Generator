using System.Text;

namespace PDF_Generator.Utility
{
    public static class TemplateGenerator
    {
        public static string GetHTMLString()
        {
            var employees = DataStorage.GetAllEmployess();
            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <body>
                                <div class='header'><h1>This is the generated PDF report!!!</h1></div>
                                <table align='center'>
                                    <tr><th>Name</th> <th>LastName</th> <th>Age</th> <th>Gender</th></tr>");

            foreach (var emp in employees)
            {
                sb.AppendFormat($"<tr><td>{ emp.Name}</td> <td>{ emp.LastName}</td> <td>{ emp.Age}</td> <td>{ emp.Gender}</td> </tr>");
            }

            sb.Append(@"
                                </table>
                            </body>
                        </html>");
            return sb.ToString();
        }
    }
}
