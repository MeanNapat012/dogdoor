public class dogdoor{
    private bool open;
    public dogdoor(){
        this.open = false;
    }

    public void Open(){
        Console.WriteLine("The dog door is open");
        this.open = true;
    }
    public void close(){
        Console.WriteLine("The dog door is close");
        this.open = false;
    }
    public bool IsOpen(){
        return  this.open;
    }
    
}