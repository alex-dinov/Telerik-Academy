using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace CatalogOfFreeContent
{
    public class Program
    {
        public static void Main()
        {
            StringBuilder output = new StringBuilder();
            Catalog catalog = new Catalog();
            ICommandExecutor command = new CommandExecutor();

            foreach (ICommand cmd in ParseCommand())
            {
                command.ExecuteCommand(catalog, cmd, output);
            }

            Console.Write(output);
        }

        private static List<ICommand> ParseCommand()
        {
            List<ICommand> commands = new List<ICommand>();
            bool end = false;

            do
            {
                string command = Console.ReadLine();
                end = (command.Trim() == "End");
                if (!end)
                {
                    commands.Add(new Command(command));
                }
            }
            while (!end);

            return commands;
        }
    }

    public class CommandExecutor : ICommandExecutor
    {
        public void ExecuteCommand(ICatalog contCat, ICommand command, StringBuilder output)
        {
            switch (command.Type)
            {
                case ContentCommand.AddBook:
                    contCat.Add(new Content(ContentType.Book, command.Parameters));
                    output.AppendLine("Book Added");
                    break;
                case ContentCommand.AddMovie:
                    contCat.Add(new Content(ContentType.Movie, command.Parameters));
                    output.AppendLine("Movie added");
                    break;
                case ContentCommand.AddSong:
                    contCat.Add(new Content(ContentType.Song, command.Parameters));
                    output.AppendLine("Song added");
                    break;
                case ContentCommand.AddApplication:
                    contCat.Add(new Content(ContentType.Application, command.Parameters));
                    output.AppendLine("Application added");
                    break;
                case ContentCommand.Update:
                    ProcessUpdateCommand(command, contCat, output);
                    break;
                case ContentCommand.Find:
                    ProcessFindCommand(command, contCat, output);
                    break;
                default:
                    throw new ArgumentException("Invalid command!");
            }
        }
  
        private void ProcessUpdateCommand(ICommand command, ICatalog contCat, StringBuilder output)
        {
            if (command.Parameters.Length != 2)
            {
                throw new FormatException("Invalid parameters!");
            }

            int itemsUpdated = contCat.UpdateContent(command.Parameters[0], command.Parameters[1]);
            output.AppendLine(String.Format("{0} items updated", itemsUpdated));
        }
  
        private void ProcessFindCommand(ICommand command, ICatalog contCat, StringBuilder output)
        {
            if (command.Parameters.Length != 2)
            {
                throw new Exception("Invalid number of parameters!");
            }

            Int32 numberOfElementsToList = Int32.Parse(command.Parameters[1]);

            IEnumerable<IContent> foundContent = contCat.GetListContent(command.Parameters[0], numberOfElementsToList);

            if (foundContent.Count() == 0)
            {
                output.AppendLine("No items found");
            }
            else
            {
                foreach (IContent content in foundContent)
                {
                    output.AppendLine(content.TextRepresentation);
                }
            }
        }
    }

    public class Catalog : ICatalog
    {
        private readonly MultiDictionary<string, IContent> url;
        private readonly OrderedMultiDictionary<string, IContent> title;

        public Catalog()
        {
            bool allowDuplicateValues = true;
            this.title = new OrderedMultiDictionary<string, IContent>(allowDuplicateValues);
            this.url = new MultiDictionary<string, IContent>(allowDuplicateValues);
        }
        /// <summary>
        /// Adds a content item in the catalog
        /// </summary>
        public void Add(IContent content)
        {
            this.title.Add(content.Title, content);
            this.url.Add(content.Url, content);
        }

        /// <summary>
        /// Finds all content items in the catalog that match the specified title
        /// </summary>
        /// <param name="title">title of the elements we search</param>
        public IEnumerable<IContent> GetListContent(string title, Int32 numberOfContentElementsToList)
        {
            IEnumerable<IContent> contentToList = from c in this.title[title] select c;

            return contentToList.Take(numberOfContentElementsToList);
        }

        /// <summary>
        /// Updates old url with new one given in parameters
        /// </summary>
        /// <param name="oldUrl">The url kept in the content</param>
        /// <param name="newUrl">The url that is gona replace the old one</param>
        /// <returns>Returns count of updated content items</returns>
        public Int32 UpdateContent(string oldUrl, string newUrl)
        {
            Int32 theElements = 0;

            List<IContent> contentToList = this.url[oldUrl].ToList();

            foreach (Content content in contentToList)
            {
                this.title.Remove(content.Title, content);
                theElements++;
            }

            this.url.Remove(oldUrl);

            foreach (IContent content in contentToList)
            {
                content.Url = newUrl;
            }

            foreach (IContent content in contentToList)
            {
                this.title.Add(content.Title, content);
                this.url.Add(content.Url, content);
            }

            return theElements;
        }

        public int Count
        {
            get
            {
                return this.title.KeyValuePairs.Count;
            }
        }
    }
    
    public class Content : IComparable, IContent
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public Int64 Size { get; set; }

        private string url;

        public string Url
        {
            get
            {
                return this.url;
            }

            set

            {
                this.url = value;
                this.TextRepresentation = this.ToString();
            }
        }

        public ContentType Type { get; set; }

        public string TextRepresentation { get; set; }

        public Content(ContentType type, string[] commandParams)
        {
            this.Type = type;
            this.Title = commandParams[(int)ContentInfo.Title];
            this.Author = commandParams[(int)ContentInfo.Author];
            this.Size = Int64.Parse(commandParams[(int)ContentInfo.Size]);
            this.Url = commandParams[(int)ContentInfo.Url];
        }

        public int CompareTo(object obj)
        {
            if (null == obj)
                return 1;

            Content otherContent = obj as Content;
            if (otherContent != null)
            {
                Int32 comparisonResul = this.TextRepresentation.CompareTo(otherContent.TextRepresentation);

                return comparisonResul;
            }
            
            throw new ArgumentException("Object is not a Content");
        }

        public override string ToString()
        {
            string output = String.Format("{0}: {1}; {2}; {3}; {4}", this.Type.ToString(), this.Title, this.Author, this.Size, this.Url);

            return output;
        }
    }

    public class Command : ICommand
    {
        readonly char[] paramsSeparators = { ';' };
        readonly char commandEnd = ':';

        public ContentCommand Type { get; set; }

        public string OriginalForm { get; set; }

        public string Name { get; set; }

        public string[] Parameters { get; set; }

        private Int32 commandNameEndIndex;

        public Command(string input)
        {
            this.OriginalForm = input.Trim();

            this.Parse();
        }

        private void Parse()
        {
            this.commandNameEndIndex = this.GetCommandNameEndIndex();

            this.Name = this.ParseName();
            this.Parameters = this.ParseParameters();
            this.TrimParams();

            this.Type = this.ParseCommandType(this.Name);
        }

        public ContentCommand ParseCommandType(string commandName)
        {
            ContentCommand type;

            if (commandName.Contains(':') || commandName.Contains(';'))
            {
                throw new FormatException();
            }

            switch (commandName.Trim())
            {
                case "Add book":
                    type = ContentCommand.AddBook;
                    break;
                case "Add movie":
                    type = ContentCommand.AddMovie;
                    break;
                case "Add song":
                    type = ContentCommand.AddSong;
                    break;
                case "Add application":
                    type = ContentCommand.AddApplication;
                    break;
                case "Update":
                    type = ContentCommand.Update;
                    break;
                case "Find":
                    type = ContentCommand.Find;
                    break;
                default:
                    throw new ArgumentException("Invalid command!");
            }

            return type;
        }

        public string ParseName()
        {
            string name = this.OriginalForm.Substring(0, this.commandNameEndIndex);
            return name;
        }

        public string[] ParseParameters()
        {
            Int32 paramsLength = this.OriginalForm.Length - (this.commandNameEndIndex + 2);

            string paramsOriginalForm = this.OriginalForm.Substring(this.commandNameEndIndex + 2, paramsLength);

            string[] parameters = paramsOriginalForm.Split(paramsSeparators, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < parameters.Length; i++)
            {
                parameters[i] = parameters[i];
            }

            return parameters;
        }

        public Int32 GetCommandNameEndIndex()
        {
            Int32 endIndex = this.OriginalForm.IndexOf(commandEnd);

            return endIndex;
        }

        private void TrimParams()
        {
            for (int i = 0; i < this.Parameters.Length; i++)
            {
                this.Parameters[i] = this.Parameters[i].Trim();
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.Append("" + this.Name + " ");

            foreach (string param in this.Parameters)
            {
                output.Append(param + " ");
            }

            return output.ToString();
        }
    }
}