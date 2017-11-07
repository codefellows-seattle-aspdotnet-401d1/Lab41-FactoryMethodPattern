![cf](http://i.imgur.com/7v5ASc8.png) Lab41-Factory Method Design Pattern
=====================================

## To Submit this Assignment
- fork this repository
- write all of your code in a directory named `lab-#`; + `<your name>` **e.g.** `lab41-amanda`
- push to your repository
- submit a pull request to this repository
- submit a link to your PR in canvas

## Directions 
- Create a new Console Application within Visual Studio 2017.
- Create a program that uses the Factory Method Design Pattern 
- This program should consist of a document/resume creation factory.
- You are creating types of **Documents** that make up a **Resume** or **Report**, that conists of different **Pages** such as **Cover Letter**, **References**, **Work History**, **Summary Page** etc...
- Identify the following. **In your readme** (hint: i bolded some of the important keywords)
    1. Product -- Page
    2. Concrete Product -- Cover Letter, Reference Letter, Background Check, Work History
    3. Creator -- Document
    4. Concrete Creator -- Resume & Report
- In your Program.cs file should clearly show through Console.WriteLines() that your program is functioning as requried.   
  
## ReadMe
- Your readme should include the following information:
  - How long did it take you to complete this assignment? 1.5 hours
  - What did you struggle with? Why? How did you solve? I struggled with my access modifiers. I asked for a second set of eyes to take a look and realized that my Page class
  needed to be set to public.
  - What did you learn during this assignment? Access modifiers are super important. Also, I understand the factory method fairly well.
  - What resources did you utilize for this assingment? The notes I took during yesterday's lecture.

## Rubric
- 3pts: Facory Method properly configured with Program.cs outputting creation. 
- 3pts: Code cleary commented
- 2pt: Readme included with answers to questions
- 2pt: Product/ConcreteProduct/Creator/ConcreteCreator correclty identified.

## Stretch
1. Gain 5pts bonus for **each** Design Pattern you succesfully implement in a new problem domain. 
2. Your Code has to be clearly commented. Make it clear that you are comfortable with the design pattern of choice. 
2. Need ideas? Let me know, we can brainstorm Problem Domains for other design patterns. 
