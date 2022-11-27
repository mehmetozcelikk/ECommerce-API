using ECommerce.Application.Abstractions.Services.Authentications;
using ECommerce.Application.Abstractions.Services;
using ECommerce.Application.Repositories.Basket;
using ECommerce.Application.Repositories.BasketItem;
using ECommerce.Application.Repositories.CompletedOrder;
using ECommerce.Application.Repositories.Endpoint;
using ECommerce.Application.Repositories.File;
using ECommerce.Application.Repositories.InvoiceFile;
using ECommerce.Application.Repositories.Menu;
using ECommerce.Application.Repositories.ProductImageFile;
using ECommerce.Domain.Entities.Identity;
using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Persistence.Contexts;
using ECommerceAPI.Persistence.Repositories;
using ECommerceAPI.Persistence.Services;
using ETicaretAPI.Persistence.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ECommerce.Application.Abstractions.Token;
using ECommerce.Application.Abstractions.Mail;
using ECommerce.Application.Abstractions.Services.Configurations;
using ECommerce.Application.Abstractions.Storage.Local;
using ECommerce.Application.Abstractions.Storage;
using ETicaretAPI.Application.Abstractions.Storage.Azure;

namespace ECommerceAPI.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<ECommerceAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        services.AddIdentity<AppUser, AppRole>(options =>
        {
            options.Password.RequiredLength = 3;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
        }).AddEntityFrameworkStores<ECommerceAPIDbContext>()
        .AddDefaultTokenProviders();
        //services.AddScoped<ITokenHandler, TokenHandler>();
        //services.AddScoped<IMailService, MailService>();
        //services.AddScoped<IApplicationService, ApplicationService>();



        services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
        services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
        services.AddScoped<IOrderReadRepository, OrderReadRepository>();
        services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
        services.AddScoped<IProductReadRepository, ProductReadRepository>();
        services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        services.AddScoped<IFileReadRepository, FileReadRepository>();
        services.AddScoped<IFileWriteRepository, FileWriteRepository>();
        services.AddScoped<IProductImageFileReadRepository, ProductImageFileReadRepository>();
        services.AddScoped<IProductImageFileWriteRepository, ProductImageFileWriteRepository>();
        services.AddScoped<IInvoiceFileReadRepository, InvoiceFileReadRepository>();
        services.AddScoped<IInvoiceFileWriteRepository, InvoiceFileWriteRepository>();
        services.AddScoped<IBasketItemReadRepository, BasketItemReadRepository>();
        services.AddScoped<IBasketItemWriteRepository, BasketItemWriteRepository>();
        services.AddScoped<IBasketReadRepository, BasketReadRepository>();
        services.AddScoped<IBasketWriteRepository, BasketWriteRepository>();
        services.AddScoped<ICompletedOrderReadRepository, CompletedOrderReadRepository>();
        services.AddScoped<ICompletedOrderWriteRepository, CompletedOrderWriteRepository>();
        services.AddScoped<IEndpointReadRepository, EndpointReadRepository>();
        services.AddScoped<IEndpointWriteRepository, EndpointWriteRepository>();
        services.AddScoped<IMenuReadRepository, MenuReadRepository>();
        services.AddScoped<IMenuWriteRepository, MenuWriteRepository>();


        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IExternalAuthentication, AuthService>();
        services.AddScoped<IInternalAuthentication, AuthService>();
        services.AddScoped<IBasketService, BasketService>();
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IAuthorizationEndpointService, AuthorizationEndpointService>();
    }

}