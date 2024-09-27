int playerHp = 100;
int enemyHp = 100;

string playerName = "Player";
string enemyName = "Enemy";

Random generator = new Random();

Console.WriteLine("""  
  ________    _____      _____  ___________   _________________________ _____________________
 /  _____/   /  _  \    /     \ \_   _____/  /   _____/\__    ___/  _  \\______   \__    ___/
/   \  ___  /  /_\  \  /  \ /  \ |    __)_   \_____  \   |    | /  /_\  \|       _/ |    |  
\    \_\  \/    |    \/    Y    \|        \  /        \  |    |/    |    \    |   \ |    |  
 \______  /\____|__  /\____|__  /_______  / /_______  /  |____|\____|__  /____|_  / |____|  
        \/         \/         \/        \/          \/                 \/       \/           
""");


while (playerHp > 0 && enemyHp > 0)
{
    Console.WriteLine("\n NEW ROUND ");
    Console.WriteLine($" {playerName}: {playerHp}  {enemyName}: {enemyHp} \n");


    int playerDamage = generator.Next(20);
    enemyHp -= playerDamage;
    enemyHp = Math.Max(0, enemyHp);
    Console.WriteLine($"{playerName} has hit {enemyName} and made {playerDamage} damage");


    int enemyDamage = generator.Next(20);
    playerHp -= enemyDamage;
    playerHp = Math.Max(0, playerHp);
    Console.WriteLine($"{enemyName} has hit {playerName} and made {enemyDamage} damage");


    if (playerDamage == enemyDamage)
    {
        Console.WriteLine("""  
                         ________                          
                         \______ \                                   ____          
                          |    |  \                                 /  _ \        
                          |    `   \                               (  <_> )        
                  ______ /_______  /                        ______  \____/   ______
                 /_____/         \/  /_____/               /_____/          /_____/
                  __        ._.         __                  /\       ._.       /\          
                 / /        | |        / /                 / /       | |      / /          
                / /         |_|       / /                 / /        |_|     / /            
                \ \         |-|       \ \                / /         |-|    / /            
                 \_\        | |        \_\              / /          | |   / /              
                            |_|                         \/           |_|   \/              
                          /\   /\                                  /\   /\                                    
                         / /   \ \                                / /   \ \                                  
                        / /     \ \                              / /     \ \                                  
                       / /       \ \                            / /       \ \                                
                      / /         \ \                          / /         \ \                                
                      \/           \/                          \/           \/                                
                """);
    }
    else if (playerDamage < enemyDamage)
    {
        Console.WriteLine("""
                ________                                                   
                \______ \                                    ____          
                 |    |  \                                  /  _ \         
                 |    `   \                                (  <_> )        
         ______ /_______  /  __________________ /\  ______  \____/   ______
        /_____/         \/  /_____/_____/_____/ \/ /_____/          /_____/
          __       ._.                              /\       ._.       /\  
         / /       | |                             / /       | |      / /  
        / /        |_|                            / /        |_|     / /   
        \ \        |-|                           / /         |-|    / /    
         \_\       | |                          / /          | |   / /     
                   |_|                          \/           |_|   \/      
                 /\   /\                                   /\   /\         
                / /   \ \                                 / /   \ \        
               / /     \ \                               / /     \ \       
              / /       \ \                             / /       \ \      
             / /         \ \                           / /         \ \     
             \/           \/                           \/           \/   
  
        """);
    }
    else
    {
        Console.WriteLine("""
                  ________                          
                  \______ \                                   ____          
                   |    |  \ ________________________________/_ _ \        
                   |    `   \\________________________________/<_> )        
           ______ /_______  /                        ______  \____/   ______
          /_____/         \/  /_____/               /_____/          /_____/
           __        ._.         __                  /\       ._.       /\          
          / /        | |        / /                 / /       | |      / /          
         / /         |_|       / /                 / /        |_|     / /            
         \ \         |-|       \ \                / /         |-|    / /            
          \_\        | |        \_\              / /          | |   / /              
                     |_|                         \/           |_|   \/              
                   /\   /\                                  /\   /\                                    
                  / /   \ \                                / /   \ \                                  
                 / /     \ \                              / /     \ \                                  
                / /       \ \                            / /       \ \                                
               / /         \ \                          / /         \ \                                
               \/           \/                          \/           \/     
        """);
    }


    Console.WriteLine("Press any button to continue.");
    Console.ReadKey();
}


Console.WriteLine("""
  ________    _____      _____  ___________ ____________   _________________________
 /  _____/   /  _  \    /     \ \_   _____/ \_____  \   \ /   /\_   _____/\______   \
/   \  ___  /  /_\  \  /  \ /  \ |    __)_   /   |   \   Y   /  |    __)_  |       _/
\    \_\  \/    |    \/    Y    \|        \ /    |    \     /   |        \ |    |   \
 \______  /\____|__  /\____|__  /_______  / \_______  /\___/   /_______  / |____|_  /
        \/         \/         \/        \/          \/                 \/         \/ 
""");


if (playerHp == 0 && enemyHp == 0)
{
    Console.WriteLine("DRAW");
}
else if (playerHp == 0)
{
    Console.WriteLine($"{enemyName} won!");
}
else{
    Console.WriteLine($"{playerName} won!");
}


Console.WriteLine("Press any button to end.");
Console.ReadKey();
