# SimpleCalculatorUsingmXParser

This is a simple calculator in Csharp using a mxParser Library which will take care of all the calculation and operation like " + , - , * , / " sqaure and etc you just need too build a method writeExpression to recieve the text from the buttons and in buttons you just need to set the text which willl be recieved by the writeExpression Function and another method for clear screen which will set the tvResult and tvExpression textfields clear.

Tbe main part of the coding is in the equal button in this project where get the text from the textfield tvExpression and then pass it to e.calculate function which is a builtin function of mxParser library to take of the calculations and operations .

you will import the library at the top using 

"using org.mariuszgromada.math.mxparser;"
"using org.mariuszgromada.math.mxparser.mathcollection;"

like this as mention above without qoutations.

there is a folder named 'mxParser executable dil file' in which you could also find the mxparser executable .dil file used as an library
in this project.

How add reference for the external Library

Right click on references and select "Add Reference"
Then in the dialogue select 'browse' and find the .dll you need on your file system:


![dwi9m](https://user-images.githubusercontent.com/35813537/54321151-08c07480-45ad-11e9-9f00-1ab923b9049b.png)



mxParser official website link
http://mathparser.org/

mxParser on Github
https://github.com/mariuszgromada/MathParser.org-mXparser

# ScreenShots

Screenshot 1

![sc1](https://user-images.githubusercontent.com/35813537/54320507-7028f500-45aa-11e9-92d3-223037fb666b.PNG)

Screenshot 2

![sc2](https://user-images.githubusercontent.com/35813537/54320528-85058880-45aa-11e9-8932-c6802f449dec.PNG)

Screenshot 3

![sc3](https://user-images.githubusercontent.com/35813537/54320543-8e8ef080-45aa-11e9-8f09-b03db276f876.PNG)
