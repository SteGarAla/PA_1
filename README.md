# Programming Assignment: Number 1
Transition from C++ to C#

## Your program will include
 - abstract Animal class.
    - Animal objects should (minimally) have a `private Name`,`Age`, `Noise`, and `Weight`.
    - Animals should have `printInfo()`, `makeNoise(`), and `ageUp()` functions (these will need to be overridden by child classes, and should all be public!)
 - a concrete `Cat` class.
    - Will do everything the animal class can but with additonal member variable `int Whisker` (count of whiskers the cat has)

 - a concrete `Cassowary` class.
    - Will do everything the animal class can but with additonal member variable `int AngerLevel` (The level of anger the cassowary is currently feeling)

 - a concrete class of `Human` (Animal of my choosing)
    - Will do everything the animal class can but with additonal member variable `int MoneyInTheBank` (The amount of money that human has)

 - a main driver that will allow user to :
    - add Cat to list
    - add Cassowary to list
    - add Human to list
    - display all animals in the list
    - age all animals in the list
    - hear the noises animals in list make
    - exit program


## Things I struggled with:
- Connecting different files so that everything wont be clumped on one single file
- Creating a List, adding to a list (was similar to C++ syntax so that made it seem easier)
- Trying to reduce repeated code

## Things I could have done differently
 - Avoid using Visual studio for mac. I was having a lot of diffculties. There were times where my code did not save.(Ended up coming to lab and finishing there)
 - Working on it consistently, instead of random days.
 - I dont like how there is lots of repeated code in the menu switch cases (i was not able to find a solution for that) but i would like to have done that differently. 
