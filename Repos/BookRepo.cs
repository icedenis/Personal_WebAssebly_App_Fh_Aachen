using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Personal_WebAssebly_App_Fh_Aachen.Models;
using Personal_WebAssebly_App_Fh_Aachen.Interfaces;
using Blazored.LocalStorage;
using System.Net.Http;

namespace Personal_WebAssebly_App_Fh_Aachen.Repos
{
    public class BookRepo : BaseRepo<BookModel>, IBookRepo
    {
        private readonly HttpClient _client;
        private readonly ILocalStorageService _localStorage;

        public BookRepo(HttpClient client, ILocalStorageService localStorage) : base(client, localStorage)
        {
            _client = client;
            _localStorage = localStorage;

        }



    }
}
