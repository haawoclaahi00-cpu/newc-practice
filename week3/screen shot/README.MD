1. THE IF STATEMENT

CODE:
if (condition)
{
    statement;
}

EXPLANATION:
- if is used to make a decision.
- condition is the expression being tested.
- If the condition is true, the statement executes.
- If the condition is false, the statement is skipped.


2. RELATIONAL OPERATORS

CODE:
if (sales > 50000)
{
    bonus = 500;
}

EXPLANATION:
- > means greater than.
- The condition checks whether sales are greater than 50000.
- If true, bonus receives the value 500.


3. THE IF-ELSE STATEMENT

CODE:
if (condition)
{
    statement1;
}
else
{
    statement2;
}

EXPLANATION:
- if tests a condition.
- If true, statement1 executes.
- If false, statement2 executes.
- Only one block executes.


4. NESTED IF-ELSE STATEMENTS

CODE:
if (condition1)
{
    if (condition2)
    {
        statement1;
    }
    else
    {
        statement2;
    }
}
else
{
    statement3;
}

EXPLANATION:
- A nested if-else is an if-else statement inside another if-else statement.
- condition1 is tested first.
- If true, condition2 is tested.
- The appropriate statement executes.


5. THE IF-ELSE-IF STATEMENT

CODE:
if (condition1)
{
    statement1;
}
else if (condition2)
{
    statement2;
}
else if (condition3)
{
    statement3;
}
else
{
    statement4;
}

EXPLANATION:
- This statement tests multiple conditions.
- Conditions are checked from top to bottom.
- The first true condition executes.
- else executes if all conditions are false.


6. LOGICAL AND OPERATOR (&&)

CODE:
if (score >= 50 && score <= 100)
{
    MessageBox.Show("Valid score");
}

EXPLANATION:
- && means AND.
- Both conditions must be true.
- The message appears when the score is between 50 and 100.


7. LOGICAL OR OPERATOR (||)

CODE:
if (day == "Saturday" || day == "Sunday")
{
    MessageBox.Show("Weekend");
}

EXPLANATION:
- || means OR.
- At least one condition must be true.
- The message appears if the day is Saturday or Sunday.


8. LOGICAL NOT OPERATOR (!)

CODE:
if (!isValid)
{
    MessageBox.Show("Invalid");
}

EXPLANATION:
- ! means NOT.
- It reverses a Boolean value.
- If isValid is false, !isValid becomes true.


9. STRING COMPARISONS

CODE:
if (name == "Ali")
{
    MessageBox.Show("Name matches");
}

EXPLANATION:
- == checks whether two strings are equal.
- The condition is true when name matches "Ali".

CODE:
if (name != "Ali")
{
    MessageBox.Show("Name does not match");
}

EXPLANATION:
- != means not equal to.
- The condition is true when name is different from "Ali".

CODE:
if (String.Compare(name, "Ali") == 0)
{
    MessageBox.Show("Name matches");
}

EXPLANATION:
- String.Compare() compares two strings.
- It returns 0 when the strings are equal.
- == 0 checks whether the strings match.


10. THE TRYPARSE METHOD

CODE:
int.TryParse(textBox1.Text, out number);

EXPLANATION:
- TryParse() attempts to convert text into a number.
- textBox1.Text contains the text to convert.
- out number stores the converted value.
- It returns true if conversion succeeds and false if it fails.

CODE:
int.TryParse(textBox1.Text, out number);
double.TryParse(textBox1.Text, out number);
decimal.TryParse(textBox1.Text, out number);

EXPLANATION:
- int.TryParse() converts text into an integer.
- double.TryParse() converts text into a double.
- decimal.TryParse() converts text into a decimal.


11. INPUT VALIDATION

CODE:
int hours;

if (int.TryParse(textBox1.Text, out hours))
{
    if (hours >= 0 && hours <= 168)
    {
        MessageBox.Show("Valid hours");
    }
}

EXPLANATION:
- int hours declares an integer variable.
- TryParse() checks whether the input can be converted into an integer.
- hours >= 0 checks that hours are not negative.
- hours <= 168 checks that hours do not exceed 168.
- Both conditions must be true for the input to be valid.


12. RADIOBUTTON CHECKED PROPERTY

CODE:
if (radioButton1.Checked)
{
    MessageBox.Show("Option selected");
}

EXPLANATION:
- RadioButton allows the user to select an option.
- Checked checks whether the RadioButton is selected.
- If selected, the message appears.


13. CHECKBOX CHECKED PROPERTY

CODE:
if (checkBox1.Checked)
{
    MessageBox.Show("CheckBox selected");
}

EXPLANATION:
- CheckBox allows the user to select or deselect an option.
- Checked checks whether the CheckBox is selected.
- If selected, the message appears.


14. CHECKEDCHANGED EVENT HANDLER

CODE:
private void checkBox1_CheckedChanged(object sender, EventArgs e)
{
    if (checkBox1.Checked)
    {
        MessageBox.Show("Selected");
    }
}

EXPLANATION:
- CheckedChanged occurs when the CheckBox selection changes.
- sender identifies the object that raised the event.
- EventArgs e contains event information.
- The if statement checks whether the CheckBox is selected.


15. THE SWITCH STATEMENT

CODE:
switch (expression)
{
    case value1:
        statement1;
        break;

    case value2:
        statement2;
        break;

    default:
        statement3;
        break;
}

EXPLANATION:
- switch selects a statement based on an expression.
- case represents a possible value.
- break ends the current case.
- default executes when no case matches.


16. LISTBOX SELECTEDITEM PROPERTY

CODE:
string selectedItem;

selectedItem = listBox1.SelectedItem.ToString();

EXPLANATION:
- string selectedItem declares a string variable.
- SelectedItem gets the selected item from the ListBox.
- ToString() converts the selected item into a string.
- The selected item is stored in selectedItem.


17. ADDING ITEMS TO A LISTBOX

CODE:
listBox1.Items.Add("Monday");
listBox1.Items.Add("Tuesday");
listBox1.Items.Add("Wednesday");

EXPLANATION:
- Items.Add() adds an item to a ListBox.
- "Monday" adds Monday.
- "Tuesday" adds Tuesday.
- "Wednesday" adds Wednesday.


18. CHECKING SELECTEDINDEX

CODE:
if (listBox1.SelectedIndex != -1)
{
    MessageBox.Show("An item is selected");
}

EXPLANATION:
- SelectedIndex returns the index of the selected item.
- -1 means no item is selected.
- != -1 checks whether an item has been selected.
- The message appears when an item is selected.


19. REMOVING AN ITEM FROM A LISTBOX

CODE:
listBox1.Items.Remove("Tuesday");

EXPLANATION:
- Items.Remove() removes a specified item from the ListBox.
- "Tuesday" is the item being removed.


20. REMOVING AN ITEM BY INDEX

CODE:
listBox1.Items.RemoveAt(2);

EXPLANATION:
- Items.RemoveAt() removes an item using its index.
- 2 represents the third item because indexing starts at zero.


21. CLEARING A LISTBOX

CODE:
listBox1.Items.Clear();

EXPLANATION:
- Items.Clear() removes all items from the ListBox.
- The ListBox becomes empty.