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





