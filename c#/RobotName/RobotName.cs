using System;
using System.Collections.Generic;
using System.Linq;

public class Robot
{
    private string _name = "";
    private NameGenerator _nameGenerator = new();
    public string Name
    {
        get
        {
            if(_name == ""){
                _name = _nameGenerator.Generate();
            }
            return _name;
        }
    }

    public void Reset()
    {
        _name = "";
        _nameGenerator.RemoveName(Name);
    }
}
class NameGenerator {
    private string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private string numbers = "1234567890";
    static List<string> currentNames = new();

    public string Generate(){
        var name = "";
        while(true){
            name = GenerateString(letters,2) + GenerateString(numbers,3);
            if(!currentNames.Contains(name)){
                currentNames.Add(name);
                break;
            }
        }
        return name;
    }

    private string GenerateString(string characters, int length){
        var random = new Random();
        return new string(Enumerable.Repeat(characters, length)
                                  .Select(s => s[random.Next(s.Length)]).ToArray());
    }

    public void RemoveName(string name){
        currentNames.Remove(name);
    }
}