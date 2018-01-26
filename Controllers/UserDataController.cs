using AutoMapper;
using corregidorApi.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace corregidorApi.Controllers {
    public class UserDataController : Controller {
        private readonly CorregidorDbContext context;
        private readonly IMapper mapper;
        public UserDataController (CorregidorDbContext context, IMapper mapper) {
            this.mapper = mapper;
            this.context = context;

        }
    }
}