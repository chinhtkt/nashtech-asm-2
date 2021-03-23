using System;
using System.Linq;
using System.Collections.Generic;

namespace dotnet_nashtech
{    class Program
    {
        static void Main(string[] args)
        {
        
            var m1 = new Member
            {
                firstName = "chinh",
                lastName = "nguyen",
                Gender = "Male",
                DOB = 12-05-2000,
                phoneNumber = 0925302500,
                birthPlace= "Ha Noi",
                Age = 21,
                isGraduated = true,
                
            };
            var m2 = new Member
            {
                firstName = "chien",
                lastName = "nguyen",
                Gender = "Male",
                DOB = 09-04-1966,
                phoneNumber = 0934571699,
                birthPlace= "Ha Nam",
                Age = 56,
                isGraduated = true,
                
            };
            var m3 = new Member
            {
                firstName = "a",
                lastName = "nguyen",
                Gender = "Female",
                DOB = 03-04-1998,
                phoneNumber = 12412412,
                birthPlace= "Thanh Hoa",
                Age = 17,
                isGraduated = false,
                
            };
            var m4 = new Member
            {
                firstName = "b",
                lastName = "tran",
                Gender = "Female",
                DOB = 31-12-1996,
                phoneNumber = 0925302500,
                birthPlace= "Ha Tinh",
                Age = 30,
                isGraduated = false,
                
            };
            var m5 = new Member
            {
                firstName = "c",
                lastName = "dux",
                Gender = "Male",
                DOB = 11-06-2005,
                phoneNumber = 0925302500,
                birthPlace= "Ha Dong",
                Age = 43,
                isGraduated = true,
                
            };
            var m6 = new Member
            {
                firstName = "d",
                lastName = "duzxfx",
                Gender = "Male",
                DOB = 11-06-1998,
                phoneNumber = 0925302500,
                birthPlace= "Ha Dong",
                Age = 43,
                isGraduated = true,
                
            };
            var m7 = new Member
            {
                firstName = "s",
                lastName = "duczxc",
                Gender = "Male",
                DOB = 31-08-1998,
                phoneNumber = 43523525,
                birthPlace= "Ha Dong",
                Age = 53,
                isGraduated = false,
                
            };
           

           var members = new List<Member>()
           {
               m1,m2,m3,m4,m5

           };

           //Excersise 1

        //    foreach (var member in members)
        //    {
        //        if (member.Gender == "Male")
        //        {
        //            System.Console.WriteLine(member.firstName );
                   
        //        }
               
        //    }

        //    //Excersise 2
        //    var maxAge = members.Max(x=>x.Age);
        //    Console.WriteLine(maxAge);

        //Excersise 3

        //      foreach (var member in members)
        //    {
        //        Console.WriteLine(member.firstName + " " + member.lastName);
               
        //    }

        // //Excersise 4

        // int year = 1998;

        // foreach(var member in members) {
        //    switch( member.DOB > year ? "Greater than 1998" :
        // member.DOB < year ? "Less than 1998" :
        // member.DOB == year ? "Equal 1998" : "None")
        // {
        //       case "Greater than 1998":
        //             Console.WriteLine("Member who greater than 1998:" + ' ' + member.DOB + ' ' + member.firstName);
        //             break;
        //        case "Less than 1998":
        //             Console.WriteLine("Member who less than 1998:"  + ' ' + member.DOB + ' ' + member.firstName);
        //             break;
        //        case "Equal 1998":
        //             Console.WriteLine("Member who equal 1998:" + ' ' + member.DOB + ' ' + member.firstName);
        //             break;
        //        case "None":
        //             Console.WriteLine("None");
        //             break;
        //  }
        // }
          // Excersise 5
        // foreach (var member in members)
        // {
          //     if (member.birthPlace == "Ha Noi")
           //   {
           //        System.Console.WriteLine(member.firstName );
                   
           //    }
               
           }
        
       
        
            

        
       
               
            
             }
               
          }

       



        }
        



         

