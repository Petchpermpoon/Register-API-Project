using Register.API.Controllers;

namespace Register.API.Models;

public interface IRegisterRepository
{
    Task<List<Registers>> GetAllRegistersAsync();
    Task CreateRegister(Registers register);
    Task UpdateRegister(Registers register);
    Task<bool> DeleteRegisterById(int id);
}