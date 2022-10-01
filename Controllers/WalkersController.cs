using DogGo.Models;
using DogGo.Models.ViewModels;
using DogGo.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;

namespace DogGo.Controllers
{
    public class WalkersController : Controller
    {
        // ASP.NET will give us an instance of our Walker Repository. This is called "Dependency Injection"
        private readonly IOwnerRepository _ownerRepo;
        private readonly IDogRepository _dogRepo;
        private readonly IWalkerRepository _walkerRepo;
        private readonly INeighborhoodRepository _neighborhoodRepo;

        public WalkersController(
            IOwnerRepository ownerRepository,
            IDogRepository dogRepository,
            IWalkerRepository walkerRepository,
            INeighborhoodRepository neighborhoodRepository)

        {
            _ownerRepo = ownerRepository;
            _dogRepo = dogRepository;
            _walkerRepo = walkerRepository;
            _neighborhoodRepo = neighborhoodRepository;
        }
        // GET: WalkersController
        //Only show the walkers that match the same neigborhood as the current user(Owner)
        
        
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated){
                
            int ownerId =GetCurrentUserId();
                Owner owner = _ownerRepo.GetOwnerById(ownerId);
                List<Walker> walkers = _walkerRepo.GetWalkersInNeighborhood(owner.NeighborhoodId);
              return View(walkers);
            } else {
                List<Walker> walkers = _walkerRepo.GetAllWalkers();
                return View(walkers); 
            }
        }

        // GET: Walkers/Details/5
        public ActionResult Details(int id)
        {
            int ownerId = GetCurrentUserId();

            Walker walker = _walkerRepo.GetWalkerById(id);
            Owner owner = _ownerRepo.GetOwnerById(id);
            List<Dog> dogs = _dogRepo.GetDogsByOwnerId(ownerId);
  

            WalkerViewModel vm = new WalkerViewModel()
            {
                Owner = owner,
                Dogs = dogs,
                Walker = walker,
          
            };

            return View(vm);
        }
        // GET: WalkersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WalkersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WalkersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WalkersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: WalkersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WalkersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        private int GetCurrentUserId()
        {
            try
            {
                string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
                return int.Parse(id);
            }
            catch (Exception e)
            {
                if (e == null)
                {
                    return 0;
                }
                return 0;
            }
        }
    }
}
