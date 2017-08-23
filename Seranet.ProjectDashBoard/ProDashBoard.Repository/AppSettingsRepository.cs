﻿using ProDashBoard.Model.Repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Configuration;

namespace ProDashBoard.Data
{
    public class AppSettingsRepository : IAppSettingsRepository
    {
        Configuration rootWebConfig;
        public AppSettingsRepository() {

            rootWebConfig=WebConfigurationManager.OpenWebConfiguration("~/Web.config");
        }

        public string getThreshold() {
            KeyValueConfigurationElement customSetting=null;
            if (rootWebConfig.AppSettings.Settings.Count > 0)
            {
                customSetting =
                    rootWebConfig.AppSettings.Settings["threshold"];
                if (customSetting != null) {
                    Debug.WriteLine("threshold " + customSetting.Value);

            } else
                Debug.WriteLine("No threshold application string");
            }
            return customSetting.Value;
        }

        public string getSpecLink()
        {
            KeyValueConfigurationElement customSetting = null;
            if (rootWebConfig.AppSettings.Settings.Count > 0)
            {
                customSetting =
                    rootWebConfig.AppSettings.Settings["specLink"];
                if (customSetting != null)
                {
                    Debug.WriteLine("specLink " + customSetting.Value);

                }
                else
                    Debug.WriteLine("No specLink application string");
            }
            return customSetting.Value;
        }

        public string getProcessComplianceLink()
        {
            KeyValueConfigurationElement customSetting = null;
            if (rootWebConfig.AppSettings.Settings.Count > 0)
            {
                customSetting =
                    rootWebConfig.AppSettings.Settings["processComplianceLink"];
                if (customSetting != null)
                {
                    Debug.WriteLine("processComplianceLink " + customSetting.Value);

                }
                else
                    Debug.WriteLine("No processComplianceLink application string");
            }
            return customSetting.Value;
        }

        public string getProcessComplianceVersion() {
            //processComplianceVersion
            KeyValueConfigurationElement customSetting = null;
            if (rootWebConfig.AppSettings.Settings.Count > 0)
            {
                customSetting =
                    rootWebConfig.AppSettings.Settings["processComplianceVersion"];
                if (customSetting != null)
                {
                    Debug.WriteLine("processComplianceVersion " + customSetting.Value);

                }
                else
                    Debug.WriteLine("No processComplianceVersion application string");
            }
            return customSetting.Value;
        }

        public bool getCorporateDashboard()
        {
            KeyValueConfigurationElement customSetting = null;
            if (rootWebConfig.AppSettings.Settings.Count > 0)
            {
                customSetting =
                    rootWebConfig.AppSettings.Settings["CorporateDashboard"];

                if (customSetting != null)
                {
                    Debug.WriteLine("CorporateDashboard " + customSetting.Value);
                    if (customSetting.Value == "true")
                    {
                        return true;
                    }
                    else if (customSetting.Value == "false")
                    {
                        return false;
                    }
                    else
                    {
                        Debug.WriteLine("Check web config");
                        return false;
                    }


                }
                else
                {
                    Debug.WriteLine("No CorporateDashboard application string");
                    return false;
                }
            }else { 
            return false;
            }
        }

        public string getRiskLink()
        {
            KeyValueConfigurationElement customSetting = null;
            if (rootWebConfig.AppSettings.Settings.Count > 0)
            {
                customSetting =
                    rootWebConfig.AppSettings.Settings["riskLink"];
                if (customSetting != null)
                {
                    Debug.WriteLine("riskLink " + customSetting.Value);

                }
                else
                    Debug.WriteLine("No riskLink application string");
            }

          
                return customSetting.Value;
        }

        public string getRiskURL()
        {
            KeyValueConfigurationElement customSetting = null;
            if (rootWebConfig.AppSettings.Settings.Count > 0)
            {
                customSetting =
                    rootWebConfig.AppSettings.Settings["riskDashboard"];
                if (customSetting != null)
                {
                    Debug.WriteLine("riskDashboard " + customSetting.Value);

                }
                else
                    Debug.WriteLine("No riskDashboard application string");
            }


            return customSetting.Value;
        }

        public int getNPSQuestionNo()
        {
            KeyValueConfigurationElement customSetting = null;
            if (rootWebConfig.AppSettings.Settings.Count > 0)
            {
                customSetting =
                    rootWebConfig.AppSettings.Settings["NPSquestionNo"];
                if (customSetting != null)
                {
                    Debug.WriteLine("NPSquestionNo " + customSetting.Value);

                }
                else
                    Debug.WriteLine("No NPSquestionNo application string");
            }


            return Int32.Parse(customSetting.Value);
        }

        public string getEmailUserName()
        {
            KeyValueConfigurationElement customSetting = null;
            if (rootWebConfig.AppSettings.Settings.Count > 0)
            {
                customSetting =
                    rootWebConfig.AppSettings.Settings["emailUserName"];
                if (customSetting != null)
                {
                    Debug.WriteLine("emailUserName " + customSetting.Value);

                }
                else
                    Debug.WriteLine("No emailUserName string");
            }
            return customSetting.Value;
        }

        public string getEmailPassword()
        {
            KeyValueConfigurationElement customSetting = null;
            if (rootWebConfig.AppSettings.Settings.Count > 0)
            {
                customSetting =
                    rootWebConfig.AppSettings.Settings["emailPassword"];
                if (customSetting != null)
                {
                    Debug.WriteLine("emailPassword " + customSetting.Value);

                }
                else
                    Debug.WriteLine("No emailPassword string");
            }
            return customSetting.Value;
        }

        public string getEmailDomain()
        {
            KeyValueConfigurationElement customSetting = null;
            if (rootWebConfig.AppSettings.Settings.Count > 0)
            {
                customSetting =
                    rootWebConfig.AppSettings.Settings["emailDomain"];
                if (customSetting != null)
                {
                    Debug.WriteLine("emailDomain " + customSetting.Value);

                }
                else
                    Debug.WriteLine("No emailDomain string");
            }
            return customSetting.Value;
        }

        public string getEmailUri()
        {
            KeyValueConfigurationElement customSetting = null;
            if (rootWebConfig.AppSettings.Settings.Count > 0)
            {
                customSetting =
                    rootWebConfig.AppSettings.Settings["emailUri"];
                if (customSetting != null)
                {
                    Debug.WriteLine("emailUri " + customSetting.Value);

                }
                else
                    Debug.WriteLine("No emailUri string");
            }
            return customSetting.Value;
        }

        public string getEmailBodyLink()
        {
            KeyValueConfigurationElement customSetting = null;
            if (rootWebConfig.AppSettings.Settings.Count > 0)
            {
                customSetting =
                    rootWebConfig.AppSettings.Settings["emailBodyLink"];
                if (customSetting != null)
                {
                    Debug.WriteLine("emailBodyLink " + customSetting.Value);

                }
                else
                    Debug.WriteLine("No emailBodyLink string");
            }
            return customSetting.Value;
        }

        public int getBurningQuestionNo()
        {
            KeyValueConfigurationElement customSetting = null;
            if (rootWebConfig.AppSettings.Settings.Count > 0)
            {
                customSetting =
                    rootWebConfig.AppSettings.Settings["BurningquestionNo"];
                if (customSetting != null)
                {
                    Debug.WriteLine("BurningquestionNo " + customSetting.Value);

                }
                else
                    Debug.WriteLine("No BurningquestionNo application string");
            }


            return Int32.Parse(customSetting.Value);
        }
    }
}
