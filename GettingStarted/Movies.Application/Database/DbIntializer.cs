using Dapper;

namespace Movies.Application.Database;

public class DbIntializer
{
    private readonly IDbConnectionFactory _dbConnectionFactory;

    public DbIntializer(IDbConnectionFactory dbConnectionFactory)
    {
        _dbConnectionFactory = dbConnectionFactory;

    }

    public async Task IntializeAsync()
    {
        using var connection = await _dbConnectionFactory.CreateConnectionAsync();
        await connection.ExecuteAsync("""
            create table if not exists movies (
            id UUID primary key,
            slug TEXT not null,
            title TEXT not null,
            yearofrelease integer not null);
            
            """);

        await connection.ExecuteAsync("""
        create unique index concurrently if not exists movies_slug_idx
        on movies
        using btree(slug);
        """);
    }
}