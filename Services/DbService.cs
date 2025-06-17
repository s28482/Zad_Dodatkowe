using APBD_Zad_Dodatkowe.Data;

namespace APBD_Zad_Dodatkowe.Services;

public interface IDbService
{
}

public class DbService(MyDbContext data) :IDbService
{
    
}