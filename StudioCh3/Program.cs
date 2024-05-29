// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string testString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
Dictionary<string, int> storeString = new Dictionary<string, int>();


foreach(char letter in testString){
    // int count =0; 
    string charac = letter.ToString();
    if(!storeString.ContainsKey(charac)){
        storeString.Add(charac, 1);
    }else if (storeString.ContainsKey(charac)){
        storeString[charac] =  storeString[charac] + 1;
        
    };
}

foreach(KeyValuePair<string, int> characterInt in storeString){
    Console.WriteLine(characterInt.Key+ " : " + characterInt.Value);
}

