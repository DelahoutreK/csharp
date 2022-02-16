this is a 

# Summary c# 


### COMMENT
        //single line

        /*multiline*/

### WRITING
`Console.Write("string"); `
> Without break

`Console.WriteLine("string")` 
> With break

### Concatene 
> use +

### VARIABLES
1. int: store whole numbers
2. long: store whole numbers (higher value) //ends with L
3. float: store floating point numbers (decimals) //ends with F
4. double: store floating point numbers (decimals more numbers) //ends whit D
5. char: single chara string ('a')
6. string: stores strings ("test")
7. bool: boolean

### DECLARE VARIABLES
`type variableName= value;`

> Declare a variable to give it a value afterwards works
> Giving a value to a variable that already has one reattributes it

`const variableName=value;` 
> locks the value (not overwrittable), needs to be definied!

> use + to add VARIABLES together
> variable Names: CASE SENSITIVE
> coma split multiple variable declaring
> scientific numbers can be stored in float/double as: 20e8F

### CASTING
> convert one variable type to another

        implicit (small to big) //automatic char - int - long - float - double
        explicit (big to small) //manual  requires brackets as:

`double doubleName = 7.84;`
`int intName = (int) doubleName;`

> Possible to use prebuilt commands for explicit CASTING
`console.WriteLine(Convert.ToString(intName));`  ToString, ToDouble, ToInt...

> USER INPUT (STOPPED CODE IN SECOND DOC HERE)
`using Console.ReadLine();` 

`string userName = Console.ReadLine();`
`Console.WriteLine("Welcome: "+userName);`

> only takes strings, convert if numbers

### Operators
|OPERATORS|operation|
|:-------:|:-------:|
|\+| addition|
|\- |substraction|
|\* |multiplication|
|\/ |division|
|\% |modulus|
|\++ |increment|
|\-- |decrement|


### Asignements (maths)
```
= reasign
+= addition to your variable
-=
*=
/=
%= 
```

### Comparison
```
== Equals
!= different
> greater than
< lesser than
>= greater or equal to
<= lesser or equal to 
```

### Logical OPERATORS
```
&& logical and (returns true if both statement are true)
|| logical or (returns true if at least on is true)
!  logical not (reverse the result, return false if true) 
```

### MATHS 
`Math.Max(x,y);`
`Math.Min(x,y);`
`Math.Sqrt(x);` square root of x
`Math.Abs(x);` absolute of x
`Math.Round(x);`rounds to nearest round number

### STRINGS 
`string  txt = "fioghvnugezrvqozu";`
`Console.WriteLine("string lenght"+txt.Length);` //String Length

### CASE conversion
`Console.WriteLine(txt.ToUpper());` //UPPER CASE
`Console.WriteLine(txt.ToLower());` //lower case 

### Concatenation
`string fName = "Lig ";`
`string lName = "Mabalz";`
`string fullName = fName + lName;`
`Console.WriteLine(fullName);`

> alternative
`string firstName = "Lig ";`
`string lastName = "Mabalz";`
`string ConcName = string.Concat(firstName, lastName);`
`Console.WriteLine(name);`

 > Concatenation using interpolation, (converts values to placeholder strings)
`string fstName = "Lig";` //no space required with this method
`string lstName = "Mabalz";`
`string flstName = $"Would you: {fstName} {lstName}";` //Note: usage of $
`Console.WriteLine(flstName);`

### Access string
`Console.WriteLine(txt[0]);` //output f, first letter of txt string

### Index string
`Console.WriteLine(txt.IndexOf("o"));` // gives position of the letters in " "

> other possiblity Substring()
`int charPos = txt.IndexOf("t");`
`string charPosUnique = txt.Substring(charPos);`
`Console.WriteLine(charPosUnique);`

Note: add a backslash \ to  add specific characters in your string as: \\, \', \"
Useful mentions: \n = new line, \t = tab, \b = backspace


### BOOLEANS
> Data type like true/false
`bool onePlusOneMakesTwo = true;`
`Console.WriteLine(onePlusOneMakesTwo);` //outputs true

> other use
`int o = 10;`
`int p = 11;` 
`Console.WriteLine(o>p);` //returns false.
> note: can be used as (10>9) or (o==10)


### Conditions
```
if (condition) 
{
    //code executed if true
} elseif (condition2) {
    //code executed if 1 false but 2 true 
} else {
    //code executed if none of the above are true
}
```
> other option
```int mafs = 10;
string result = (mafs < 10) ? "Yes, of course" : " Nope, sorry" ;
Console.WriteLine(result);
```

### switch condition
```switch(expression) {
    case 1:     //expression of cases
        //code;
        break;  //stops checking more cases if it fits the initial expression
    case 2:
        //code;
        break;
    default:    //gives a default value if no cases fit the expression
        //code; 
        break;  
}
```
### LOOPS
> While
```
While (condition) { //loops the specified code as long as conditon is true
    //code
}
```
Note: advise to change the variable in the code to not have an endless loop


> do while loop (similar to while)
```
do {        //executes  the code
    //code
} while (condition);
``` 
checks condition, then rolls back to do as long as condition=true

> For loops
```
for (statement 1; statement 2; statement 3) { //1 defines and execute the code block
    //code                                    //2 defines the condition of execution
}                                             //3 executes the code in loop 
```

##### Example for(int i = 0; i<10; i++)
```
      int i is  statement 1, it defines our variable i
      i<10  is  statement 2, it defines the condition
      i++   is  statement 3, it increments i by 1
```
> foreach, exclusive to arrays (will be explained a bit lower)
```
foreach (type variable in array) {
    //code
}
```

Note: Break can be applied  to a loop
> Continue, breaks one iteration (example using 188-191: adding if (i==5) {code} will skip 5)

### ARRAY
```
string[] arrayString = {"string 1","string 2",...};
int[] arrayInt = {1,2,3,4,5};
```
//access a specific element in an array 
Console.WriteLine(arrayString[0]); //outputs your first array value

//Note: Array values can be redefined as array[n°] = "value";
//Note: Length can be found using Console.Length
//Note: Loops and arrays can be combined to show a certain amount of the array
    //example: string[] brands = {"Square Enix", "Capcom", "Supergiants"};
    //for (int = 0;i < brands.Length; i++) {
    //Console.WriteLine(brands[i])};

//Operations/commands on array
Array.Sort(arrayName); //sorts alphabetically
Console.WriteLine(intName.Max()); //retunrs the max value
//Note: also min() and Sum()

//other ways to create arrays
string[] arrayName = new string[n°] {"1","2","3","4"}; //new is the creation of array, n° is the array length
//Note:array length isn't obliged nor is attributing values to your array, nor the "new" keyword
//WARNING: declaring an array needs to use NEW to modify/add values


to be continued
