﻿using NHibernate;
using NHibernate.Criterion;
using cat.itb.M6UF2Pr_RequenaEric.model;

namespace cat.itb.M6UF2Pr_RequenaEric.cruds;

public class SupplierCRUD
{

    public Supplier SelectByid(int Id)
    {
        Supplier supplier;
        using (var session = SessionFactoryCloud.Open())
        {
            supplier = session.Get<Supplier>(Id);
            session.Close();
        }
        return supplier;
    }

    public IList<Supplier> SelectAll()
    {
        IList<Supplier> supplier;
        using (var session = SessionFactoryCloud.Open())
        {
            supplier = (from c in session.Query<Supplier>() select c).ToList();
            session.Close();
        }
        return supplier;
    }

    public void Insert(Supplier supplier)
    {
        using (var session = SessionFactoryCloud.Open())
        {
            using (var tx = session.BeginTransaction())
            {
                session.Save(supplier);
                tx.Commit();
                Console.WriteLine("Supplier {0} inserted", supplier.name);
                session.Close();
            }
        }
    }
    public void Update(Supplier supplier)
    {
        using (var session = SessionFactoryCloud.Open())
        {
            using (var tx = session.BeginTransaction())
            {
                try
                {
                    session.Update(supplier);
                    tx.Commit();
                    Console.WriteLine("Supplier {0} updated", supplier.name);
                }
                catch (Exception ex)
                {
                    if (!tx.WasCommitted)
                    {
                        tx.Rollback();
                    }
                    throw new Exception("Error updating supplier : " + ex.Message);
                }
            }
            session.Close();
        }
    }
    public void Delete(Supplier supplier)
    {
        using (var session = SessionFactoryCloud.Open())
        {
            using (var tx = session.BeginTransaction())
            {
                try
                {
                    session.Delete(supplier);
                    tx.Commit();
                    Console.WriteLine("Supplier {0} deleted", supplier.name);
                }
                catch (Exception ex)
                {
                    if (!tx.WasCommitted)
                    {
                        tx.Rollback();
                    }
                    throw new Exception("Error deleting supplier : " + ex.Message);
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