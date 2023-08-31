namespace WebAPI.AddServices
{
    public interface IWebAppliacationAddServices : IRegistrar
    {
        public void AddServicesPipeline(WebApplication app);
    }
}
