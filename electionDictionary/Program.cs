using System.Collections.Generic;

Dictionary<string, int> election = new Dictionary<string, int>();

Console.Write("Enter file full path: ");
string path = Console.ReadLine();
try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(",");
            string name = line[0];
            int votes = int.Parse(line[1]);
            
            if (election.ContainsKey(name))
            {
                election[name] += votes;
            }
            else
            {
                election.Add(name, votes);
            }
            
        }

        foreach(var item in election)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}