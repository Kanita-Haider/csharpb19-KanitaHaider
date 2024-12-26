// See https://aka.ms/new-console-template for more information
using Task1;

Machine machine = new Machine();
machine.Start();

Machine newMachine = new newMachine();
newMachine.Start();


internal class newMachine : Machine{

    public override void Start(){
        Console.WriteLine("Hello, Galaxy");
    }
}







