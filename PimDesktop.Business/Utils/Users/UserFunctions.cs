using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PimDesktop.Data.Server;

namespace PimDesktop.Business.Utils.Users
{
    public class UserFunctions
    {
        public UserData getUser(string email)
        {

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                UserData userFound = new UserData();

                try
                {
                    userFound = context.usuario_sistema.Where(i => i.email == email)
                        .Select(x => new UserData()
                        {
                            userId = x.id_usuarioSistema,
                            user = x.nome,
                            emailUser = x.email,
                            id_profile = x.id_perfil,
                            enabled = x.ativo
                        })
                        .FirstOrDefault();

                    return userFound;
                }
                catch (Exception ex)
                {
                    return userFound;
                }
            }
        }
        public List<UserData> getUserRpt(DateTime firstDate, DateTime lastDate)
        {

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                List<UserData> usersFound = new List<UserData>();

                usersFound = (from u in context.usuario_sistema
                              join p in context.perfil on u.id_perfil equals p.id_perfil
                              join uca in context.reserva on u.id_usuarioSistema equals uca.id_usuarioCadastro into createGroup
                              join uci in context.reserva on u.id_usuarioSistema equals uci.id_usuarioCheckIn into checkInGroup
                              join uco in context.reserva on u.id_usuarioSistema equals uco.id_usuarioCheckOut into checkOutGroup
                              select new
                              {
                                  u,
                                  p,
                                  countCreate = createGroup.Where(x => x.id_usuarioCadastro == u.id_usuarioSistema && x.ativo && x.data_cadastro >= firstDate && x.data_cadastro <= lastDate).Count(),
                                  countCheckin = checkInGroup.Where(x => x.id_usuarioCheckIn == u.id_usuarioSistema && x.ativo && x.data_checkIn >= firstDate && x.data_checkIn <= lastDate).Count(),
                                  countCheckOut = checkOutGroup.Where(x => x.id_usuarioCheckOut == u.id_usuarioSistema && x.ativo && x.data_checkOut >= firstDate && x.data_checkOut <= lastDate).Count()
                              })
                     .Select(x => new UserData()
                     {
                         userId = x.u.id_usuarioSistema,
                         user = x.u.nome,
                         emailUser = x.u.email,
                         id_profile = x.u.id_perfil,
                         enabled = x.u.ativo,
                         nameProfile = x.p.nome,
                         qtyReservationCreated = x.countCreate,
                         qtyReservationCheckIn = x.countCheckin,
                         qtyReservationCheckOut = x.countCheckOut
                     })
                     .ToList();

                return usersFound;

            }
        }

        public bool putUser(UserData currentUser)
        {

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {
                var updateUser = context.usuario_sistema.AsEnumerable().Where(i => i.id_usuarioSistema == currentUser.userId).SingleOrDefault();

                updateUser.ativo = currentUser.enabled;

                if (!string.IsNullOrEmpty(currentUser.user))
                    updateUser.nome = currentUser.user;

                if (!string.IsNullOrEmpty(currentUser.emailUser))
                    updateUser.email = currentUser.emailUser;

                if (context.usuario_sistema.AsEnumerable().Where(i => i.email == currentUser.emailUser && i.id_usuarioSistema != currentUser.userId).Count() == 0)
                {
                    if (currentUser.id_profile != 0)
                        updateUser.id_perfil = currentUser.id_profile;

                    if (!string.IsNullOrEmpty(currentUser.password))
                        updateUser.senha = currentUser.password;

                    context.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }

            }

        }

        public bool setUser(UserData currentUser)
        {

            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new PimDesktop.Data.Server.db_pim_hmlEntities())
            {

                if (context.usuario_sistema.AsEnumerable().Where(i => i.email == currentUser.emailUser).Count() == 0)
                {
                    PimDesktop.Data.Server.usuario_sistema createUser = new Data.Server.usuario_sistema()
                    {
                        nome = currentUser.user,
                        email = currentUser.emailUser,
                        senha = currentUser.password,
                        id_perfil = currentUser.id_profile,
                        ativo = currentUser.enabled
                    };

                    context.usuario_sistema.Add(createUser);

                    context.SaveChanges();

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
