﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication3.Models;
using Xunit;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            IndexViewModel ivm = new IndexViewModel();
            ViewData["Message"] = "Добрый день, это тестовый текст на главной странице";
            ViewResult vr = View("Main", ivm);
            vr.StatusCode = 200;
            return vr;
        }

        public IActionResult Privacy()
        {
            string policy = "Текст политики конфидециальности сайта.";
            ViewData["Policy"] = policy;
            ViewResult vr = View("Privacy");
            return vr;
        }

        public IActionResult TestPage(int page)
        {
            ViewBag.PageIncrement = ++page;
            return View(new TestPageViewModel{Page = page});
        }

        
    }
}