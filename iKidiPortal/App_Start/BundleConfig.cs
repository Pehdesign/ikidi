﻿using System.Web;
using System.Web.Optimization;

namespace iKidi
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

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            bundles.Add(new ScriptBundle("~/bundles/admin").Include(
                "~/Scripts/AdminMenu.js"));

            bundles.Add(new ScriptBundle("~/bundles/ui").Include(
                "~/Scripts/carret.js",
                "~/Scripts/JWPlayer.js",
                "~/Scripts/RegisterCode.js",
                "~/Scripts/RegisterUser.js",
                "~/Scripts/login.js",
                "~/Scripts/forgot-password.js"
                ));

            bundles.Add(new StyleBundle("~/Content/membership").Include(
                "~/Content/navbar.css",
                "~/Content/thumbnails.css",
                "~/Content/ProductContent.css",
                "~/Content/carret.css",
                "~/Content/RegisterCode.css",
                "~/Content/RegisterUser.css",
                "~/Content/login.css",
                "~/Content/forgot-password.css"));

        }
    }
}
