namespace ApiFichaAcademia.Repository.Contract.Base
{
	public interface IBaseRepository<T, M> 
		where T : class
		where M : class
	{
		Task<List<M>> GetAll();
		Task<M> GetById(int id);

		Task<T> Create(T teacher);
		Task<T> Update(T teacher);
		Task<T> Delete(int id);
	}
}
