using Xunit;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RawCoreAPIxUnit.Controllers;
using RawCoreAPIxUnit.Data;
using RawCoreAPIxUnit.Models.AccountViewModels;
using RawCoreAPIxUnit.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace RawCoreAPIxUnit.Tests
{
    #region Shopping List:
    // ======================
    //     Shopping List
    // ======================

    // ...    // Summary:  Provides an abstraction for a store which manages user accounts.
    // ...    // Type parameters:
    // ...    //   TUser:  The type encapsulating a user.
    // ...    public interface IUserStore<TUser> : IDisposable where TUser : class
    // ...    {

    // ... Error CS0535
    //     'RawIdentityStore' does not implement interface member 'IDisposable.Dispose()'	
    
    // ...        // Summary:  Creates the specified user in the user store.
    // ...        // Parameters:
    // ...        //   user:  The user to create.
    // ...        //   cancellationToken:
    // ...        //     The System.Threading.CancellationToken used to propagate notifications that the
    // ...        //     operation should be canceled.
    // ...        // Returns:
    // ...        //     The System.Threading.Tasks.Task that represents the asynchronous operation, containing
    // ...        //     the Microsoft.AspNetCore.Identity.IdentityResult of the creation operation.
    // ... Method Task<IdentityResult> CreateAsync(TUser user, CancellationToken cancellationToken);
    // ...        // =============================================================

    // ...        // Summary:  Deletes the specified user from the user store.
    // ...        // Parameters:
    // ...        //   user:  The user to delete.
    // ...        //   cancellationToken:
    // ...        //     The System.Threading.CancellationToken used to propagate notifications that the
    // ...        //     operation should be canceled.
    // ...        // Returns:
    // ...        //     The System.Threading.Tasks.Task that represents the asynchronous operation, containing
    // ...        //     the Microsoft.AspNetCore.Identity.IdentityResult of the update operation.
    // ... Method Task<IdentityResult> DeleteAsync(TUser user, CancellationToken cancellationToken);
    // ...        // =============================================================

    // ...        // Summary:  Finds and returns a user, if any, who has the specified userId.
    // ...        // Parameters:
    // ...        //   userId:  The user ID to search for.
    // ...        //   cancellationToken:
    // ...        //     The System.Threading.CancellationToken used to propagate notifications that the
    // ...        //     operation should be canceled.
    // ...        // Returns:
    // ...        //     The System.Threading.Tasks.Task that represents the asynchronous operation, containing
    // ...        //     the user matching the specified userId if it exists.
    // ... Method Task<TUser> FindByIdAsync(string userId, CancellationToken cancellationToken);
    // ...        // =============================================================

    // ...        // Summary:  Finds and returns a user, if any, who has the specified normalized user name.
    // ...        // Parameters:
    // ...        //   normalizedUserName:  The normalized user name to search for.
    // ...        //   cancellationToken:
    // ...        //     The System.Threading.CancellationToken used to propagate notifications that the
    // ...        //     operation should be canceled.
    // ...        // Returns:
    // ...        //     The System.Threading.Tasks.Task that represents the asynchronous operation, containing
    // ...        //     the user matching the specified normalizedUserName if it exists.
    // ... Method Task<TUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken);
    // ...        // =============================================================

    // ...        // Summary:    Gets the normalized user name for the specified user.
    // ...        // Parameters:
    // ...        //   user:  The user whose normalized name should be retrieved.
    // ...        //   cancellationToken:
    // ...        //     The System.Threading.CancellationToken used to propagate notifications that the
    // ...        //     operation should be canceled.
    // ...        // Returns:
    // ...        //     The System.Threading.Tasks.Task that represents the asynchronous operation, containing
    // ...        //     the normalized user name for the specified user.
    // ... Method Task<string> GetNormalizedUserNameAsync(TUser user, CancellationToken cancellationToken);
    // ...        // =============================================================

    // ...        // Summary:  Gets the user identifier for the specified user.
    // ...        // Parameters:
    // ...        //   user:  The user whose identifier should be retrieved.
    // ...        //   cancellationToken:
    // ...        //     The System.Threading.CancellationToken used to propagate notifications that the
    // ...        //     operation should be canceled.
    // ...        // Returns:
    // ...        //     The System.Threading.Tasks.Task that represents the asynchronous operation, containing
    // ...        //     the identifier for the specified user.
    // ... Method Task<string> GetUserIdAsync(TUser user, CancellationToken cancellationToken);
    // ...        // =============================================================

    // ...        // Summary:  Gets the user name for the specified user.
    // ...        // Parameters:
    // ...        //   user:  The user whose name should be retrieved.
    // ...        //   cancellationToken:
    // ...        //     The System.Threading.CancellationToken used to propagate notifications that the
    // ...        //     operation should be canceled.
    // ...        // Returns:
    // ...        //     The System.Threading.Tasks.Task that represents the asynchronous operation, containing
    // ...        //     the name for the specified user.
    // ... Method Task<string> GetUserNameAsync(TUser user, CancellationToken cancellationToken);
    // ...        // =============================================================

    // ...        // Summary:  Sets the given normalized name for the specified user.
    // ...        // Parameters:
    // ...        //   user:            The user whose name should be set.
    // ...        //   normalizedName:  The normalized name to set.
    // ...        //   cancellationToken:
    // ...        //     The System.Threading.CancellationToken used to propagate notifications that the
    // ...        //     operation should be canceled.
    // ...        // Returns:
    // ...        //     The System.Threading.Tasks.Task that represents the asynchronous operation.
    // ... Method Task SetNormalizedUserNameAsync(TUser user, string normalizedName,
    //                                            CancellationToken cancellationToken);
    // ...        // =============================================================

    // ...        // Summary:  Sets the given userName for the specified user.
    // ...        // Parameters:
    // ...        //   user:      The user whose name should be set.
    // ...        //   userName:  The user name to set.
    // ...        //   cancellationToken:
    // ...        //     The System.Threading.CancellationToken used to propagate notifications that the
    // ...        //     operation should be canceled.
    // ...        // Returns:
    // ...        //     The System.Threading.Tasks.Task that represents the asynchronous operation.
    // ... Method Task SetUserNameAsync(TUser user, string userName, CancellationToken cancellationToken);
    // ...        // =============================================================

    // ...        // Summary:  Updates the specified user in the user store.
    // ...        // Parameters:
    // ...        //   user:  The user to update.
    // ...        //   cancellationToken:
    // ...        //     The System.Threading.CancellationToken used to propagate notifications that the
    // ...        //     operation should be canceled.
    // ...        // Returns:
    // ...        //     The System.Threading.Tasks.Task that represents the asynchronous operation, containing
    // ...        //     the Microsoft.AspNetCore.Identity.IdentityResult of the update operation.
    // ... Method Task<IdentityResult> UpdateAsync(TUser user, CancellationToken cancellationToken);
    // ...        // =============================================================
    // ...    }  // public interface IUserStore<TUser> : IDisposable where TUser : class
    // ...        // =============================================================
    // ...        // =============================================================

    // public class UserManager<TUser> : IDisposable where TUser : class
    // {
    // Summary:
    //     Provides the APIs for managing user in a persistence store.
    // Type parameters:
    //   TUser:  The type encapsulating a user.
    //     protected const string ConfirmEmailTokenPurpose = "EmailConfirmation";
    //     protected const string ResetPasswordTokenPurpose = "ResetPassword";
    // Summary:
    //     Constructs a new instance of Microsoft.AspNetCore.Identity.UserManager`1. (sic)
    //  public UserManager(IUserStore<TUser> store,    // The persistence store the manager will operate over.
    //        IOptions<IdentityOptions> optionsAccessor, // The accessor used to access the
    //                                                   // Microsoft.AspNetCore.Builder.IdentityOptions.
    //        IPasswordHasher<TUser> passwordHasher,     // The password hashing implementation to use
    //                                                   // when saving passwords.
    //        IEnumerable<IUserValidator<TUser>> userValidators,
    //            //     collection of Microsoft.AspNetCore.Identity.IUserValidator`1 (sic)
    //            //     to validate users against.
    //        IEnumerable<IPasswordValidator<TUser>> passwordValidators,
    //            //     a collection of Microsoft.AspNetCore.Identity.IPasswordValidator`1 (sic)
    //            //     to validate passwords against.
    //        ILookupNormalizer keyNormalizer,     // The Microsoft.AspNetCore.Identity.ILookupNormalizer
    //                                             // to use when generating index keys for users.
    //        IdentityErrorDescriber errors,       // Microsoft.AspNetCore.Identity.IdentityErrorDescriber
    //                                             // used to provider error messages.
    //        IServiceProvider services,           // System.IServiceProvider used to resolve services.
    //        ILogger<UserManager<TUser>> logger); // used to log messages, warnings and errors.
    // }  // public class UserManager<TUser> : IDisposable where TUser : class
    // ======================
    #endregion Shopping List.

    /// <summary>
    /// UserManager requires a store parameter.
    /// We want to use the same store as the AccountController
    /// </summary>
// ????    public class RawIdentityStore : IUserStore<ApplicationUser>
// ????    {
// ????        // Error CS0535
// ????        // 'RawIdentityStore' does not implement interface member
// ????        // 'IUserStore<ApplicationUser>.GetUserIdAsync(ApplicationUser, CancellationToken)'
// ????        
// ????    }

    public class Class1
    {
        // https://docs.asp.net/en/latest/mvc/controllers/testing.html
        //   {currently documents version 1.0.0-rc1 and has not yet been updated for version 1.0.0}

        [Fact]
        public void GerryLowryAtSomewhereComCanLogIn()
        {
            // Arrange
            var applicationUser = new ApplicationUser();
            var dbContextOptions = new DbContextOptions<ApplicationDbContext>();
            var applicationDbContext = new ApplicationDbContext(dbContextOptions);
  // ???          IUserStore<ApplicationUser> store = new RawIdentityStore() ;
            //     var userManager = new UserManager<ApplicationUser>();
            // ??
            // ??    var accountController
            // ??        = new AccountController(userManager:,signInManager:,emailSender:, smsSender:, loggerFactory:)

            // https://msdn.microsoft.com/en-us/magazine/mt694089.aspx
            // "Essential .NET - Logging with .NET Core"
            ILoggerFactory loggerFactory = new LoggerFactory()
                                          .AddConsole()
                                          .AddDebug();
            var accountController
                = new AccountController(userManager: null,
                    signInManager: null,
                    emailSender: null,
                    smsSender: null,
                    loggerFactory: loggerFactory); // can NOT be null
            var loginViewModel = new LoginViewModel();
            loginViewModel.Email = "gerry.lowry@somewhere.com";
            loginViewModel.Password = "Az1234!";
            loginViewModel.RememberMe = false;

            // Act
            var result = accountController.Login(loginViewModel);
            var resultType = result.GetType();

            // Assert

        }

        [Fact]
        public void GerryLowryNotAtSomewhereComFailsLogIn()
        {
            // Arrange
            var applicationUser = new ApplicationUser();
            var dbContextOptions = new DbContextOptions<ApplicationDbContext>();
            var applicationDbContext = new ApplicationDbContext(dbContextOptions);
            //            var store = new IUserStore<ApplicationUser>() ;
            //     var userManager = new UserManager<ApplicationUser>();
            // ??
            // ??    var accountController
            // ??        = new AccountController(userManager:,signInManager:,emailSender:, smsSender:, loggerFactory:)

            // https://msdn.microsoft.com/en-us/magazine/mt694089.aspx
            // "Essential .NET - Logging with .NET Core"
            ILoggerFactory loggerFactory = new LoggerFactory()
                                          .AddConsole()
                                          .AddDebug();
            var accountController
                = new AccountController(userManager: null,
                    signInManager: null,
                    emailSender: null,
                    smsSender: null,
                    loggerFactory: loggerFactory); // can NOT be null
            var loginViewModel = new LoginViewModel();
            loginViewModel.Email = "gerry.lowry@nowhere.ru";
            loginViewModel.Password = "Az1234!";
            loginViewModel.RememberMe = false;

            // Act
            var result = accountController.Login(loginViewModel);
            var resultType = result.GetType();

            // Assert

        }

        [Fact]
        public void GerryLowryAtSomewhereComFailsLogInWhenPasswordWrong()
        {
            // Arrange
            var applicationUser = new ApplicationUser();
            var dbContextOptions = new DbContextOptions<ApplicationDbContext>();
            var applicationDbContext = new ApplicationDbContext(dbContextOptions);
            //            var store = new IUserStore<ApplicationUser>() ;
            //     var userManager = new UserManager<ApplicationUser>();
            // ??
            // ??    var accountController
            // ??        = new AccountController(userManager:,signInManager:,emailSender:, smsSender:, loggerFactory:)

            // https://msdn.microsoft.com/en-us/magazine/mt694089.aspx
            // "Essential .NET - Logging with .NET Core"
            ILoggerFactory loggerFactory = new LoggerFactory()
                                          .AddConsole()
                                          .AddDebug();
            var accountController
                = new AccountController(userManager: null,
                    signInManager: null,
                    emailSender: null,
                    smsSender: null,
                    loggerFactory: loggerFactory); // can NOT be null
            var loginViewModel = new LoginViewModel();
            loginViewModel.Email = "gerry.lowry@somewhere.com";
            loginViewModel.Password = "Sir, i send a rhyme excelling";
            loginViewModel.RememberMe = false;

            // Act
            var result = accountController.Login(loginViewModel);
            var resultType = result.GetType();

            // Assert

        }




        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void FailingTest()
        {
            Assert.Equal(5, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }



    }
}
