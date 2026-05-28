// Client-side WCF contract mirrors — must match server contracts exactly.
using System.Collections.Generic;
using System.Runtime.Serialization;
using System;
using System.ServiceModel;

namespace HangmanGameWPF.Services
{
    // ── DTOs — namespace debe coincidir exactamente con el servidor ───────────
    // Servidor: HangmanGameEntities.Dtos → XML ns = http://schemas.datacontract.org/2004/07/HangmanGameEntities.Dtos

    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/HangmanGameEntities.Dtos")]
    public class UserDto
    {
        [DataMember] public int UserId { get; set; }
        [DataMember] public string FullName { get; set; }
        [DataMember] public DateTime BirthDate { get; set; }
        [DataMember] public string PhoneNumber { get; set; }
        [DataMember] public string Email { get; set; }
        [DataMember] public int GlobalScore { get; set; }
        [DataMember] public DateTime CreatedAt { get; set; }
    }

    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/HangmanGameEntities.Dtos")]
    public class OperationResultDto
    {
        [DataMember] public bool Success { get; set; }
        [DataMember] public string Message { get; set; }
        [DataMember] public UserDto User { get; set; }
    }

    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/HangmanGameEntities.Dtos")]
    public class LoginDto
    {
        [DataMember] public string Email { get; set; }
        [DataMember] public string Password { get; set; }
    }

    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/HangmanGameEntities.Dtos")]
    public class RegisterUserDto
    {
        [DataMember] public string FullName { get; set; }
        [DataMember] public DateTime BirthDate { get; set; }
        [DataMember] public string PhoneNumber { get; set; }
        [DataMember] public string Email { get; set; }
        [DataMember] public string Password { get; set; }
    }

    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/HangmanGameEntities.Dtos")]
    public class UpdateUserProfileDto
    {
        [DataMember] public int UserId { get; set; }
        [DataMember] public string FullName { get; set; }
        [DataMember] public DateTime BirthDate { get; set; }
        [DataMember] public string PhoneNumber { get; set; }
    }

    [ServiceContract]
    public interface IUserService
    {
        [OperationContract] OperationResultDto RegisterUser(RegisterUserDto registerUserDto);
        [OperationContract] OperationResultDto Login(LoginDto loginDto);
        [OperationContract] OperationResultDto GetUserProfile(int userId);
        [OperationContract] OperationResultDto UpdateUserProfile(UpdateUserProfileDto updateUserProfileDto);
    }
}
