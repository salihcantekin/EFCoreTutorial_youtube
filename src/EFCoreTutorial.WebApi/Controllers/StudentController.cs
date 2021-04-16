using EFCoreTutorial.Data.Context;
using EFCoreTutorial.Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTutorial.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;

        public StudentController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var student = await applicationDbContext.Students.ToListAsync();

            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> Add()
        {
            Student st = new Student()
            {
                FirstName = "Salih",
                LastName = "Cantekin",
                Number = 1,
                Address = new StudentAddress()
                {
                    City = "İstanbul",
                    Country = "Türkiye",
                    District = "Kadıköy",
                    FullAddress = "X sokak, No: y"
                }
            };

            await applicationDbContext.Students.AddAsync(st);
            await applicationDbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var student = await applicationDbContext.Students.FindAsync(id);
            applicationDbContext.Students.Remove(student);

            await applicationDbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update()
        {
            var student = await applicationDbContext.Students.FirstOrDefaultAsync();
            
            student.FirstName = "SALİH";
            student.LastName = "CANTEKİN";

            await applicationDbContext.SaveChangesAsync();

            return Ok();
        }

    }
}
