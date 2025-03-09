using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Repositorioes.Expenses;
public interface IExpensesRepository
{
    Task Add(Expense expense);
}
