using Microsoft.EntityFrameworkCore;
using Patient.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace Patient.Application.Mappings
{
    public static class MappingExtensions
    {
        public static Task<PaginatedList<T>>PaginatedListAsync<T>(this IQueryable<T> queryable, int pageNumber, int pageSize) where T : class
            => PaginatedList<T>.CreateAsync(queryable.AsNoTracking(), pageNumber, pageSize);

        public static Task<List<T>> ProjectToListAsync<T>(this IQueryable queryable, IConfigurationProvider configuration) where T : class
            => queryable.ProjectTo<T>(configuration).AsNoTracking().ToListAsync();
    }
}