using System;

public class SpaceExpedition
{
  public static void Main(string[] args){
    /* You’re the captain of a space expedition aimed at discovering new planets. Your space agency has established a set of parameters that need regular evaluations to make informed decisions. These parameters include atmospheric quality, gravity levels, and resource availability. Your task is to use boolean logic and comparison operators in C# to make sure each planet is suitable for exploration.*/
    bool isAtmosphereBreathable = true;
    bool isGravityStable  = false;
    bool resourcesSufficient = true;

    bool isHabitable = isAtmosphereBreathable && isGravityStable;
    Console.WriteLine(isHabitable);

    bool suitableForExpansion = isGravityStable || resourcesSufficient;
    Console.WriteLine(suitableForExpansion);

    int currentCrew = 5;
    int maxCrewCapacity  = 10;
    bool canAcceptMoreCrew = currentCrew < maxCrewCapacity;
    Console.WriteLine(canAcceptMoreCrew);
  }
}