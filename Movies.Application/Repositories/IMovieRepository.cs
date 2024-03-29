﻿using Movies.Application.Model;

namespace Movies.Application.Repositories
{
    public interface IMovieRepository
    {
        Task<bool> CreateAsync(Movie movie);

        Task<Movie?> GetByIdAsync(Guid id);

        Task<IEnumerable<Movie>> GetAllAsync();

        Task<bool> UpdateAsync(Movie movie);

        Task<bool> DeleteAsync(Guid id);
    }
}
