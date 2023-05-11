namespace Part4ContestHomework;

public class Participant
{
    private static int NextId = 1;

    public int Id { get; }
    public string Name { get; set; }
    private int score;
    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            if (value < 1 || value > 10)
            {
                throw new ArgumentException("Score must be between 1 and 10");
            }
            score = value;
        }
    }

    public Participant(string name, int score)
    {
        Id = NextId++;
        Name = name;
        Score = score;
    }

    public static void AddParticipantToEndOfList(List<Participant> participants)
    {
        Write("\nEnter participant name: ");
        string name = ReadLine();

        int score;

        do
        {
            Write("Enter participant score. Score must be between 1 to 10: ");
            bool isValidScore = int.TryParse(ReadLine(), out score);

            if (!isValidScore || score < 1 || score > 10)
            {
                WriteLine("Invalid score! Score must be a number between 1 and 10.");
            }
        } while (score < 1 || score > 10);

        participants.Add(new Participant(name, score));

        WriteLine("\nParticipant was successfully added!");
    }

    public static void AddParticipantToGivenPosition(List<Participant> participants)
    {
        WriteLine($"\nCurrently the list has {participants.Count} participants");

        Write("\nEnter the position where you want to add the participant: ");
        int position = int.Parse(ReadLine()) - 1;

        Write("Enter participant name: ");
        string name = ReadLine();

        int score;

        do
        {
            Write("Enter participant score. Score must be between 1 to 10: ");
            score = int.Parse(ReadLine());
        } while (score < 1 || score > 10);

        participants.Insert(position, new Participant(name, score));

        WriteLine("\nParticipant was successfully added!");
    }

    public static void DeleteParticipantFromGivenPosition(List<Participant> participants)
    {
        WriteLine($"\nCurrently the list has {participants.Count} participants");

        Write("\nEnter the position of the participant you want to delete: ");
        int position;
        bool isValidPosition = int.TryParse(ReadLine(), out position);

        if (!isValidPosition)
        {
            WriteLine("\nInvalid position! Please enter a valid position.");
            return;
        }

        Participant participantToDelete = participants.Find(p => p.Id == position);

        if (participantToDelete == null)
        {
            WriteLine("\nParticipant not found!");
            return;
        }

        Participant deletedParticipant = participants[position - 1];
        participants.RemoveAt(position - 1);

        WriteLine($"\nParticipant " +
            $"{deletedParticipant.Name} (Score: " +
            $"{deletedParticipant.Score}) deleted successfully!");
    }

    public static void ModifyParticipantScore(List<Participant> participants)
    {
        WriteLine($"\nCurrently the list has {participants.Count} participants");

        Write("\nEnter the ID of the participant whose score you want to modify: ");
        int id;
        bool isValidId = int.TryParse(ReadLine(), out id);

        if (!isValidId)
        {
            WriteLine("\nInvalid ID! Please enter a valid ID.");
            return;
        }

        Participant participantToModify = participants.Find(p => p.Id == id);

        if (participantToModify == null)
        {
            WriteLine("\nParticipant not found!");
            return;
        }

        WriteLine($"\nParticipant " +
            $"{participantToModify.Name} " +
            $"(Score: {participantToModify.Score})");

        int newScore;

        do
        {
            Write("Enter new score. Score must be between 1 to 10: ");
            bool isValidScore = int.TryParse(ReadLine(), out newScore);

            if (!isValidScore || newScore < 1 || newScore > 10)
            {
                WriteLine("Invalid score! Score must be a number between 1 and 10.");
            }
        } while (newScore < 1 || newScore > 10);

        participantToModify.Score = newScore;

        WriteLine("\nScore was successfully modified!");
    }

    public static void PrintParticipantsWithEqualOrLessScore(List<Participant> participants)
    {
        WriteLine($"\nCurrently the list has {participants.Count} participants");

        Write("\nEnter the score threshold: ");
        int threshold;
        bool isValidInput = int.TryParse(ReadLine(), out threshold);

        if (!isValidInput || threshold >= 11 || threshold <= 0)
        {
            WriteLine("Invalid input. The score must be a number between 1 and 10.");
            return;
        }

        List<Participant> filteredParticipants = participants.Where(p => p.Score <= threshold).OrderBy(p => p.Score).ToList();

        if (filteredParticipants.Count == 0)
        {
            WriteLine($"There are no participants with a score equal or less than {threshold}.");
            return;
        }

        WriteLine($"\nParticipants with score equal or less than {threshold}:");

        foreach (Participant p in participants)
        {
            if (p.Score <= threshold)
            {
                WriteLine($"Participant with ID {p.Id} and name {p.Name} has the score {p.Score}");
            }
        }
    }

    public static void PrintParticipantsByScoreAscending(List<Participant> participants)
    {
        WriteLine($"\nCurrently the list has {participants.Count} participants");

        List<Participant> sortedParticipants = participants.OrderBy(p => p.Score).ToList();

        if (sortedParticipants.Count == 0)
        {
            WriteLine("There are no participants! Nothing to show you. If you want, you can add participants.");
            return;
        }

        WriteLine("\nParticipants by score (ascending):");
        foreach (Participant p in sortedParticipants)
        {
            WriteLine($"Participant with ID {p.Id} and name {p.Name} has the score: {p.Score}");
        }
    }

    public static void PrintParticipantsWithBiggerScoreAscending(List<Participant> participants)
    {
        WriteLine($"\nCurrently the list has {participants.Count} participants");

        Write("\nEnter the score threshold: ");
        int threshold;
        bool isValidInput = int.TryParse(ReadLine(), out threshold);

        if (!isValidInput || threshold >= 11 || threshold <= 0)
        {
            WriteLine("Invalid input. The score must be a number between 1 and 10.");
            return;
        }

        List<Participant> filteredParticipants = participants.Where(p => p.Score >= threshold).OrderBy(p => p.Score).ToList();

        if (filteredParticipants.Count == 0)
        {
            WriteLine($"There are no participants with a score equal or greater than {threshold}.");
            return;
        }

        WriteLine($"\nParticipants with score equal or greater than {threshold} (ascending): ");
        foreach (Participant p in filteredParticipants)
        {
            WriteLine($"Participant with ID {p.Id} and name {p.Name} has scored {p.Score} points");
        }
    }

    public static void CalculateArithmeticMean(List<Participant> participants)
    {
        WriteLine($"\nCurrently the list has {participants.Count} participants");

        Write("\nEnter the starting position: ");
        int startPosition;
        bool isValidStartPosition = int.TryParse(ReadLine(), out startPosition);

        Write("Enter the ending position: ");
        int endPosition;
        bool isValidEndPosition = int.TryParse(ReadLine(), out endPosition);

        if (!isValidStartPosition || !isValidEndPosition || startPosition < 1)
        {
            WriteLine("\nInvalid positions! Please enter valid positions.");
            return;
        }

        if (endPosition > participants.Count || startPosition > participants.Count)
        {
            WriteLine("\nThere aren't so many participants in the list.");
            return;
        }

        if (startPosition > endPosition)
        {
            WriteLine("\nYou have entered a start position greater than an end position");
            return;
        }

        int sum = 0;
        for (int i = startPosition - 1; i < endPosition; i++)
        {
            sum += participants[i].Score;
        }

        double arithmeticMean = (double)sum / (endPosition - startPosition + 1);

        WriteLine($"\nArithmetic mean of scores between positions " +
            $"{startPosition} " +
            $"and {endPosition}: " +
            $"{arithmeticMean:F2}");
    }

}
