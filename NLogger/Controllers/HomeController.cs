using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NLog;
using NLogger.Data;
using NLogger.Login;
using NLogger.Models;
using NLogger.Register;
using System;
using System.Diagnostics;

namespace NLogger.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AppDbContext _dbContext;

        private Logger logger { get; }

        public HomeController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager, AppDbContext dbContext)
        {
            logger = LogManager.GetCurrentClassLogger();
            _signInManager = signInManager;
            _userManager = userManager;
            _dbContext = dbContext;
        }



        public IActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {

            JsonViewModel viewModel = new();
            try
            {
                var result = await _signInManager.PasswordSignInAsync(model.UserName, model.Password, isPersistent: false, lockoutOnFailure: false);

                string _AlertMessage = "User logged in.";
                if (result.Succeeded)
                {
                    HttpContext.Session.SetString("Login UserName", model.UserName);
                    viewModel.AlertMessage = _AlertMessage;
                    viewModel.IsSuccess = result.Succeeded;
                    return new JsonResult(viewModel);
                }
                else
                {
                    _AlertMessage = "Invalid login attempt.";

                    viewModel.AlertMessage = _AlertMessage;
                    viewModel.IsSuccess = result.Succeeded;
                    return new JsonResult(viewModel);
                }
            }
            catch (Exception ex)
            {

                viewModel.AlertMessage = ex.Message;
                viewModel.IsSuccess = false;
                return new JsonResult(viewModel);
            }
            return new JsonResult(viewModel);

        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            JsonViewModel viewModel = new();
            ApplicationUser _appUsers = new ApplicationUser();
            try
            {
                var user = new ApplicationUser
                {
                    UserName = model.FirstName,
                    Email = model.UserName,
                    EmailConfirmed = false

                };
                var Result = await _userManager.CreateAsync(user, model.Password);
                if (Result.Succeeded)
                {
                    //insert userprofile
                    UserProfile _Userprofile = new UserProfile
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        PhoneNumber = "892999541",
                        Email = model.UserName,
                        Address = "Bangalore",
                        Country = "India",
                        ApplicationUserId = _appUsers.Id,
                        EmployeeId = "EMP" + string.Concat(Enumerable.Range(1, 6).Select(a => new Random().Next(6))),
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        CreatedBy = "sudarshan",// HttpContext.User.Identity.Name,
                        ModifiedBy = "shetty"//HttpContext.User.Identity.Name

                    };
                    var Result2 = await _dbContext.UserProfile.AddAsync(_Userprofile);
                    await _dbContext.SaveChangesAsync();
                    viewModel.AlertMessage = "User Created Successfully. User Name: " + _appUsers.UserName;
                    viewModel.IsSuccess = true;
                    return new JsonResult(viewModel);

                }
                else
                {
                    logger.Error("Your error message here");

                    logger.Error("Failed to create user. Errors: " + string.Join(", ", Result.Errors.Select(e => e.Description)));

                    logger.WithProperty("tags", $"Trasfer Equipment Approved datetime {DateTime.Now} and {_appUsers.Id}")
                          .WithProperty("params", JsonConvert.SerializeObject("_appUsers"))
                          .Trace($"Equipment History Approved by {_appUsers.Id}.");
                    viewModel.AlertMessage = "User Created Successfully. User Name: " + _appUsers.UserName;
                    viewModel.IsSuccess = true;
                    return new JsonResult(viewModel);
                }
            }
            catch (Exception)
            {
                await Console.Out.WriteLineAsync("");
                logger.WithProperty("tags", $"Trasfer Equipment Approved datetime {DateTime.Now} and {_appUsers.Id}")
                         .WithProperty("params", JsonConvert.SerializeObject(""))
                         .Trace($"Equipment History Approved by {_appUsers.Id}.");
                return new JsonResult(viewModel);

            }

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
