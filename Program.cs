string enjoymentLevel = GetEnjoymentLevel();
string stadiumRecommendation = GetStadiumRecommendation(enjoymentLevel);
string gameRecommendation = GetGameRecommendation(stadiumRecommendation);
DisplayStadiumDetails( stadiumRecommendation,  gameRecommendation);



static string GetEnjoymentLevel(){
    Console.WriteLine("Select a level of enjoyment ( Boring, Average, Fun, Epic):");
    return Console.ReadLine();
}
static string GetStadiumRecommendation(string enjoymentLevel){
    if(enjoymentLevel == "Boring"){
    return "Neyland Stadium";
    System.Console.WriteLine("here");
    }
    if(enjoymentLevel== "Average"){
    return "Jordan-Hare Stadium";
    }
    if(enjoymentLevel== "Fun"){
    return "Tiger Stadium";
    }
    if(enjoymentLevel== "Epic"){
    return "Saban Field at Bryant-Denny Stadium";
    }
    else
    {return "Invalid";
        
    }
}
static string GetGameRecommendation(string stadium){
    if(stadium == "Neyland Stadium"){
        return "vs Kent State";
    }
    if(stadium == "Jordan-Hare Stadium"){
        return "vs Kentucky";
    }
    if(stadium== "Tiger Stadium"){
        return "vs Alabama";
    }
    if(stadium== "Saban Field at Bryant-Denny Stadium"){
        return "vs Auburn";
    }
    else
    {   
        return "Invalid";
    }
}
static void DisplayStadiumDetails(string stadiumRecommendation, string gameRecommendation){
System.Console.WriteLine($"Based on your perference, I recommend {gameRecommendation} at {stadiumRecommendation}");
}