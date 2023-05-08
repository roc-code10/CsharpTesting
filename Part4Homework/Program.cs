
//Create a program that manages the score of participants from a contest.
//Participant contains a name and a score.
//The score is between 1 and 10, and each participant has an identification number.
//Feel free to use List<> from .NET.
//The program should contain an list of the participants and their scores with the following actions: 
//1.Add a new participant with score to the end of the list.
//2.Add a new participant with score to a position given in the list.
//3.Delete a participant from a given position.
//4.Modify the score of a participant by identification number.
//5.Print all participants that have a score less that a given score.
//6.Print all the participants in ascending order by score.
//7.Print all the participants with a score bigger than a given score in ascending order by score.
//8.Calculate the arithmetic mean of the scores for a given interval( for example - the function receives 2 and 6,
//calculate the arithmetic mean of scores for participants from the list with the positions 2,3,4,5 and 6).

using Part4ContestHomework;

List<Participant> participants = new List<Participant>();

while (true)
{
    WriteLine("\nPlease choose from the following options:");

    WriteLine("\n1. Add a new participant with score to the end of the list.");
    WriteLine("2. Add a new participant with score to a given position in the list.");
    WriteLine("3. Delete a participant from a given position.");
    WriteLine("4. Modify the score of a participant by id.");
    WriteLine("5. Print all participants that have a score equal or less that a given score.");
    WriteLine("6. Print all the participants in ascending order by score.");
    WriteLine("7. Print all the participants with a score equal or greater than a given score in ascending order by score.");
    WriteLine("8. Calculate the arithmetic mean of the scores for a given interval.");
    WriteLine("0. Exit");

    Write("\nEnter your choice: ");

    int choice;
    bool isValidChoice = int.TryParse(ReadLine(), out choice);

    if (!isValidChoice)
    {
        WriteLine("\nYou entered an invalid choice! Please choose one option from the list.");
    }
    else

        switch (choice)
    {
        case 0:
                WriteLine("\nBye bye!");
            return;
        case 1:
            Participant.AddParticipantToEndOfList(participants);
            break;
        case 2:
            Participant.AddParticipantToGivenPosition(participants);
            break;
        case 3:
            Participant.DeleteParticipantFromGivenPosition(participants);
            break;
        case 4:
            Participant.ModifyParticipantScore(participants);
            break;
        case 5:
            Participant.PrintParticipantsWithEqualOrLessScore(participants);
            break;
        case 6:
            Participant.PrintParticipantsByScoreAscending(participants);
            break;
        case 7:
            Participant.PrintParticipantsWithBiggerScoreAscending(participants);
            break;
        case 8:
            Participant.CalculateArithmeticMean(participants);
            break;
        default:
                WriteLine($"\nInvalid choice: {choice}");
            break;
    }
}





