using Entity_Framework_Exercise.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framework_Exercise
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        TSQLDATAEntities db = new TSQLDATAEntities();
        private void button1_Click(object sender, EventArgs e)
        {

            //Select 
            //  custid
            //  ,country            
            //  ,region
            //  ,city
            //From sales.Customers
            //Where  region = 'WA';


            #region Linq to SQL
            //var result = from c in db.Customers
            //             where c.region == "WA"
            //             select new
            //             {
            //                 customerID = c.custid,
            //                 country = c.country,
            //                 region = c.region,
            //                 city = c.city
            //             };
            //dataGridView1.DataSource = result.ToList();
            #endregion

            #region LinQ to Entities
            dataGridView1.DataSource = db.Customers.Where(x => x.region == "WA").Select(c => new
            {
                customerID = c.custid,
                country = c.country,
                region = c.region,
                city = c.city
            }).ToList();

            #endregion           



        }

        private void btnSorgu2_Click(object sender, EventArgs e)
        {
            // Orderdate sıkıntı çıkarıyor...
            // Select
            //              orderdate
            // From sales.Orders
            // Where orderdate >= '20070601' And orderdate <'20070701'

            #region LinQ to SQL

            //var result = from o in db.Orders
            //             where o.orderdate >= "" && o.orderdate < ""
            //             select new { orderDate1 = o.orderdate };

            //dataGridView1.DataSource = result.ToList();
            #endregion

            #region LinQ to Entities

            //dataGridView1.DataSource = db.Orders.Where(o => o.orderdate >= "20070601" && o.orderdate <= "20070601").Select()

            #endregion
        }

        private void btnSorgu3_Click(object sender, EventArgs e)
        {
            //            Select
            //              o.shipcountry
            //		        ,o.shipcity
            //              ,o.empid
            //              ,o.freight
            //            From Sales.Orders as o
            //            where o.shipcountry = 'USA' and o.shipcity = 'Seattle'
            //            and o.empid in(1, 2, 3)--o.empid <= 3
            //            and o.freight > 100

            #region LinQ to SQL
            //var result = from o in db.Orders
            //             where o.shipcountry == "USA" && o.shipcity == "Seattle" && o.empid <= 3 && o.freight > 100
            //             select new
            //             {
            //                 o.shipcountry
            //                 ,o.shipcity
            //                 ,o.empid
            //                 ,o.freight
            //             };
            //dataGridView1.DataSource = result.ToList();
            #endregion

            #region Linq To Entity
            dataGridView1.DataSource = db.Orders.
                                             Where(o => o.shipcountry == "USA"
                                                && o.shipcity == "Seattle"
                                                && o.empid <= 3
                                                && o.freight > 100)
                                             .Select(x => new
                                             {
                                                 x.shipcountry
                                                ,
                                                 x.shipcity
                                                ,
                                                 x.empid
                                                ,
                                                 x.freight
                                             }).ToList();
            #endregion

        }

        private void btnSorgu4_Click(object sender, EventArgs e)
        {
            //  Select
            //      o.shipcountry
            //      ,o.shipcity
            //      ,sum(o.freight) as Toplam
            //      ,min(o.freight) as MinimumDeğer
            //      ,max(o.freight) as MaximumDeger
            //      ,avg(o.freight) as Avarage
            //  From Sales.Orders as o
            //  Group By o.shipcountry,o.shipcity             
            //  Order By o.shipcountry, o.shipcity

            #region Linq to SQL
            //var result = from o in db.Orders
            //             orderby o.shipcountry,o.shipcity
            //             group o by new { o.shipcountry,o.shipcity } into g                         
            //             select new
            //             {
            //                 mamberName =g.Key
            //                 ,ToplamFiyat = g.Sum( f=> f.freight)
            //                 ,MinFiyat = g.Min(f=> f.freight)
            //                 ,MaxFiyat = g.Max(f=> f.freight)
            //                 ,OrtalamaFiyat = g.Average(f=> f.freight)                             
            //             };

            //dataGridView1.DataSource = result.ToList();

            //MessageBox.Show("Oluşan Tablonun Satır Sayısı "+ dataGridView1.RowCount.ToString());
            #endregion

            #region LinQ to Entity

            dataGridView1.DataSource = db.Orders
                                        .OrderBy(o => new
                                        {
                                            o.shipcountry
                                            ,o.shipcity
                                        })
                                        .GroupBy(o => new
                                        {
                                            o.shipcountry
                                            ,o.shipcity
                                        })
                                        .Select(o => new
                                        {
                                            membername = o.Key
                                            ,Toplamfiyat = o.Sum(f => f.freight)
                                            ,MinFiyat = o.Min(f => f.freight)
                                            ,MaxFiyat = o.Max(f => f.freight)
                                            ,OrtalamaFiyat = o.Average(f => f.freight)
                                        }).ToList();

            MessageBox.Show("Oluşan Tablonun Satır Sayısı " + dataGridView1.RowCount.ToString());
            #endregion



        }
    }
}
