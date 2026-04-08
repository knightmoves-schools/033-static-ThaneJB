namespace knightmoves;

public class Account {
   // Add your code here
   public static string Name = "";

   public static ChangeName(string newName){
      Name = newName;

      return Name;
   }

   static MainAccount(){
      Name = "Main Account";
   }
}

