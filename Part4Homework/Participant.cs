namespace Part4ContestHomework
{
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
            Console.Write("\nEnter participant name: ");
            string name = Console.ReadLine();

            int score;

            do
            {
                Console.Write("Enter participant score. Score must be between 1 to 10: ");
                bool isValidScore = int.TryParse(Console.ReadLine(), out score);

                if (!isValidScore || score < 1 || score > 10)
                {
                    Console.WriteLine("Invalid score! Score must be a number between 1 and 10.");
                }
            } while (score < 1 || score > 10);

            participants.Add(new Participant(name, score));

            Console.WriteLine("\nParticipant was successfully added!");
        }


        public static void AddParticipantToGivenPosition(List<Participant> participants)
        {
            Console.WriteLine($"\nCurrently the list has {participants.Count} participants");

            Console.Write("\nEnter the position where you want to add the participant: ");
            int position = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Enter participant name: ");
            string name = Console.ReadLine();

            int score;

            do
            {
                Console.Write("Enter participant score. Score must be between 1 to 10: ");
                score = int.Parse(Console.ReadLine());
            } while (score < 1 || score > 10);

            participants.Insert(position, new Participant(name, score));

            Console.WriteLine("\nParticipant was successfully added!");
        }

        public static void DeleteParticipantFromGivenPosition(List<Participant> participants)
        {
            Console.WriteLine($"\nCurrently the list has {participants.Count} participants");

            Console.Write("\nEnter the position of the participant you want to delete: ");
            int position;
            bool isValidPosition = int.TryParse(Console.ReadLine(), out position);

            if (!isValidPosition)
            {
                Console.WriteLine("\nInvalid position! Please enter a valid position.");
                return;
            }

            Participant participantToDelete = participants.Find(p => p.Id == position);

            if (participantToDelete == null)
            {
                Console.WriteLine("\nParticipant not found!");
                return;
            }

            Participant deletedParticipant = participants[position - 1];
            participants.RemoveAt(position - 1);

            Console.WriteLine($"\nParticipant " +
                $"{deletedParticipant.Name} (Score: " +
                $"{deletedParticipant.Score}) deleted successfully!");
        }


        public static void ModifyParticipantScore(List<Participant> participants)
        {
            Console.WriteLine($"\nCurrently the list has {participants.Count} participants");

            Console.Write("\nEnter the ID of the participant whose score you want to modify: ");
            int id;
            bool isValidId = int.TryParse(Console.ReadLine(), out id);

            if (!isValidId)
            {
                Console.WriteLine("\nInvalid ID! Please enter a valid ID.");
                return;
            }

            Participant participantToModify = participants.Find(p => p.Id == id);

            if (participantToModify == null)
            {
                Console.WriteLine("\nParticipant not found!");
                return;
            }

            Console.WriteLine($"\nParticipant " +
                $"{participantToModify.Name} " +
                $"(Score: {participantToModify.Score})");

            int newScore;

            do
            {
                Console.Write("Enter new score. Score must be between 1 to 10: ");
                bool isValidScore = int.TryParse(Console.ReadLine(), out newScore);

                if (!isValidScore || newScore < 1 || newScore > 10)
                {
                    Console.WriteLine("Invalid score! Score must be a number between 1 and 10.");
                }
            } while (newScore < 1 || newScore > 10);

            participantToModify.Score = newScore;

            Console.WriteLine("\nScore was successfully modified!");
        }


        public static void PrintParticipantsWithEqualOrLessScore(List<Participant> participants)
        {
            Console.WriteLine($"\nCurrently the list has {participants.Count} participants");

            Console.Write("\nEnter the score threshold: ");
            int threshold;
            bool isValidInput = int.TryParse(Console.ReadLine(), out threshold);

            if (!isValidInput || threshold >= 11 || threshold <= 0)
            {
                Console.WriteLine("Invalid input. The score must be a number between 1 and 10.");
                return;
            }

            List<Participant> filteredParticipants = participants.Where(p => p.Score <= threshold).OrderBy(p => p.Score).ToList();

            if (filteredParticipants.Count == 0)
            {
                Console.WriteLine($"There are no participants with a score equal or less than {threshold}.");
                return;
            }

            Console.WriteLine($"\nParticipants with score equal or less than {threshold}:");

            foreach (Participant p in participants)
            {
                if (p.Score <= threshold)
                {
                    Console.WriteLine($"Participant with ID {p.Id} and name {p.Name} has the score {p.Score}");
                }
            }
        }

        public static void PrintParticipantsByScoreAscending(List<Participant> participants)
        {
            Console.WriteLine($"\nCurrently the list has {participants.Count} participants");

            List<Participant> sortedParticipants = participants.OrderBy(p => p.Score).ToList();

            if (sortedParticipants.Count == 0)
            {
                Console.WriteLine("There are no participants! Nothing to show you. If you want, you can add participants.");
                return;
            }

            Console.WriteLine("\nParticipants by score (ascending):");
            foreach (Participant p in sortedParticipants)
            {
                Console.WriteLine($"Participant with ID {p.Id} and name {p.Name} has the score: {p.Score}");
            }
        }

        public static void PrintParticipantsWithBiggerScoreAscending(List<Participant> participants)
        {
            Console.WriteLine($"\nCurrently the list has {participants.Count} participants");

            Console.Write("\nEnter the score threshold: ");
            int threshold;
            bool isValidInput = int.TryParse(Console.ReadLine(), out threshold);

            if (!isValidInput || threshold >= 11 || threshold <= 0)
            {
                Console.WriteLine("Invalid input. The score must be a number between 1 and 10.");
                return;
            }

            List<Participant> filteredParticipants = participants.Where(p => p.Score >= threshold).OrderBy(p => p.Score).ToList();

            if (filteredParticipants.Count == 0)
            {
                Console.WriteLine($"There are no participants with a score equal or greater than {threshold}.");
                return;
            }

            Console.WriteLine($"\nParticipants with score equal or greater than {threshold} (ascending): ");
            foreach (Participant p in filteredParticipants)
            {
                Console.WriteLine($"Participant with ID {p.Id} and name {p.Name} has scored {p.Score} points");
            }
        }


        public static void CalculateArithmeticMean(List<Participant> participants)
        {
            Console.WriteLine($"\nCurrently the list has {participants.Count} participants");

            Console.Write("\nEnter the starting position: ");
            int startPosition;
            bool isValidStartPosition = int.TryParse(Console.ReadLine(), out startPosition);

            Console.Write("Enter the ending position: ");
            int endPosition;
            bool isValidEndPosition = int.TryParse(Console.ReadLine(), out endPosition);

            if (!isValidStartPosition || !isValidEndPosition || startPosition < 1)
            {
                Console.WriteLine("\nInvalid positions! Please enter valid positions.");
                return;
            }

            if (endPosition > participants.Count || startPosition > participants.Count)
            {
                Console.WriteLine("\nThere aren't so many participants in the list.");
                return;
            }

            if (startPosition > endPosition)
            {
                Console.WriteLine("\nYou have entered a start position greater than an end position");
                return;
            }


            int sum = 0;
            for (int i = startPosition - 1; i < endPosition; i++)
            {
                sum += participants[i].Score;
            }

            double arithmeticMean = (double)sum / (endPosition - startPosition + 1);

            Console.WriteLine($"\nArithmetic mean of scores between positions " +
                $"{startPosition} " +
                $"and {endPosition}: " +
                $"{arithmeticMean:F2}");
        }

    }
}
