using NHibernate;
using NHibernate.Criterion;
using cat.itb.M6UF2Pr_RequenaEric.model;

namespace cat.itb.M6UF2Pr_RequenaEric.cruds;

public class ProductCRUD
{

    public Product SelectByid(int Id)
    {
        Product product;
        using (var session = SessionFactoryCloud.Open())
        {
            product = session.Get<Product>(Id);
            session.Close();
        }
        return product;
    }

    public IList<Product> SelectAll()
    {
        IList<Product> product;
        using (var session = SessionFactoryCloud.Open())
        {
            product = (from c in session.Query<Product>() select c).ToList();
            session.Close();
        }
        return product;
    }

    public void Insert(Product product)
    {
        using (var session = SessionFactoryCloud.Open())
        {
            using (var tx = session.BeginTransaction())
            {
                session.Save(product);
                tx.Commit();
                Console.WriteLine("Product {0} inserted", product.code);
                session.Close();
            }
        }
    }
    public void Update(Product product)
    {
        using (var session = SessionFactoryCloud.Open())
        {
            using (var tx = session.BeginTransaction())
            {
                try
                {
                    session.Update(product);
                    tx.Commit();
                    Console.WriteLine("Product {0} updated", product.code);
                }
                catch (Exception ex)
                {
                    if (!tx.WasCommitted)
                    {
                        tx.Rollback();
                    }
                    throw new Exception("Error updating product : " + ex.Message);
                }
            }
            session.Close();
        }
    }
    public void Delete(Product product)
    {
        using (var session = SessionFactoryCloud.Open())
        {
            using (var tx = session.BeginTransaction())
            {
                try
                {
                    session.Delete(product);
                    tx.Commit();
                    Console.WriteLine("Product {0} deleted", product.code);
                }
                catch (Exception ex)
                {
                    if (!tx.WasCommitted)
                    {
                        tx.Rollback();
                    }
                    throw new Exception("Error deleting product : " + ex.Message);
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