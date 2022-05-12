using DevTrackR.Api.Entities;
using DevTrackR.Api.Models;
using DevTrackR.Api.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace DevTrackR.Api.Controllers
{
    [ApiController]
    [Route("api/packages")]
    public class PackagesController : ControllerBase
    {
        private readonly DevTrackRContext _context;
        public PackagesController(DevTrackRContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAllPackages()
        {
            var packages = _context.Packages;

            return Ok(packages);
        }

        [HttpGet("{code}")]

        public IActionResult GetByCode(string code)
        {
            var package = _context.Packages.SingleOrDefault(p => p.Code == code);

            if (package == null)
            {
                return NotFound();
            }

            return Ok(package);
        }

        [HttpPost]
        public IActionResult PostPackage(AddPackageInputModel model)
        {
            if (model.Title.Length < 10)
            {
                return BadRequest("Title length must be at least 10 characters long");
            }

            var package = new Package(model.Title, model.Weight);

            _context.Packages.Add(package);

            return CreatedAtAction("GetByCode", new { code = package.Code }, package);
        }


        [HttpPut("{code}/updates")]
        public IActionResult PutPackageUpdate(string code, AddPackageUpdateInputModel model)
        {
            var package = _context.Packages.SingleOrDefault(p => p.Code == code);

            if (package == null)
            {
                return NotFound();
            }

            package.AddUpdate(model.Status, model.Delivered);

            return NoContent();
        }
    }
}