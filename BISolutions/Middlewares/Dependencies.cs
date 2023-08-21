using BISolutions.BusinessLogic.Interfaces;
using BISolutions.BusinessLogic.Services;

namespace BISolutions.Middlewares;

public static class Dependencies
{
    public static void AddIService(this IServiceCollection services)
    {
        services.AddTransient<ILogicService, LogicService>();
        services.AddTransient<IDisplayService, DisplayService>();
    }
}