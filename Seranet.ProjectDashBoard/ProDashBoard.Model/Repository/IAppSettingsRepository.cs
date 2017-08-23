﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDashBoard.Model.Repository
{
    public interface IAppSettingsRepository
    {
        string getThreshold();
        string getSpecLink();
        string getProcessComplianceLink();
        bool getCorporateDashboard();
        string getRiskLink();
        string getRiskURL();
        int getNPSQuestionNo();
        string getEmailUserName();
        string getEmailPassword();
        string getEmailUri();
        string getEmailDomain();
        string getEmailBodyLink();
        int getBurningQuestionNo();
    }
}
