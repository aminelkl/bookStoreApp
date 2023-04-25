using BookStore.DataAccess.Repository.Irepository;
using BookStore.DataAccess.Repository;
using BookStore.DataAccess;
using BookStore.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
	public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
	{
		private ApplicationDbContext _db;

		public OrderDetailRepository(ApplicationDbContext db) : base(db)
		{
			_db = db;
		}


		public void Update(OrderDetail obj)
		{
			_db.OrderDetail.Update(obj);
		}
	}
}