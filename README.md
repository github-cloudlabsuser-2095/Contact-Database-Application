# UserController Documentation
 
The [`UserController`] is a controller class in an MVC application that manages the CRUD operations for the [`User`] model.
 
## Methods
 
### Index()
 
This is a GET method that returns a view of all users.
 
```csharp
public ActionResult Index()
```
 
### Details(int id)
 
This is a GET method that returns a view of the details of a specific user.
 
```csharp
public ActionResult Details(int id)
```
 
### Create()
 
This is a GET method that returns a view to create a new user.
 
```csharp
public ActionResult Create()
```
 
### Create(User user)
 
This is a POST method that creates a new user and redirects to the Index view if successful.
 
```csharp
[HttpPost]
public ActionResult Create(User user)
```
 
### Edit(int id)
 
This is a GET method that returns a view to edit a specific user.
 
```csharp
public ActionResult Edit(int id)
```
 
### Edit(int id, User user)
 
This is a POST method that updates a specific user and redirects to the Index view if successful.
 
```csharp
[HttpPost]
public ActionResult Edit(int id, User user)
```
 
### Delete(int id)
 
This is a GET method that returns a view to confirm the deletion of a specific user.
 
```csharp
public ActionResult Delete(int id)
```
 
### Delete(int id, FormCollection collection)
 
This is a POST method that deletes a specific user and redirects to the Index view.
 
```csharp
[HttpPost]
public ActionResult Delete(int id, FormCollection collection)
```
 
## Model
 
The [`User`]model used in this controller has the following properties:
 
- [`Id`]The unique identifier of the user.
- [`Name`] The name of the user.
- [`Email`] The email of the user.
- Other fields as necessary.
 
## Data
 
The data for this controller is stored in a static list of [`User`]objects called [`userlist`]
 
```csharp
public static System.Collections.Generic.List<User> userlist = new System.Collections.Generic.List<User>();
```
