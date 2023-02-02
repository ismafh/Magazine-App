using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magazine.Entities;


namespace Magazine.Services
{
    public interface IMagazineService
    {
        void RemoveAllData();
        void Commit();

        // Necesario para la inicialización de la BD
        void DBInitialization();
        void AddPerson(Person p);
        void AddMagazine(Magazine.Entities.Magazine m);
        void AddArea(Area a);

        // A partir de aquí cread los vuestros
        void AddUser(User u);
        void AddPaper(Paper p);
        void Login(string username, string password);
        User UserLogged();
        void Logout();
        void EvaluatePaper(Paper p, bool accepted, String comment);
        void SendPaper(Paper pp);
        Area FindAreaByName(String name);
        Paper FindPaperByName(String name);
        Person FindPersonById(String id);
        Paper FindPaperById(String id);
        IList<Paper> ListPapersByArea();
        IList<Paper> GetPapersByArea(Area a);
        Magazine.Entities.Magazine GetMagazine();
        IList<Magazine.Entities.Magazine> GetAllMagazines();
        IList<Magazine.Entities.Paper> GetAllPapers();
        IList<Magazine.Entities.Area> GetAllAreas();
        void addPublish(Issue current, Area area, Paper p);
    }
}
