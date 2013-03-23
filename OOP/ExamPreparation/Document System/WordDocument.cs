using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    class WordDocument : OfficeDocument,IEditable
    {
        public int? NumberOfChars { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "chars")
            {
                this.NumberOfChars = int.Parse(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("chars", this.NumberOfChars));
        }

        public void ChangeContent(string newContent)
        {
            this.Content = newContent;
        }
    }
}
