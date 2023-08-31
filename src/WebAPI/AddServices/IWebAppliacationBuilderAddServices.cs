namespace WebAPI.AddServices
{
    public interface IWebAppliacationBuilderAddServices : IRegistrar
    {
        public void AddServices(WebApplicationBuilder builder);
    }
}
