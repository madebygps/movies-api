using System;
namespace Movies.Contracts.Requests
{
	public class CreateMovieRequest
	{
		public required string Title { get; set; }
		public required int YearOfRelease { get; set; }
		public required IEnumerable<string> Genres { get; init; } = Enumerable.Empty<string>();
		
	}
}