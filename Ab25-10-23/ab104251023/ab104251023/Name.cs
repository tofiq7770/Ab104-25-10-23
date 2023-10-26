using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Name
{
    private string _path= @"C:\Users\tofiq\Desktop\Ab25-10-23\ab104251023\ab104251023\Files\names.json";

    public Name(string jsonFilePath)
    {
        List<string> list = new List<string>(); 
        _path = jsonFilePath;
        if (File.Exists(_path) != false)
        {
            File.Create(_path).Close();
        }
    }
    private List<string> DeserializeNames()
    {
        string json = File.ReadAllText(_path);
        return JsonConvert.DeserializeObject<List<string>>(json);
    }

    public void Add(string name)
    {
        List<string> names = DeserializeNames();
        names.Add(name);
        SerializeNames(names);
    }

    public bool Search(string name, Predicate<string> match)
    {
        List<string> names = DeserializeNames();
        return names.Exists(match);
    }

    public void Delete(string name)
    {
        List<string> names = DeserializeNames();
        names.Remove(name);
        SerializeNames(names);
    }

    private void SerializeNames(List<string> names)
    {
        string json = JsonConvert.SerializeObject(names, Formatting.Indented);
        File.WriteAllText(_path, json);
    }
}
