using System;
using BloggerApp.Application.Interface;
using BloggerApp.Database;
using BloggerApp.Database.Entities;
using BloggerApp.Request;

namespace BloggerApp.Application.Repository;

public class UserService : IUserService
{
    private readonly DatabaseContext _db;
    private readonly ILogger<UserService> _logger;
    public UserService(DatabaseContext _db,ILogger<UserService> logger)
    {
        this._db = _db;
        _logger = logger;
    }

    public async Task<bool> registerUser(Register request)
    {
        try
        {
            _logger.LogInformation("Log information");
            var user = new Users()
            {
                email = request.email,
                name = request.name
            };

            await _db.users.AddAsync(user).ConfigureAwait(false);
            await _db.SaveChangesAsync().ConfigureAwait(false);

            return true;
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }
}
