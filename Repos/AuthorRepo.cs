using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Personal_WebAssebly_App_Fh_Aachen.Interfaces;
using System.Net.Http;
using Personal_WebAssebly_App_Fh_Aachen.Models;
using Blazored.LocalStorage;

namespace Personal_WebAssebly_App_Fh_Aachen.Repos

{
    public class AuthorRepo : BaseRepo<AuthorModel>, IAuthoRepo
    {

        private readonly HttpClient _client;
        private readonly ILocalStorageService _localStorage;

        public AuthorRepo(HttpClient client, ILocalStorageService localStorage) : base(client,localStorage)
        {
            _client = client;
            _localStorage = localStorage;
        }

 
    }
}
