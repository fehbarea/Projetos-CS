using PostAPP.entities;

static void Main(string[] args)
{
    Coments c1 = new Coments("Have a nice trip");
    Coments c2 = new Coments("OOOHH thats awesome");
    Post p1 = new Post(

        DateTime.Parse("21/06/2018 13:05:44"),
        "Traveling to new Zeland",
        "I'm going to visit this wonderful contry",
        12
    );
    p1.AddComent(c1);
    p1.AddComent(c2);

    Coments c3 = new Coments("Good Night");
    Coments c4 = new Coments("May the Force be with you");
    Post p2 = new Post(
        
        DateTime.Parse("28/12/2018 23:14:35"),
        "Good night",
        "See you tomorrow",
        5
    );

    p2.AddComent(c3);

    p2.AddComent(c4);

    System.Console.WriteLine(p1);
    System.Console.WriteLine(p2);
}
