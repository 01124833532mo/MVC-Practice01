namespace Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webApplicationBuilder = WebApplication.CreateBuilder();

            #region configure servises
            // configure servesise 

            webApplicationBuilder.Services.AddControllersWithViews(); // register mvc to di container 


            var app = webApplicationBuilder.Build(); 
            #endregion


            if (app.Environment.IsDevelopment()) {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseStatusCodePagesWithReExecute("/Home/Error");
            }


            app.UseRouting();



            app.MapControllerRoute(
                name: "default",
                pattern: /*urlpath*/ "{controller=Home}/{action=Index}/{id:int?}"
                //defaults: new {controller ="Movies" , action = "Index"}

                );


            app.Run();
        }
    }
}
