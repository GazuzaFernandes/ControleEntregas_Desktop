using DALLogisticaNHibertnate;
using NHibernate;

using System;
using System.Collections.Generic;
using System.Linq;

namespace DALLogistica.NHibertnate
{
    public class Repository<T> : IConnectionDal<T> where T : class
    {
        public int Inserir(T entidade)
        {
            int id = 0;
            using (ISession session = SQLSessionFactory.StartSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        int.TryParse(session.Save(entidade).ToString(), out id);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {
                            transaction.Rollback();
                        }
                        throw ex;
                    }
                }
            }
            return id;
        }

        public void Atualizar(T entidade)
        {
            using (ISession session = SQLSessionFactory.StartSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(entidade);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {
                            transaction.Rollback();
                        }
                        throw ex;
                    }
                }
            }
        }

        public void Excluir(T entidade)
        {
            using (ISession session = SQLSessionFactory.StartSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(entidade);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transaction.WasCommitted)
                        {
                            transaction.Rollback();
                        }
                        throw ex;
                    }
                }
            }
        }

        /// <summary>
        /// Método Consultar
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna o objeto de uma classe do Id informado</returns>
        public T ConsultarPorId(int id)
        {
            using (ISession session = SQLSessionFactory.StartSession())
            {
                return session.Get<T>(id);
            }
        }
        /// <summary>
        /// Método Listar
        /// </summary>
        /// <returns>Retorna uma List<T> da classe utilizada</returns>
        public List<T> Listar()
        {
            using (ISession session = SQLSessionFactory.StartSession())
            {
                return (from e in session.Query<T>() select e).ToList();
            }
        }
    }
}

