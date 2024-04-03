using AutoMapper;
using BanVeXemPhimApi.Common;
using BanVeXemPhimApi.Database;
using BanVeXemPhimApi.Dto;
using BanVeXemPhimApi.Request;
using BanVeXemPhimApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BanVeXemPhimApi.Controllers.Admin
{
    [ApiController]
    [Route("api/admin/[controller]")]
    public class AdminAuthenticateController : BaseApiController<AdminAuthenticateController>
    {
        private readonly AdminAuthenticateService _adminAuthenticateService;
        public AdminAuthenticateController(DatabaseContext databaseContext, IMapper mapper, ApiOption apiConfig)
        {
            _adminAuthenticateService = new AdminAuthenticateService(apiConfig, databaseContext, mapper);
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("AdminLogin")]
        [AllowAnonymous]
        public IActionResult AdminLogin(AdminLoginRequest request)
        {
            try
            {
                var res = _adminAuthenticateService.AdminLogin(request);
                return Ok(new MessageData { Data = res });
            }
            catch (Exception ex)
            {
                return NG(ex);
            }
        }

        /// <summary>
        /// Change password
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("ChangePassword")]
        public IActionResult ChangePassword(ChangePasswordRequest request)
        {
            try
            {
                var res = _adminAuthenticateService.ChangePassword(UserId, request);
                return Ok(new MessageData { Data = res });
            }
            catch (Exception ex)
            {
                return NG(ex);
            }
        }
    }
}
