using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using REST_API.Models;
using REST_API.Data;

namespace REST_API.Services
{
    public class ArdoaService : IArdoaService
    {
        private readonly WineShopDbContext _context;

        public ArdoaService(WineShopDbContext context)
        {
            _context = context;
        }
        public async Task<List<ArdoaUpeltegiDto>> GetMota(int id)
        {
            return _context.Ardoa
                .Where(m => m.MotaId == id)
                .Select(x => new ArdoaUpeltegiDto()
                {
                    Id = x.Id,
                    Izena = x.Izena,
                    UpeltegiIzena = x.Upeltegia.Izena
                })
                .ToList();

        }
        public async Task<List<Ardoa>> GetArdoak()
        {
            return await _context.Ardoa.ToListAsync();
        }
    }
}
