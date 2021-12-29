using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Personal_WebAssebly_App_Fh_Aachen.Models;

namespace Personal_WebAssebly_App_Fh_Aachen.Interfaces
{
    interface IAuthenticationRepo
    {
        public Task<bool> Register(Register_Personal user);
        public Task<bool> Login(ModelLogin user);
        public Task  Logout();
    }
}
