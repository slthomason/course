using System;
using BloggerApp.Application.Interface;
using BloggerApp.Database;
using BloggerApp.Database.Entities;
using BloggerApp.Request;

namespace BloggerApp.Application.Repository;

public class UserService : IUserService
{
    private readonly DatabaseContext _db;
    public UserService(DatabaseContext _db)
    {
        this._db = _db;
    }

    public async Task<bool> registerUser(Register request)
    {
        try
        {
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
