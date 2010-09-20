/*=============================================================
(c) 2010 by The Build Doctor Limited
All rights reserved.
================================================================*/
using System;

namespace BuildDoctor{
  public class Message{

      public static void Main(string[] args){ 
         Console.WriteLine(new Message().Text());
      }
      
      public String Text() {
         return "This is the voice of the Cybermen";
      }
   }
}
