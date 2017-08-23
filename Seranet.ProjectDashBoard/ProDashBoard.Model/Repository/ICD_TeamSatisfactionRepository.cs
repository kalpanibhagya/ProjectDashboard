using ProDashBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProDashBoard.Model.Repository
{
    public interface ICD_TeamSatisfactionRepository
    {
        List<CD_SatisfactionData> Get();
        List<CD_ProjectSatisfactionData> GetProjects(int Year, int Quarter);

        int getCompletion(int Year, int Quarter);

        List<UserTeamSatisfaction> GetUserTeamSatisfaction(int year, int quarter);
        List<Account> GetAccounts();

        List<UserTeamSatisfaction> GetBurningIssues(int year, int quarter);
    }
}
