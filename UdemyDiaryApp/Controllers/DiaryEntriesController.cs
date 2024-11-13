﻿using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using UdemyDiaryApp.Data;
using UdemyDiaryApp.Models;

namespace UdemyDiaryApp.Controllers;

public class DiaryEntriesController : Controller
{
    private readonly ApplicationDbContext _db;

    public DiaryEntriesController(ApplicationDbContext db)
    {
        _db = db;
    }
    public IActionResult Index()
    {
        List<DiaryEntry> objDiaryEntryList = _db.DiaryEntries.ToList();
        return View(objDiaryEntryList);
    }
    
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(DiaryEntry obj)
    {
        if(obj != null && obj.Title.Length < 3)
        {
            ModelState.AddModelError("Title", "Title is too short.");
        }
        
        if (ModelState.IsValid)
        {
            _db.DiaryEntries.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(obj);
    }
}
