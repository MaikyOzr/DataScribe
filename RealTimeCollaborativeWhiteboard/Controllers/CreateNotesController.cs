﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealTimeCollaborativeWhiteboard.Data;
using RealTimeCollaborativeWhiteboard.Models;

namespace RealTimeCollaborativeWhiteboard.Controllers
{
    public class CreateNotesController : Controller
    {

        //private readonly IWebHostEnvironment _environment;
        private readonly ApplicationDbContext _dbContext;

        public CreateNotesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult CreateNotes()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> CreateNotes(Notes note) {
            _dbContext.Notes.Add(note);
            await _dbContext.SaveChangesAsync();
            return RedirectToAction("CreateNotes");
        }
        
    }
}