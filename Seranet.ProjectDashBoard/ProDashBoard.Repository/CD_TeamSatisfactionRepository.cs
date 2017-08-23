﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProDashBoard.Model;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using System.Diagnostics;
using ProDashBoard.Model.Repository;
using ProDashBoard.Models;

namespace ProDashBoard.Data
{
    public class CD_TeamSatisfactionRepository : ICD_TeamSatisfactionRepository
    {
        private readonly IDbConnection _db;
        //private AuthorizationRepository authRepo;
        private AppSettingsRepository repo = new AppSettingsRepository();        
        public CD_TeamSatisfactionRepository()
        {
            _db = new SqlConnection(ConfigurationManager.ConnectionStrings["DashBoard1"].ConnectionString);
            //authRepo = new AuthorizationRepository();
        }

        public List<CD_SatisfactionData> Get()
        {
            List<CD_SatisfactionData> resultsArray = this._db.Query("select top 7 Year,Quarter,Rating,Completion,burningIssues FROM CD_TeamSatisfaction order by Year desc, Quarter desc").Select(d => new CD_SatisfactionData { Year = d.Year, Quarter = d.Quarter, Rating = d.Rating, Completion = d.Completion, BurningIssues=d.burningIssues}).ToList();

            return resultsArray;
        }

        public List<Account> GetAccounts()
        {
            List<Account> Completed = this._db.Query("select AccountName from Account where Availability = 1").Select(d => new Account { AccountName = d.AccountName }).ToList();
            return Completed;
        }

        public int getCompletion(int Year, int Quarter)
        {
            List<CD_SatisfactionData> Completed = this._db.Query("SELECT Year FROM [ProjectDashboard].[dbo].[TeamSatisfactionEmployeeSummary] where year="+Year+ "and Quarter ="+Quarter+";").Select(d => new CD_SatisfactionData { Year = d.Year}).ToList();
            return Completed.Count();
        }

        public List<CD_ProjectSatisfactionData> GetProjects(int year,int quarter)
        {
            List<CD_ProjectSatisfactionData> resultsArray = this._db.Query("SELECT  pj.AccountName, sumr.Rating, sumr.ProjectID FROM Summary sumr join Account pj on sumr.ProjectID = pj.Id where sumr.Year ="+year+" and sumr.Quarter ="+quarter + " and sumr.Rating !=0 order by ABS(sumr.Rating) desc; ").Select(d => new CD_ProjectSatisfactionData { Name =d.AccountName, Rating = d.Rating ,projectID=d.ProjectID}).ToList();

            return resultsArray;
        }

        public List<UserTeamSatisfaction> GetUserTeamSatisfaction(int year, int quarter)
        {
            List<UserTeamSatisfaction> resultsArray = this._db.Query("SELECT tm.MemberName,ts.Rating,acc.AccountName from TeamSatisfactionEmployeeSummary ts join TeamMembers tm  on ts.EmpId=tm.Id join Account acc on acc.Id=ts.AccountId  where ts.Year="+year+ "and ts.Quarter="+quarter+";").Select(d => new UserTeamSatisfaction { Name = d.MemberName, Rating = d.Rating,Account=d.AccountName }).ToList();
            return resultsArray;
        }

        public List<UserTeamSatisfaction> GetBurningIssues(int year, int quarter)
        {
            int No = repo.getBurningQuestionNo();
            List<UserTeamSatisfaction> resultsArray = this._db.Query("SELECT tm.MemberName,ts.Comment,acc.AccountName from Results ts join TeamMembers tm  on ts.MemberId=tm.Id join Account acc on acc.Id=ts.AccountID  where ts.Year=" + year + "and ts.Quarter=" + quarter + " and ts.Answer=0 and ts.QuestionID="+No+";").Select(d => new UserTeamSatisfaction { Name = d.MemberName, Comment = d.Comment, Account = d.AccountName }).ToList();
            return resultsArray;
        }
    }


}