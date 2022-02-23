using System;
using cse210_greed.Game.Casting;
using cse210_greed.Game.Directing;
using cse210_greed.Game.Services;
/// possible phrases of diologue 
/// 'hit by a rock' = ouch, dang it!, I need to miss that!, That hurt!
/// 'gets a gem' = yay!, I'm rich!, whoo hoo!, 

namespace cse210_greed.Game.Casting
{
 public class Artifact : Actor{
  private string message = " ";
  private int fallSpeed = 0;
  private int pointValue = 0;




   public int SetFallSpeed(int cap){
       Random rand = new Random();
       fallSpeed = rand.Next(0, cap);
   }

public int GetFallSpeed(){
       return fallSpeed;
   }

 public Artifact()
        {
        }

 public int SetPointValue(string type){
        if (type == "gem" )
        {
               pointValue = 500;

        }
        else if (type == "rock")
        {
               pointValue = -500;
        }
 }

 public void GetPointValue(){
 return pointValue;
 }
 public string SetMessage(string type){
if (type == "rock" ){
       List<string> rockMessage = new List<string>();

       rockMessage.Add("Ouch!");
       rockMessage.Add("Dang it!");
       rockMessage.Add("I need to miss that!");
       rockMessage.Add("That hurt!");
       rockMessage.Add("Oof!");
       int newMessage = random.Next(rockMessage.Count);
       message = rockMessage[newMessage];
}
else if (type == "gem"){
       List<string> gemMessage = new List<string>();

       gemMessage.Add("Yay!");
       gemMessage.Add("I'm rich!");
       gemMessage.Add("Whoo hoo!");
       int newMessage = random.Next(gemMessage.Count);
       message = gemMessage[newMessage];
}
  
  



 }
 public string GetMessage(){
        return message;
 }
  }
}