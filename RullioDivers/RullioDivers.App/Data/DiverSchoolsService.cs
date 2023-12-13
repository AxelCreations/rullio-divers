using Microsoft.EntityFrameworkCore;
using RullioDivers.DAL;
using RullioDivers.DAL.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RullioDivers.App.Data;

public class DiverSchoolsService(RullioDataContext context)
{
    private readonly RullioDataContext _context = context;

    public async Task<List<DiverSchool>> GetAllAsync() => await _context.DiverSchools.ToListAsync();

    public async Task<DiverSchool> GetByIDAsync(int ID) => await _context.DiverSchools.FindAsync(ID);
}
