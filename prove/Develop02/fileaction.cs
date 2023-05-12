using System.IO;
using Newtonsoft.Json;

public class FileAction
{
    private string fileName;

    public FileAction(string fileName)
    {
        this.fileName = fileName;
    }

    public void Load(Journal journal, Prompt prompt)
    {
        if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);

            // Convert from json to objects
            var data = JsonConvert.DeserializeObject<Data>(json);

            // Load into journal and prompts
            journal.Created = data.Created;
            journal.Name = data.JournalName;
            journal.Entries = data.Entries;
            prompt.prompts = data.Prompts;
        }
    }

    public void Save(Journal journal, Prompt prompt)
    {
        // Create a data object with the jornal, entry, and prompt information
        var data = new Data
        {
            Created = journal.Created,
            JournalName = journal.Name,
            Entries = journal.Entries,
            Prompts = prompt.prompts
        };

        // Convert from object to json
        string json = JsonConvert.SerializeObject(data, Formatting.Indented);

        
        // Write the json to file
        File.WriteAllText(fileName, json);
    }

    private class Data
    {
        public DateTime Created { get; set; }
        public string JournalName { get; set; }
        public List<Entry> Entries { get; set; }
        public List<string> Prompts { get; set; }
    }

}
