using System;

namespace FlorianBaier.Week07
{
    public class Output
    {
        public static void Launch()
        {
        ParticipantsList participantsList = new ParticipantsList();
        UserInterface userInterface = new UserInterface(participantsList);

        userInterface.Start();
        }
    }
}