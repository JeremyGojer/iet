namespace BCCI;

public class Team {
    private string [] players={"Sachin", "Sourav", "Rahul", "Yuvraj", "Dhoni", "Jadeja", "V. Prasad", "Anil Kumble"};

    //indexer for class
    //Smart Array
    public string this[int index]{
        get{
           return this.players[index];
        }
        set{
            this.players[index]=value;
        }
    }
}


