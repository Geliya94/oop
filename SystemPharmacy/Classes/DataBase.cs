using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SystemPharmacy
{
    public class DataBase : DataContext
    {
        public DataBase(string path)
            : base(path)
        { }
        public Table<Algoritm> Algoritm;
        public Table<Card> Card;
        public Table<Discount> Discount;
        public Table<Preparat> Preparat;
        public Table<Group> Group;
        public Table<Sale> Sale;
        public Table<Setup> Setup;
        public Table<Postavchik> Postavchik;
        public Table<Zakaz> Zakaz;
        public Table<Zakupki> Zakupki;


        #region Adding
        public void ADD_Algoritm(string Nazvanie, DateTime Date)
        {
            Algoritm a = new Algoritm();
            a.nazvanie = Nazvanie;
            a.date = Date;
            this.Algoritm.InsertOnSubmit(a);
            this.SubmitChanges();
        }
        public void ADD_Card(int id_algoritm, float save_summa, int current_procent)
        {
            Card a = new Card();
            a.id_algoritm = id_algoritm;
            a.summa_nakopl = save_summa;
            a.current_procent = current_procent;
            this.Card.InsertOnSubmit(a);
            this.SubmitChanges();
        }
        public void ADD_Discount(int id_algoritm, float summa, int procent)
        {
            Discount a = new Discount();
            a.id_algoritm = id_algoritm;
            a.summa = summa;
            a.procent = procent;
            this.Discount.InsertOnSubmit(a);
            this.SubmitChanges();
        }
        public void ADD_Group(int id_group, string name)
        {
            Group a = new Group();
            a.id_group = id_group;
            a.name = name;
            this.Group.InsertOnSubmit(a);
            this.SubmitChanges();
        }
        public void ADD_Preparat(int id_postavchik, int id_setup, int id_group, string name, float price, int amount, DateTime srok)
        {
            Preparat a = new Preparat();
            a.id_postavchik = id_postavchik;
            a.id_setup = id_setup;
            a.id_group = id_group;
            a.name = name;
            a.price = price;
            a.amount = amount;
            a.srok = srok;
            this.Preparat.InsertOnSubmit(a);
            this.SubmitChanges();
        }
        public void ADD_Postavchik(string name, string email,string address)
        {
            Postavchik a = new Postavchik();
            a.name = name;
            a.email = email;
            a.address= address;
            this.Postavchik.InsertOnSubmit(a);
            this.SubmitChanges();
        }
        public void ADD_Zakaz( int id_preparat, int kolvo,  DateTime date)
        {
           Zakaz a = new Zakaz();
            a.id_preparat = id_preparat;
            a.kolvo = kolvo;
            a.date = date;
            this.Zakaz.InsertOnSubmit(a);
            this.SubmitChanges();
        }
        public void ADD_Zakupki(int id_preparat, int kolvo,float price,  DateTime date)
        {
            Zakupki a = new Zakupki();
            a.id_preparat = id_preparat;
            a.kolvo = kolvo;
            a.price = price;
            a.date = date;
            this.Zakupki.InsertOnSubmit(a);
            this.SubmitChanges();
        }
        public void ADD_Sale(int id_preparat,  int amount,  DateTime date, float summa)
        {
            Sale a = new Sale();
            a.id_preparat = id_preparat;
            a.amount = amount;
            a.date = date;
            a.summa = summa;
            this.Sale.InsertOnSubmit(a);
            this.SubmitChanges();
        }
        public void ADD_Setup(string name,  int porog)
        {
            Setup a = new Setup();
            a.name = name;
            a.porog = porog;
            this.Setup.InsertOnSubmit(a);
            this.SubmitChanges();
        }
        #endregion

        #region Deleting
        public int FindIdPrep(int idpost)
        {
            int id = -1;
            var query = from h in this.Preparat where (h.id_postavchik == idpost) select h.id_preparat;
            foreach (var q in query)
            { id = q; }
            return id;
        }
        public void Update_Preparat(int id_preparat,int id_postavchik, string name, float price, int amount)
        {
            Preparat a = this.Preparat.Where(c => c.id_preparat == id_preparat).FirstOrDefault();
            a.id_postavchik = id_postavchik;
            a.name = name;
            a.price = price;
            a.amount = amount;


            this.SubmitChanges();
        }
        public int FindIdpostav(string name)
        {
            int id = 0;
            var query = from h in this.Postavchik where (h.Name).ToLower() == name.ToLower() select h.id_postavchik;
            foreach (var q in query)
                id = q;
            return id;
        }
        public void Delete_Algoritm(int id)
        {
            var query = from h in this.Algoritm where h.id_algoritm == id select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Algoritm.DeleteOnSubmit(l as Algoritm);
            }
            this.SubmitChanges();
        }
        public void Delete_Card(int id)
        {
            var query = from h in this.Card where h.id_card == id select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Card.DeleteOnSubmit(l as Card);
            }
            this.SubmitChanges();
        }
        public void Delete_Discount(int id)
        {
            var query = from h in this.Discount where h.id_discount == id select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Discount.DeleteOnSubmit(l as Discount);
            }
            this.SubmitChanges();
        }
        public void Delete_Preparat(int id)
        {
            var query = from h in this.Preparat where h.id_preparat == id select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Preparat.DeleteOnSubmit(l as Preparat);
            }
            this.SubmitChanges();
        }
        public void Delete_Group(int id)
        {
            var query = from h in this.Group where h.id_group == id select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Group.DeleteOnSubmit(l as Group);
            }
            this.SubmitChanges();
        }
        public void Delete_Sale(int id)
        {
            var query = from h in this.Sale where h.id_sale == id select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Sale.DeleteOnSubmit(l as Sale);
            }
            this.SubmitChanges();
        }
        public void Delete_Setup(int id)
        {
            var query = from h in this.Setup where h.id_setup == id select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Setup.DeleteOnSubmit(l as Setup);
            }
            this.SubmitChanges();
        }
        public void Delete_Postavchik(int id)
        {
            var query = from h in this.Postavchik where h.id_postavchik == id select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Postavchik.DeleteOnSubmit(l as Postavchik);
            }
            this.SubmitChanges();
        }
        public void Delete_Zakaz(int id)
        {
            var query = from h in this.Zakaz where h.id_zakaz == id select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Zakaz.DeleteOnSubmit(l as Zakaz);
            }
            this.SubmitChanges();
        }
        public void Delete_Zakupki(int id)
        {
            var query = from h in this.Zakupki where h.id_zakupki == id select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Zakupki.DeleteOnSubmit(l as Zakupki);
            }
            this.SubmitChanges();
        }
        #endregion

        #region DeletingALL
        public void Delete_ALLAlgoritm()
        {
            var query = from h in this.Algoritm select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Algoritm.DeleteOnSubmit(l as Algoritm);
            }
            this.SubmitChanges();
        }
        public void Delete_ALLCard()
        {
            var query = from h in this.Card select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Card.DeleteOnSubmit(l as Card);
            }
            this.SubmitChanges();
        }
        public void Delete_ALLDiscount()
        {
            var query = from h in this.Discount select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Discount.DeleteOnSubmit(l as Discount);
            }
            this.SubmitChanges();
        }
        public void Delete_ALLPreparat()
        {
            var query = from h in this.Preparat select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Preparat.DeleteOnSubmit(l as Preparat);
            }
            this.SubmitChanges();
        }
        public void Delete_ALLZakaz()
        {
            var query = from h in this.Zakaz select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Zakaz.DeleteOnSubmit(l as Zakaz);
            }
            this.SubmitChanges();
        }
        public void Delete_ALLGroup()
        {
            var query = from h in this.Group select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Group.DeleteOnSubmit(l as Group);
            }
            this.SubmitChanges();
        }
        public void Delete_ALLSale()
        {
            var query = from h in this.Sale select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Sale.DeleteOnSubmit(l as Sale);
            }
            this.SubmitChanges();
        }
        public void Delete_ALLSetup()
        {
            var query = from h in this.Setup select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Setup.DeleteOnSubmit(l as Setup);
            }
            this.SubmitChanges();
        }
        public void Delete_ALLPostavchik()
        {
            var query = from h in this.Postavchik select h;
            List<Object> list = new List<object>();
            foreach (Object q in query)
                list.Add(q);
            foreach (Object l in list)
            {
                this.Postavchik.DeleteOnSubmit(l as Postavchik);
            }
            this.SubmitChanges();
        }

        #endregion


        #region Selecting

        public List<Object> Select_Algoritm()
        {
            List<Object> list = new List<object>();
            var query = from h in this.Algoritm select h;
            foreach (var q in query)
            {
                list.Add(q);
            }
            return list;
        }
        public List<Object> Select_Card()
        {
            List<Object> list = new List<object>();
            var query = from h in this.Card select h;
            foreach (var q in query)
            {
                list.Add(q);
            }
            return list;
        }
        public List<Object> Select_Discount()
        {
            List<Object> list = new List<object>();
            var query = from h in this.Discount select h;
            foreach (var q in query)
            {
                list.Add(q);
            }
            return list;
        }
        public List<Object> Select_Preparat()
        {
            List<Object> list = new List<object>();
            var query = from h in this.Preparat select h;
            foreach (var q in query)
            {
                list.Add(q);
            }
            return list;
        }
        public List<Object> Select_Group()
        {
            List<Object> list = new List<object>();
            var query = from h in this.Group select h;
            foreach (var q in query)
            {
                list.Add(q);
            }
            return list;
        }
        public List<Object> Select_Sale()
        {
            List<Object> list = new List<object>();
            var query = from h in this.Sale select h;
            foreach (var q in query)
            {
                list.Add(q);
            }
            return list;
        }
        public List<Object> Select_Setup()
        {
            List<Object> list = new List<object>();
            var query = from h in this.Setup select h;
            foreach (var q in query)
            {
                list.Add(q);
            }
            return list;
        }
        public List<Object> Select_Postavchik()
        {
            List<Object> list = new List<object>();
            var query = from h in this.Postavchik select h;
            foreach (var q in query)
            {
                list.Add(q);
            }
            return list;
        }

        #endregion
    }
    [Table]
    public partial class Algoritm
    {
        private int Id_algoritm;

        [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, DbType = "int", Storage = "Id_algoritm")]
        public int id_algoritm
        {
            get { return this.Id_algoritm; }
            set { this.Id_algoritm = value; }
        }
        private string Nazvanie;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "string", Storage = "Nazvanie")]
        public string nazvanie
        {
            get { return this.Nazvanie; }
            set { this.Nazvanie = value; }
        }

        private DateTime Date;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "DateTime", Storage = "Date")]
        public DateTime date
        {
            get { return this.Date; }
            set { this.Date= value; }
        }
    }
    [Table]
    public partial class Card
    {
        private int Id_card;
        [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, DbType = "int", Storage = "Id_card")]
        public int id_card
        {
            get { return this.Id_card; }
            set { this.Id_card = value; }
        }
        private int Id_algoritm;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Id_algoritm")]
        public int id_algoritm
        {
            get { return this.Id_algoritm; }
            set { this.Id_algoritm = value; }
        }
        private float Summa_nakopl;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "float", Storage = "Summa_nakopl")]
        public float summa_nakopl
        {
            get { return this.Summa_nakopl; }
            set { this.Summa_nakopl = value; }
        }
        private int Current_procent;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Current_procent")]
        public int current_procent
        {
            get { return this.Current_procent; }
            set { this.Current_procent = value; }
        }
    }
    [Table]
    public partial class Discount
    {
        private int Id_discount;
        [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, DbType = "int", Storage = "Id_discount")]
        public int id_discount
        {
            get { return this.Id_discount; }
            set { this.Id_discount = value; }
        }
        private int Id_algoritm;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Id_algoritm")]
        public int id_algoritm
        {
            get { return this.Id_algoritm; }
            set { this.Id_algoritm = value; }
        }
        private float Summa;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "float", Storage = "Summa")]
        public float summa
        {
            get { return this.Summa; }
            set { this.Summa = value; }
        }
        private int Procent;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Procent")]
        public int procent
        {
            get { return this.Procent; }
            set { this.Procent = value; }
        }
    }
    [Table]
    public partial class Group
    {
        private int Id_group;

        [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, DbType = "int", Storage = "Id_group")]
        public int id_group
        {
            get { return this.Id_group; }
            set { this.Id_group = value; }
        }
        private string Name;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "string", Storage = "Name")]
        public string name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
    }
    [Table]
    public partial class Preparat
    {
        private int Id_preparat;
        [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, DbType = "int", Storage = "Id_preparat")]
        public int id_preparat
        {
            get { return this.Id_preparat; }
            set { this.Id_preparat = value; }
        }
        private int Id_postavchik;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Id_postavchik")]
        public int id_postavchik
        {
            get { return this.Id_postavchik; }
            set { this.Id_postavchik = value; }
        }
        private int Id_setup;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Id_setup")]
        public int id_setup
        {
            get { return this.Id_setup; }
            set { this.Id_setup = value; }
        }
        private int Id_group;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Id_group")]
        public int id_group
        {
            get { return this.Id_group; }
            set { this.Id_group = value; }
        }
        private string Name;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "varchar(50)", Storage = "Name")]
        public string name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        private float Price;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "float", Storage = "Price")]
        public float price
        {
            get { return this.Price; }
            set { this.Price = value; }
        }
        private int Amount;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Amount")]
        public int amount
        {
            get { return this.Amount; }
            set { this.Amount = value; }
        }
        private DateTime Srok;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "DateTime", Storage = "Srok")]
        public DateTime srok
        {
            get { return this.Srok; }
            set { this.Srok = value; }
        }
    }
    [Table]
    public partial class Zakupki
    {
        private int Id_zakupki;
        [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, DbType = "int", Storage = "Id_zakupki")]
        public int id_zakupki
        {
            get { return this.Id_zakupki; }
            set { this.Id_zakupki = value; }
        }
        private int Id_preparat;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Id_preparat")]
        public int id_preparat
        {
            get { return this.Id_preparat; }
            set { this.Id_preparat = value; }
        }
        private int Kolvo;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Kolvo")]
        public int kolvo
        {
            get { return this.Kolvo; }
            set { this.Kolvo = value; }
        }
        private float Price;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "float", Storage = "Price")]
        public float price
        {
            get { return this.Price; }
            set { this.Price = value; }
        }
        private DateTime Date;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "DateTime", Storage = "Date")]
        public DateTime date
        {
            get { return this.Date; }
            set { this.Date = value; }
        }
    }
    [Table]
    public partial class Sale
    {
        private int Id_sale;
        [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, DbType = "int", Storage = "Id_sale")]
        public int id_sale
        {
            get { return this.Id_sale; }
            set { this.Id_sale = value; }
        }
        private int Id_preparat;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Id_preparat")]
        public int id_preparat
        {
            get { return this.Id_preparat; }
            set { this.Id_preparat = value; }
        }
       
        private int Amount;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Amount")]
        public int amount
        {
            get { return this.Amount; }
            set { this.Amount = value; }
        }
        private DateTime Date;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "DateTime", Storage = "Date")]
        public DateTime date
        {
            get { return this.Date; }
            set { this.Date = value; }
        }
        private float Summa;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "float", Storage = "Summa")]
        public float summa
        {
            get { return this.Summa; }
            set { this.Summa = value; }
        }
    }
    [Table]
    public partial class Setup
    {
        private int Id_setup;
        [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, DbType = "int", Storage = "Id_setup")]
        public int id_setup
        {
            get { return this.Id_setup; }
            set { this.Id_setup = value; }
        }
        private string Name;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "varchar(50)", Storage = "Name")]
        public string name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        private int Porog;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Porog")]
        public int porog
        {
            get { return this.Porog; }
            set { this.Porog = value; }
        }
    }
    [Table]
    public partial class Postavchik
    {
        private int Id_postavchik;
        [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, DbType = "int", Storage = "Id_postavchik")]
        public int id_postavchik
        {
            get { return this.Id_postavchik; }
            set { this.Id_postavchik = value; }
        }
        private string Name;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "varchar(50)", Storage = "Name")]
        public string name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        private string Email;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "varchar(50)", Storage = "Email")]
        public string email
        {
            get { return this.Email; }
            set { this.Email = value; }
        }
        private string Address;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "varchar(50)", Storage = "Address")]
        public string address
        {
            get { return this.Address; }
            set { this.Address = value; }
        }
    }
    [Table]
    public partial class Zakaz
    {
        private int Id_zakaz;
        [Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false, DbType = "int", Storage = "Id_zakaz")]
        public int id_zakaz
        {
            get { return this.Id_zakaz; }
            set { this.Id_zakaz = value; }
        }
        private int Id_preparat;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Id_preparat")]
        public int id_preparat
        {
            get { return this.Id_preparat; }
            set { this.Id_preparat = value; }
        }

        private int Kolvo;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "int", Storage = "Kolvo")]
        public int kolvo
        {
            get { return this.Kolvo; }
            set { this.Kolvo = value; }
        }
        private DateTime Date;
        [Column(IsPrimaryKey = false, IsDbGenerated = false, CanBeNull = true, DbType = "DateTime", Storage = "Date")]
        public DateTime date
        {
            get { return this.Date; }
            set { this.Date = value; }
        }
        
    }

}

