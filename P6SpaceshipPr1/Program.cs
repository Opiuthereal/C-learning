using System;

public class GalacticTravelAgency { 
  public static void Main(string[] args) {
    /* Create a string variable called passengerName and assign it to "Zara".
    create an integer variable called passengerAge and assign it to 28.
    Create a string variable called ticketType and assign it the "First Class" ticket type
    create a string variable called preferredPlanet and assign it to "Mars".*/

    string passengerName = "Zara";
    int passengerAge = 28;
    string ticketType = "First Class";
    string preferredPlanet = "Mars";
    
    //print all variables created before
    Console.WriteLine(passengerName);
    Console.WriteLine(passengerAge);
    Console.WriteLine(ticketType);
    Console.WriteLine(preferredPlanet);
    
    //Increment the passengerAge by 1
    passengerAge++;
    Console.WriteLine(passengerAge);

    //Explicitly convert the passengerAge to a double
    double passengerAgeDouble = (double)passengerAge;
    Console.WriteLine(passengerAgeDouble);

    //Implicitly convert passengerAge to a double
    double passengerAgeDouble2 = passengerAge;
    Console.WriteLine(passengerAgeDouble2);

    //Finally, convert the passengerAge to a string 
    string passengerAgeString = Convert.ToString(passengerAge);
    Console.WriteLine(passengerAgeString);

  }
}