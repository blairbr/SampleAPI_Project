namespace PracticeWebApi.Services
{
    public interface IMapper<TunaFish, Apples>
    {
        TunaFish MapToBase(Apples dataEntity);
        Apples MapToDataEntity(TunaFish baseType);
    }
}
