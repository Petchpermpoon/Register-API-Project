using Microsoft.AspNetCore.Mvc;
using Register.API.Models;

namespace Register.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RegisterControllers: ControllerBase 
{
    private IRegisterService _registerService;
    public RegisterControllers(IRegisterService registerService)
    {
        _registerService = registerService;
    }
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        List<Registers> register = await _registerService.GetAllRegistersAsync();
        return Ok(register);
    }
    [HttpPost]
    public async Task<IActionResult> CreateRegister(Registers register)
    {
        await _registerService.CreateRegister(register);
        return Ok(register);
    }
    [HttpPatch]
    public async Task<IActionResult> UpdateRegister(Registers register)
    {
        await _registerService.UpdateRegister(register);
        return Ok(register);
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRegisterById(int id)
    {
        bool success = await _registerService.DeleteRegisterById(id);
        if (success)
        {
            return NoContent();
        }
        else
        {
            return NotFound();
        }
    }
}