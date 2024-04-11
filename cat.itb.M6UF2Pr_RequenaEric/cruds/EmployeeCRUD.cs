using NHibernate;
using cat.itb.M6UF2Pr_RequenaEric.model;
using cat.itb.M6UF2Pr_RequenaEric;

namespace cat.itb.M6UF2Pr_RequenaEric.cruds;

    public class EmloyeeCRUD
    {
        public Emloyee SelectByid(int Id)
        {
            Emloyee emloyee;
            using (var session = SessionFactoryCloud.Open())
            {
                emloyee = session.Get<Emloyee>(Id);
                session.Close();
            }
            return emloyee;
        }

        public IList<Emloyee> SelectAll()
        {
            IList<Emloyee> emloyee;
            using (var session = SessionFactoryCloud.Open())
            {
                emloyee = (from c in session.Query<Emloyee>() select c).ToList();
                session.Close();
            }
            return emloyee;
        }

        public void Insert(Emloyee emloyee)
        {
            using (var session = SessionFactoryCloud.Open())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Save(emloyee);
                    tx.Commit();
                    Console.WriteLine("Emloyee {0} inserted", emloyee.surname);
                    session.Close();
                }
            }
        }
        public void Update(Emloyee emloyee)
        {
            using (var session = SessionFactoryCloud.Open())
            {
                using (var tx = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(emloyee);
                        tx.Commit();
                        Console.WriteLine("Emloyee {0} updated", emloyee.surname);
                    }
                    catch (Exception ex)
                    {
                        if (!tx.WasCommitted)
                        {
                            tx.Rollback();
                        }
                        throw new Exception("Error updating emloyee : " + ex.Message);
                    }
                }
                session.Close();
            }
        }
        public void Delete(Emloyee employee)
        {
            using (var session = SessionFactoryCloud.Open())
            {
                using (var tx = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(employee);
                        tx.Commit();
                        Console.WriteLine("Emloyee {0} deleted", employee.surname);
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

    