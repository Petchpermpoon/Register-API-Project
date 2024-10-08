using Register.API.Controllers;

namespace Register.API.Models;

public class RegisterService : IRegisterService
{
    public IRegisterRepository _registerRepository;
    public RegisterService(IRegisterRepository registerRepository)
    {
        _registerRepository = registerRepository;
    }
    public async Task<List<Registers>> GetAllRegistersAsync()
    {
        List<Registers> registers = await _registerRepository.GetAllRegistersAsync();
        return registers;
    }
    public async Task CreateRegister(Registers register)
    {
        await _registerRepository.CreateRegister(register);
    }
    public async Task UpdateRegister(Registers register)
    {
        await _registerRepository.UpdateRegister(register);
    }
    public async Task<bool> DeleteRegisterById(int id)
    {
        return await _registerRepository.DeleteRegisterById(id);
    }
}