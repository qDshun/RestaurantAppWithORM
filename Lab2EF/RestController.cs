using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2EF
{
    class RestController
    {
        public static RestModel.RestEntities ctx = new RestModel.RestEntities();

        public static void FillCategoriesComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (var category in ctx.DishCategories)
                comboBox.Items.Add(category.CategoryId.ToString() + " " + category.CategoryName);
            comboBox.SelectedIndex = 0;
        }

        public static void FillPositionComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (var position in ctx.Positions)
                comboBox.Items.Add(position.PositionId.ToString() + ' ' + position.StaffPosition);
            comboBox.SelectedIndex = 0;
        }
        
        public static void FillOrderDetailsComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (var order in ctx.Orders)
                comboBox.Items.Add(order.OrderId);
            comboBox.SelectedIndex = 0;
        }

        public static void FillDishesComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (var dish in ctx.DishDictionaries)
                comboBox.Items.Add(dish.DishId + " " + dish.Name);


        }

        public static void AddDish(int category_id, int price, int amount, string name, DataGridView dataGridView1)
        {
            try
            {
                var dishesQuery = from d in ctx.DishDictionaries
                                  select new { d.DishId, d.Name, d.Price, d.Amount, d.CategoryId };
                List<int> DishIDs = new List<int>();
                foreach (var dish in dishesQuery)
                    DishIDs.Add(dish.DishId);
                int dish_id = 1;
                while (DishIDs.Contains(dish_id))
                    dish_id++;
                RestModel.DishDictionary dishToAdd = new RestModel.DishDictionary { DishId = dish_id, CategoryId = category_id, Amount = amount, Name = name, Price = price };
                ctx.AddToDishDictionaries(dishToAdd);
                ctx.SaveChanges();
                MessageBox.Show("Dish added succesfully");
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void AddDishToOrder(int dish_id, int dishes_count, int order_id)
        {
            try
            {
                RestModel.DishesOrder dish = new RestModel.DishesOrder { DishId = dish_id, DishesCount = dishes_count, OrderId = order_id, DishesOrderId = ctx.DishesOrders.Count() + 1 };
                ctx.AddToDishesOrders(dish);
                ctx.SaveChanges();
                MessageBox.Show("Dish added succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public static void AddOrder(DateTime orderDate, int table_id)
        {
            try
            {
                int order_id = ctx.Orders.Count() + 1;
                RestModel.Order order = new RestModel.Order { OrderId = order_id, OrderDate = orderDate, TableId = table_id };
                ctx.AddToOrders(order);
                ctx.SaveChanges();
                MessageBox.Show("Order added succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void DeleteSelectedDish(DataGridView dataGridView)
        {
            try
            {
                int dish_id = 0;
                if (dataGridView.SelectedRows.Count == 1)
                    dish_id = Convert.ToInt16(dataGridView.SelectedRows[0].Cells[1].Value);
                var deleteQuery = from d in ctx.DishDictionaries
                                  where d.DishId == dish_id
                                  select d;
                ctx.DishDictionaries.DeleteObject(deleteQuery.First());
                ctx.SaveChanges();
                MessageBox.Show("Dish deleted succesfully");
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void DeleteSelectedWorker(DataGridView dataGridView)
        {
            try
            {
                int staff_id = 0;
                if (dataGridView.SelectedRows.Count == 1)
                    staff_id = Convert.ToInt16(dataGridView.SelectedRows[0].Cells[0].Value);
                var deleteQuery = from s in ctx.Staffs
                              where s.StaffId == staff_id
                              select s;
            ctx.Staffs.DeleteObject(deleteQuery.First());
            ctx.SaveChanges();
            MessageBox.Show("Worker deleted succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void AddWorker(string name, string passport_id, string email, int position_id)
        {
            try
            {
                List<int> staff = new List<int>();
                foreach (var person in ctx.Staffs)
                    staff.Add(person.StaffId);
                int staff_id = 1;
                while (staff.Contains(staff_id))
                    staff_id++;
                RestModel.Staff personToAdd = new RestModel.Staff { StaffId = staff_id, Name = name, Email = email, PositionId = position_id };
                ctx.AddToStaffs(personToAdd);
                ctx.SaveChanges();
                MessageBox.Show("Peasant added succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void RefreshDishMenu (DataGridView dataGridView, BindingSource dishMenuBindingSource)
        {
            dataGridView.Rows.Clear();
            RestModel.DishMenu dishMenu = new RestModel.DishMenu();
            foreach (RestModel.DishMenu r in ctx.DishMenus)
                dishMenuBindingSource.Add(r);
        }

        public static void RefreshStaff(DataGridView dataGridView)
        {
            BindingSource staffBindingSource = new BindingSource();
            dataGridView.DataSource = staffBindingSource;
            var displayStaffQuery = from s in ctx.Staffs
                                    join p in ctx.Positions on s.PositionId equals p.PositionId
                                    select new { staff_id = s.StaffId, name = s.Name, email = s.Email, position = p.StaffPosition, salary = p.Salary };

            foreach (var r in displayStaffQuery)
                staffBindingSource.Add(r);
            dataGridView.Columns[0].Visible = false;
        }

        public static void RefreshOrderDishes(DataGridView dataGridView)
        {
            BindingSource orderDishesBindingSource = new BindingSource();
            dataGridView.DataSource = orderDishesBindingSource;
            var displayQuery = from dishOrder in ctx.DishesOrders
                               join order in ctx.Orders on dishOrder.OrderId equals order.OrderId
                               join dish in ctx.DishDictionaries on dishOrder.DishId equals dish.DishId
                               select new
                               {
                                   order_id = order.OrderId,
                                   dish.Name,
                                   dishOrder.DishesCount,
                                   dish.Price,
                                   total = dishOrder.DishesCount * dish.Price,
                                   TableNumber = order.TableId,
                                   order.OrderDate
                               };
            foreach (var d in displayQuery)
                orderDishesBindingSource.Add(d);

        }
        
        public static void RefreshOrderDetails(DataGridView dataGridView, int order_id)
        {
            BindingSource orderDetailsBindingSource = new BindingSource();
            dataGridView.DataSource = orderDetailsBindingSource;
            var orderDetailDisplayQuery = from comment in ctx.CommentOrComplains
                                          join order in ctx.Orders on comment.OrderId equals order.OrderId
                                          where (order.OrderId == order_id)
                                          select new
                                          {
                                              order.OrderId,
                                              comment.Name,
                                              comment.Email,
                                              comment.Comment
                                          };
            foreach (var d in orderDetailDisplayQuery)
                orderDetailsBindingSource.Add(d);
        }
    }
}
