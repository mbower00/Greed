using System;
using System.Collections.Generic
using cse210_greed.Game.Casting;
///using cse210_greed.Game.Directing;
using cse210_greed.Game.Services;
/// possible phrases of diologue 
/// 'hit by a rock' = ouch, dang it!, I need to miss that!, That hurt!
/// 'gets a gem' = yay!, I'm rich!, whoo hoo!, 

namespace cse210_greed.Game.Casting
{
 public class Artifact : Actor{  /// Artifact will inherit all of the code and methods created in actor to be used here
  private string message = " ";
  private int fallSpeed = 0;   /// setting all of our private variables to be returned later
  private int pointValue = 0;




   public void SetFallSpeed(int cap){  
       Random random = new Random();    /// this new method in artifact calculates the speed of on coming rocks and gems
       fallSpeed = random.Next(0, cap); /// and gives it a random value from 1 to what ever cap is mentioned in cast
       
   }

public int GetFallSpeed(){
       return fallSpeed;   
   }

 public Artifact() /// Constructor
        {
        }

 public void SetPointValue(string type){  /// if player collides with gem then they get rewarded 500 points
        if (type == "gem" )
        {
               pointValue = 500;

        }
        else if (type == "rock")    /// if player collides with rock then they get deducked 500 points
        {
               pointValue = -500;
        }
 }

 public int GetPointValue(){
 return pointValue;
 }
 public void SetMessage(string type){
if (type == "rock" ){
       List<string> rockMessage = new List<string>();   ///We will have a message display if they hit a rock and these wil be chosen at random to be displayed

       rockMessage.Add("Ouch!");
       rockMessage.Add("Dang it!");
       rockMessage.Add("I need to miss that!");
       rockMessage.Add("That hurt!");
       rockMessage.Add("Oof!");
       rockMessage.Add("That hurt my soul");
       rockMessage.Add("this person controlling me is gunna kill me!");
       rockMessage.Add("My pride will never recover");
       int newMessage = random.Next(rockMessage.Count);
       message = rockMessage[newMessage];
}
else if (type == "gem"){
       List<string> gemMessage = new List<string>();   ///We will have a message display if they hit a gem and these wil be chosen at random to be displayed

       gemMessage.Add("Yay!");
       gemMessage.Add("I'm rich!");
       gemMessage.Add("Whoo hoo!");
       gemMessage.Add("Dolla Dolla bills yall");
       gemMessage.Add("This is going into crypto stock!");
       gemMessage.Add("new whip here I come!");
       int newMessage = random.Next(gemMessage.Count);
       message = gemMessage[newMessage];
}
  
  



 }
 public string GetMessage(){
        return message;
 }
  }
}

///OBJECT 3: Artifact
///Class: Artifact
///RESPONSIBILITY: assign points to the actors
///Team member: Nate
///BEHAVIORS:
///Methods: 
///STATE:
///Attributes (datatype name):
///Sets the point values for the actors
///SetPointValue():
///int
///Point value
 ///int pointValue
///returns the point values for the actors
///Void GetPointValue():





