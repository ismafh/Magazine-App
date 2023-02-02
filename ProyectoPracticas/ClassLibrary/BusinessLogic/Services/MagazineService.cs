using Magazine.Entities;
using Magazine.Persistence;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Magazine.Services
{
    public class MagazineService : IMagazineService
    {
        private readonly IDAL dal;
        private User user;

        public MagazineService(IDAL dal)
        {
            this.dal = dal;
        }

        public MagazineService()
        {
        }

        public void RemoveAllData()
        {
            dal.RemoveAllData();
        }

        public void Commit()
        {
            dal.Commit();
        }

        public void DBInitialization()
        {
            RemoveAllData();

            /*User u1 = new User("1234", "Pepe", "TheBoss", false, "ninguna", "ptheboss@gmail.com", "theboss", "1234");
            AddUser(u1);

            Magazine.Entities.Magazine m = new Magazine.Entities.Magazine("Revista Universitaria", u1);
            AddMagazine(m);

            User u2 = new User("2345", "Javier", "Garcia", false, "la mia", "jgarcia@gmail.com", "jgarcia", "1234");
            AddUser(u2);
            Area a1 = new Area("Area 1", u2, m);
            AddArea(a1);

            User u3 = new User("3456", "Mª Carmen", "Jimenez", false, "la mia por supuesto", "mcjimenez@gmail.com", "mcjimenez", "1234");
            AddUser(u3);
            Area a2 = new Area("Area 2", u3, m);
            AddArea(a2);

            // De regalo
            User u4 = new User("4567", "Juan", "Campeador", false, "la mejor", "jcampeador@gmail.com", "jcampeador", "1234");
            AddUser(u4);*/

            User u1 = new User("1234", "Pepe", "TheBoss", false, "ninguna", "pgarcia@gmail.com", "theboss", "1234");
            dal.Insert<User>(u1);
            dal.Commit();

            User u2 = new User("9823", "Torralba", "AreaEditor", true, "Editor", "torrycaqui@gmail.com", "pipas", "99c9");
            dal.Insert<User>(u2);
            dal.Commit();

            User u3 = new User("3642", "Carlos", "ArticleRes", false, "Article", "delegado@gmail.com", "march", "7s72");
            dal.Insert<User>(u3);
            dal.Commit();

            User u4 = new User("3643", "Paco", "paquito", false, "Article", "paco@gmail.com", "pakk", "7s73");
            dal.Insert<User>(u4);
            dal.Commit();

            User u5 = new User("3644", "Pakito", "frances", false, "Article", "miau@gmail.com", "grrr", "8s72");
            dal.Insert<User>(u5);
            dal.Commit();

            Magazine.Entities.Magazine m = new Magazine.Entities.Magazine("Revista Universitaria", u1);
            u1.Magazine = m;
            dal.Insert<Magazine.Entities.Magazine>(m);
            dal.Commit();



            Area a1 = new Area("Deportes", u2, m);
            Area a2 = new Area("Deportesitos", u3, m);
            Area a3 = new Area("Pepitos", u4, m);
            Area a4 = new Area("Manuelitos", u5, m);

            dal.Insert<Area>(a2);
            dal.Insert<Area>(a1);
            dal.Insert<Area>(a3);
            dal.Insert<Area>(a4);
            dal.Commit();

            Issue i1 = new Issue(2, m);

            Paper p1 = new Paper("Noticias", DateTime.Today, a1, u3);
            Paper p2 = new Paper("Cositas", DateTime.Today, a1, u2);
            Paper p3 = new Paper("Magia", DateTime.Today, a2, u3);
            Paper p4 = new Paper("Cronica", DateTime.Today, a2, u3);
            Paper p5 = new Paper("Animales", DateTime.Today, a3, u3);
            Paper p6 = new Paper("Papeleo", DateTime.Today, a3, u3);
            Paper p7 = new Paper("Matumbo", DateTime.Today, a4, u3);
            Paper p8 = new Paper("Furbo", DateTime.Today, a4, u3);


            // a1.EvaluationPending.Add(p1);
            //p1.EvaluationPendingArea = a1;
            //p2.EvaluationPendingArea = a1;

            i1.PublishedPapers.Add(p1);
            i1.PublishedPapers.Add(p2);
            i1.PublishedPapers.Add(p3);
            i1.PublishedPapers.Add(p4);

            a1.PublicationPending.Add(p5);
            a1.PublicationPending.Add(p6);
            a1.PublicationPending.Add(p7);
            a2.PublicationPending.Add(p8);


            dal.Insert<Paper>(p1);
            dal.Insert<Paper>(p2);
            dal.Insert<Paper>(p3);
            dal.Insert<Paper>(p4);
            dal.Insert<Paper>(p5);
            dal.Insert<Paper>(p6);
            dal.Insert<Paper>(p7);
            dal.Insert<Paper>(p8);
            dal.Commit();


            // a2.EvaluationPending.Add(p3);



            Area pruebaArea = new Area("Torralba", u1, m);
            Paper pruebaPaper = new Paper("Torralbaaa", DateTime.Today, pruebaArea, u1);
            pruebaPaper.Issue = i1;
            pruebaPaper.EvaluationPendingArea = pruebaArea;
            dal.Insert<Paper>(pruebaPaper);
            dal.Insert<Issue>(i1);
            dal.Insert<Area>(pruebaArea);
            dal.Commit();

            Console.WriteLine("Nombre de la revista: " + m.Name);
            Console.WriteLine("Jefe de la revista: " + m.ChiefEditor.Name + " " + m.ChiefEditor.Surname);
            Console.WriteLine("Editor del area: " + u1.Name);
            Console.WriteLine("Responsable del articulo: " + u3.Name);
            Console.WriteLine("Papeles por revisar: " + a1.EvaluationPending);
        }

        public void AddPerson(Person person)
        {
            // Restricción: No puede haber dos personas con el mismo DNI
            if (dal.GetById<Person>(person.Id) == null)
            {
                dal.Insert<Person>(person);
                dal.Commit();
            }
            else throw new ServiceException("Person with Id " + person.Id + " already exists.");
        }

        public void AddMagazine(Magazine.Entities.Magazine magazine)
        {
            // Restricción: No puede haber dos revistas con el mismo nombre
            if (!dal.GetWhere<Magazine.Entities.Magazine>(x => x.Name == magazine.Name).Any())
            {
                dal.Insert<Magazine.Entities.Magazine>(magazine);
                dal.Commit();
            }
            else throw new ServiceException("Magazine with name " + magazine.Name + " already exists.");
        }

        public void AddArea(Area area)
        {
            // Restricción: No puede haber dos areas con el mismo nombre
            if (!dal.GetWhere<Area>(x => x.Name == area.Name).Any())
            {
                dal.Insert<Area>(area);
                dal.Commit();
            }
            else throw new ServiceException("Area with name " + area.Name + " already exists.");
        }

        // A partid de aquí escribid vuestras implementaciones
        public void AddUser(User u)
        {
            if (dal.Exists<User>(u.Id) == false)
            {
                dal.Insert<User>(u);
                dal.Commit();
            }
            else throw new ServiceException("Usario ya existente");
            
         }


        public void AddPaper(Paper p)
        {
            if (!dal.GetWhere<Paper>(x => x.Title == p.Title).Any())
            {
                p.BelongingArea.EvaluationPending.Add(p);
                dal.Insert<Paper>(p);
                dal.Commit();
            }
            else throw new ServiceException("Artículo ya existente");
        }

        public void RemovePaper(Paper p)
        {
            if (dal.GetWhere<Paper>(x => x.Title == p.Title).Any())
            {
                dal.Delete<Paper>(p);
                dal.Commit();
            }
            else throw new ServiceException("Artículo no existente");
        }

        public void Login(String login, String password)
        {
            if(dal.GetWhere<User>(x => x.Login == login).First().Login == "" )
                throw new ServiceException("User does not exist");

            user = dal.GetWhere<User>(x => x.Login == login).First();
            if (user != null)
            {
                if (user.Password != password)
                {
                    throw new ServiceException("Password incorrecto");
                }
                else Console.Out.WriteLine("Contraseña encontrada");
            }
            else throw new ServiceException("Login with login " + login + " already exists.");
        }

        public User UserLogged() { return user; }

        public void Logout() { user = null; }

        public void SendPaper(Paper pp)
        {
            if (UserLogged() == null)
                throw new ServiceException("User not logged in");
            
            dal.Insert<Paper>(pp);
            dal.Commit();
        }

        public void EvaluatePaper(Paper p, bool accepted, String comment)
        {
            Evaluation eval = new Evaluation(accepted, comment, DateTime.Now);
            Area a = p.BelongingArea;

            if (accepted) 
            {
                dal.Insert<Evaluation>(eval);
                dal.Commit();

                a.EvaluationPending.Remove(p);
                a.PublicationPending.Add(p);

                p.Evaluation = eval;

                dal.Commit();
            }
            else 
            {
                dal.Insert<Evaluation>(eval);
                dal.Commit();

                a.EvaluationPending.Remove(p);

                p.Evaluation = eval;

                dal.Commit();
            }
        }
        public Area FindAreaByName(String name)
        {
            if (dal.GetWhere<Area>(x => x.Name.Equals(name)).Any())
            {
                return dal.GetWhere<Area>(x => x.Name.Equals(name)).First();
            }
            else throw new ServiceException("Area does not exist"); 
        }

        public Paper FindPaperByName(String name)
        {
            return dal.GetWhere<Paper>(x => x.Title.Equals(name)).First();
        }

        public Person FindPersonById(String id)
        {
            return dal.GetById<Person>(id);
        }

        public Paper FindPaperById(String id)
        {
            Paper pp = dal.GetWhere<Paper>(x => x.Title == id).First();
            return pp;
        }

        public IList<Paper> ListPapersByArea()
        {
           
                IList<Paper> plist = new List<Paper>();
                IList<Area> areaList = new List<Area>();
                areaList = GetAllAreas();
                IList<Paper> aux = new List<Paper>();
                for (int i = 0; i < areaList.Count(); i++)
                {
                    aux = GetPapersByArea(areaList[i]);
                    for (int j = 0; j < aux.Count(); j++)
                    {
                        plist.Add(aux[j]);
                    }
                }
                return plist;
        }

        public IList<Paper> GetPapersByArea(Area a)
        {
            return new List<Paper>(dal.GetWhere<Paper>(x => x.BelongingArea.Name == a.Name));
        }

        public Magazine.Entities.Magazine GetMagazine()
        {
            return dal.GetWhere<Magazine.Entities.Magazine>(x => x != null).First();
        }

        public IList<Magazine.Entities.Magazine> GetAllMagazines()
        {
            return new List<Magazine.Entities.Magazine>(dal.GetAll<Magazine.Entities.Magazine>());
        }

        public IList<Magazine.Entities.Paper> GetAllPapers()
        {
            return new List<Magazine.Entities.Paper>(dal.GetAll<Magazine.Entities.Paper>());
        }

        public IList<Magazine.Entities.Area> GetAllAreas()
        {
            return new List<Magazine.Entities.Area>(dal.GetAll<Magazine.Entities.Area>());
        }

        public void addPublish(Issue current, Area area, Paper p) 
        {
            current.PublishedPapers.Add(p);
            area.PublicationPending.Remove(p);
            dal.Commit();
        }
    }
}