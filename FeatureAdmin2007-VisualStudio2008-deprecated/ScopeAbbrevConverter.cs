﻿using System;
using Microsoft.SharePoint;

namespace FeatureAdmin
{
    public static class ScopeAbbrevConverter
    {
        public static string ScopeToAbbrev(SPFeatureScope scope)
        {
            switch (scope)
            {
                case SPFeatureScope.Farm: return "Farm";
                case SPFeatureScope.WebApplication: return "WebApp";
                case SPFeatureScope.Site: return "SiteColl";
                case SPFeatureScope.Web: return "Web";
                default: return "Invalid";
            }
        }
        public static SPFeatureScope AbbrevToScope(string scope)
        {
            switch (scope)
            {
                case "Farm": return SPFeatureScope.Farm;
                case "WebApp": return SPFeatureScope.WebApplication;
                case "SiteColl": return SPFeatureScope.Site;
                case "Web": return SPFeatureScope.Web;
                default: return SPFeatureScope.ScopeInvalid;
            }
        }
    }
}
