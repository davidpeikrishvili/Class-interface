//David Peikrishvili
//CSCI 39537  
//Creating an interface
// Tried using Instance Methods in the Player class, Properties and Indexers.
interface MMO
{
    string player_name
    {
        get;
        set;
    }
    double player_height
    {
        get;
        set;
    }
    int player_level
    {
        get;
        set;
    }
}
//Public Class


public class Player:MMO
    {
    //Creating private variables for class Player
    private string name;
    private double height;
    private int lvl;
    public string player_name
    {
        get { return name; }
        set { name = value; }
    }
    public double player_height
    {
        get { return height; }
        set { height = value;} 
    }
    public int player_level
    {
        get { return lvl;}
        set { lvl = value; } 
    }
}
public class Game:Player
{
    private List<Player> listPlayers; //Private list that cannot be accessed outside this class.
    public Game() //Constructor
    {
        listPlayers = new List<Player>();
        //Adding Players to the lsit of players with specified conditions.
        listPlayers.Add(new Player() {player_name = "Aeterna", player_height = 5.5, player_level = 99 }); 
        listPlayers.Add(new Player() {player_name = "Random", player_height = 4.9, player_level = 1 });
    }
    public string this[int playerLvL]
    {
        get
        {
            return listPlayers.FirstOrDefault(play => play.player_level == playerLvL).player_name;
        }
    }
}