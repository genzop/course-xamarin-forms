using System.Collections.Generic;
using System.Threading.Tasks;
using HelloWorld.BeyondBasics.MessagingCenter.Exercise.Models;
using HelloWorld.DataAccess.SQLite;
using SQLite;

namespace HelloWorld.BeyondBasics.MessagingCenter.Exercise.Persistence
{
	public class SQLiteContactStore : IContactStore
	{
		private SQLiteAsyncConnection _connection;

		public SQLiteContactStore(ISQLiteDb db)
		{
			_connection = db.GetConnection();
			_connection.CreateTableAsync<Contact>();
		}

		public async Task<IEnumerable<Contact>> GetContactsAsync()
		{
			return await _connection.Table<Contact>().ToListAsync();
		}

		public async Task DeleteContact(Contact contact)
		{
			await _connection.DeleteAsync(contact);
		}

		public async Task AddContact(Contact contact)
		{
			await _connection.InsertAsync(contact);
		}

		public async Task UpdateContact(Contact contact)
		{
			await _connection.UpdateAsync(contact);
		}

		public async Task<Contact> GetContact(int id)
		{
			return await _connection.FindAsync<Contact>(id);
		}
	}
}
