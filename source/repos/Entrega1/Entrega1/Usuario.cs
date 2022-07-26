using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega1
{
    public class Usuario
    {
        protected int id;
        protected string name;
        protected string lastname;
        protected string usrName;
        protected string pwd;
        protected string email;

        public Usuario()
        {
            id = 1;
            name = string.Empty;
            lastname = string.Empty;    
            usrName = string.Empty;
            pwd = string.Empty;
            email = string.Empty;
        }
        public Usuario(int unId,string unName,string unLastname,string unUsr,string unaPass, string unMail)
        {
            id = unId;
            name = unName;
            lastname = unLastname;
            usrName = unUsr;
            pwd = unaPass;
            email = unMail;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string unName)
        {
            this.name = unName;
        }

        public string getLastname()
        {
            return lastname;
        }
        public void setLastname(string unLastname)
        {
            this.lastname = unLastname;
        }

        public string getUsrname()
        {
            return usrName;
        }
        public void setUsrname(string unUsr)
        {
            this.usrName = unUsr;
        }

        public string getPwd()
        {
            return pwd;
        }
        public void setPwd( string unaPwd)
        {
            this.pwd = unaPwd;
        }

        public string getEmail()
        {
            return email;
        }
        public void setEmail (string unEmail)
        {
            this.email = unEmail;
        }
    }
}
