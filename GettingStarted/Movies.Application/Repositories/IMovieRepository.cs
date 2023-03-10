using System;
using Movies.Application.Models;

namespace Movies.Application.Repositories
{
	public interface IMovieRepository
	{
		Task<bool> CreateAsync(Movie movie, CancellationToken cancellationToken = default);
		Task<Movie?> GetByIdAsync(Guid id, Guid? userid = default, CancellationToken cancellationToken = default);
		Task<Movie?> GetBySlugAsync(string slug,Guid? userid = default, CancellationToken cancellationToken = default);
		Task<IEnumerable<Movie>> GetAllAsync(Guid? userid = default, CancellationToken cancellationToken = default);
		Task<bool> UpdateAsync(Movie movie, CancellationToken cancellationToken = default, Guid? userid = default);
		Task<bool> DeleteByIdAsync(Guid id, CancellationToken cancellationToken = default);
		Task<bool> ExistsByIdAsync(Guid id, CancellationToken cancellationToken = default);
	}
}

