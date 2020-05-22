namespace PracticeWebApi.Services
{
    public interface IMapper<T, TDataEntity>
    {
        T MapToBase(TDataEntity dataEntity);
        TDataEntity MapToDataEntity(T baseType);
    }
}
