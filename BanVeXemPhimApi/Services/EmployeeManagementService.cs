using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using BanVeXemPhimApi.Common;
using BanVeXemPhimApi.Common.Enum;
using BanVeXemPhimApi.Database;
using BanVeXemPhimApi.Dto;
using BanVeXemPhimApi.Models;
using BanVeXemPhimApi.Repositories;
using BanVeXemPhimApi.Request;
using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Collections.Generic;
using System.Xml.Linq;

namespace BanVeXemPhimApi.Services
{
    public class EmployeeManagementService
    {
        private readonly AdminRepository _adminRepository;
        private readonly IMapper _mapper;
        public EmployeeManagementService(ApiOption apiOption, DatabaseContext databaseContext, IMapper mapper)
        {
            _adminRepository = new AdminRepository(apiOption, databaseContext, mapper);
            _mapper = mapper;
        }

        /// <summary>
        /// Get schedule
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        public object GetEmployees(int limit, int page, string? name, string? email)
        {
            try
            {
                var query = this._adminRepository.FindAll();
                if (!string.IsNullOrEmpty(name))
                {
                    query = query.Where(row => row.Name.ToLower().Contains(name.ToLower()));
                }

                if (!string.IsNullOrEmpty(email))
                {
                    query = query.Where(row => row.Email.ToLower().Contains(email.ToLower()));
                }

                return new Pagination<Admin>(query, limit, page);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Store cinema
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public object Store(EmployeeStoreRequest request)
        {
            try
            {
                var model = _mapper.Map<Admin>(request);
                model.Username = model.Email;
                model.Password = Untill.CreateMD5(model.Email);
                
                var modelList = _adminRepository.FindByCondition(row => row.Email.ToLower() == model.Email.ToLower());
                if(modelList.Count() > 0)
                {
                    throw new Exception("Email đã tồn tại!");
                }
                
                _adminRepository.Create(model);
                _adminRepository.SaveChange();
                return model;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// get detail
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public object GetDetail(int id)
        {
            try
            {
                return _adminRepository.FindOrFail(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object Delete(int employeeId, int adminId)
        {
            try
            {
                if (employeeId == adminId)
                {
                    throw new Exception("Bạn không thể xoá chính bạn");
                }
                var employee = _adminRepository.FindOrFail(employeeId);
                if (employee == null)
                {
                    new Exception("user id không tồn tại");
                }
                _adminRepository.DeleteByEntity(employee);
                _adminRepository.SaveChange();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object Update(int id, EmployeeStoreRequest request)
        {
            try
            {
                var employee = _adminRepository.FindOrFail(id);
                if (employee == null)
                {
                    new Exception("user id không tồn tại");
                }
                employee.Role = request.Role;
                _adminRepository.UpdateByEntity(employee);
                _adminRepository.SaveChange();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
