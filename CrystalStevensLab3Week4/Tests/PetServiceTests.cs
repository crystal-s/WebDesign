using CrystalStevensLab3Week4.Repositories;
using NUnit.Framework;
using FakeItEasy;
using CrystalStevensLab3Week4.Data.Entities;
using System;
using CrystalStevensLab3Week4.Services;

namespace Tests
{
    public class PetServiceTests
    {
        private IEntityRepository _repo;

        [SetUp]
        public void Setup()
        {
            _repo = A.Fake<IEntityRepository>();
        }

        [Test]
        public void CheckDateShouldAlert()
        {
            A.CallTo(() => _repo.GetPet(A<int>.Ignored)).Returns(new Pet
            {
                NextCheckup = DateTime.Today.AddDays(13)
            });

            var service = new PetService(_repo);
            var view = service.GetPet(1);

            Assert.IsTrue(view.CheckupAlert);
        }

        [Test]
        public void CheckDateShouldNotAlert()
        {
            A.CallTo(() => _repo.GetPet(A<int>.Ignored)).Returns(new Pet
            {
                NextCheckup = DateTime.Today.AddDays(15)
            });

            var service = new PetService(_repo);
            var view = service.GetPet(1);

            Assert.IsFalse(view.CheckupAlert);
        }
    }
}
