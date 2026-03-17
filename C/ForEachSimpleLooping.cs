
using System;

public class ForEachSimpleExercise
{
    public static void Main(string[] args)
    {
        //start with declaring four students
        string[] students = new string[] {"Alex","Mike","George","Chris"};
        int[] alexScores = new int[] {70,70,70,70,70};
        int[] mikeScores = new int[] {80,80,80,80,80};
        int[] georgeScores = new int[] {90,90,90,90,90};
        int[] chrisScores = new int[] {100,100,100,100,100};
        
        decimal alexFinal =0;
        decimal mikeFinal=0;
        decimal georgeFinal=0;
        decimal chrisFinal=0;
        
        foreach(string name in students){
            int[] tempArr = new int[5];
            int tempSum = 0;
            decimal tempFinal = 0;
            
            if(name == "Alex"){
                tempArr = alexScores;
            }else if(name=="Mike"){
                tempArr=mikeScores;
            }else if(name=="George"){
                tempArr=georgeScores;
            }else{
                tempArr=chrisScores;
            }
            
            foreach(int grade in tempArr){
                tempSum+=grade;
            }
            tempFinal = (decimal)tempSum/5;
        
            if(name == "Alex"){
                alexFinal = tempFinal;
            }else if(name=="Mike"){
                mikeFinal = tempFinal;
            }else if(name=="George"){
                georgeFinal = tempFinal;
            }else{
                chrisFinal = tempFinal;
            }
            
        }
        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine($"{students[0]}\t\t{alexFinal}\n");
        Console.WriteLine($"{students[1]}\t\t{mikeFinal}\n");
        Console.WriteLine($"{students[2]}\t\t{georgeFinal}\n");
        Console.WriteLine($"{students[3]}\t\t{chrisFinal}\n");
        
    }
}