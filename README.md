# Sattolo_Randomiser_aucerna
Done on VS2017 with Ninject
Used the Sattolo ALgorithm, more efficient with just one cycle through a fixed array andd more challennging than the usual Fisher-Yates shown on Stackoverflow.
To use:
-Start the program. It has the start aray as default.
-Click on "Shuffle" it will randomise the array and show it as output
-if you want to copy the ouput click on "Show in Textbox" wait a few seconds and you will see the same array in the second window.
 "Show in Textbox" does NOT start the algorithm, it just shows the current array
 
 It has one unit test which checks the lenghth and components of th ouput array, check the randomness of a 1000 element array is not really a thing.
 I found out that the latest library for Ninject Moq on Nunit does not work on VS2017 so I used a more common unit test with the kernel of Ninject.
