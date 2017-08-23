using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProDashBoard.Model
{
    public class UserTeamSatisfaction
    {
        public String Name { get; set; }
        public decimal Rating { get; set; }
        public string Account { get; set; }

        public string Comment { get; set; }

    }
}