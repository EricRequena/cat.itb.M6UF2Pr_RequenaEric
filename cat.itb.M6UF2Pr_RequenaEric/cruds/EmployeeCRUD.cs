using NHibernate;
using cat.itb.M6UF2Pr_RequenaEric.model;
using cat.itb.M6UF2Pr_RequenaEric;

namespace cat.itb.M6UF2Pr_RequenaEric.cruds;

    public class EmployeeCRUD
    {
        public Employee SelectByid(int Id)
        {
            Employee employee;
            using (var session = SessionFactoryCloud.Open())
            {
                employee = session.Get<Employee>(Id);
                session.Close();
            }
            return employee;
        }

        public IList<Employee> SelectAll()
        {
            IList<Employee> employee;
            using (var session = SessionFactoryCloud.Open())
            {
                employee = (from c in session.Query<Employee>() select c).ToList();
                session.Close();
            }
            return employee;
        }

        public void Insert(Employee employee)
        {
            using (var session = SessionFactoryCloud.Open())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Save(employee);
                    tx.Commit();
                    Console.WriteLine("Employee {0} inserted", employee.surname);
                    session.Close();
                }
            }
        }
        public void Update(Employee employee)
        {
            using (var session = SessionFactoryCloud.Open())
            {
                using (var tx = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(employee);
                        tx.Commit();
                        Console.WriteLine("Employee {0} updated", employee.surname);
                    }
                    catch (Exception ex)
                    {
                        if (!tx.WasCommitted)
                        {
                            tx.Rollback();
                        }
                        throw new Exception("Error updating Employee : " + ex.Message);
                    }
                }
                session.Close();
            }
        }
        public void Delete(Employee employee)
        {
            using (var session = SessionFactoryCloud.Open())
            {
                using (var tx = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(employee);
                        tx.Commit();
                        Console.WriteLine("Employee {0} deleted", employee.surname);
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

    