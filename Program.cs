using System;

public class Program{
    
    static void Main(string[] args){

    dogdoor door = new dogdoor();
    door.Open();
    door.close();
    Console.WriteLine("Door is open ? : {0}", door.IsOpen());

    }

}