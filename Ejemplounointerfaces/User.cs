using Interfaces;

 

namespace Classes{

    public class User : IUser{

        //Los atributos

        private string Name{get;set;}
        private string LastName{get;set;}

        //Constructor

        public User(string name){
            this.Name = name;
        }

 
        //Son las funciones definidas de la Interfas

        public string GetFullName(){
            return string.Format("Nombre: {0} Apeliido: {1}", this.Name, this.LastName);
        }

 

        public void SetLastName(string lastName){
            this.LastName = lastName;
        }

 

        public void SetName(string name){
            this.Name = name;
        }

    }

}