using System;
using BloggerApp.Request;

namespace BloggerApp.Application.Interface;

public interface IUserService
{
    Task<bool> registerUser(Register request);
}
