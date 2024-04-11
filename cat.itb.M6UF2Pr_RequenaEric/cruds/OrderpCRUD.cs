using NHibernate;
using NHibernate.Criterion;
using cat.itb.M6UF2Pr_RequenaEric.model;
namespace cat.itb.M6UF2Pr_RequenaEric.cruds;

public class OrderpCRUD
{

    public Orderp SelectByid(int Id)
    {
        Orderp orderp;
        using (var session = SessionFactoryCloud.Open())
        {
            orderp = session.Get<Orderp>(Id);
            session.Close();
        }
        return orderp;
    }

    public IList<Orderp> SelectAll()
    {
        IList<Orderp> orderp;
        using (var session = SessionFactoryCloud.Open())
        {
            orderp = (from c in session.Query<Orderp>() select c).ToList();
            session.Close();
        }
        return orderp;
    }

    public void Insert(Orderp orderp)
    {
        using (var session = SessionFactoryCloud.Open())
        {
            using (var tx = session.BeginTransaction())
            {
                session.Save(orderp);
                tx.Commit();
                Console.WriteLine("Emloyee {0} inserted", orderp.supplierno);
                session.Close();
            }
        }
    }
    public void Update(Orderp orderp)
    {
        using (var session = SessionFactoryCloud.Open())
        {
            using (var tx = session.BeginTransaction())
            {
                try
                {
                    session.Update(orderp);
                    tx.Commit();
                    Console.WriteLine("Orderp {0} updated", orderp.supplierno);
                }
                catch (Exception ex)
                {
                    if (!tx.WasCommitted)
                    {
                        tx.Rollback();
                    }
                    throw new Exception("Error updating orderp : " + ex.Message);
                }
            }
            session.Close();
        }
    }
    public void Delete(Orderp orderp)
    {
        using (var session = SessionFactoryCloud.Open())
        {
            using (var tx = session.BeginTransaction())
            {
                try
                {
                    session.Delete(orderp);
                    tx.Commit();
                    Console.WriteLine("Emloyee {0} deleted", orderp.supplierno);
                }
                catch (Exception ex)
                {
                    if (!tx.WasCommitted)
                    {
                        tx.Rollback();
                    }
                    throw new Exception("Error deleting employee : " + ex.Message);
                }
            }
            session.Close();
        }
    }




    /*
    public IList<Student> SelectByName(string name)
    {
        IList<Student> students;
        using (var session = SessionFactoryCloud.Open())
        {
            // IQuery query = session.CreateQuery("select * from student c where c.firstname = 'Roc'");
            IQuery query = session.CreateQuery("select c from Student c where c.firstname = " +"'" + name +"'");
            students = query.List<Student>();
           
            session.Close();
        }

        return students;
    }
    
    public IList<Student> SelectAll()
    {
        IList<Student> students;
        using (var session = SessionFactoryCloud.Open())
        {
            students = (from c in session.Query<Student>() select c).ToList();
            session.Close();
        }
        return students;
    }
    public void Insert(Student student)
    {
        using (var session = SessionFactoryCloud.Open())
        {
            using (var tx = session.BeginTransaction())
            {
                session.Save(student);
                tx.Commit();
                Console.WriteLine("Student {0} inserted",student.lastname);
                session.Close();
            }
        }
    }
    
    public void Update(Student student)
    {
        using (var session = SessionFactoryCloud.Open())
        {
            using (var tx = session.BeginTransaction())
            {
                try
                {
                   session.Update(student);
                    tx.Commit();
                   Console.WriteLine("Student {0} updated",student.lastname);
                }
                catch (Exception ex)
                {
                    if (!tx.WasCommitted)
                    {
                        tx.Rollback();
                    }
                    throw new Exception("Error updating student : " + ex.Message);
                }
            }
            session.Close();
        }
    }
    public void Delete(Student student)
    {
        using (var session = SessionFactoryCloud.Open())
        {
            using (var tx = session.BeginTransaction())
            {
                try
                {
                    session.Delete(student);
                    tx.Commit();
                   Console.WriteLine("Student {0} deleted",student.lastname);
                }
                catch (Exception ex)
                {
                    if (!tx.WasCommitted)
                    {
                        tx.Rollback();
                    }
                    throw new Exception("Error deleting student : " + ex.Message);
                }
            }
            session.Close();
        }
    }*/
}