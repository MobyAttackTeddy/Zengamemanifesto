using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using zengamemanifesto.Models;

namespace zengamemanifesto.Repo
{

    public interface IAuthen
    {
        bool CheckLogin(string email, string password);
        bool logout();
    }

    public class UserAuth : IAuthen
    {
        private Entities1 db = new Entities1();
        public bool CheckLogin(string name, string password)
        {

            return db.UserSet.SingleOrDefault(c => c.Name == name && c.Password == password) != null;
        }

        public bool logout()
        {
            return false;
        }
    }
}