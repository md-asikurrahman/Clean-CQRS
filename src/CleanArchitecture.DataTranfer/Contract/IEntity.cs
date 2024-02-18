
namespace CleanArchitecture.DataTranfer.Contract
{
    public interface IEntity<out TKey> where TKey : IComparable<TKey>
    {
        TKey Id { get; }
    }
}