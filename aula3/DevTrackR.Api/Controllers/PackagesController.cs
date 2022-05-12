using DevTrackR.Api.Entities;
using DevTrackR.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevTrackR.Api.Controllers
{
    [ApiController]
    [Route("api/packages")]
    public class PackagesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllPackages()
        {
            var packages = new List<Package> {
                new Package("Pacote 1", 1.3M),
                new Package("Pacote 2", 0.3M),
            };

            return Ok(packages);
        }

        [HttpGet("{code}")]

        public IActionResult GetByCode(string code)
        {
            var package = new Package("Pacote 2", 0.2M);
            return Ok(package);
        }

        [HttpPost]
        public IActionResult PostPackage(AddPackageInputModel model)
        {
            var package = new Package(model.Title, model.Weight);
            return Ok();
        }


        [HttpPost("{code}/updates")]
        public IActionResult PostPackageUpdate(string code, AddPackageUpdateInputModel model)
        {
            var package = new Package("Pacote blusa", 1.2M);

            package.AddUpdate(model.Status, model.Delivered);
            return Ok();
        }
    }
}