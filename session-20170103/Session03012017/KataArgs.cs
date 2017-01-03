using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03012017
{
    public class KataArgs
    {
        private readonly IDictionary<string, string> args = new Dictionary<string, string>();

        public void ParseArgs(IReadOnlyCollection<string> args, IReadOnlyDictionary<string, string> schema = null)
        {
            for (var i = 0; i < args.Count; i++)
            {
                var key = args.ElementAt(i).Substring(1);
                if (isEnabledFlag(schema, key))
                    continue;
                var value = isValidValue(args, i) ? args.ElementAt(++i) : string.Empty;
                this.args.Add(key, value);
            }
        }

        private static bool isValidValue(IReadOnlyCollection<string> args, int i)
        {
            return i + 1 < args.Count && !args.ElementAt(i + 1).StartsWith("-");
        }

        private static bool isEnabledFlag(IReadOnlyDictionary<string, string> schema, string key)
        {
            return schema != null && !schema.ContainsKey(key);
        }

        public int Size => args.Count;

        public string GetFlagValue(string flag)
        {
            if (args.ContainsKey(flag))
            {
                return args[flag];
            }
            return null;
        }
    }
}
