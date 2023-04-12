using Business.Concrete;
using Business.ValidationRules;
using CoreDemo.Models;
using DataAccess.Concrete;
using DataAccess.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());

        UserManager userManager = new UserManager(new EfUserRepository());


        private readonly UserManager<AppUser> appUserManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            this.appUserManager = userManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            var userMail = User.Identity.Name;
            ViewBag.value = userMail;
            Context context = new Context();
            var writerName = context.Writers.Where(x => x.WriterMail == userMail).Select(x => x.WriterName).FirstOrDefault();
            ViewBag.value2 = writerName;
            return View();
        }
        public IActionResult WriterProfile()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public async Task<IActionResult> WriterEditProfile()
        {
            //Context context = new Context();
            //var userName = User.Identity.Name;
            //var userMail = context.Users.Where(x => x.UserName == userName).Select(x => x.Email).FirstOrDefault();
            //var id = context.Users.Where(x=>x.Email==userMail).Select(x=>x.Id).FirstOrDefault();
            //var values = userManager.GetById(id);
            UserUpdateViewModel userUpdateViewModel = new UserUpdateViewModel();
            var values = await appUserManager.FindByNameAsync(User.Identity.Name);

            userUpdateViewModel.mail = values.Email;
            userUpdateViewModel.nameSurname = values.NameSurname;
            userUpdateViewModel.imageUrl = values.ImageUrl;
            userUpdateViewModel.userName = values.UserName;
            return View(userUpdateViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> WriterEditProfile(UserUpdateViewModel userUpdateViewModel)
        {
            var values = await appUserManager.FindByNameAsync(User.Identity.Name);
            values.NameSurname = userUpdateViewModel.nameSurname;
            values.Email = userUpdateViewModel.mail;
            values.ImageUrl = userUpdateViewModel.imageUrl;
            values.PasswordHash = appUserManager.PasswordHasher.HashPassword(values,userUpdateViewModel.password);
            var result = await appUserManager.UpdateAsync(values);
            return RedirectToAction("Index", "Dashboard");

            //WriterValidator writerValidator = new WriterValidator();
            //ValidationResult results = writerValidator.Validate(writer);
            //if (results.IsValid)
            //{
            //    writerManager.Update(writer);
            //    return RedirectToAction("Index", "Dashboard");
            //}
            //else
            //{
            //    foreach (var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //    return View();
            //}
        }
        [AllowAnonymous, HttpGet]
        public IActionResult AddWriter()
        {
            return View();
        }
        [AllowAnonymous, HttpPost]
        public IActionResult AddWriter(AddProfileImage writerProfileImage)
        {
            Writer writer = new Writer();
            if (writerProfileImage.WriterImage != null)
            {
                var extension = Path.GetExtension(writerProfileImage.WriterImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                writerProfileImage.WriterImage.CopyTo(stream);
                writer.WriterImage = newImageName;
            }
            writer.WriterMail = writerProfileImage.WriterMail;
            writer.WriterName = writerProfileImage.WriterName;
            writer.WriterPassword = writerProfileImage.WriterPassword;
            writer.WriterStatus = true;
            writer.WriterAbout = writerProfileImage.WriterAbout;
            writerManager.Add(writer);
            return RedirectToAction("Index", "Dashboard");
        }

    }
}
