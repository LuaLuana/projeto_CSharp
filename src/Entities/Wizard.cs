namespace src.Entities
{
    public class Wizard : Hero 
    {
      public Wizard(string Name , int Level , string Herotype)
      {
          this.Name = Name;
          this.Level = Level;
          this.HeroType = HeroType;

      }  

       public override string Attack(){
          return this.Name + " Atacou com sua magia";
       }

       public string Attack (int Bonus){
           if (Bonus > 6){
           return this.Name + "Lançou magia com bonus de ataque de " + Bonus;      
           
           }else{
             return this.Name + "Lançou uma magia fraca com bonus de " + Bonus;
           }
       }

    }
}