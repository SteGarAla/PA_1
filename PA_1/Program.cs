using System;

namespace PA_1 {
    //This will act as the entry point of the code
    //This is where we will be creating an object of the StartMenu so that we can interact with user
    class EntryPoint
    {
        static void Main()
        {
            //once created, menu will now interact with the user 
            StartMenu run = new StartMenu();
            run.menuInterFace();
        }
    }
}
