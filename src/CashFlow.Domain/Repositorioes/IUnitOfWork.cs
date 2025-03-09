namespace CashFlow.Domain.Repositorioes;
public interface IUnitOfWork
{
    Task Commit();
}
