using System;
using System.Collections.Generic;

namespace T2008M.Labs4
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            List<Customer> lst = new List<Customer>();


            CustomerVN vn = new CustomerVN(1, "Tai", "13/05/2019", 153, "sinh hoat");
            CustomerVN vn1 = new CustomerVN(2"xiu","20/11/2019",53,"kinh doanh");
            CustomerVN vn2 = new CustomerVN(3, "hieu", "04/11/2019", 42, "san xuat");
            CustomerNN nn = new CustomerNN(4,"huy","24/12/2019",135,"Anh");
            CustomerNN nn2 = new CustomerNN(5,"chien","30/11/2019",62,"Duc");
            CustomerNN nn3 = new CustomerNN(6,"Thư","25/12/2019",42,"Mi");
            
            lst.Add(vn);
            lst.Add(vn1);
            lst.Add(vn2);
            lst.Add(nn);
            lst.Add(nn);
            lst.Add(nn2);
            lst.Add(nn3);

            foreach (var x in lst)
            {
                if (x.GetType() == typeof(CustomerVN))
                {
                    var v = (CustomerVN) x;
                    Console.Write("Id: " + v.id + " - " + v.name + " - " + v.dateTime + " - " + v.amount + " - " + v.userObject + "\n");
                    Console.Write("Tong tien: " + x.total + "\n");
                }else if (x.GetType() == typeof(CustomerNN))
                {
                    var n = (CustomerNN) x;
                    Console.Write("Id: " + n.id + " - " + n.name + " - " + n.dateTime + " - " + n.amount + " - " + n.nationality + "\n" );
                    Console.Write("Tong tien: " + x.total + "\n");
                }
            }

            double totalNN = 0;
            int count = 0;
            foreach (var x in lst)
            {
                if (x.GetType() == typeof(CustomerNN))
                {
                    totalNN += x.total;
                    count++;
                }
            }
            Console.Write("Tong tien khach hang nuoc ngoai:"+totalNN+"-"+"so khach hang NN"+count +"\n");

            double totalTB = 0;
            if (totalNN > 0)
            {
                totalTB = totalNN / count;
            }
            Console.Write("Trung binh tien dien cua KHNN la :"+ totalTB+ "\n");
            
            Console.Write("Nhap ngay can tim kiem:");
            string date = Console.ReadLine();
            foreach (var x in lst)
            {
                if (x.dateTime.Contains(date))
                {
                    Console.Write("Id: " + x.id + " - " + x.name + " - " + x.dateTime + " - " + x.amount + "\n");
                    Console.Write("Tong tien: "+x.Total +"\n");
                }
            }
        }
    }
}