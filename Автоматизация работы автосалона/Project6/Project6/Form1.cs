using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
namespace Project6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*init_car();
            Catalog catalog1 = new Catalog(); 
            Catalog catalog2 = new Catalog();
            catalog1.discount = new Discount();
            catalog1.catalogId = 1;
            var db = new db();
            var cars = from car in db.Cars where car.brand == "BMW" select car;
            Discount discount = new Discount();
            discount.discount_name = "Новогодняя распродажа";
            discount.discount_percent = 0.05;
            catalog1.cars = cars.ToArray();
            catalog2.discount = discount;
            catalog2.catalogId = 1;
            cars = from car in db.Cars where car.brand == "Audi" select car;
            catalog2.cars = cars.ToArray();
            db.Catalogs.Add(catalog1);
            db.Catalogs.Add(catalog2);
            db.SaveChanges();*/
            
        }
        public void init_car(){
            CatalogHandler ch = new CatalogHandler();
            string[] array_str = new string[] { "http://cdn3.3dtuning.com/info/BMW%20M1%201981%20Coupe/factory/1.jpg", "http://www.bimmerpost.com/storyimages/44054c78-9e4b-d7b5.jpg", "http://www.zastavki.com/pictures/1920x1200/2011/Auto_BMW_Others_BMW_BMW_M3_E46_029113_.jpg" };
            for (int i = 0; i < 3; i++)
			{
                ch.add_car("BMW", "M" + (i + 1), DateTime.Now, "red", "12" + i * 3 + "hp", 1000000 * (1 + i), array_str[i]);
			}
            array_str = new string[]{ "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS9hjATPm3Vaitog9pqaMo3jbqWRX1kpyqTnMvsZ-QNmoiaK5n8", "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTdKW6Sg853YvAFwdkrcAFsMi19_e4r_DA8r7e6kkObpMCbgkIqxw" };
            for (int i = 0; i < 2; i++)
            {
                ch.add_car("Audi", "A" + (i + 1), DateTime.Now, "white", "12" + i * 4 + "hp", 1200000 * (1 + i), array_str[i] );
            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (auth) {
                listBox2.Items.Clear();
                listBox2.Visible = true;
                string str = listBox1.SelectedItem.ToString();
                var db = new db();
                var cars = from car in db.Cars where car.brand == str select car;
                Car[] cars_name = cars.ToArray();
                foreach (var item in cars_name)
                {
                    listBox2.Items.Add(item.model);
                }
            }
        }

        private bool auth=false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (auth)
            {
                label2.Text = "";
                textBox1.Visible = true;
                textBox2.Visible = true;
                listBox2.Items.Clear();
                listBox2.Visible = false;
                Car car = new Car();
                fill_info(car);
                button1.Text = "Войти";
                auth = false;
                date.Text = "";
                price.Text = "";
                pictureBox1.Visible = false;
            }
            else {
                UserHandler userhandler = new UserHandler();
                if (userhandler.get_auth(textBox1.Text, textBox2.Text) == "unauth")
                {
                    label2.Text = "Неверная пара логин/пароль";
                }
                else
                {
                    label2.Text = "Добро пожаловать, " + textBox1.Text;
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    button1.Text = "Выход";
                    auth = true;
                }
            }
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("BMW");
            listBox1.Items.Add("Audi");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox2.SelectedItem.ToString();
            var db = new db();
            var cars = from car in db.Cars where car.model == str select car;
            Car cur_car = cars.First();
            fill_info(cur_car);
            pictureBox1.Visible = true;
        }
        private void fill_info(Car cur_car)
        {
            brand.Text = cur_car.brand;
            model.Text = cur_car.model;
            date.Text = cur_car.date.ToString();
            color.Text = cur_car.color;
            engine_performance.Text = cur_car.engine_performance;
            price.Text = Convert.ToString(cur_car.price);
            if (cur_car.images_url == null) {
                pictureBox1.InitialImage = null;
            } else {
                pictureBox1.Load(cur_car.images_url);    
            }
           
        }
    }
}
