# Power 1.0
**Power** is a programming language which is made for using **data** like **JSON**.
The programming language was made by [TIPDYT](https://www.youtube.com/c/TIPDYT).
Released: 07/04/2021
# How it works
Basically there are parsers for **3** programming languages. **C#**, ***Python*** and ***Java***.
These are libraries for parsing Power code. Then you can get a variable's value or add data to the current data.
## File Extension
It's *.**por**
# Power syntax
$variablename=value
You can add spaces and you don't have to justify the data type.
## Example

    $favourite language=C#
    $my name=TIPDYT

**What these lines do:**
|Names|Values  |
|--|--|
|favourite language  |C#  |
|my name|TIPDYT

It's really easy!
Each line which doesn't start with a $ will be ignored.

# C# Power Parser
|Commands|What the do  |
|--|--|
|`using Power;`  |Imports the Power Parser  |
|`Power.PowerData.NewFile(PowerData);`|Changes the current used Power data
|`Power.PowerData.GetValue(VarName);`|The parser returns a variable's value
|`Power.PowerData.AddData(VarName, Value);`|Adds new variable to the current Power data
|`Power.PowerData.GetCurrentData();`|Parser returns the current modified Power data
|`Power.PowerData.ClearData();`|Clears the current Power data

# Java Power Parser
|Commands|What the do  |
|--|--|
|`import tipdyt.power.PowerData;`  |Imports the Power Parser  |
|`PowerData.NewFile(Data);`|Changes the current used Power data
|`PowerData.GetValue(VarName);`|The parser returns a variable's value
|`PowerData.AddData(VarName, Value);`|Adds new variable to the current Power data
|`PowerData.GetCurrentData();`|Parser returns the current modified Power data
|`PowerData.ClearData();`|Clears the current Power data

# Python Power Parser
|Commands|What the do  |
|--|--|
|`import pythpower`  |Imports the Power Parser  |
|`variable = pythpower.PowerData(Data)`|Class Constructor
|`variable.GetValue(VarName)`|The parser returns a variable's value
|`variable.AddData(VarName, Value)`|Adds new variable to the current Power data
|`variable.GetCurrentData()`|Parser returns the current modified Power data
|`variable.ClearData()`|Clears the current Power data
