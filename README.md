# How to use 
1. After starting the calculator, you will see a panel with buttons ![image](https://user-images.githubusercontent.com/65130365/131757424-5c22ca54-d8b7-4533-b4a6-75c1a6a247e1.png)
2. You can enter any number by sequentially pressing the required buttons ![image](https://user-images.githubusercontent.com/65130365/131757477-3867eca1-8d3b-4a4c-b799-78a8dae63fb3.png)
3. After that you will need to select the required mathematical operation and enter the second number
4. By clicking on equals you will see the result of the entered expression
5. If you need to erase the entered data, you can press the button C
6. You can perform as many operations as you like before pressing the "=" button
7. If an error occurs, you will see the inscription "error". You can press the C button or start entering a new number to remove it
# Architecture
1. the main controller was changed to CalcController.cs in the Startup.cs file
2. There is only one variable in the model - number. To display the result
3. Added style file - style.css
4. Index view is changed. it contains 1 label and 17 buttons
5. CalcController contains 3 static variables for storing temporary data and four methods
6. Index() method is overloaded to perform operations depending on the pressed button
7. ActinoClear() changes the number to be written to the second
8. ActinoHelper() performs the necessary mathematical calculations
