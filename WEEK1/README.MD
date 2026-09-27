Starting Out with Visual C#

Sixth Edition

Chapter 1

Introduction to Visual C#


Topics

1.1 Objects
1.2 The Program Development Process
1.8 Getting Started with Visual Studio
2.1 Getting Started with Forms and Controls
2.2 Creating the GUI for Your First Visual C# Application
2.3 Introduction to C# Code
2.4 Writing Code for the Hello World Application
2.5 Label Controls
2.6 Making Sense of IntelliSense
2.7 PictureBox Controls
2.8 Comments, Blank Lines, and Indentation
2.9 Writing the Code to Close an Application’s Form
2.10 Dealing with Syntax Errors


1.1 Objects

An object is a program component that contains data and performs operations. Programs use objects to perform specific tasks.

Most programming languages use object-oriented programming in which a program component is called an “object”.

Program objects have properties (or fields) and methods.

Properties – data stored in an object

Methods – the operations an object can perform


Wage Calculator

Wage calculator is the form object.

The dialog box consists of 2 label objects with corresponding text box objects, and two button objects.

The label objects read as follows:
Number of hours worked
Hourly pay rate

The button objects read as follows:
Calculate gross pay
Exit


Controls

Objects that are visible in a program GUI are known as controls.

Commonly used controls are Labels, Buttons, and TextBoxes.

They enhance the functionality of your programs.

There are invisible objects in a GUI such as Timers and OpenFileDialog.

A class is code that describes a particular type of object.


.NET Framework

.NET is a collection of classes and other code that can be used to create programs for Windows operating system.

C# is a language supported by .NET.

Controls are defined by specialized classes provided by .NET.

You can also write your own class to perform a special task.


1.2 Getting Started with Visual Studio

Visual Studio is a professional integrated development environment (IDE).

The Visual Studio Environment includes:

Designer Window

Solution Explorer Window

Properties Window


Getting Started with Visual Studio

Auto Hide allows a window to display only as a tab at the edges.


Menu Bar and Standard Toolbar

Menu bar provides menus such as File, Edit, View, Project, etc.

Standard toolbar contains buttons that execute frequently used commands.


The Toolbox

Toolbox is a window for selecting controls to use in an application.

Typically appears on the left side of Visual Studio environment.

Often is in Auto Hide mode.


The Toolbox

Toolbox is a window for selecting controls to use in an application.

Divided into sections such as:

All Windows Forms

Common Controls


Common Controls

Pointer
Button
Check Box
Checked List Box
Combo Box
Date Time Picker
Label
Link Label
List Box
List View
Masked Text Box
Month Calendar


Tooltips

A Tooltip is a small box that pops up when you hover the mouse pointer over an item on the toolbar or toolbox.


Docked and Floating Windows

When a window such as Solution Explorer is docked, it is attached to one of the edges of the Visual Studio environment.

When a window is floating, you can click and drag it around the screen.

A window cannot float if it is in Auto Hide mode.

Right click a window’s title bar and select Float or Dock to change between them.


Projects and Solutions

Each Visual Studio application you will create is a project.

A project contains several files.

Typically they are Form1.cs, Program.cs, etc.

A solution is a container that can hold one or more Visual Studio projects.

Each project, however, is saved in its own solution.

Solution = entire container (can have many projects).

Project = one application inside the solution.

Files of project = the actual code and resources that make the application run.


Specifying the Project Name

You can specify the project name the first time you save the project.

The name is the project name.

The location is where the solution folder will be created.

The solution name is, for example, My First Project.


Displaying the Designer

Sometimes when you open an existing project, the project’s form will not be automatically displayed in the Designer.

You should:

Right click Form1.cs in the Solution Explorer.

Click View Designer in the pop-up menu.


2.1 Getting Started with Forms and Controls

When you start a new Windows Forms App, an empty form named Form1 is automatically created.

Initially the form’s size is 300 pixels wide by 300 pixels high.


The Form’s Bounding Box and Sizing Handles

A form in Designer is enclosed with thin dotted lines called the bounding box.

The bounding box has small sizing handles; you can use them to resize the form.


The Properties Window

The appearance and other characteristics of a GUI object are determined by the object's properties.

Properties are settings that control how the object looks and behaves.

The Properties window lists all properties.

When selecting an object, its properties are displayed in Properties windows.

Each property has 2 columns:

Left: property’s name

Right: property’s value


Changing a Property’s Value

Select an object, such as the Form, by clicking it once.

If the Properties panel is not already visible, go to the View menu → Properties Window.

Find the property’s name in the list and change its value.

The Text property determines the text to be displayed in the form’s title bar.

Example: Change the value from “Form1” to “My First Program”.

Properties can be displayed in alphabetical order or by category.

The Categorized listing is the default selection, and most of the time, it makes it easier to locate specific properties.


Adding Controls to a Form

In the Toolbox, select the Control, such as a Button.

You can either:

Double click the Button control.

Click and drag the Button control to the form.

On the form, you can:

Resize the control using its bounding box and sizing handles.

Move the control’s position by dragging it.

Change its properties in the Properties window.


Deleting a Control

Deleting a control is simple: you select it and then press the Delete key on the keyboard.


Rules for Naming Controls

Controls are identified by their names in code.

Control names are also known as identifiers.

The naming rules are:

The first character must be a letter (lower or uppercase, does not matter) or an underscore (_).

All other characters can be alphanumerical characters or underscores.

The name cannot contain spaces.

Examples of valid names are:

showDayButton

DisplayTotal

_ScoreLabel


camelCase

Most C# programmers address this problem by using the camelCase naming convention for controls.

camelCase names are written in the following manner:

You begin writing the name with lowercase letters.

The first character of the second and subsequent words is written in uppercase.


2.2 Creating the GUI for Your First Visual C# Application

In section 2.2 you will start creating an app that has a Form and a Button control.

When the app is finished, it will display the message "Hello World" when the Button control is clicked.

In this section you will create the GUI.

In section 2.3 you will learn the details of coding an app.

In section 2.4 you will write the code that displays “Hello World” when the user clicks the button.


2.3 Introduction to C# Code

C# code is primarily organized in three ways:

Namespaces

Classes

Methods

Namespace: a container that holds classes.

Class: a container that holds methods.

Method: a group of one or more programming statements that perform some operations.

A file that contains program code is called a source code file.


Source Code in the Solution Explorer

Each time a new project is created the following two source code files are automatically created:

Program.cs file: contains the application’s start-up code to be executed when the application runs.

Form1.cs contains code that is associated with the Form1 form.


Source Code in the Solution Explorer

You can open them through the Solution Explorer.


Organization of the Form1.cs

A sample of Form1.cs:

The user-defined namespace of the project

Class declaration

A method


Adding Your Code

GUI applications are event-driven, which means they respond to events that occur while the application is running.

This means the program waits for the user to do something, like clicking a button, typing, or moving the mouse, and then responds.

An event is a user’s action such as mouse clicking, key pressing, or moving.

In the Designer, double clicking a control such as Button will link the control to a default Event Handler.

An event handler is a method that executes when a specific event takes place.


Message Boxes

A message box (a.k.a. dialog box) displays a message.

.NET provides a method for displaying a message.

The method displays a window with a message.

Placing it in an event handler can display the string in the message box when the button is clicked.


2.4 Writing Code for the Hello World Application

The completed source code of Form1.cs is used to display “Hello World” when the button is clicked.


2.5 Label Controls

A Label control displays text on a form and can be used to display unchanging text or program output.

Commonly used properties are:

Text: gets (read) or sets (write/change) the text associated with Label control.

Name: gets or sets the name of Label control.

Font: allows you to set the font, font style, and font size.

BorderStyle: allows you to display a border around the control’s text.

AutoSize: controls the way they can be resized.

TextAlign: set the text alignments.


Handling Text Alignments

The TextAlign property supports the following values:

TopLeft
TopCenter
TopRight

MiddleLeft
MiddleCenter
MiddleRight

BottomLeft
BottomCenter
BottomRight

You can select them by clicking the down-arrow button of the TextAlign property.


Using Code to Display Output in a Label Control

By adding code to a Button's event handler, a Label control can display output of the application.

The equal sign (=) is known as assignment operator.

The item receiving the value must be on the left of the = operator.

The Text property accepts a string only.

If you need to clear the text of a Label, assign an empty string to clear the Text property.


2.6 Making Sense of IntelliSense

IntelliSense provides automatic code completion as you write programming statements.

IntelliSense is a smart code completion feature.

As you type in your code, it automatically suggests possible keywords, variables, methods, classes, or properties that you might want to use.

It provides an array of options that make language references easily accessible.

With it, you can find the information you need, and insert language elements directly into your code.


2.7 PictureBox Controls

A PictureBox control displays a graphic image on a form.

Commonly used properties are:

Image: specifies the image that it will display.

SizeMode: specifies how the control’s image is to be displayed.

Visible: determines whether the control is visible on the form at run time.


Creating Clickable Images

You can double click the PictureBox control in the Designer to create a Click event handler and then add your code to it.


Sequential Execution of Statements

Programmers need to carefully arrange the sequence of statements in order to generate the correct results.

The statements in a method execute in the order that they appear.

Incorrect arrangement of sequence can cause logic errors.

When you click the button, you want to flip the card: back is visible, face is hidden.

If the statements are arranged incorrectly, both pictures can become hidden.


2.8 Comments, Blank Lines, and Indentation

Comments are brief notes that are placed in a program’s source code to explain how parts of the program work.

A line comment appears on one line in a program.

A block comment can occupy multiple consecutive lines in a program.


Using Blank Lines and Indentation

Programmers frequently use blank lines and indentation in their codes to make the code more human-readable.

Blank lines and indentation help organize source code and make it easier to read.


2.9 Writing the Code to Close an Application’s Form

To close an application’s form in code, use the appropriate statement.

A commonly used practice is to create an Exit button and manually add the code to it.


2.10 Dealing with Syntax Errors

The Visual Studio code editor examines each statement as you type it and reports any syntax errors that are found.

If a syntax error is found, it is underlined with a jagged line.

If a syntax error exists and you attempt to compile and execute,
 you will see an error window.


 