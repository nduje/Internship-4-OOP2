namespace Internship_4_OOP2.Infrastructure.Interfaces
{
    public interface IDapperManager
    {
        Task<IReadOnlyList<T>> QueryAsync<T>(string sql, object? param = null);
        
        Task<T?> QuerySingleAsync<T>(string sql, object? param = null);

        Task ExecuteAsync(string sql, object? param = null);
    }
}
