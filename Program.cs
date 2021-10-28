/*
In this project, I build a pretty well-organized system of dating profiles.
*/

using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile stella = new Profile("Stella McCartney", 30, "New York", "USA", "she/her");

      stella.SetHobbies(new string[] {"listening to audiobooks and podcasts", "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice columns"});

      Console.WriteLine(stella.ViewProfile());

    }
  }
}
