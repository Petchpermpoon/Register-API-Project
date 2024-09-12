using Microsoft.EntityFrameworkCore;
using Register.API.Controllers;

namespace Register.API.Models;

public class RegisterRepository : IRegisterRepository
{
    private readonly RegisterDbConntext _registerDbcontext;

    public RegisterRepository(RegisterDbConntext registerDbcontext)
    {
        _registerDbcontext = registerDbcontext;
    }
    public async Task<List<Registers>> GetAllRegistersAsync()
    {
        List<Registers> registers = await _registerDbcontext.Registers.ToListAsync();
        return registers;
    }
    public async Task CreateRegister(Registers register)
    {
        _registerDbcontext.Registers.Add(register);
        await _registerDbcontext.SaveChangesAsync();
    }
    public async Task UpdateRegister(Registers register)
    {
        _registerDbcontext.Registers.Update(register);
        await _registerDbcontext.SaveChangesAsync();
    }
    public async Task<bool> DeleteRegisterById(int id)
    {
        Registers? register = await _registerDbcontext.Registers.FindAsync(id);
        if (register == null)
        {
            return false;
        }
        _registerDbcontext.Registers.Remove(register);
        await _registerDbcontext.SaveChangesAsync();
        return true;
    }
}