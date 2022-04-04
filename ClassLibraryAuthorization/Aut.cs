using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryAuthorization.AppDataFiles;

namespace ClassLibraryAuthorization
{
    public class Aut
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="log">логин</param>
        /// <param name="pas">пароль</param>
        /// <param name="chek">верны ли они</param>
        public static void Authoriz(string log, string pas,
                                    out bool chek)
        {
            chek = false;
            if (log.Length > 0)
            {
                if (pas.Length > 0)
                {
                    if (log == "admin" && pas == "admin")
                        chek = true;
                }
            }
        }
    }
}
