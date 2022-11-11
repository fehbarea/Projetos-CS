using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace ORDER.entities
{
    public class Orders
    {
        public OrderStatus Status{get; set;}
        public DateTime Moment{get;set;}
        public Client Client{get; set;}
        public List<OrderItem>Items = new List<OrderItem>();


        public Orders(){

        }
        public Orders(OrderStatus status, DateTime moment, Client client){
            status = status;
            Moment = moment;
            Client = client;
        }
        public void Additem(OrderItem item){
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item){
            Items.Remove(item);
        }
        public double TotalPrice(){
            double sum = 0.0;
            foreach(var i in Items){
                sum += i.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order Moment: ");
            sb.Append(Moment);
            sb.Append(" Order Status: ");
            sb.Append(Status);
            sb.AppendLine("Order itens");
            foreach(var i in Items){
                sb.Append(i.Product.Name);
                sb.Append(", ");
                sb.Append(i.Price);
                sb.Append(" Quantity: ");
                sb.Append(i.Quantity);
                sb.Append(i.SubTotal());
                sb.AppendLine();
            }
            sb.Append(TotalPrice());
            return sb.ToString();
        }
    }
}