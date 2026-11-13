CHAPTER 4: LOOPS, FILES, AND RANDOM NUMBERS

========================================
1. WHILE LOOP
========================================

CODE:
int count = 0;

while (count < 5)
{
    MessageBox.Show("Hello");
    count = count + 1;
}

EXPLANATION:
- int count = 0: Declares a counter variable and initializes it to 0.
- while (count < 5): Repeats the loop while the condition is true.
- MessageBox.Show("Hello"): Displays the message Hello.
- count = count + 1: Increases the counter by 1.

OUTPUT:
Hello is displayed 5 times.


========================================
2. WHILE LOOP – FALSE CONDITION
========================================

CODE:
int count = 5;

while (count < 5)
{
    MessageBox.Show("Hello");
    count = count + 1;
}

EXPLANATION:
- int count = 5: Initializes count to 5.
- count < 5: Tests whether count is less than 5.
- The condition is false, so the loop does not execute.

OUTPUT:
No message is displayed.


========================================
3. INFINITE LOOP
========================================

CODE:
int count = 0;

while (count < 5)
{
    MessageBox.Show("Hello");
}

EXPLANATION:
- int count = 0: Initializes count to 0.
- while (count < 5): Checks the condition.
- MessageBox.Show("Hello"): Displays Hello.
- Count is never increased, so the condition never becomes false.

OUTPUT:
The loop continues indefinitely.


========================================
4. INCREMENT OPERATOR (++)
========================================

CODE:
count++;
count += 1;
count = count + 1;

EXPLANATION:
Increment means to increase a variable's value by 1.

All three statements perform the same operation.


========================================
5. DECREMENT OPERATOR (--)
========================================

CODE:
count--;
count -= 1;
count = count - 1;

EXPLANATION:
Decrement means to decrease a variable's value by 1.

All three statements perform the same operation.


========================================
6. POSTFIX MODE
========================================

CODE:
int x = 5;
int y = x++;

EXPLANATION:
- int x = 5: Initializes x to 5.
- int y = x++: Uses the old value of x first, then increases x by 1.

OUTPUT:
x = 6
y = 5


========================================
7. PREFIX MODE
========================================

CODE:
int x = 5;
int y = ++x;

EXPLANATION:
- int x = 5: Initializes x to 5.
- int y = ++x: Increases x first, then uses the new value.

OUTPUT:
x = 6
y = 6


========================================
8. FOR LOOP
========================================

CODE:
for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}

EXPLANATION:
- Initialization: Starts count at 0.
- Test condition: Checks whether count is less than 5.
- Update: Increases count by 1.
- MessageBox.Show: Displays Hello.

OUTPUT:
Hello is displayed 5 times.


========================================
9. FOR LOOP – COUNTING BY 10
========================================

CODE:
for (int count = 0; count <= 100; count += 10)
{
    MessageBox.Show(count.ToString());
}

EXPLANATION:
- int count = 0: Starts counting from 0.
- count <= 100: Continues until count reaches 100.
- count += 10: Increases count by 10.
- ToString(): Converts the number into a string.

OUTPUT:
0, 10, 20, 30, 40, 50,
60, 70, 80, 90, 100.


========================================
10. FOR LOOP – COUNTING BACKWARD
========================================

CODE:
for (int count = 10; count >= 0; count--)
{
    MessageBox.Show(count.ToString());
}

EXPLANATION:
- int count = 10: Starts counting from 10.
- count >= 0: Continues while count is greater than or equal to 0.
- count--: Decreases count by 1.
- ToString(): Converts the number into a string.

OUTPUT:
10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0.


========================================
11. DO-WHILE LOOP
========================================

CODE:
int number = 1;

do
{
    MessageBox.Show(number.ToString());
}
while (number < 0);

EXPLANATION:
- int number = 1: Initializes number to 1.
- do: Executes the statements first.
- MessageBox.Show: Displays the number.
- while (number < 0): Tests the condition after execution.

OUTPUT:
1 is displayed once because do-while executes at least once.


========================================
12. WHILE LOOP COMPARISON
========================================

CODE:
int number = 1;

while (number < 0)
{
    MessageBox.Show(number.ToString());
}

EXPLANATION:
- int number = 1: Initializes number to 1.
- number < 0: The condition is false.
- The loop does not execute because while checks the condition first.

OUTPUT:
No message is displayed.


========================================
13. WRITING DATA TO A FILE
========================================

CODE:
StreamWriter outputFile;

outputFile = File.CreateText("courses.txt");

outputFile.WriteLine("Introduction to Computer Science");
outputFile.WriteLine("English Composition");
outputFile.WriteLine("Calculus I");

outputFile.Close();

EXPLANATION:
- StreamWriter: Creates a variable for writing data to a file.
- File.CreateText(): Creates a text file.
- WriteLine(): Writes data into the file and moves to a new line.
- Close(): Closes the file connection.


========================================
14. APPEND TEXT
========================================

CODE:
StreamWriter outputFile;

outputFile = File.AppendText("Names.txt");

outputFile.WriteLine("Lynn");
outputFile.WriteLine("Jamal");
outputFile.WriteLine("Alex");

outputFile.Close();

EXPLANATION:
- StreamWriter: Creates a file-writing object.
- File.AppendText(): Adds new data to an existing file.
- WriteLine(): Writes the names into the file.
- Close(): Closes the file.

NOTE:
CreateText erases existing contents when the file already exists.
AppendText preserves existing contents and adds new data.


========================================
15. SPECIFYING FILE LOCATION
========================================

CODE:
StreamWriter outputFile;

outputFile = File.AppendText(@"C:\Data\Names.txt");

EXPLANATION:
- StreamWriter: Declares a file-writing object.
- AppendText(): Opens a file for adding data.
- @: Allows the path to be written using backslashes.
- C:\Data\Names.txt: Specifies the file location.


========================================
16. READING DATA FROM A FILE
========================================

CODE:
StreamReader inputFile;

inputFile = File.OpenText("students.txt");

EXPLANATION:
- StreamReader: Creates an object for reading a text file.
- File.OpenText(): Opens the specified text file.
- students.txt: The name of the file being opened.


========================================
17. READLINE()
========================================

CODE:
StreamReader inputFile;

inputFile = File.OpenText("students.txt");

string line;

line = inputFile.ReadLine();

MessageBox.Show(line);

inputFile.Close();

EXPLANATION:
- string line: Declares a string variable.
- ReadLine(): Reads one line from the file.
- MessageBox.Show(): Displays the line.
- Close(): Closes the file connection.


========================================
18. READING A FILE WITH A LOOP
========================================

CODE:
while (inputFile.EndOfStream == false)
{
    string line = inputFile.ReadLine();
    MessageBox.Show(line);
}

EXPLANATION:
- EndOfStream: Checks whether the end of the file has been reached.
- == false: Means the end of the file has not been reached.
- ReadLine(): Reads one line at a time.
- MessageBox.Show(): Displays each line.

RESULT:
The loop reads the file until the end is reached.


========================================
19. OPEN FILE DIALOG
========================================

CODE:
private void openButton_Click(object sender, EventArgs e)
{
    openFileDialog.ShowDialog();
}

EXPLANATION:
- openButton_Click: An event handler that runs when the button is clicked.
- ShowDialog(): Displays the Open File dialog box.
- openFileDialog: The OpenFileDialog control.


========================================
20. DIALOG RESULT – OK AND CANCEL
========================================

CODE:
DialogResult result = openFileDialog.ShowDialog();

if (result == DialogResult.OK)
{
    MessageBox.Show("File selected");
}
else if (result == DialogResult.Cancel)
{
    MessageBox.Show("Cancelled");
}

EXPLANATION:
- DialogResult: Stores the user's dialog selection.
- ShowDialog(): Displays the dialog box.
- DialogResult.OK: Indicates that the user clicked Open.
- DialogResult.Cancel: Indicates that the user clicked Cancel.
- if: Checks the first condition.
- else if: Checks another condition.


========================================
21. FILENAME PROPERTY
========================================

CODE:
if (openFileDialog.ShowDialog() == DialogResult.OK)
{
    inputFile = File.OpenText(openFileDialog.FileName);
}

EXPLANATION:
- ShowDialog(): Displays the Open dialog box.
- DialogResult.OK: Checks whether the user selected Open.
- FileName: Gets the selected file's path and name.
- File.OpenText(): Opens the selected file.


========================================
22. INITIAL DIRECTORY
========================================

CODE:
openFileDialog.InitialDirectory = @"C:\Data";

EXPLANATION:
- InitialDirectory: Specifies the directory displayed first.
- C:\Data: The folder that opens initially.


========================================
23. SAVE FILE DIALOG
========================================

CODE:
saveFileDialog.ShowDialog();

EXPLANATION:
- saveFileDialog: The SaveFileDialog control.
- ShowDialog(): Displays the standard Windows Save As dialog box.


========================================
24. SAVING A FILE
========================================

CODE:
if (saveFileDialog.ShowDialog() == DialogResult.OK)
{
    StreamWriter outputFile;

    outputFile = File.CreateText(saveFileDialog.FileName);

    outputFile.WriteLine("Hello");

    outputFile.Close();
}

EXPLANATION:
- ShowDialog(): Displays the Save As dialog box.
- DialogResult.OK: Checks whether the user selected Save.
- StreamWriter: Creates a file-writing object.
- File.CreateText(): Creates the selected file.
- FileName: Gets the selected file path.
- WriteLine(): Writes Hello into the file.
- Close(): Closes the file.


========================================
25. RANDOM NUMBERS
========================================

CODE:
Random rand = new Random();

int number1 = rand.Next();

double number2 = rand.NextDouble();

EXPLANATION:
- Random: The class used to generate random numbers.
- rand: The name of the Random object.
- Next(): Generates a random integer.
- NextDouble(): Generates a floating-point number between 0.0 and 1.0.
- int: Stores an integer.
- double: Stores a floating-point number.


========================================
26. RANDOM.NEXT(100)
========================================

CODE:
Random rand = new Random();

int number = rand.Next(100);

EXPLANATION:
- Random rand = new Random(): Creates a Random object.
- Next(100): Generates a random integer from 0 to 99.
- int number: Stores the generated number.


========================================
27. LOAD EVENT
========================================

CODE:
private void Form1_Load(object sender, EventArgs e)
{
}

EXPLANATION:
- Form1_Load: The event handler that runs when the form loads.
- object sender: Represents the object that raised the event.
- EventArgs e: Contains event information.
- The empty braces contain no statements.


========================================
28. LOAD EVENT WITH MESSAGE BOX
========================================

CODE:
private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Prepare to see the form!");
}

EXPLANATION:
- Form1_Load: Runs when the form is loaded.
- MessageBox.Show(): Displays a message box.
- "Prepare to see the form!": The message displayed to the user.

OUTPUT:
Prepare to see the form!

