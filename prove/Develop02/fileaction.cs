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

            // Deserialize the JSON to the Journal and Prompt objects
            var data = JsonConvert.DeserializeObject<Data>(json);

            // Copy the loaded data to the Journal and Prompt objects
            journal.Created = data.Created;
            journal.Name = data.JournalName;
            journal.Entries = data.Entries;
            prompt.prompts = data.Prompts;
        }
    }

    public void Save(Journal journal, Prompt prompt)
    {
        // Create a new Data object and copy the necessary data from Journal and Prompt objects
        var data = new Data
        {
            Created = journal.Created,
            JournalName = journal.Name,
            Entries = journal.Entries,
            Prompts = prompt.prompts
        };

        // Serialize the Data object to JSON
        string json = JsonConvert.SerializeObject(data, Formatting.Indented);

        // Write the JSON to the file
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
