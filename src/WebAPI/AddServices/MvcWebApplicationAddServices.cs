namespace WebAPI.AddServices
{
    public class MvcWebApplicationAddServices : IWebAppliacationAddServices
    {
        public void AddServicesPipeline(WebApplication app)
        {
            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
