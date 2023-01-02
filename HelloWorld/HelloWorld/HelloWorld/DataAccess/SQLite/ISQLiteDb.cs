using SQLite;

namespace HelloWorld.DataAccess.SQLite
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
