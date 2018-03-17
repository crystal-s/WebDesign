using System;
using System.Collections.Generic;
using CrystalStevensAssignment8.Repositories;
using CrystalStevensAssignment8.Models.View;
using CrystalStevensAssignment8.Data.Entities;

namespace CrystalStevensAssignment8.Services
{
    public class PetService : IPetService
    {
        private readonly IEntityRepository _repo;

        public PetService(IEntityRepository repo)
        {
            _repo = repo;
        }

        public PetViewModel GetPet(int id)
        {
            var pet = _repo.GetPet(id);
            return MapToPetViewModel(pet);
        }

        public IEnumerable<PetViewModel> GetPetsForUser(string userId)
        {
            var petViewModels = new List<PetViewModel>();

            var pets = _repo.GetPetsForUser(userId);

            foreach (var pet in pets)
            {
                petViewModels.Add(MapToPetViewModel(pet));
            }

            return petViewModels;
        }

        public void SavePet(string userid, PetViewModel petViewModel)
        {
            //throw new Exception("Test Exception");

            var pet = MapToPet(userid, petViewModel);

            _repo.SavePet(pet);
        }

        public void UpdatePet(PetViewModel petViewModel)
        {
            var pet = _repo.GetPet(petViewModel.Id);

            CopyToPet(petViewModel, pet);

            _repo.UpdatePet(pet);
        }

        public void DeletePet(int id)
        {
            _repo.DeletePet(id);
        }

        private Pet MapToPet(string userid, PetViewModel petViewModel)
        {
            return new Pet
            {
                Id = petViewModel.Id,
                Name = petViewModel.Name,
                Age = petViewModel.Age,
                NextCheckup = petViewModel.NextCheckup,
                VetName = petViewModel.VetName,
                UserId = userid
            };
        }

        private PetViewModel MapToPetViewModel(Pet pet)
        {
            var petViewModel = new PetViewModel
            {
                Id = pet.Id,
                Name = pet.Name,
                Age = pet.Age,
                NextCheckup = pet.NextCheckup,
                VetName = pet.VetName,
                UserId = pet.UserId
            };

            petViewModel.CheckupAlert = (petViewModel.NextCheckup - DateTime.Now).Days < 14;

            return petViewModel;
        }

        private void CopyToPet(PetViewModel petViewModel, Pet pet)
        {
            pet.Id = petViewModel.Id;
            pet.Name = petViewModel.Name;
            pet.Age = petViewModel.Age;
            pet.NextCheckup = petViewModel.NextCheckup;
            pet.VetName = petViewModel.VetName;
            pet.UserId = petViewModel.UserId;
        }
    }
}