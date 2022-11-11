using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace PostAPP.entities
{
    public class Post
    {
        public DateTime Moment {get; set;}
        public string Title {get; set;}
        public String Cotent {get; set;}
        public int Likes {get;  set;}

        public List<Coments> Coment {get; set;} = new List<Coments>();

        public Post(){

        }
        public Post( DateTime moment, String title, String cotent, int likes){
            
            Moment = moment;
            Title = title;
            Cotent = cotent;
            Likes = likes;

        }

        public void AddComent(Coments coment){
            Coment.Add(coment);
        }
        public void RemoveComent(Coments coment){
            Coment.Remove(coment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes -  ");
            sb.Append(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Cotent);
            sb.AppendLine("Coments: ");
            foreach(Coments c in Coment){
                sb.AppendLine(c.Text);
            }
            return sb.ToString();  

        }

    }

}