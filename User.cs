using System;
using System.Collections.Generic;
using System.Text;

namespace UserPasswordCheck
{
    class User
    {

        private string _username;
        private string _password;
        
        public User(string userid)
        {
            Name = userid;
           
        }
        public User(string userid,string userpsw) : this(userid)
        {
            Password = userpsw;
        }
        
        public string Name
        {
            get{
                
                return _username;
            }
            set
            {
               
                while (true)
                {
                    if (value.Length < 8)
                    {
                        Console.WriteLine("Uzunluq 8den az ola bilmez");
                        value = Console.ReadLine();
                    }
                    else
                    {
                        _username = value;
                        break;

                    }
                    

                }
                
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                while (true)
                {

                    bool checkDigit = false;
                    bool checkLetter = false;
                    bool checkUpper = false;



                    for (int i = 0; i < value.Length; i++)
                    {
                        if (char.IsDigit(value[i]))
                        {
                            checkDigit = true;
                        }
                        if (char.IsLetter(value[i]))
                        {
                            checkLetter = true;

                        }
                        if (char.IsUpper(value[i]))
                        {
                            checkUpper = true;
                        }


                    }
                    if (checkDigit && checkLetter && checkUpper)
                    {
                        _password = value;
                        break;

                    }
                    else
                    {
                        
                        Console.WriteLine("Sifreni Duzgun Daxil Edin");
                        value = Console.ReadLine();
                    }
                    
                }

             
            }




        }



    }
}
