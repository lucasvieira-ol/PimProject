using PimDesktop.Data.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PimWebApi.Models.Payment
{

    public class paymentLog
    {
        public int reservationId { get; set; }
        public string description { get; set; }
        public decimal value { get; set; }
        public string typePayment { get; set; }
        public int payTimes { get; set; }
        public bool refund { get; set; }
        public bool registerPaid { get; set; }
        public DateTime registerDate { get; set; }
        public DateTime? paymentDate { get; set; }

    }

    public class paymentData
    {

        public int idCard { get; set; }
        public int idUserclient { get; set; }
        public string nameCard { get; set; }
        public string numberCard { get; set; }
        public DateTime validationDate { get; set; }
        public string validationConverted { get; set; }

    }

    public class paymentFunctions
    {
        #region payment

        public List<paymentData> getPayments(int userId)
        {
            using (db_pim_hmlEntities context = new db_pim_hmlEntities())
            {
                List<paymentData> lstPayments = context.usuario_cartao.Where(i => i.id_usuarioHospede == userId)
                    .AsEnumerable()
                    .Select(i => new paymentData()
                    {
                        idUserclient = i.id_usuarioHospede,
                        nameCard = i.nome_cartao,
                        numberCard = i.numero_cartao,
                        validationDate = i.data_validade.Value,
                        idCard = i.idCartao,
                        validationConverted = i.data_validade.Value.ToString("MM/yyyy")
                    })
                    .ToList();

                return lstPayments;
            }
        }

        public string createPayment(paymentData newPayment)
        {
            using (db_pim_hmlEntities context = new db_pim_hmlEntities())
            {

                if (context.usuario_cartao.Where(i => i.numero_cartao == newPayment.numberCard && i.id_usuarioHospede == newPayment.idUserclient).Count() != 0)
                    return "Não é possível adicionar o cartão, o mesmo já se encontra cadastrado para esse usuário";

                usuario_cartao addPayment = new usuario_cartao()
                {
                    id_usuarioHospede = newPayment.idUserclient,
                    data_validade = newPayment.validationDate,
                    nome_cartao = newPayment.nameCard,
                    numero_cartao = newPayment.numberCard
                };

                context.usuario_cartao.Add(addPayment);

                context.SaveChanges();

                return "Cartão adicionado com sucesso";
            }
        }
        public bool updatePayment(paymentData currentPayment)
        {
            using (db_pim_hmlEntities context = new db_pim_hmlEntities())
            {
                try
                {
                    var update = context.usuario_cartao.Where(i => i.id_usuarioHospede == currentPayment.idUserclient && i.idCartao == currentPayment.idCard).FirstOrDefault();

                    update.data_validade = currentPayment.validationDate;
                    update.nome_cartao = currentPayment.nameCard;
                    update.numero_cartao = currentPayment.numberCard;

                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }

            }
        }

        public bool deletePayment(paymentData deletePayment)
        {
            using (db_pim_hmlEntities context = new db_pim_hmlEntities())
            {
                try
                {
                    var delete = context.usuario_cartao.Where(i => i.idCartao == deletePayment.idCard).FirstOrDefault();

                    context.usuario_cartao.Remove(delete);

                    context.SaveChanges();

                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        #endregion

    }


}