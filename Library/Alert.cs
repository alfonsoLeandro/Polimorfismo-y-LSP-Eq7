using System;

namespace LSPLibrary
{
    public class Alert
    {
        // No cumple con polymorphism ya que tiene un bloque de codigo para cada uno de los destinos
        public void Send(string type, string text)
        {
            if (type == "trello")
            {
                new TrelloCardCreator().CreateCard(text);
            }
            else if (type == "text") 
            {
                Console.WriteLine(text);
            }
        }
    }
}