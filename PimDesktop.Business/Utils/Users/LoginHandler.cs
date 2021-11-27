using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserData = PimDesktop.Business.Utils.Users.UserData;

namespace PimDesktop.Business.Utils.Users
{
    public class LoginHandler
    {
        public UserData HandleLogin(UserData userData)
        {

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                try
                {
                    var users = context.usuario_sistema.Where(i => i.email == userData.user && i.senha == userData.password && i.ativo == true).FirstOrDefault();


                    if(users != null)
                    {
                    userData.id_profile = users.id_perfil;
                    userData.userId = users.id_usuarioSistema;

                    return userData;
                    }
                    else
                    {
                        return userData;
                    }
                }
                catch(Exception ex)
                {
                    return null;
                }
            }

        }

    }
}
