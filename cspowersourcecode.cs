using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    public class PowerData
    {
        static private string powerdata;
        static private IDictionary variablesDictionary = new Dictionary<string, object>();
        static public void NewFile(string data)
        {
            variablesDictionary.Clear();
            powerdata = data;
            string[] lines = powerdata.Split(Environment.NewLine);
            foreach (string line in lines)
            {
                if (line.StartsWith("%"))
                {
                    
                    string varname = line.Substring(1,line.IndexOf("="));
                    var value = line.Substring(line.IndexOf("=")).Replace("=", "");
                    variablesDictionary.Add(varname, value);
                }
            }
        }
        static public object GetValue(string VariableName)
        {
            object valuee = variablesDictionary[VariableName];
            return valuee;
        }
        static public void AddData(string VariableName, object Value)
        {
            powerdata = powerdata + Environment.NewLine + "%" + VariableName + "%=" + Value.ToString();
            variablesDictionary.Add(VariableName, Value);
        }
        static public object GetCurrentData()
        {
            return powerdata;
        }
        static public void ClearData()
        {
            powerdata = null;
            variablesDictionary.Clear();
        }
    }

}
