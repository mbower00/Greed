using System;
using cse210_greed.Game.Casting;
using cse210_greed.Game.Directing;
using cse210_greed.Game.Services;
/// possible phrases of diologue 
/// 'hit by a rock' = ouch, dang it!, I need to miss that!, That hurt!
/// 'gets a gem' = yay!, I'm rich!, whoo hoo!, 


 public class Artifact : Actor{
 private string message = " ";
 fallspeed


 public Artifact()
        {
        }

 public int SetPointValue(){
 int pointValue = 0;

 }

 public void GetPointValue(){


 }
 public string SetMessage(){
  List<string> rockMessage = new List<string>();

  rockMessage.Add("Ouch!");
  rockMessage.Add("Dang it!");
  rockMessage.Add("I need to miss that!");
  rockMessage.Add("That hurt!");
  rockMessage.Add("Oof!");

  List<string> gemMessage = new List<string>();

  gemMessage.Add("Yay!");
  gemMessage.Add("I'm rich!");
  gemMessage.Add("Whoo hoo!");
  
  



 }
  }
