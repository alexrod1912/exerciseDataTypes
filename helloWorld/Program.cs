// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, Naomi!");
// Console.WriteLine("What is your name");
// string name = Console.ReadLine();
// Console.WriteLine("Hello " + name);
// Console.WriteLine("Please provide a length value for your rectangle");
// string length = Console.ReadLine();
// int lengthInt = int.Parse(length);
// Console.WriteLine("Please provide a width ");
// string width = Console.ReadLine();
// int widthInt = int.Parse(width);
// Console.WriteLine("Your rectangles area is " + widthInt * lengthInt);
string originalString = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
Console.WriteLine("Please type a word that you want to search our string for");
string searchWord = Console.ReadLine();
if(originalString.ToLower().Contains(searchWord.ToLower())){
    int indexSearchWord = originalString.ToLower().IndexOf(searchWord.ToLower());
    int lengthOfSearchWord = searchWord.Length;
    string lowerString = originalString.ToLower();
    string[] trimmedString = lowerString.Split(searchWord);
    string? concatString = null;
    foreach(string line in trimmedString){
        // Console.WriteLine(line);
        concatString = concatString + line;
        string concatTrimmedString;
    }
    Console.WriteLine(concatString + "Here");
    // Console.WriteLine(trimmedString.Count());
    // Console.WriteLine(trimmedString);
    Console.WriteLine(searchWord + ": is in our original string and is at index: " + indexSearchWord + "and has a length of: " + lengthOfSearchWord);
    Console.WriteLine("New String: " + concatString);
}else{
    Console.WriteLine("That search word was not found");
}