# Practice in MVC Component At Route Academy 
## Content 
## 1-Routing
-Routing in ASP.NET Core or MVC is the process of mapping incoming HTTP requests to the corresponding controller actions. It defines how URLs correspond to controller actions and which data to pass to the action
## 2-Action Return Type 
-The action return type refers to the type of data that a controller action returns to the client. Common return types in ASP.NET include:
ViewResult: Returns a view (HTML page) to the client.
JsonResult: Returns data in JSON format.
RedirectResult: Redirects the client to another action or URL.
ContentResult: Returns a plain text response.
IActionResult: A flexible return type that allows for multiple types of responses (View, JSON, File, etc.).
## 3-Model Binding 
-Model binding is the process by which ASP.NET Core automatically maps incoming request data (e.g., form inputs, query strings) to action parameters or model properties.
##useing Bootstrap at Simple Project 
-Bootstrap is a popular CSS framework for building responsive and mobile-first websites. It provides pre-built components like forms, buttons, navigation, and layouts.
## 4-View
-A view in MVC is responsible for generating the HTML output that is sent to the client's browser. It is typically a .cshtml file that contains HTML mixed with Razor syntax.
## 5-Serving Static Files
-Static files are files like CSS, JavaScript, and images that are served directly to the client without any server-side processing.
## 6-Layout and _ViewStrat 
A layout is a template used by multiple views to provide a consistent structure for pages (e.g., common headers, footers, and navigation menus).
Layouts are defined in _Layout.cshtml and usually contain a placeholder (@RenderBody()) where the view content is inserted.
You specify the layout for a view using the Layout property:
## 7-Tah Helpers and _ViewImportant
The _ViewStart.cshtml file runs before any view is rendered. It is used to specify settings (like the layout) that apply to all views.
