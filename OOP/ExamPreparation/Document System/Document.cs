using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    public abstract class Document : IDocument
    {
        public string Name { get; protected set; }
        public string Content { get; protected set; }

        public virtual void LoadProperty(string key, string value)
        {
            if (key == "name")
            {
                this.Name = value;
            }
            if (key == "content")
            {
                this.Content = value;
            }
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string,object>("name",this.Name));
            output.Add(new KeyValuePair<string,object>("content",this.Content));
        }

        public override string ToString()
        {
            List<KeyValuePair<string, object>> atrr = new List<KeyValuePair<string, object>>();
            this.SaveAllProperties(atrr);
            atrr.Sort((a,b) => a.Key.CompareTo(b.Key));
            StringBuilder output = new StringBuilder();
            output.Append(this.GetType().Name);
            output.Append("[");
            bool last = true;
            foreach (var att in atrr)
            {
                if (att.Value != null)
                {
                    if (!last)
                    {
                        output.Append(";");
                    }
                    output.Append(att.Key);
                    output.Append("=");
                    output.Append(att.Value);
                    last = false;
                }
            }
            output.Append("]");
            return output.ToString();
        }
    }
}
