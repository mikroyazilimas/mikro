﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
public struct Const
{
    public const string FormReturnUrl = "http://mikroyazilim.local/tesekkurler";
}

public struct Names
{
    public struct PagesView
    {
        public const string DemoRequestForm = "~/Mvc/Views/Form/DemoRequestForm.cshtml";
        public const string ProductSelectionWizard = "~/Mvc/Views/Form/ProductSelectionWizard.cshtml";
    }

    public struct Pages
    {
        public const string ErrorPage = "/404";
    }

    public struct Cache
    {
        public const string Cities = "Cities";
    }
}

public class KeyValue
{
    public string Key { get; set; }
    public string Value { get; set; }
}