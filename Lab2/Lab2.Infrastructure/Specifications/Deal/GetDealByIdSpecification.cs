namespace Lab2.Infrastructure.Specifications.Deal;

public class GetDealByIdSpecification : Specification<Domain.Entities.Deal>
{
    public GetDealByIdSpecification(int id)
    {
        AddInclude("Lead.Account");
        AddFilter(p => p.Id == id);
    }
}