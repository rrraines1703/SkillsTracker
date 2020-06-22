using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        [HttpGet("/skills/")]
        public IActionResult Index()
        {
            string html = "<h1><b>Skills Tracker</b></h1>" +
                "<h2><b>Coding skills to learn:</b></h2>" + 
                " <ol>" +
                "<li>C#</li>" +
                "<li>JavaScript</li>" +
                "<li>Python</li>";

            return Content(html, "text/html");
        }
        [HttpGet("/skills/form/")]
        public IActionResult Form()
        {
            string html = "<form method = 'post' action = '/skills/form'>" +
                "<label for='date'><b>Date:</b></label><input type='date' id='date' name='date'>" + "<br>" +
                "<label for='csharp'><b>C#:</b></label>" + "<br>" +
                "<select id='csharp' name='csharp'>" + "<br>" +
                    "<option value='learning basics'>Learning Basics</option>" +
                    "<option value='making apps'>Making Apps</option>" +
                    "<option value='master coder'>Master Coder</option>" +
                "</select>" + "<br>" +
                "<label for='javascript'><b>JavaScript:</b></label>" + "<br>" +
                "<select id='javascript' name='javascript'>" + "<br>" +
                    "<option value='learning basics'>Learning Basics</option>" +
                    "<option value='making apps'>Making Apps</option>" +
                    "<option value='master coder'>Master Coder</option>" +
                "</select>" + "<br>" +
                "<label for='python'><b>Python:</b></label>" + "<br>" +
                "<select id='python' name='python'>" + "<br>" +
                    "<option value='learning basics'>Learning Basics</option>" +
                    "<option value='making apps'>Making Apps</option>" +
                    "<option value='master coder'>Master Coder</option>" +
                "</select>" + "<br>" +
                "<input type='submit' value='Submit'/>" +
                "</form>";

            return Content(html, "text/html");
        }
        [HttpPost("/skills/form/")]
        public IActionResult InputResults(string date, string csharp, string javascript, string python)
        {
            string html = $"<h1><b>{date}</b></h1>" +
                " <ol>" +
                $"<li><b>C#: </b>{csharp}</li>" +
                $"<li><b>JavaScript: </b>{javascript}</li>" +
                $"<li><b>Python: </b>{python}</li>";
            return Content(html, "text/html");
        }

    }
}
