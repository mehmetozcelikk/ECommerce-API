﻿using ECommerce.Application.DTOs.User;
using ECommerce.Domain.Entities.Identity;
using ETicECommercearetAPI.Application.DTOs.User;

namespace ECommerce.Application.Abstractions.Services;

public interface IUserService
{
    Task<CreateUserResponse> CreateAsync(CreateUser model);
    Task UpdateRefreshTokenAsync(string refreshToken, AppUser user, DateTime accessTokenDate, int addOnAccessTokenDate);
    Task UpdatePasswordAsync(string userId, string resetToken, string newPassword);
    Task<List<ListUser>> GetAllUsersAsync(int page, int size);
    int TotalUsersCount { get; }
    Task AssignRoleToUserAsnyc(string userId, string[] roles);
    Task<string[]> GetRolesToUserAsync(string userId);
    Task<bool> HasRolePermissionToEndpointAsync(string name, string code);
}
