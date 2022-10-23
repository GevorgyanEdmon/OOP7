using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP7
{
    internal class UserStorage
    {
        private Dictionary<AuthorizeInfo, UserInfo> data;

        public UserStorage()
        {
            data= new Dictionary<AuthorizeInfo, UserInfo>();
            data.Add(new AuthorizeInfo("Геворгян", "123"), new UserInfo("Геворгян Э.Г.", "gevorgyan@mail.ru","Stavropol"));
            data.Add(new AuthorizeInfo("Адам", "321"), new UserInfo("Зайгов А.М.", "Zaigov@mail.ru", "Stavropol"));
        }

        public UserInfo GetUser(AuthorizeInfo ob)
        {
            if(data.ContainsKey(ob)) return data[ob];
            else return null;
        }
    }
}
