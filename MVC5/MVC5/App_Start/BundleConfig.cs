﻿using System.Web;
using System.Web.Optimization;

namespace MVC5
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/kendo").Include(
            "~/Scripts/kendo/kendo.all.min.js",
                // "~/Scripts/kendo/kendo.timezones.min.js", // uncomment if using the Scheduler
            "~/Scripts/kendo/kendo.aspnetmvc.min.js"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/angular.min.js",
                       "~/Scripts/codeacademy.js",
                      "~/Scripts/angular-route.min.js",
                      "~/Scripts/myangular.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/codeacademy.css",
                      "~/Content/kendo/kendo.common.min.css",
                      "~/Content/kendo/kendo.dataviz.min.css",
                      "~/Content/kendo/kendo.default.min.css",
                      "~/Content/kendo/kendo.dataviz.default.min.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/kendo/css").Include(
            "~/Content/kendo/kendo.common-bootstrap.min.css",
            "~/Content/kendo/kendo.bootstrap.min.css"));
            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
            "~/Content/themes/base/accordion.css",
            "~/Content/themes/base/all.css",
            "~/Content/themes/base/autocomplete.css",
            "~/Content/themes/base/base.css",
            "~/Content/themes/base/button.css",
            "~/Content/themes/base/core.css",
            "~/Content/themes/base/datepicker.css",
            "~/Content/themes/base/dialog.css",
            "~/Content/themes/base/draggable.css",
            "~/Content/themes/base/menu.css",
            "~/Content/themes/base/progressbar.css",
            "~/Content/themes/base/resizable.css",
            "~/Content/themes/base/selectable.css",
            "~/Content/themes/base/selectmenu.css",
            "~/Content/themes/base/slider.css",
            "~/Content/themes/base/sortable.css",
            "~/Content/themes/base/spinner.css",
            "~/Content/themes/base/tabs.css",
            "~/Content/themes/base/theme.css",
            "~/Content/themes/base/tooltip.css"));
            
            bundles.IgnoreList.Clear();
        }
    }
}

