namespace ApiFichaAcademia.Repository.Contract.Base
{
	public interface IBaseRepository<T> where T : class
	{
		Task<T> GetAll();
		Task<T> GetById(int id);

		Task<T> Create(T teacher);
		Task<T> Update(T teacher);
		Task<T> Delete(int id);
	}
}
