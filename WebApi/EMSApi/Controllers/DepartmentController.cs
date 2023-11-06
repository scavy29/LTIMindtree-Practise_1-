using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace EMSApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController : ControllerBase
    {
        IDept repo;
        public DepartmentController(IDept _repo)
        {
            this.repo=_repo;
        }   
    }
}