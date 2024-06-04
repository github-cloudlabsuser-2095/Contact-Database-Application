using CRUD_application_2.Models;
using System.Linq;
using System.Web.Mvc;
 
namespace CRUD_application_2.Controllers
{
    public class UserController : Controller
    {
        public static System.Collections.Generic.List<User> userlist = new System.Collections.Generic.List<User>();
        // GET: User
        public ActionResult Index()
        {
            return View(userlist);
        }
 
      // GET: User/Details/5
        public ActionResult Details(int id)
        {
            // Find the user with the specified ID in the userlist
            User user = userlist.FirstOrDefault(u => u.Id == id);

            // Check if the user exists
            if (user == null)
            {
                // If no user is found, return a HttpNotFoundResult
                return HttpNotFound();
            }

            // Pass the user object to the Details view
            return View(user);
        }
 
        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                // Add the new user to the userlist
                userlist.Add(user);

                // Redirect to the Index action to display the updated list of users
                return RedirectToAction("Index");
            }

            // If there are validation errors, return the Create view to display the errors
            return View(user);
        }
 
        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            // This method is responsible for displaying the view to edit an existing user with the specified ID.
            // It retrieves the user from the userlist based on the provided ID and passes it to the Edit view.

            // Find the user with the specified ID in the userlist
            User user = userlist.FirstOrDefault(u => u.Id == id);

            // Check if the user exists
            if (user == null)
            {
                // If no user is found, return a HttpNotFoundResult
                return HttpNotFound();
            }

            // Pass the user object to the Edit view
            return View(user);

        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, User user)
        {
            // Find the user with the specified ID in the userlist
            User existingUser = userlist.FirstOrDefault(u => u.Id == id);

            // Check if the user exists
            if (existingUser == null)
            {
                // If no user is found, return a HttpNotFoundResult
                return HttpNotFound();
            }

            // Update the user's information with the new values
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;

            // Redirect to the Index action to display the updated list of users
            return RedirectToAction("Index");
        }
 
      // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            // Find the user with the specified ID in the userlist
            User user = userlist.FirstOrDefault(u => u.Id == id);

            // Check if the user exists
            if (user == null)
            {
                // If no user is found, return a HttpNotFoundResult
                return HttpNotFound();
            }

            // Pass the user object to the Delete view
            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            // Find the user with the specified ID in the userlist
            User user = userlist.FirstOrDefault(u => u.Id == id);

            // Check if the user exists
            if (user == null)
            {
                // If no user is found, return a HttpNotFoundResult
                return HttpNotFound();
            }

            // Remove the user from the userlist
            userlist.Remove(user);

            // Redirect to the Index action to display the updated list of users
            return RedirectToAction("Index");
        }            // This method is responsible for displaying the view to edit an existing user with the specified ID.
                     // It retrieves the user from the userlist based on the provided ID and passes it to the Edit view.

        // Find the user with the specified ID in the userlist
        User user = userlist.FirstOrDefault(u => u.Id == id);

            // Check if the user exists
            if (user == null)
            {
                // If no user is found, return a HttpNotFoundResult
                return HttpNotFound();
    }

            // Pass the user object to the Edit view
            return View(user);

}
}
