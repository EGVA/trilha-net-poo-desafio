using DesafioPOO.Models;

static class Program {
    static void Main(string[] args)
    {
        Iphone iphone = new ("0", "16", "12311231231241", 4); 
        Nokia nokia = new ("1", "Z", "asdawgnwg29081jr1", 2);
        nokia.InstalarAplicativo("Whatsapp");
        iphone.InstalarAplicativo("IMessage");
    }
}