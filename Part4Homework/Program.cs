using Part4ContestHomework;

List<Participant> participants = new List<Participant>();

while (true)
{
    Console.WriteLine("\nPlease choose from the following options:");

    Console.WriteLine("\n1. Add a new participant with score to the end of the list.");
    Console.WriteLine("2. Add a new participant with score to a given position in the list.");
    Console.WriteLine("3. Delete a participant from a given position.");
    Console.WriteLine("4. Modify the score of a participant by id.");
    Console.WriteLine("5. Print all participants that have a score equal or less that a given score.");
    Console.WriteLine("6. Print all the participants in ascending order by score.");
    Console.WriteLine("7. Print all the participants with a score equal or greater than a given score in ascending order by score.");
    Console.WriteLine("8. Calculate the arithmetic mean of the scores for a given interval.");
    Console.WriteLine("0. Exit");

    Console.Write("\nEnter your choice: ");

    int choice;
    bool isValidChoice = int.TryParse(Console.ReadLine(), out choice);

    if (!isValidChoice)
    {
        Console.WriteLine("\nYou entered an invalid choice! Please choose one option from the list.");
    }
    else

        switch (choice)
    {
        case 0:
            Console.WriteLine("\nBye bye!");
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
            Console.WriteLine($"\nInvalid choice: {choice}");
            break;
    }
}





