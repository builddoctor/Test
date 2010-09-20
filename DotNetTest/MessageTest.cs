/*=============================================================
(c) 2010 by The Build Doctor Limited
All rights reserved.
================================================================*/

namespace BuildDoctor{
  using System;
  using NUnit.Framework;
  [TestFixture]
   public class MessageTest{
      [Test] 
      public void ShouldHaveMysteronVoices() 
        {
         
         Assert.AreEqual ("This is the voice of the Mysterons", new Message().Text());
        
        }
      
      
   }
   
   
}
