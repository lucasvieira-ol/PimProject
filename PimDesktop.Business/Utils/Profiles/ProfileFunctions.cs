using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDesktop.Business.Utils.Profiles
{
    public class ProfileFunctions
    {
        public ProfileData getPermissions(int idProfile)
        {
            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new Data.Server.db_pim_hmlEntities())
            {
                try
                {
                    ProfileData permissions = (ProfileData)context.perfil.Where(i => i.id_perfil == idProfile && i.ativo).Select(x => new ProfileData()
                    {
                        Id = x.id_perfil,
                        Name = x.nome,
                        Admin = x.admin,
                        Create_Client = x.criar_hospede,
                        Create_Employee = x.criar_funcionario,
                        Create_reservation = x.criar_reserva,
                        Reports = x.relatorios,
                        Enabled = x.ativo,
                    }).FirstOrDefault();

                    return permissions;
                }
                catch
                {
                    return null;
                }
            }
        }

        public List<ProfileData> getProfiles()
        {
            using (PimDesktop.Data.Server.db_pim_hmlEntities context = new Data.Server.db_pim_hmlEntities())
            {
                try
                {
                    List<ProfileData> profiles = new List<ProfileData>();

                    profiles = context.perfil.Where(i => i.ativo == true)
                        .Select(i => new ProfileData()
                        {
                            Id = i.id_perfil,
                            Name = i.nome
                        })
                        .OrderBy(x => x.Name)
                        .ToList();

                    return profiles;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
