using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemoFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            //做一个添加操作
            //声明一个EF的上下文
            DarkHorseEntiies dbContext = new DarkHorseEntiies();

            Employees employees = new Employees();
            //employees.EmpName = "李二白";
            //employees.EmpGender = "男";
            //employees.EmpAge = 22;
            //employees.EmpEmail = "5264128@qq.com";
            //employees.EmpDepId = 2;
            //employees.EmpAddr = "北京市昌平区";
            //employees.EmpId = 3;

            //增加数据
            //dbContext.Employees.Add(employees);

            //修改数据
            //dbContext.Entry<Employees>(employees).State = System.Data.Entity.EntityState.Modified;

            //只修改某一列
            //dbContext.Employees.Attach(employees);
            //dbContext.Entry<Employees>(employees).Property(u => u.EmpName).IsModified = true;
            //dbContext.SaveChanges();

            //Console.WriteLine("修改成功");

            foreach (var em in dbContext.Employees)
            {
                Console.WriteLine(em.EmpName + em.EmpGender + em.EmpAge);
            }
            Console.ReadKey();
        }
    }
}
